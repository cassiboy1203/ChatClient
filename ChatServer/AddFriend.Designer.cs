
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
            this.lbFriendAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.noAutoSizeTextBox1 = new ChatServer.SizeAblePlaceholderTextBox();
            this.SuspendLayout();
            // 
            // lbFriendAmount
            // 
            this.lbFriendAmount.AutoSize = true;
            this.lbFriendAmount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFriendAmount.ForeColor = System.Drawing.Color.White;
            this.lbFriendAmount.Location = new System.Drawing.Point(15, 18);
            this.lbFriendAmount.Name = "lbFriendAmount";
            this.lbFriendAmount.Size = new System.Drawing.Size(150, 32);
            this.lbFriendAmount.TabIndex = 1;
            this.lbFriendAmount.Text = "ADD FRIEND";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(15, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "You can add a friend with their FriendCode";
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnSendRequest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnSendRequest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(106)))), ((int)(((byte)(170)))));
            this.btnSendRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnSendRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendRequest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendRequest.ForeColor = System.Drawing.Color.White;
            this.btnSendRequest.Location = new System.Drawing.Point(1290, 86);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(188, 40);
            this.btnSendRequest.TabIndex = 5;
            this.btnSendRequest.Text = "Send Friend Request";
            this.btnSendRequest.UseVisualStyleBackColor = false;
            // 
            // noAutoSizeTextBox1
            // 
            this.noAutoSizeTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.noAutoSizeTextBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.noAutoSizeTextBox1.ForeColor = System.Drawing.Color.White;
            this.noAutoSizeTextBox1.Location = new System.Drawing.Point(20, 80);
            this.noAutoSizeTextBox1.Name = "noAutoSizeTextBox1";
            this.noAutoSizeTextBox1.PlaceholderAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.noAutoSizeTextBox1.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(82)))));
            this.noAutoSizeTextBox1.PlaceholderEnabled = true;
            this.noAutoSizeTextBox1.PlaceholderOffset = new System.Drawing.Point(10, 0);
            this.noAutoSizeTextBox1.PlaceholderText = "Enter a #FriendCode";
            this.noAutoSizeTextBox1.Size = new System.Drawing.Size(1467, 50);
            this.noAutoSizeTextBox1.TabIndex = 6;
            this.noAutoSizeTextBox1.TextBoxOffset = new System.Drawing.Point(10, 11);
            // 
            // AddFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.btnSendRequest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbFriendAmount);
            this.Controls.Add(this.noAutoSizeTextBox1);
            this.Name = "AddFriend";
            this.Size = new System.Drawing.Size(1520, 142);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFriendAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSendRequest;
        private SizeAblePlaceholderTextBox noAutoSizeTextBox1;
    }
}
