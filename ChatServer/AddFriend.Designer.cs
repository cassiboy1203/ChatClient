
namespace ChatServer
{
    partial class AddFriend
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
            this.components = new System.ComponentModel.Container();
            this.lbFriendAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.tbFriend = new ChatServer.SizeAblePlaceholderTextBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFriendAmount
            // 
            this.lbFriendAmount.AutoSize = true;
            this.lbFriendAmount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFriendAmount.ForeColor = System.Drawing.Color.White;
            this.lbFriendAmount.Location = new System.Drawing.Point(20, 22);
            this.lbFriendAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFriendAmount.Name = "lbFriendAmount";
            this.lbFriendAmount.Size = new System.Drawing.Size(186, 41);
            this.lbFriendAmount.TabIndex = 1;
            this.lbFriendAmount.Text = "ADD FRIEND";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(20, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "You can add a friend with their FriendCode";
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnSendRequest.Cursor = System.Windows.Forms.Cursors.No;
            this.btnSendRequest.Enabled = false;
            this.btnSendRequest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnSendRequest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(106)))), ((int)(((byte)(170)))));
            this.btnSendRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnSendRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendRequest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(204)))), ((int)(((byte)(206)))));
            this.btnSendRequest.Location = new System.Drawing.Point(982, 106);
            this.btnSendRequest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(251, 49);
            this.btnSendRequest.TabIndex = 5;
            this.btnSendRequest.Text = "Send Friend Request";
            this.btnSendRequest.UseVisualStyleBackColor = false;
            // 
            // tbFriend
            // 
            this.tbFriend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.tbFriend.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.tbFriend.ForeColor = System.Drawing.Color.White;
            this.tbFriend.Location = new System.Drawing.Point(27, 98);
            this.tbFriend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbFriend.Name = "tbFriend";
            this.tbFriend.PasswordChar = '\0';
            this.tbFriend.PlaceholderAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbFriend.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(82)))));
            this.tbFriend.PlaceholderEnabled = true;
            this.tbFriend.PlaceholderOffset = new System.Drawing.Point(10, -9);
            this.tbFriend.PlaceholderText = "Enter Username#0000";
            this.tbFriend.Size = new System.Drawing.Size(1218, 62);
            this.tbFriend.TabIndex = 6;
            this.tbFriend.TextBoxOffset = new System.Drawing.Point(10, 14);
            this.tbFriend.UseSystemPasswordChar = false;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // AddFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.btnSendRequest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbFriendAmount);
            this.Controls.Add(this.tbFriend);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddFriend";
            this.Size = new System.Drawing.Size(1289, 175);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFriendAmount;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnSendRequest;
        public SizeAblePlaceholderTextBox tbFriend;
        public System.Windows.Forms.ErrorProvider error;
    }
}
