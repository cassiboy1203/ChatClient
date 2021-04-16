
using System.Windows.Forms;

namespace ChatServer
{
    partial class Layout
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FormBorder = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.ServerList = new System.Windows.Forms.Panel();
            this.serverList1 = new ChatServer.ServerList();
            this.serverButtons1 = new ChatServer.ServerButtons();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Menu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuBorder = new System.Windows.Forms.Panel();
            this.FriendAndChannelList = new System.Windows.Forms.Panel();
            this.user1 = new ChatServer.User();
            this.FormBorder.SuspendLayout();
            this.ServerList.SuspendLayout();
            this.Menu.SuspendLayout();
            this.FriendAndChannelList.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormBorder
            // 
            this.FormBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.FormBorder.Controls.Add(this.btnMinimize);
            this.FormBorder.Controls.Add(this.btnMaximize);
            this.FormBorder.Controls.Add(this.btnExit);
            this.FormBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormBorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.FormBorder.Location = new System.Drawing.Point(0, 0);
            this.FormBorder.Name = "FormBorder";
            this.FormBorder.Size = new System.Drawing.Size(1455, 20);
            this.FormBorder.TabIndex = 0;
            this.FormBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.FormBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.FormBorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(1393, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(22, 20);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(1413, 0);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(22, 20);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.Text = "//";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1433, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(22, 20);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // ServerList
            // 
            this.ServerList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.ServerList.Controls.Add(this.serverList1);
            this.ServerList.Controls.Add(this.serverButtons1);
            this.ServerList.Controls.Add(this.panel2);
            this.ServerList.Dock = System.Windows.Forms.DockStyle.Left;
            this.ServerList.Location = new System.Drawing.Point(0, 20);
            this.ServerList.Name = "ServerList";
            this.ServerList.Size = new System.Drawing.Size(100, 1060);
            this.ServerList.TabIndex = 2;
            // 
            // serverList1
            // 
            this.serverList1.AutoScroll = true;
            this.serverList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.serverList1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.serverList1.Location = new System.Drawing.Point(0, 94);
            this.serverList1.Margin = new System.Windows.Forms.Padding(4);
            this.serverList1.Name = "serverList1";
            this.serverList1.Size = new System.Drawing.Size(100, 966);
            this.serverList1.TabIndex = 1;
            // 
            // serverButtons1
            // 
            this.serverButtons1.BackColor = System.Drawing.Color.Transparent;
            this.serverButtons1.Location = new System.Drawing.Point(0, 4);
            this.serverButtons1.Margin = new System.Windows.Forms.Padding(4);
            this.serverButtons1.Name = "serverButtons1";
            this.serverButtons1.Size = new System.Drawing.Size(100, 80);
            this.serverButtons1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(12, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(75, 1);
            this.panel2.TabIndex = 8;
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.panel1);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Menu.Location = new System.Drawing.Point(100, 20);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1355, 50);
            this.Menu.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 50);
            this.panel1.TabIndex = 0;
            // 
            // MenuBorder
            // 
            this.MenuBorder.BackColor = System.Drawing.Color.Black;
            this.MenuBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuBorder.Location = new System.Drawing.Point(100, 70);
            this.MenuBorder.Name = "MenuBorder";
            this.MenuBorder.Size = new System.Drawing.Size(1355, 1);
            this.MenuBorder.TabIndex = 6;
            // 
            // FriendAndChannelList
            // 
            this.FriendAndChannelList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.FriendAndChannelList.Controls.Add(this.user1);
            this.FriendAndChannelList.Dock = System.Windows.Forms.DockStyle.Left;
            this.FriendAndChannelList.Location = new System.Drawing.Point(100, 71);
            this.FriendAndChannelList.Name = "FriendAndChannelList";
            this.FriendAndChannelList.Size = new System.Drawing.Size(300, 1009);
            this.FriendAndChannelList.TabIndex = 7;
            // 
            // user1
            // 
            this.user1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.user1.Location = new System.Drawing.Point(0, 934);
            this.user1.Margin = new System.Windows.Forms.Padding(4);
            this.user1.Name = "user1";
            this.user1.Size = new System.Drawing.Size(300, 75);
            this.user1.TabIndex = 0;
            // 
            // Layout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1455, 1080);
            this.Controls.Add(this.FriendAndChannelList);
            this.Controls.Add(this.MenuBorder);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.ServerList);
            this.Controls.Add(this.FormBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Layout";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Layout_Load);
            this.FormBorder.ResumeLayout(false);
            this.ServerList.ResumeLayout(false);
            this.Menu.ResumeLayout(false);
            this.FriendAndChannelList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FormBorder;
        private System.Windows.Forms.Panel ServerList;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Panel MenuBorder;
        private System.Windows.Forms.Panel FriendAndChannelList;
        private System.Windows.Forms.Panel panel2;
        private ServerButtons serverButtons1;
        private System.Windows.Forms.Panel panel1;
        private ServerList serverList1;
        private Button btnExit;
        private Button btnMinimize;
        private Button btnMaximize;
        public User user1;
    }
}

