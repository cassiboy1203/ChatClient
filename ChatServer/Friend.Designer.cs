
namespace ChatServer
{
    partial class Friend
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
            this.lbFriendStatusText = new System.Windows.Forms.Label();
            this.lbFriendName = new System.Windows.Forms.Label();
            this.pbFriendImage = new ChatServer.RoundPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbStatus = new ChatServer.RoundPictureBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFriendImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFriendStatusText
            // 
            this.lbFriendStatusText.AutoSize = true;
            this.lbFriendStatusText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFriendStatusText.ForeColor = System.Drawing.Color.Silver;
            this.lbFriendStatusText.Location = new System.Drawing.Point(87, 53);
            this.lbFriendStatusText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFriendStatusText.Name = "lbFriendStatusText";
            this.lbFriendStatusText.Size = new System.Drawing.Size(69, 28);
            this.lbFriendStatusText.TabIndex = 6;
            this.lbFriendStatusText.Text = "Online";
            // 
            // lbFriendName
            // 
            this.lbFriendName.AutoSize = true;
            this.lbFriendName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFriendName.ForeColor = System.Drawing.Color.White;
            this.lbFriendName.Location = new System.Drawing.Point(87, 27);
            this.lbFriendName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFriendName.Name = "lbFriendName";
            this.lbFriendName.Size = new System.Drawing.Size(71, 28);
            this.lbFriendName.TabIndex = 5;
            this.lbFriendName.Text = "Friend";
            // 
            // pbFriendImage
            // 
            this.pbFriendImage.BackColor = System.Drawing.Color.White;
            this.pbFriendImage.Location = new System.Drawing.Point(13, 21);
            this.pbFriendImage.Margin = new System.Windows.Forms.Padding(4);
            this.pbFriendImage.Name = "pbFriendImage";
            this.pbFriendImage.Size = new System.Drawing.Size(67, 62);
            this.pbFriendImage.TabIndex = 4;
            this.pbFriendImage.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(29, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 1);
            this.panel1.TabIndex = 7;
            // 
            // pbStatus
            // 
            this.pbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.pbStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbStatus.Location = new System.Drawing.Point(63, 68);
            this.pbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(13, 12);
            this.pbStatus.TabIndex = 8;
            this.pbStatus.TabStop = false;
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Location = new System.Drawing.Point(410, 27);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(61, 41);
            this.btnAccept.TabIndex = 9;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // btnReject
            // 
            this.btnReject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReject.Location = new System.Drawing.Point(343, 27);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(61, 41);
            this.btnReject.TabIndex = 10;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.BtnReject_Click);
            // 
            // Friend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.pbStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbFriendStatusText);
            this.Controls.Add(this.lbFriendName);
            this.Controls.Add(this.pbFriendImage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Friend";
            this.Size = new System.Drawing.Size(492, 98);
            ((System.ComponentModel.ISupportInitialize)(this.pbFriendImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFriendStatusText;
        private System.Windows.Forms.Label lbFriendName;
        private RoundPictureBox pbFriendImage;
        private System.Windows.Forms.Panel panel1;
        private RoundPictureBox pbStatus;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnReject;
    }
}
