namespace SugarStock
{
    partial class Forms
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
            this.LblUser = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblUser
            // 
            this.LblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.LblUser.Location = new System.Drawing.Point(191, 9);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(175, 48);
            this.LblUser.TabIndex = 0;
            this.LblUser.Text = "LOGIN IN";
            this.LblUser.Click += new System.EventHandler(this.LblUser_Click);
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.LblUsername.Location = new System.Drawing.Point(32, 74);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(113, 26);
            this.LblUsername.TabIndex = 1;
            this.LblUsername.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(32, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(184, 80);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(182, 20);
            this.TxtUser.TabIndex = 3;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(184, 165);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(182, 20);
            this.TxtPassword.TabIndex = 4;
            // 
            // BtnCreate
            // 
            this.BtnCreate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCreate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnCreate.Location = new System.Drawing.Point(236, 250);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(95, 41);
            this.BtnCreate.TabIndex = 5;
            this.BtnCreate.Text = "Start";
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            this.BtnCreate.MouseLeave += new System.EventHandler(this.BtnCreate_MouseLeave);
            this.BtnCreate.MouseHover += new System.EventHandler(this.BtnCreate_MouseHover);
            // 
            // Forms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblUsername);
            this.Controls.Add(this.LblUser);
            this.Name = "Forms";
            this.Text = "User";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnCreate;
    }
}

