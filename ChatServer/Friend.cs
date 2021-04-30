using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatServer
{
    public partial class Friend : UserControl
    {
        public Friend(string token, string name, UserStatus status)
        {
            InitializeComponent();
            Token = token;
            UserName = name;
            Status = status;

            UpdateFriend();
        }

        public Friend(string token, string name, FriendListMenu friendListMenu)
        {
            InitializeComponent();
            Token = token;
            UserName = name;
            _friendListMenu = friendListMenu;

            UpdateFriend();
        }

        public Friend(string token, string name)
        {
            InitializeComponent();
            Token = token;
            UserName = name;

            lbFriendStatusText.Visible = false;

            UpdateFriend();
        }

        public string Token;
        public string UserName;
        public UserStatus Status;
        public Image Image;
        private FriendListMenu _friendListMenu;

        private void UpdateFriend()
        {
            lbFriendName.Text = UserName;
            lbFriendStatusText.Text = Status.ToString();

            //TODO: update status color.
            //TODO: update image.
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            if (AuthClient.FriendRequestReply(Token, true))
            {
                _friendListMenu.SetupMenu();
            }
        }

        private void BtnReject_Click(object sender, EventArgs e)
        {
            if (AuthClient.FriendRequestReply(Token, false))
            {
                _friendListMenu.SetupMenu();
            }
        }

        //TODO: On status change.
        //TODO: On name change.
        //TODO: On image change.
    }
}
