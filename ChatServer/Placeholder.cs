using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatServer
{
    public class Placeholder : Label
    {
        public Placeholder(SizeAblePlaceholderTextBox panel)
        {
            _panel = panel;
        }

        private readonly SizeAblePlaceholderTextBox _panel;

        protected override void OnClick(EventArgs e)
        {
            _panel.EnterTextbox();
        }
    }
}
