
namespace ChatServer
{
    partial class Message
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
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.roundPictureBox1 = new ChatServer.RoundPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.White;
            this.lbUserName.Location = new System.Drawing.Point(79, 4);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(103, 28);
            this.lbUserName.TabIndex = 4;
            this.lbUserName.Text = "UserName";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.lbDate.Location = new System.Drawing.Point(189, 14);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(80, 17);
            this.lbDate.TabIndex = 5;
            this.lbDate.Text = "01/01/2000";
            // 
            // tbMessage
            // 
            this.tbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.tbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMessage.ForeColor = System.Drawing.Color.White;
            this.tbMessage.Location = new System.Drawing.Point(84, 44);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ReadOnly = true;
            this.tbMessage.Size = new System.Drawing.Size(597, 19);
            this.tbMessage.TabIndex = 6;
            // 
            // roundPictureBox1
            // 
            this.roundPictureBox1.BackColor = System.Drawing.Color.White;
            this.roundPictureBox1.Location = new System.Drawing.Point(4, 4);
            this.roundPictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.roundPictureBox1.Name = "roundPictureBox1";
            this.roundPictureBox1.Size = new System.Drawing.Size(67, 62);
            this.roundPictureBox1.TabIndex = 3;
            this.roundPictureBox1.TabStop = false;
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.roundPictureBox1);
            this.Name = "Message";
            this.Size = new System.Drawing.Size(684, 75);
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUserName;
        private RoundPictureBox roundPictureBox1;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.TextBox tbMessage;
    }
}
