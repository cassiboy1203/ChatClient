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
    public partial class AddFriend : UserControl
    {
        public AddFriend()
        {
            InitializeComponent();
            tbFriend.TextBox.TextChanged += ValidateValue;
        }

        private void ValidateValue(object sender, EventArgs e)
        {
            PlaceholderTextBox tb = sender as PlaceholderTextBox;
            if (tb.Text.Contains("#"))
            {
                int lastIndex = tb.Text.LastIndexOf("#");
                string userName = tb.Text.Substring(0, lastIndex);
                string friendCode = tb.Text.Substring(lastIndex + 1);
                if (friendCode.Length == 4 && userName.Length > 0)
                {
                    btnSendRequest.BackColor = Color.FromArgb(255, 114, 137, 218);
                    btnSendRequest.ForeColor = Color.White;
                    btnSendRequest.FlatAppearance.BorderColor = btnSendRequest.BackColor;
                    btnSendRequest.FlatAppearance.MouseOverBackColor = btnSendRequest.BackColor;
                    btnSendRequest.Cursor = Cursors.Hand;
                    btnSendRequest.Enabled = true;
                }
                else
                {
                    btnSendRequest.BackColor = Color.FromArgb(150, 114, 137, 218);
                    btnSendRequest.ForeColor = Color.FromArgb(203, 204, 206);
                    btnSendRequest.FlatAppearance.BorderColor = btnSendRequest.BackColor;
                    btnSendRequest.FlatAppearance.MouseOverBackColor = btnSendRequest.BackColor;
                    btnSendRequest.Cursor = Cursors.No;
                    btnSendRequest.Enabled = false;
                }
            }
        }
    }
}
