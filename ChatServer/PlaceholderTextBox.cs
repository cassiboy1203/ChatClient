using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChatServer
{
    public class PlaceholderTextBox : TextBox
    {
        public PlaceholderTextBox(Placeholder placeholder)
        {
            _placeholder = placeholder;
        }

        private readonly Placeholder _placeholder;

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);

            _placeholder.Hide();
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

            if (Text.Length <= 0)
            {
                _placeholder.Show();
            }
        }
    }
}
