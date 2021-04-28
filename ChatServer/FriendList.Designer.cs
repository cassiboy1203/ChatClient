
namespace ChatServer
{
    partial class FriendList
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
            this.lbFriendAmount = new System.Windows.Forms.Label();
            this.lbFriends = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbFriendAmount
            // 
            this.lbFriendAmount.AutoSize = true;
            this.lbFriendAmount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFriendAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(204)))), ((int)(((byte)(206)))));
            this.lbFriendAmount.Location = new System.Drawing.Point(20, 22);
            this.lbFriendAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFriendAmount.Name = "lbFriendAmount";
            this.lbFriendAmount.Size = new System.Drawing.Size(166, 41);
            this.lbFriendAmount.TabIndex = 0;
            this.lbFriendAmount.Text = "ONLINE - 4";
            // 
            // lbFriends
            // 
            this.lbFriends.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFriends.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.lbFriends.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbFriends.FormattingEnabled = true;
            this.lbFriends.ItemHeight = 16;
            this.lbFriends.Location = new System.Drawing.Point(27, 80);
            this.lbFriends.Name = "lbFriends";
            this.lbFriends.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbFriends.Size = new System.Drawing.Size(549, 160);
            this.lbFriends.TabIndex = 1;
            // 
            // FriendList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.lbFriends);
            this.Controls.Add(this.lbFriendAmount);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FriendList";
            this.Size = new System.Drawing.Size(604, 285);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbFriendAmount;
        public System.Windows.Forms.ListBox lbFriends;
    }
}
