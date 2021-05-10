using System;
using System.Collections.Generic;
using System.Drawing;
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
        Disconnect = 0x06,
        AddFriend = 0x07,
        GetFriends = 0x08,
        GetRequest = 0x09,
        AcceptRequest = 0x0A,
        RejectRequest = 0x0B,
        BlockUser = 0x0C,
        UnblockUser = 0x0D,
        GetBlockedUsers = 0x0E,
        SendPrivateMessage = 0x0F,

    }

    public enum ReplyCodes : byte
    {
        InvalidAction = 0x00,
        InvalidKey = 0x01,
        InvalidArgs = 0x02,
        ConnectionSuccessful = 0x03,
        LoginSuccessful = 0x04,
        LoginFailed = 0x05,
        UserCreate = 0x06,
        EmailInUse = 0x07,
        UserLoggedOut = 0x08,
        Confirm = 0x09,
        FriendRequestSend = 0x0A,
        UserNotFound = 0x0B,
        FriendRequestExists = 0x0C,
        FriendsFound = 0x0D,
        FriendsNotFound = 0x0E,
        MessageReceived = 0x0F,

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
                buffer[0] = (byte)ActionCodes.Connect;

                _authServer.Send(buffer);

                buffer = new byte[17];
                _authServer.Receive(buffer);

                Array.Copy(buffer, 1, AuthKey, 0, 16);

                return buffer[0] == (byte)ReplyCodes.ConnectionSuccessful;
            }
            catch (SocketException)
            {
                return false;
            }
        }

        public static void DisconnectFromServer()
        {
            if (_authServer == null) return;

            byte[] buffer = new byte[21];
            Array.Copy(AuthKey, 0, buffer, 0, 16);
            buffer[16] = (byte)ActionCodes.Disconnect;
            byte[] length = BitConverter.GetBytes(0);
            Array.Copy(length, 0, buffer, 17, 4);

            _authServer.Send(buffer);

            byte[] reply = new byte[1];
            _authServer.Receive(reply);

            _authServer.Close();
            _authServer.Dispose();
        }

        public static bool CheckLoginInfo(string email, string pass, out UserInfo userInfo, out ReplyCodes replyCode)
        {
            byte[] message = BuildMessage(email, pass);
            byte[] messageLengthBytes = BitConverter.GetBytes(message.Length);
            byte[] buffer = new byte[21 + message.Length];

            Array.Copy(AuthKey, 0, buffer, 0, 16);
            buffer[16] = (byte)ActionCodes.Login;
            Array.Copy(messageLengthBytes, 0, buffer, 17, 4);
            Array.Copy(message, 0, buffer, 21, message.Length);

            _authServer.Send(buffer);

            byte[] reply = new byte[1024];
            int replyLength = _authServer.Receive(reply);
            Array.Resize(ref buffer, replyLength);

            replyCode = (ReplyCodes)reply[0];
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
                        FriendCode = responceMessage[0],
                        Name = responceMessage[1],
                        Email = email,
                        Role = (UserRoles)Convert.ToInt32(responceMessage[2]),
                        status = Properties.Settings.Default.UserStatus != (int)UserStatus.Online ? (UserStatus)Properties.Settings.Default.UserStatus : UserStatus.Online
                    };
                    Properties.Settings.Default.LoginToken = responceMessage[3];
                    Properties.Settings.Default.UserToken = responceMessage[4];
                    Properties.Settings.Default.Save();
                    return true;
                }
            }

            userInfo = new UserInfo();

            return false;
        }

        public static bool CheckLoginInfo(out UserInfo userInfo, out ReplyCodes replyCode)
        {
            string loginToken = Properties.Settings.Default.LoginToken;
            string userToken = Properties.Settings.Default.UserToken;
            byte[] message = (UserStatus)Properties.Settings.Default.UserStatus == UserStatus.Online ? BuildMessage(loginToken, userToken) : BuildMessage(loginToken, Properties.Settings.Default.UserStatus.ToString());
            byte[] messageLengthBytes = BitConverter.GetBytes(message.Length);
            byte[] buffer = new byte[21 + message.Length];

            Array.Copy(AuthKey, 0, buffer, 0, 16);
            buffer[16] = (byte)ActionCodes.LoginInfo;
            Array.Copy(messageLengthBytes, 0, buffer, 17, 4);
            Array.Copy(message, 0, buffer, 21, message.Length);

            _authServer.Send(buffer);

            byte[] reply = new byte[1024];
            int replyLength = _authServer.Receive(reply);

            Array.Resize(ref buffer, replyLength);

            replyCode = (ReplyCodes)reply[0];
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
                        Token = responceMessage[0],
                        Name = responceMessage[1],
                        Email = responceMessage[2],
                        Role = (UserRoles)Convert.ToInt32(responceMessage[3]),
                        status = Properties.Settings.Default.UserStatus != (int)UserStatus.Online ? (UserStatus)Properties.Settings.Default.UserStatus : UserStatus.Online,
                        FriendCode = responceMessage[4]
                    };
                    return true;
                }
            }

            userInfo = new UserInfo();

            return false;
        }

        public static bool SendFriendRequest(string userName, string friendCode, out ReplyCodes reply)
        {
            byte[] message = BuildMessage(userName, friendCode);
            byte[] messageLengthBytes = BitConverter.GetBytes(message.Length);
            byte[] buffer = new byte[message.Length + 21];
            Array.Copy(AuthKey, 0, buffer, 0, 16);
            buffer[16] = (byte)ActionCodes.AddFriend;
            Array.Copy(messageLengthBytes, 0, buffer, 17, 4);
            Array.Copy(message, 0, buffer, 21, message.Length);

            _authServer.Send(buffer);

            buffer = new byte[1024];
            int length = _authServer.Receive(buffer);
            Array.Resize(ref buffer, length);

            reply = (ReplyCodes)buffer[0];
            Array.Copy(buffer, 1, AuthKey, 0, 16);

            return reply == ReplyCodes.FriendRequestSend;
        }

        public static bool GetFriends(ActionCodes filter, FriendListMenu flm, out List<Friend> friends, int timestamp)
        {
            friends = new List<Friend>();

            byte[] message = BuildMessage(timestamp.ToString());
            byte[] messageLengthBytes = BitConverter.GetBytes(message.Length);
            byte[] buffer = new byte[21 + message.Length];
            Array.Copy(AuthKey, 0, buffer, 0, 16);
            buffer[16] = (byte) filter;
            Array.Copy(messageLengthBytes, 0, buffer, 17, 4);
            Array.Copy(message, 0, buffer, 21, message.Length);

            _authServer.Send(buffer);

            buffer = new byte[1024];
            int length = _authServer.Receive(buffer);
            Array.Resize(ref buffer, length);
            
            ReplyCodes reply = (ReplyCodes)buffer[0];
            Array.Copy(buffer, 1, AuthKey, 0, 16);
            if (reply == ReplyCodes.FriendsFound)
            {
                int messageLength = BitConverter.ToInt32(buffer, 17);
            
                byte[] replyMessage = new byte[messageLength];
                Array.Copy(buffer, 21, replyMessage, 0, buffer.Length - 21);
                if (messageLength > 1024 - 21)
                {
                    GetFullMessage(messageLength, buffer.Length - 21, ref replyMessage);
                }

                List<List<byte[]>> extendedMessages = ReadExtendeMessage(replyMessage);

                foreach (var messageList in extendedMessages)
                {
                    string friendToken = Encoding.UTF8.GetString(messageList[0]);
                    string friendName = Encoding.UTF8.GetString(messageList[1]);
                    UserStatus friendStatus = UserStatus.Offline;
                    if (filter == ActionCodes.GetFriends)
                    {
                        friendStatus = (UserStatus) Convert.ToInt32(Encoding.UTF8.GetString(messageList[2]));
                    }

                    Friend friend;
                    if (filter == ActionCodes.GetRequest)
                    {
                        friend = new Friend(friendToken, friendName, flm);
                    }
                    else if (filter == ActionCodes.GetBlockedUsers)
                    {
                        friend = new Friend(friendToken, friendName);
                    }
                    else
                    {
                        friend = new Friend(friendToken, friendName, friendStatus);
                    }

                    friends.Add(friend);
                }

                return true;
            }

            return false;
        }

        public static bool FriendRequestReply(string userToken, bool isAccepted)
        {
            byte[] message = BuildMessage(userToken);
            byte[] messageLengthBytes = BitConverter.GetBytes(message.Length);
            byte[] buffer = new byte[message.Length + 21];
            Array.Copy(AuthKey, 0, buffer, 0, 16);
            buffer[16] = isAccepted ? (byte) ActionCodes.AcceptRequest : (byte) ActionCodes.RejectRequest;
            Array.Copy(messageLengthBytes, 0, buffer, 17, 4);
            Array.Copy(message, 0, buffer, 21, message.Length);

            _authServer.Send(buffer);

            buffer = new byte[1024];
            int replyLength = _authServer.Receive(buffer);
            Array.Resize(ref buffer, replyLength);

            ReplyCodes reply = (ReplyCodes) buffer[0];
            Array.Copy(buffer, 1, AuthKey, 0, 16);

            return reply == ReplyCodes.Confirm;
        }

        public static bool BlockUser(string userToken, bool isBlocked)
        {
            byte[] message = BuildMessage(userToken);
            byte[] messageLengthBytes = BitConverter.GetBytes(message.Length);
            byte[] buffer = new byte[message.Length + 21];
            Array.Copy(AuthKey, 0, buffer, 0, 16);
            buffer[16] = isBlocked ? (byte) ActionCodes.UnblockUser : (byte) ActionCodes.BlockUser;
            Array.Copy(messageLengthBytes, 0, buffer, 17, 4);
            Array.Copy(message, 0, buffer, 21, message.Length);

            _authServer.Send(buffer);

            buffer = new byte[1024];
            int replyLength = _authServer.Receive(buffer);
            Array.Resize(ref buffer, replyLength);

            ReplyCodes reply = (ReplyCodes) buffer[0];
            Array.Copy(buffer, 1, AuthKey, 0, 16);

            return reply == ReplyCodes.Confirm;
        }

        public static bool SendMessage(string text, string userToken)
        {
            byte[] message = BuildMessage(text, userToken);
            byte[] messageLengthBytes = BitConverter.GetBytes(message.Length);
            byte[] buffer = new byte[message.Length + 21];
            Array.Copy(AuthKey, 0, buffer, 0, 16);
            buffer[16] = (byte) ActionCodes.SendPrivateMessage;
            Array.Copy(messageLengthBytes, 0, buffer, 17, 4);
            Array.Copy(message, 0, buffer, 21, message.Length);

            if (buffer.Length > 1024)
            {
                int pointer = 0;
                while (pointer < buffer.Length)
                {
                    int messageLength = buffer.Length - pointer > 1024 ? 1025 : buffer.Length - pointer;
                    byte[] splitBuffer = new byte[messageLength];
                    Array.Copy(buffer, pointer, splitBuffer, 0, messageLength);

                    _authServer.Send(splitBuffer);
                    pointer += messageLength;
                }
            }
            else _authServer.Send(buffer);

            buffer = new byte[1024];
            int replyLength = _authServer.Receive(buffer);
            Array.Resize(ref buffer, replyLength);

            ReplyCodes reply = (ReplyCodes) buffer[0];
            Array.Copy(buffer, 1, AuthKey, 0, 16);

            return reply == ReplyCodes.MessageReceived;
        }

        private static void GetFullMessage(int length, int pointer, ref byte[] message)
        {
            while (pointer < length)
            {
                byte[] buffer = new byte[1024];
                int bufferLength = _authServer.Receive(buffer);
                Array.Resize(ref buffer, bufferLength);

                Array.Copy(buffer, 0, message, pointer, bufferLength);

                pointer += bufferLength;
            }
        }

        private static List<List<byte[]>> ReadExtendeMessage(byte[] buffer)
        {
            int pointer = 0;
            List<byte[]> messageBytes = new List<byte[]>();
            List<List<byte[]>> extendeMessage = new List<List<byte[]>>();

            while (pointer < buffer.Length)
            {
                int length = BitConverter.ToInt32(buffer, pointer);
                byte[] friendBuffer = new byte[length];
                Array.Copy(buffer, pointer + 4, friendBuffer, 0, length);
                messageBytes.Add(friendBuffer);
                pointer += length + 4;
            }

            foreach (var message in messageBytes)
            {
                pointer = 0;
                List<byte[]> bytes = new List<byte[]>();
                while (pointer < message.Length)
                {
                    int length = BitConverter.ToInt32(message, pointer);
                    byte[] messageBuffer = new byte[length];
                    Array.Copy(message, pointer + 4, messageBuffer, 0, length);
                    bytes.Add(messageBuffer);
                    pointer += length + 4;
                }
                extendeMessage.Add(bytes);
            }

            return extendeMessage;
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
