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

        public void ShowMessages(UserInfo user)
        {
            if (AuthClient.GetPrivateMessages(user.Token, 0, out List<Message> messages))
            {
                DateTime lastDate = DateTime.MinValue;
                foreach (var message in messages)
                {
                    if (message.MessageDate.Date > lastDate.Date)
                    {
                        lastDate = message.MessageDate;
                        MessageTimeStamp timeStamp = new MessageTimeStamp(lastDate);
                        timeStamp.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
                        timeStamp.Size = new Size(lbMessages.Width, message.Height);

                        lbMessages.Items.Add(timeStamp);
                        lbMessages.Controls.Add(timeStamp);
                    }
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
