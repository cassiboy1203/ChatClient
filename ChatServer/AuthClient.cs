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
    class AuthClient
    {
        private const string IpAddress = "127.0.0.1";
        private const int ServerPort = 1234;

        private static Socket _authClient;
        private static string authKey;

        public static bool ConnectToServer()
        {
            try
            {
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(IpAddress, ServerPort);

                _authClient = socket;
                return true;
            }
            catch (SocketException)
            {
                return false;
            }
        }

        public static bool CheckLoginInfo(string email, string pass, out UserInfo userInfo)
        {
            byte[] message = Encoding.UTF8.GetBytes(Properties.Settings.Default.UserStatus != Convert.ToInt32(UserStatus.Online) ? $"Login,{email},{pass},{Properties.Settings.Default.UserStatus}" : $"Login,{email},{pass}");

            _authClient.Send(message);
            
            byte[] responce = new byte[1024];
            _authClient.Receive(responce);

            string[] responceMessage = Encoding.UTF8.GetString(responce).Split(',');

            if (Convert.ToBoolean(responceMessage[0]))
            {
                userInfo = new UserInfo
                {
                    Name = responceMessage[1],
                    Email = email,
                    Role = (UserRoles)Convert.ToInt32(responceMessage[2]),
                    status = UserStatus.Online,
                    LoginString = responceMessage[3]
                };

                authKey = responceMessage[4];
                return true;
            }

            userInfo = new UserInfo();

            return false;
        }

        public static bool CheckLoginInfo(string loginInfo, out UserInfo userInfo)
        {
            byte[] message = Encoding.UTF8.GetBytes(Properties.Settings.Default.UserStatus != Convert.ToInt32(UserStatus.Online) ? $"checkInfo,{loginInfo},{Properties.Settings.Default.UserStatus}" : $"Login,{loginInfo}");

            _authClient.Send(message);
            
            byte[] responce = new byte[1024];
            _authClient.Receive(responce);

            string[] responceMessage = Encoding.UTF8.GetString(responce).Split(',');

            if (Convert.ToBoolean(responceMessage[0]))
            {
                userInfo = new UserInfo
                {
                    Name = responceMessage[1],
                    Email = responceMessage[2],
                    Role = (UserRoles)Convert.ToInt32(responceMessage[3]),
                    status = UserStatus.Online,
                    LoginString = responceMessage[4]
                };
                authKey = responceMessage[5];

                return true;
            }

            userInfo = new UserInfo();

            return false;
        }
    }
}
