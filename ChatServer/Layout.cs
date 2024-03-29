﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatServer
{
    public partial class Layout : Form
    {
        public Layout()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.friendListMenu1.MainLayout = this;
        }

        public enum CurrentScreen
        {
            None,
            FriendList,
            AddFriend,
            Server,
            Login,
            CreateJoinServer
        }

        public CurrentScreen OpenScreen = CurrentScreen.Login;

        public void OnLogin()
        {
            friendListMenu1.SetupMenu();
            Show();
            user1.UpdateUserInfo();
            //TODO: open friendlist screen
            OpenScreen = CurrentScreen.FriendList;
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public override Size MinimumSize
        {
            get => base.MinimumSize; 
            set => base.MinimumSize = new Size(900, 500);
        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Layout_Load(object sender, EventArgs e)
        {
            this.Hide();
            LabelRetry:
            if (AuthClient.ConnectToServer())
            {
                //Properties.Settings.Default.Reset();
                LabelRetryLogin:
                string loginToken = Properties.Settings.Default.LoginToken;
                //MessageBox.Show(loginToken);
                if (string.IsNullOrEmpty(loginToken))
                {
                    Login login = new Login(this);
                    login.Show();
                }
                else
                {
                    if (AuthClient.CheckLoginInfo(out UserInfo userInfo, out ReplyCodes replyCode))
                    {
                        user1.UserInfo = userInfo;
                        OnLogin();
                    }
                    else
                    {
                        Properties.Settings.Default.LoginToken = null;
                        Properties.Settings.Default.Save();
                        goto LabelRetryLogin;
                    }
                }
            }
            else
            {
                Thread.Sleep(2000);
                //TODO: show unable to connect to server, retrying to connect.
                goto LabelRetry;
            }
        }

        private void Layout_FormClosed(object sender, FormClosedEventArgs e)
        {
            AuthClient.DisconnectFromServer();
        }
    }
}
