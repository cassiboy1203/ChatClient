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
    public partial class MessageTimeStamp : UserControl
    {
        public MessageTimeStamp(DateTime date)
        {
            InitializeComponent();

            lbDate.Text = date.ToString("MMMM dd, yyyy");
        }

        private void LbDate_Resize(object sender, EventArgs e)
        {
            lbDate.Left = (this.Width - lbDate.Width) / 2;
        }
    }
}
