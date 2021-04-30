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
    public partial class FriendList : UserControl
    {
        public FriendList()
        {
            InitializeComponent();

            cmsUserOptions.Renderer = new ToolStripProfessionalRenderer(new CustomColorTable());
        }

        public Friend SelectedFriend;

        private void ToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem mi) mi.ForeColor = Color.White;
        }

        private void ToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem mi) mi.ForeColor = Color.FromArgb(203, 204, 206);
        }

        private void ProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: open friends profile
        }

        private void MessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: start/open private messages
        }

        private void RemoveFriendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: remove friend relation
        }

        public void BlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthClient.BlockUser(SelectedFriend.Token, false);
        }

        public void UnBlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthClient.BlockUser(SelectedFriend.Token, true);
        }
    }
}
