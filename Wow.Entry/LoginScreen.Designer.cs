namespace Wow.Entry
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblHata = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.BurlyWood;
            this.label1.Location = new System.Drawing.Point(321, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.BurlyWood;
            this.label2.Location = new System.Drawing.Point(332, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 51);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(546, 300);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(153, 22);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.Location = new System.Drawing.Point(546, 246);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(153, 22);
            this.txtUserName.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnLogin.Location = new System.Drawing.Point(502, 368);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(233, 76);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOGİN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnEnterHorde_Click);
            // 
            // lblHata
            // 
            this.lblHata.BackColor = System.Drawing.Color.Transparent;
            this.lblHata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHata.ForeColor = System.Drawing.Color.DarkRed;
            this.lblHata.Location = new System.Drawing.Point(475, 158);
            this.lblHata.Name = "lblHata";
            this.lblHata.Size = new System.Drawing.Size(468, 29);
            this.lblHata.TabIndex = 4;
            this.lblHata.Text = "username or password is wrong";
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1353, 583);
            this.Controls.Add(this.lblHata);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginScreen";
            this.Text = "LoginScreen";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblHata;
    }
}