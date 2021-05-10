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
    public partial class Message : UserControl
    {
        public Message(string message, DateTime date)
        {
            _message = message;
            _messageDate = date;

            tbMessage.Text = message;
            lbDate.Text = date.ToString(date.Date == DateTime.Today.Date ? "HH:mm:ss" : "dd/MM/yyyy");
        }
        public Message(string message, UserInfo user, DateTime date)
        {
            InitializeComponent();

            _message = message;
            _user = user;
            _messageDate = date;

            tbMessage.Text = message;
            lbUserName.Text = user.Name;
            lbDate.Text = date.ToString(date.Date == DateTime.Today.Date ? "HH:mm:ss" : "dd/MM/yyyy");
        }

        private UserInfo _user;
        private DateTime _messageDate;
        private string _message;

        public void UpdateUserInfo(UserInfo user)
        {
            _user = user;

            lbUserName.Text = user.Name;
        }
    }
}
