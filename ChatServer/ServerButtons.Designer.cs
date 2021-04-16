
namespace ChatServer
{
    partial class ServerButtons
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
            this.roundPictureBox2 = new ChatServer.RoundPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // roundPictureBox2
            // 
            this.roundPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.roundPictureBox2.Location = new System.Drawing.Point(10, 0);
            this.roundPictureBox2.Name = "roundPictureBox2";
            this.roundPictureBox2.Size = new System.Drawing.Size(80, 80);
            this.roundPictureBox2.TabIndex = 2;
            this.roundPictureBox2.TabStop = false;
            // 
            // ServerButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.roundPictureBox2);
            this.Name = "ServerButtons";
            this.Size = new System.Drawing.Size(90, 80);
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundPictureBox roundPictureBox2;
    }
}
