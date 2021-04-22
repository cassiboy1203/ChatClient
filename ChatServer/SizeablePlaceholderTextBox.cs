using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ChatServer
{
    class SizeAblePlaceholderTextBox : Panel
    {
        [
            Category("TextBox"),
            Description("TextBox text")
        ]
        public string Text
        {
            get => _textBox.Text;
            set
            {
                _textBox.Text = value;
                _textBox.Invalidate();
            }
        }
        [
            Category("TextBox"),
            Description("TextBox offset")
        ]
        public Point TextBoxOffset
        {
            get => _textBox.Location;
            set
            {
                _textBox.Location = value;
                _textBox.Invalidate();
            }
        }
        [
            Category("TextBox"),
            Description("Use system password char")
        ]
        public bool UseSystemPasswordChar
        {
            get => _textBox.UseSystemPasswordChar;
            set
            {
                _textBox.UseSystemPasswordChar = value;
                _textBox.Invalidate();
            }
        }
        [
            Category("TextBox"),
            Description("The used password char")
        ]
        public char PasswordChar
        {
            get => _textBox.PasswordChar;
            set
            {
                _textBox.PasswordChar = value;
                _textBox.Invalidate();
            }
        }
        [
            Category("Placeholder"),
            Description("If the placeholder is enabled")
        ]
        public bool PlaceholderEnabled 
        { 
            get => _placeholder.Visible;
            set
            {
                _placeholder.Visible = value;
                _placeholder.Invalidate();
            }
        }
        [
            Category("Placeholder"),
            Description("The text color of the placeholder")
        ]
        public Color PlaceholderColor
        {
            get => _placeholder.ForeColor;
            set
            {
                _placeholder.ForeColor = value;
                _placeholder.Invalidate();
            }
        }
        [
            Category("Placeholder"),
            Description("The text that the placeholder has")
        ]
        public string PlaceholderText
        {
            get => _placeholder.Text;
            set
            {
                _placeholder.Text = value; 
                _placeholder.Invalidate();
            }
        }
        [
            Category("Placeholder"),
            Description("The location of the placeholder in the textbox")
        ]
        public Point PlaceholderOffset
        {
            get => _placeholder.Location;
            set 
            {
                _placeholder.Location = value;
                _placeholder.Invalidate();
            }
        }

        [
            Category("Placeholder"),
            Description("The alignment of the placeholder")
        ]
        public ContentAlignment PlaceholderAlignment
        {
            get => _placeholder.TextAlign;
            set
            {
                _placeholder.TextAlign = value;
                _placeholder.Invalidate();
            }
        }

        private readonly Placeholder _placeholder;
        private PlaceholderTextBox _textBox;

        public SizeAblePlaceholderTextBox()
        {
            _placeholder = new Placeholder(this);

            _textBox = new PlaceholderTextBox(_placeholder);
            _textBox.BorderStyle = BorderStyle.None;
            Size = new Size(this.Width - TextBoxOffset.X, _textBox.Height);
            Location = new Point(10, this.Height / 2 - _textBox.Height / 2);

            _placeholder.Location = new Point(10,0);
            _placeholder.Size = new Size(this.Width - PlaceholderOffset.X, this.Height - PlaceholderOffset.Y * 2);
            _placeholder.ForeColor = Color.FromArgb(71, 75, 82);
            _placeholder.AutoSize = false;
            _placeholder.Text = "Placeholder";
            _placeholder.TextAlign = ContentAlignment.MiddleLeft;

            Controls.Add(_placeholder);
            Controls.Add(_textBox);
        }

        public void EnterTextbox()
        {
            _textBox.Select();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            _textBox.Select();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            _textBox.Size = new Size(this.Width - PlaceholderOffset.X,_textBox.Height);
            _textBox.Location = new Point(PlaceholderOffset.X, this.Height / 2 - _textBox.Height / 2);
            _placeholder.Size = new Size(this.Width - PlaceholderOffset.X, this.Height - PlaceholderOffset.Y * 2);
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);

            _textBox.Font = this.Font;
            _textBox.Size = new Size(this.Width - PlaceholderOffset.X,_textBox.Height);
            _textBox.Location = new Point(PlaceholderOffset.X, this.Height / 2 - _textBox.Height / 2);

            _placeholder.Font = this.Font;
            _placeholder.Size = new Size(this.Width - PlaceholderOffset.X, this.Height - PlaceholderOffset.Y * 2);
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);

            _placeholder.BackColor = this.BackColor;
            _textBox.BackColor = this.BackColor;
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);

            _textBox.ForeColor = this.ForeColor;
        }
    }
}
