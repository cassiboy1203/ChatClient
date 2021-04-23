using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ChatServer
{
    public class SizeAblePlaceholderTextBox : Panel
    {
        [
            Category("TextBox"),
            Description("TextBox text")
        ]
        public string Text
        {
            get => TextBox.Text;
            set
            {
                TextBox.Text = value;
                TextBox.Invalidate();
            }
        }
        [
            Category("TextBox"),
            Description("TextBox offset")
        ]
        public Point TextBoxOffset
        {
            get => TextBox.Location;
            set
            {
                TextBox.Location = value;
                TextBox.Invalidate();
            }
        }
        [
            Category("TextBox"),
            Description("Use system password char")
        ]
        public bool UseSystemPasswordChar
        {
            get => TextBox.UseSystemPasswordChar;
            set
            {
                TextBox.UseSystemPasswordChar = value;
                TextBox.Invalidate();
            }
        }
        [
            Category("TextBox"),
            Description("The used password char")
        ]
        public char PasswordChar
        {
            get => TextBox.PasswordChar;
            set
            {
                TextBox.PasswordChar = value;
                TextBox.Invalidate();
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
        public readonly PlaceholderTextBox TextBox;

        public SizeAblePlaceholderTextBox()
        {
            _placeholder = new Placeholder(this);

            TextBox = new PlaceholderTextBox(_placeholder);
            TextBox.BorderStyle = BorderStyle.None;
            Size = new Size(this.Width - TextBoxOffset.X, TextBox.Height);
            Location = new Point(10, this.Height / 2 - TextBox.Height / 2);

            _placeholder.Location = new Point(10,0);
            _placeholder.Size = new Size(this.Width - PlaceholderOffset.X, this.Height - PlaceholderOffset.Y * 2);
            _placeholder.ForeColor = Color.FromArgb(71, 75, 82);
            _placeholder.AutoSize = false;
            _placeholder.Text = "Placeholder";
            _placeholder.TextAlign = ContentAlignment.MiddleLeft;

            Controls.Add(_placeholder);
            Controls.Add(TextBox);
        }

        public void EnterTextbox()
        {
            TextBox.Select();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            TextBox.Select();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            TextBox.Size = new Size(this.Width - PlaceholderOffset.X,TextBox.Height);
            TextBox.Location = new Point(PlaceholderOffset.X, this.Height / 2 - TextBox.Height / 2);
            _placeholder.Size = new Size(this.Width - PlaceholderOffset.X, this.Height - PlaceholderOffset.Y * 2);
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);

            TextBox.Font = this.Font;
            TextBox.Size = new Size(this.Width - PlaceholderOffset.X,TextBox.Height);
            TextBox.Location = new Point(PlaceholderOffset.X, this.Height / 2 - TextBox.Height / 2);

            _placeholder.Font = this.Font;
            _placeholder.Size = new Size(this.Width - PlaceholderOffset.X, this.Height - PlaceholderOffset.Y * 2);
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);

            _placeholder.BackColor = this.BackColor;
            TextBox.BackColor = this.BackColor;
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);

            TextBox.ForeColor = this.ForeColor;
        }
    }
}
