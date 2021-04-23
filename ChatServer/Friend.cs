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

        public Friend(string token, string name, int requestInfo)
        {
            InitializeComponent();
            Token = token;
            UserName = name;
            RequestInfo = requestInfo;

            UpdateFriend();
        }

        public string Token;
        public string UserName;
        public UserStatus Status;
        public int RequestInfo;
        public Image Image;

        private void UpdateFriend()
        {
            lbFriendName.Text = UserName;
            lbFriendStatusText.Text = Status.ToString();

            //TODO: update status color.
            //TODO: update image.
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            //TODO: accept request.
        }

        private void BtnReject_Click(object sender, EventArgs e)
        {
            //TODO: reject request.
        }

        //TODO: On status change.
        //TODO: On name change.
        //TODO: On image change.
    }
}
