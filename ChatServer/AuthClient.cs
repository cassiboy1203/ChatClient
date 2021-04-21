using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ChatServer
{
    public enum ActionCodes : byte
    {
        None = 0x00,
        Connect = 0x01,
        Login = 0x02,
        LoginInfo = 0x03,
        NewUser = 0x04,
        Logout = 0x05,

    }

    public enum ReplyCodes : byte
    {
        InvalidAction = 0x00,
        InvalidKey = 0x01,
        InvalidArgs = 0x02,
        ConnectionSuccessful = 0x03,
        ConnectionFailed = 0x04,
        LoginSuccessful = 0x05,
        LoginFailed = 0x06,
        UserCreate = 0x07,
        EmailInUse = 0x08,
        UserLoggedOut = 0x09,

    }

    class AuthClient
    {
        private const string IpAddress = "127.0.0.1";
        private const int ServerPort = 61234;

        private static Socket _authServer;
        private static readonly byte[] AuthKey = new byte[16];

        public static bool ConnectToServer()
        {
            try
            {
                _authServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _authServer.Connect(IpAddress, ServerPort);

                byte[] buffer = new byte[1];
                buffer[0] = (byte) ActionCodes.Connect;

                _authServer.Send(buffer);

                buffer = new byte[17];
                _authServer.Receive(buffer);

                Array.Copy(buffer, 1, AuthKey, 0, 16);

                return buffer[0] == (byte) ReplyCodes.ConnectionSuccessful;
            }
            catch (SocketException)
            {
                return false;
            }
        }

        public static bool CheckLoginInfo(string email, string pass, out UserInfo userInfo, out ReplyCodes replyCode)
        {
            byte[] buffer = new byte[1024];
            Array.Copy(AuthKey, 0, buffer, 0, 16);
            buffer[16] = (byte) ActionCodes.Login;
            byte[] message = BuildMessage(email, pass);
            byte[] messageLengthBytes = BitConverter.GetBytes(message.Length);
            Array.Copy(messageLengthBytes, 0, buffer, 17, 4);
            Array.Copy(message, 0, buffer, 21, message.Length);

            _authServer.Send(buffer);
            
            byte[] reply = new byte[1024];
            int replyLength = _authServer.Receive(reply);

            replyCode = (ReplyCodes) reply[0];
            Array.Copy(reply, 1, AuthKey, 0, 16);

            int messageLength = BitConverter.ToInt32(reply, 17);

            if (replyCode == ReplyCodes.LoginSuccessful)
            {
                if (messageLength > 0)
                {
                    byte[] replyMessage = new byte[messageLength];
                    Array.Copy(reply, 21, replyMessage, 0, messageLength);
                    string[] responceMessage = ReadMessage(replyMessage);
                    userInfo = new UserInfo
                    {
                        Id = Convert.ToInt32(responceMessage[0]),
                        Name = responceMessage[1],
                        Email = email,
                        Role = (UserRoles)Convert.ToInt32(responceMessage[2]),
                        status = Properties.Settings.Default.UserStatus != (int)UserStatus.Online ? (UserStatus)Properties.Settings.Default.UserStatus : UserStatus.Online
                    };
                    Properties.Settings.Default.LoginToken = responceMessage[3];
                    Properties.Settings.Default.LoginTime = Convert.ToInt32(responceMessage[4]);
                    Properties.Settings.Default.Save();
                    return true;
                }
            }

            userInfo = new UserInfo();

            return false;
        }

        public static bool CheckLoginInfo(string loginInfo, out UserInfo userInfo, out ReplyCodes replyCode)
        {
            byte[] buffer = new byte[1024];
            Array.Copy(AuthKey, 0, buffer, 0, 16);
            buffer[16] = (byte) ActionCodes.Login;
            byte[] message = Encoding.UTF8.GetBytes($"{loginInfo}");
            byte[] messageLengthBytes = BitConverter.GetBytes(message.Length);
            Array.Copy(messageLengthBytes, 0, buffer, 17, 4);
            Array.Copy(message, 0, buffer, 22, message.Length);

            _authServer.Send(buffer);
            
            byte[] reply = new byte[1024];
            int replyLength = _authServer.Receive(reply);

            replyCode = (ReplyCodes) reply[0];
            Array.Copy(reply, 1, AuthKey, 0, 16);
            int messageLength = BitConverter.ToInt32(reply,17);
            int pointer = replyLength - 21;
            message = new byte[messageLength];
            Array.Copy(reply, 22, message, 0, pointer);

            while (pointer < messageLength)
            {
                buffer = new byte[1024];
                int length = _authServer.Receive(buffer);
                Array.Copy(buffer, 0, message, pointer, length);
                pointer += length;
            }

            string[] responceMessage = Encoding.UTF8.GetString(message).Split(',');

            if (replyCode == ReplyCodes.LoginSuccessful)
            {
                userInfo = new UserInfo
                {
                    Id = Convert.ToInt32(responceMessage[0]),
                    Name = responceMessage[1],
                    Email = responceMessage[2],
                    Role = (UserRoles)Convert.ToInt32(responceMessage[3]),
                    status = Properties.Settings.Default.UserStatus != (int)UserStatus.Online ? (UserStatus)Properties.Settings.Default.UserStatus : UserStatus.Online
                };
                return true;
            }

            userInfo = new UserInfo();

            return false;
        }

        private static string[] ReadMessage(byte[] buffer)
        {
            int pointer = 0;
            List<string> messages = new List<string>();
            while (pointer < buffer.Length)
            {
                int length = BitConverter.ToInt32(buffer, pointer);
                byte[] messageBuffer = new byte[length];
                Array.Copy(buffer, pointer + 4, messageBuffer, 0, length);
                string message = Encoding.UTF8.GetString(messageBuffer);
                messages.Add(message);
                pointer += length + 4;
            }

            return messages.ToArray();
        }

        private static byte[] BuildMessage(params string[] args)
        {
            int count = 0;
            foreach (var arg in args)
            {
                count += arg.Length + 4;
            }
            byte[] buffer = new byte[count];
            int pointer = 0;
            foreach (var arg in args)
            {
                byte[] length = BitConverter.GetBytes(arg.Length);
                byte[] message = Encoding.UTF8.GetBytes(arg);
                Array.Copy(length, 0, buffer, pointer, 4);
                Array.Copy(message, 0, buffer, pointer + 4, message.Length);
                pointer += message.Length + 4;
            }

            return buffer;
        }
    }
}
