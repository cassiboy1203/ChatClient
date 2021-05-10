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
    public partial class MessageList : UserControl
    {
        public MessageList(string userToken)
        {
            InitializeComponent();

            _userToken = userToken;

            tbMessage.TextBox.KeyPress += SendMessage;
        }

        public MessageList(int channelId)
        {
            InitializeComponent();

            _channelId = channelId;
        }

        private void ShowMessages(UserInfo user)
        {
            if (AuthClient.GetPrivateMessages(user.Token, 0, out List<Message> messages))
            {
                foreach (var message in messages)
                {
                    message.UpdateUserInfo(user);
                    message.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
                    message.Size = new Size(lbMessages.Width, message.Height);

                    lbMessages.Items.Add(messages);
                    lbMessages.Controls.Add(message);
                }
            }
        }

        private string _userToken;
        private int _channelId;

        private void SendMessage(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string message = tbMessage.Text;

                AuthClient.SendMessage(message, _userToken);

                tbMessage.TextBox.Clear();
            }
        }
    }
}
