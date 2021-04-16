
namespace ChatServer
{
    partial class FriendListMenu
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
            this.lbFriends = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbOnline = new System.Windows.Forms.Label();
            this.lbAll = new System.Windows.Forms.Label();
            this.lbPending = new System.Windows.Forms.Label();
            this.lbBlocked = new System.Windows.Forms.Label();
            this.btnAddFriends = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbFriends
            // 
            this.lbFriends.AutoSize = true;
            this.lbFriends.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFriends.ForeColor = System.Drawing.Color.White;
            this.lbFriends.Location = new System.Drawing.Point(40, 4);
            this.lbFriends.Name = "lbFriends";
            this.lbFriends.Size = new System.Drawing.Size(102, 37);
            this.lbFriends.TabIndex = 0;
            this.lbFriends.Text = "Friends";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(140, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 30);
            this.panel1.TabIndex = 1;
            // 
            // lbOnline
            // 
            this.lbOnline.AutoSize = true;
            this.lbOnline.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOnline.ForeColor = System.Drawing.Color.Silver;
            this.lbOnline.Location = new System.Drawing.Point(150, 10);
            this.lbOnline.Name = "lbOnline";
            this.lbOnline.Size = new System.Drawing.Size(74, 30);
            this.lbOnline.TabIndex = 2;
            this.lbOnline.Text = "Online";
            // 
            // lbAll
            // 
            this.lbAll.AutoSize = true;
            this.lbAll.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAll.ForeColor = System.Drawing.Color.Silver;
            this.lbAll.Location = new System.Drawing.Point(230, 10);
            this.lbAll.Name = "lbAll";
            this.lbAll.Size = new System.Drawing.Size(37, 30);
            this.lbAll.TabIndex = 3;
            this.lbAll.Text = "All";
            // 
            // lbPending
            // 
            this.lbPending.AutoSize = true;
            this.lbPending.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPending.ForeColor = System.Drawing.Color.Silver;
            this.lbPending.Location = new System.Drawing.Point(273, 10);
            this.lbPending.Name = "lbPending";
            this.lbPending.Size = new System.Drawing.Size(88, 30);
            this.lbPending.TabIndex = 4;
            this.lbPending.Text = "Pending";
            // 
            // lbBlocked
            // 
            this.lbBlocked.AutoSize = true;
            this.lbBlocked.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBlocked.ForeColor = System.Drawing.Color.Silver;
            this.lbBlocked.Location = new System.Drawing.Point(367, 10);
            this.lbBlocked.Name = "lbBlocked";
            this.lbBlocked.Size = new System.Drawing.Size(85, 30);
            this.lbBlocked.TabIndex = 5;
            this.lbBlocked.Text = "Blocked";
            // 
            // btnAddFriends
            // 
            this.btnAddFriends.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.btnAddFriends.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.btnAddFriends.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.btnAddFriends.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.btnAddFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFriends.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFriends.ForeColor = System.Drawing.Color.White;
            this.btnAddFriends.Location = new System.Drawing.Point(458, 8);
            this.btnAddFriends.Name = "btnAddFriends";
            this.btnAddFriends.Size = new System.Drawing.Size(125, 34);
            this.btnAddFriends.TabIndex = 7;
            this.btnAddFriends.Text = "Add Friend";
            this.btnAddFriends.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddFriends.UseVisualStyleBackColor = false;
            // 
            // FriendListMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.btnAddFriends);
            this.Controls.Add(this.lbBlocked);
            this.Controls.Add(this.lbPending);
            this.Controls.Add(this.lbAll);
            this.Controls.Add(this.lbOnline);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbFriends);
            this.Name = "FriendListMenu";
            this.Size = new System.Drawing.Size(1520, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFriends;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbOnline;
        private System.Windows.Forms.Label lbAll;
        private System.Windows.Forms.Label lbPending;
        private System.Windows.Forms.Label lbBlocked;
        private System.Windows.Forms.Button btnAddFriends;
    }
}
