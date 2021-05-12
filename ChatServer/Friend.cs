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
            FriendInfo.Token = token;
            FriendInfo.Name = name;
            FriendInfo.status = status;

            UpdateFriend();
        }

        public Friend(string token, string name, FriendListMenu friendListMenu)
        {
            InitializeComponent();
            FriendInfo.Token = token;
            FriendInfo.Name = name;
            _friendListMenu = friendListMenu;

            UpdateFriend();
        }

        public Friend(string token, string name)
        {
            InitializeComponent();
            FriendInfo.Token = token;
            FriendInfo.Name = name;

            lbFriendStatusText.Visible = false;

            UpdateFriend();
        }

        private FriendListMenu _friendListMenu;
        public UserInfo FriendInfo = new UserInfo();

        private void UpdateFriend()
        {
            lbFriendName.Text = FriendInfo.Name;
            lbFriendStatusText.Text = FriendInfo.status.ToString();

            //TODO: update status color.
            //TODO: update image.
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            if (AuthClient.FriendRequestReply(FriendInfo.Token, true))
            {
                _friendListMenu.SetupMenu();
            }
        }

        private void BtnReject_Click(object sender, EventArgs e)
        {
            if (AuthClient.FriendRequestReply(FriendInfo.Token, false))
            {
                _friendListMenu.SetupMenu();
            }
        }

        //TODO: On status change.
        //TODO: On name change.
        //TODO: On image change.
    }
}
