
namespace ChatServer
{
    partial class FriendList
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbFriendAmount = new System.Windows.Forms.Label();
            this.lbFriends = new System.Windows.Forms.ListBox();
            this.cmsUserOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFriendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUserOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFriendAmount
            // 
            this.lbFriendAmount.AutoSize = true;
            this.lbFriendAmount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFriendAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(204)))), ((int)(((byte)(206)))));
            this.lbFriendAmount.Location = new System.Drawing.Point(20, 22);
            this.lbFriendAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFriendAmount.Name = "lbFriendAmount";
            this.lbFriendAmount.Size = new System.Drawing.Size(166, 41);
            this.lbFriendAmount.TabIndex = 0;
            this.lbFriendAmount.Text = "ONLINE - 4";
            // 
            // lbFriends
            // 
            this.lbFriends.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFriends.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.lbFriends.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbFriends.FormattingEnabled = true;
            this.lbFriends.ItemHeight = 16;
            this.lbFriends.Location = new System.Drawing.Point(27, 80);
            this.lbFriends.Name = "lbFriends";
            this.lbFriends.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbFriends.Size = new System.Drawing.Size(549, 160);
            this.lbFriends.TabIndex = 1;
            // 
            // cmsUserOptions
            // 
            this.cmsUserOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.cmsUserOptions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsUserOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsUserOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.messageToolStripMenuItem,
            this.removeFriendToolStripMenuItem,
            this.blockToolStripMenuItem});
            this.cmsUserOptions.Name = "cmsUserOptions";
            this.cmsUserOptions.ShowImageMargin = false;
            this.cmsUserOptions.Size = new System.Drawing.Size(186, 156);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(204)))), ((int)(((byte)(206)))));
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(185, 32);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.ProfileToolStripMenuItem_Click);
            this.profileToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripMenuItem_MouseEnter);
            this.profileToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripMenuItem_MouseLeave);
            // 
            // messageToolStripMenuItem
            // 
            this.messageToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(204)))), ((int)(((byte)(206)))));
            this.messageToolStripMenuItem.Name = "messageToolStripMenuItem";
            this.messageToolStripMenuItem.Size = new System.Drawing.Size(185, 32);
            this.messageToolStripMenuItem.Text = "Message";
            this.messageToolStripMenuItem.Click += new System.EventHandler(this.MessageToolStripMenuItem_Click);
            this.messageToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripMenuItem_MouseEnter);
            this.messageToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripMenuItem_MouseLeave);
            // 
            // removeFriendToolStripMenuItem
            // 
            this.removeFriendToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(204)))), ((int)(((byte)(206)))));
            this.removeFriendToolStripMenuItem.Name = "removeFriendToolStripMenuItem";
            this.removeFriendToolStripMenuItem.Size = new System.Drawing.Size(185, 32);
            this.removeFriendToolStripMenuItem.Text = "Remove friend";
            this.removeFriendToolStripMenuItem.Click += new System.EventHandler(this.RemoveFriendToolStripMenuItem_Click);
            this.removeFriendToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripMenuItem_MouseEnter);
            this.removeFriendToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripMenuItem_MouseLeave);
            // 
            // blockToolStripMenuItem
            // 
            this.blockToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(204)))), ((int)(((byte)(206)))));
            this.blockToolStripMenuItem.Name = "blockToolStripMenuItem";
            this.blockToolStripMenuItem.Size = new System.Drawing.Size(185, 32);
            this.blockToolStripMenuItem.Text = "Block";
            this.blockToolStripMenuItem.Click += new System.EventHandler(this.BlockToolStripMenuItem_Click);
            this.blockToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripMenuItem_MouseEnter);
            this.blockToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripMenuItem_MouseLeave);
            // 
            // FriendList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.lbFriends);
            this.Controls.Add(this.lbFriendAmount);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FriendList";
            this.Size = new System.Drawing.Size(604, 285);
            this.cmsUserOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbFriendAmount;
        public System.Windows.Forms.ListBox lbFriends;
        public System.Windows.Forms.ContextMenuStrip cmsUserOptions;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeFriendToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem blockToolStripMenuItem;
    }
}
