using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatServer
{
    public partial class Login : Form
    {
        public Login(Layout layout)
        {
            InitializeComponent();
            _layout = layout;

            this.ActiveControl = label1;
        }

        private readonly Layout _layout;

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            this.error.Clear();

            string email = tbEmail.Text;
            string pass = tbPassword.Text;

            bool error = false;

            if (email == string.Empty)
            {
                this.error.SetError(tbEmail,"Please enter a email.");
                error = true;
            }
            else if (!email.Contains("@"))
            {
                this.error.SetError(tbEmail, "Please enter a valid email.");
                error = true;
            }

            if (pass.Length < 8 || pass.Length > 50)
            {
                this.error.SetError(tbPassword, "Please enter a valid password.");
                error = true;
            }

            if (!error)
            {
                if (AuthClient.CheckLoginInfo(email,pass,out UserInfo userInfo,out ReplyCodes reply))
                {
                    _layout.user1.UserInfo = userInfo;
                    _layout.OnLogin();
                }
                else
                {
                    this.error.SetError(tbPassword, "Password email combination is not valid.");
                }
            }
        }

        private bool ValidatePass(string pass)
        {
            bool returnValue = true;
            bool containsSpecialCh = false;

            string specialCh = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            char[] specialChArray = specialCh.ToCharArray();
            foreach (char ch in specialChArray)
            {
                if (pass.Contains(ch))
                {
                    containsSpecialCh = true;
                    break;
                }
            }

            if (pass.Length < 8 || pass.Length > 50)
            {
                returnValue = false;
            }
            else if (!pass.Any(char.IsUpper))
            {
                returnValue = false;
            }
            else if (!pass.Any(char.IsLower))
            {
                returnValue = false;
            }
            else if (pass.Contains(" "))
            {
                returnValue = false;
            }
            else if (!pass.Any(char.IsDigit) && !containsSpecialCh)
            {
                returnValue = false;
            }

            return returnValue;
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
