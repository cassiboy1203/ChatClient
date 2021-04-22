using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatServer
{
    public struct UserInfo
    {
        public string Token;
        public string Name;
        public string Email;
        public UserRoles Role;
        public Image image;
        public UserStatus status;
        public string FriendCode;
    }

    public enum UserStatus
    {
        Online = 0,
        Offline = 1,
        Idle = 2,
        Dnd = 3,
        Invisible = 4
    }

    public enum UserRoles
    {
        User = 0,
        Mod = 29,
        Dev = 30
    }

    public partial class User : UserControl
    {
        public User()
        {
            InitializeComponent();
        }

        public UserInfo UserInfo;

        public void UpdateUserInfo()
        {
            lbUserName.Text = UserInfo.Name;
            lbUserId.Text = $"#{UserInfo.FriendCode}";
            //TODO: update picture
        }
    }
}
