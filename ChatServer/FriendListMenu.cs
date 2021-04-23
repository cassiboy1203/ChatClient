using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatServer
{
    public partial class FriendListMenu : UserControl
    {
        public FriendListMenu()
        {
            InitializeComponent();
        }

        private enum Screens
        {
            Online,
            All,
            Pending,
            Blocked,
            AddFriend
        }

        public Layout MainLayout { get => _layout; set => _layout = value; }

        private Layout _layout;
        private FriendList _friendList;
        private AddFriend _addFriend;
        private Screens _selectedScreen = Screens.Online;

        public void OpenFriendList()
        {
            switch (_selectedScreen)
            {
                case Screens.Online:
                    break;
                case Screens.All:
                    break;
                case Screens.Pending:
                    break;
                case Screens.Blocked:
                    break;
                case Screens.AddFriend:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void BtnAddFriends_Click(object sender, EventArgs e)
        {
            _layout.OpenScreen = ChatServer.Layout.CurrentScreen.AddFriend;
            btnAddFriends.BackColor = Color.FromArgb(56,82,76);
            btnAddFriends.FlatAppearance.BorderColor = btnAddFriends.BackColor;
            btnAddFriends.FlatAppearance.MouseOverBackColor = btnAddFriends.BackColor;
            btnAddFriends.ForeColor = Color.FromArgb(67, 181, 115);
            OpenFriendScreen();
        }

        private void OpenFriendScreen()
        {
            if (!_layout.Controls.Contains(_addFriend))
            {
                _addFriend = new AddFriend();
                _addFriend.Dock = DockStyle.Fill;
                _layout.Controls.Add(_addFriend);
                _addFriend.BringToFront();
                _addFriend.btnSendRequest.Click += BtnSendRequest_Click;
            }
            else
            {
                _addFriend.Visible = true;
                _friendList.Visible = false;
            }
        }

        private void BtnSendRequest_Click(object sender, EventArgs e)
        {
            _addFriend.error.Clear();
            string friendRequest = _addFriend.tbFriend.Text;
            int lastIndex = friendRequest.LastIndexOf('#');
            if (lastIndex + 1 < friendRequest.Length)
            {
                string userName = friendRequest.Substring(0, lastIndex);
                string friendCode = friendRequest.Substring(lastIndex + 1);

                if (AuthClient.SendFriendRequest(userName, friendCode, out ReplyCodes reply))
                {
                    MessageBox.Show("Request send.");
                }
                else
                {
                    if (reply == ReplyCodes.FriendRequestExists)
                    {
                        _addFriend.error.SetError(_addFriend.tbFriend, "Request already exists");
                    }
                    else
                    {
                        _addFriend.error.SetError(_addFriend.tbFriend, "User not found.");
                    }
                }
            }
            else
            {
                _addFriend.error.SetError(_addFriend.tbFriend, "Invalid friend request use 'Username#0000'.");
            }
        }
    }
}
