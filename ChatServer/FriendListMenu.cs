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

        private enum Screens : int
        {
            Online = 0,
            All = 1,
            Pending = 2,
            Blocked = 3,
            AddFriend
        }

        public Layout MainLayout { get => _layout; set => _layout = value; }
        public List<Friend> Friends;
        public List<Friend> Requests;

        private Layout _layout;
        public FriendList FriendList;
        private AddFriend _addFriend;
        private Screens _selectedScreen = Screens.Online;

        public void SetupMenu()
        {
            AuthClient.GetFriends(ActionCodes.GetFriends, out Friends);
            AuthClient.GetFriends(ActionCodes.GetRequest, out Requests);
        }

        private void ShowFriendList(Screens filter)
        {
            if (!_layout.Controls.Contains(FriendList))
            {
                FriendList = new FriendList();
                FriendList.Dock = DockStyle.Fill;
                _layout.Controls.Add(FriendList);
                FriendList.BringToFront();
                FriendList.AutoScroll = true;
            }

            foreach (var friend in Friends)
            {
                FriendList.Controls.Remove(friend);
            }

            foreach (var request in Requests)
            {
                FriendList.Controls.Remove(request);
            }

            List<Friend> friends = Friends;

            switch (filter)
            {
                case Screens.Pending:
                    friends = Requests;
                    break;
                case Screens.Blocked:
                    //TODO: get blocked users
                    break;
            }
            if (friends != null)
            {
                int count = 0;
                foreach (var friend in friends)
                {
                    switch (filter)
                    {
                        case Screens.Online:
                            if (friend.Status == UserStatus.Offline || friend.Status == UserStatus.Invisible)
                            {
                                continue;
                            }
                            break;
                        case Screens.Blocked:
                            //TODO: get blocked
                            break;
                    }
                    friend.Location = new Point(0,70 + count * 100);
                    friend.Size = new Size(FriendList.Width, 100);
                    friend.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
                    
                    FriendList.Controls.Add(friend);
                    friend.BringToFront();
                }

                switch (filter)
                {
                    case Screens.Online:
                        FriendList.lbFriendAmount.Text = $"ONLINE - {count}";
                        break;
                    case Screens.All:
                        FriendList.lbFriendAmount.Text = $"ALL FRIENDS - {friends.Count}";
                        break;
                    case Screens.Pending:
                        FriendList.lbFriendAmount.Text = $"PENDING - {count}";
                        break;
                    case Screens.Blocked:
                        FriendList.lbFriendAmount.Text = $"BLOCKED - {count}";
                        break;
                }
            }
            else
            {
                switch (filter)
                {
                    case Screens.Online:
                        FriendList.lbFriendAmount.Text = $"ONLINE - 0";
                        break;
                    case Screens.All:
                        FriendList.lbFriendAmount.Text = $"ALL FRIENDS - 0";
                        break;
                    case Screens.Pending:
                        FriendList.lbFriendAmount.Text = $"PENDING - 0";
                        break;
                    case Screens.Blocked:
                        FriendList.lbFriendAmount.Text = $"BLOCKED - 0";
                        break;
                }
            }

            FriendList.Visible = true;
            if (_addFriend != null) _addFriend.Visible = false;
        }

        private void OpenAddFriendScreen()
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
                FriendList.Visible = false;
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
        
        private void BtnAddFriends_Click(object sender, EventArgs e)
        {
            _layout.OpenScreen = ChatServer.Layout.CurrentScreen.AddFriend;
            btnAddFriends.BackColor = Color.FromArgb(56,82,76);
            btnAddFriends.FlatAppearance.BorderColor = btnAddFriends.BackColor;
            btnAddFriends.FlatAppearance.MouseOverBackColor = btnAddFriends.BackColor;
            btnAddFriends.ForeColor = Color.FromArgb(67, 181, 115);
            OpenAddFriendScreen();

            lbOnline.ForeColor = Color.Silver;
            lbAll.ForeColor = Color.Silver;
            lbPending.ForeColor = Color.Silver;
            lbBlocked.ForeColor = Color.Silver;
        }

        private void LbOnline_Click(object sender, EventArgs e)
        {
            ShowFriendList(Screens.Online);
            lbOnline.ForeColor = Color.White;
            lbAll.ForeColor = Color.Silver;
            lbPending.ForeColor = Color.Silver;
            lbBlocked.ForeColor = Color.Silver;
        }

        private void LbAll_Click(object sender, EventArgs e)
        {
            ShowFriendList(Screens.All);
            lbOnline.ForeColor = Color.Silver;
            lbAll.ForeColor = Color.White;
            lbPending.ForeColor = Color.Silver;
            lbBlocked.ForeColor = Color.Silver;
        }

        private void LbPending_Click(object sender, EventArgs e)
        {
            ShowFriendList(Screens.Pending);
            lbOnline.ForeColor = Color.Silver;
            lbAll.ForeColor = Color.Silver;
            lbPending.ForeColor = Color.White;
            lbBlocked.ForeColor = Color.Silver;
        }
    }
}
