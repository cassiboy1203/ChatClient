
namespace ChatServer
{
    partial class Login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoginRequest = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.FormBorder = new System.Windows.Forms.Panel();
            this.tbPassword = new ChatServer.SizeAblePlaceholderTextBox();
            this.tbEmail = new ChatServer.SizeAblePlaceholderTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.FormBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(257, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // btnLoginRequest
            // 
            this.btnLoginRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnLoginRequest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnLoginRequest.FlatAppearance.BorderSize = 0;
            this.btnLoginRequest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(106)))), ((int)(((byte)(170)))));
            this.btnLoginRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnLoginRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginRequest.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginRequest.ForeColor = System.Drawing.Color.White;
            this.btnLoginRequest.Location = new System.Drawing.Point(252, 286);
            this.btnLoginRequest.Name = "btnLoginRequest";
            this.btnLoginRequest.Size = new System.Drawing.Size(188, 40);
            this.btnLoginRequest.TabIndex = 6;
            this.btnLoginRequest.Text = "Login";
            this.btnLoginRequest.UseVisualStyleBackColor = false;
            this.btnLoginRequest.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(668, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(22, 20);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FormBorder
            // 
            this.FormBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.FormBorder.Controls.Add(this.btnExit);
            this.FormBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormBorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.FormBorder.Location = new System.Drawing.Point(0, 0);
            this.FormBorder.Name = "FormBorder";
            this.FormBorder.Size = new System.Drawing.Size(690, 20);
            this.FormBorder.TabIndex = 7;
            this.FormBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.FormBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.FormBorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Login_MouseUp);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.White;
            this.tbPassword.Location = new System.Drawing.Point(77, 198);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PlaceholderAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbPassword.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(82)))));
            this.tbPassword.PlaceholderEnabled = true;
            this.tbPassword.PlaceholderOffset = new System.Drawing.Point(10, 0);
            this.tbPassword.PlaceholderText = "Password";
            this.tbPassword.Size = new System.Drawing.Size(512, 50);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.TabStop = true;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.White;
            this.tbEmail.Location = new System.Drawing.Point(77, 108);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PlaceholderAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbEmail.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(82)))));
            this.tbEmail.PlaceholderEnabled = true;
            this.tbEmail.PlaceholderOffset = new System.Drawing.Point(10, 0);
            this.tbEmail.PlaceholderText = "Email";
            this.tbEmail.Size = new System.Drawing.Size(512, 50);
            this.tbEmail.TabIndex = 1;
            this.tbEmail.TabStop = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(690, 380);
            this.Controls.Add(this.FormBorder);
            this.Controls.Add(this.btnLoginRequest);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.ShowInTaskbar = false;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.FormBorder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private SizeAblePlaceholderTextBox tbEmail;
        private SizeAblePlaceholderTextBox tbPassword;
        private System.Windows.Forms.Button btnLoginRequest;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Panel FormBorder;
        private System.Windows.Forms.Button btnExit;
    }
}