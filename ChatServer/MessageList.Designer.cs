
namespace ChatServer
{
    partial class MessageList
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
            this.lbMessages = new System.Windows.Forms.ListBox();
            this.tbMessage = new ChatServer.SizeAblePlaceholderTextBox();
            this.SuspendLayout();
            // 
            // lbMessages
            // 
            this.lbMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.lbMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbMessages.FormattingEnabled = true;
            this.lbMessages.ItemHeight = 16;
            this.lbMessages.Location = new System.Drawing.Point(0, 2);
            this.lbMessages.Name = "lbMessages";
            this.lbMessages.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbMessages.Size = new System.Drawing.Size(1291, 528);
            this.lbMessages.TabIndex = 0;
            // 
            // tbMessage
            // 
            this.tbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.tbMessage.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbMessage.ForeColor = System.Drawing.Color.White;
            this.tbMessage.Location = new System.Drawing.Point(12, 536);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.PasswordChar = '\0';
            this.tbMessage.PlaceholderAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbMessage.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(114)))), ((int)(((byte)(123)))));
            this.tbMessage.PlaceholderEnabled = true;
            this.tbMessage.PlaceholderOffset = new System.Drawing.Point(10, 0);
            this.tbMessage.PlaceholderText = "Message";
            this.tbMessage.Size = new System.Drawing.Size(1265, 50);
            this.tbMessage.TabIndex = 1;
            this.tbMessage.TextBoxOffset = new System.Drawing.Point(10, 18);
            this.tbMessage.UseSystemPasswordChar = false;
            // 
            // MessageList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.lbMessages);
            this.Name = "MessageList";
            this.Size = new System.Drawing.Size(1291, 601);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbMessages;
        private SizeAblePlaceholderTextBox tbMessage;
    }
}
