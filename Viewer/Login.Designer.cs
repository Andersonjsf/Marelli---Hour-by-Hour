
namespace Marelli___Hour_by_Hour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Lb_UserID = new System.Windows.Forms.Label();
            this.Lb_Password = new System.Windows.Forms.Label();
            this.Button_Login = new System.Windows.Forms.Button();
            this.TxtBox_UserID = new System.Windows.Forms.TextBox();
            this.TxtBox_Password = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lb_UserID
            // 
            this.Lb_UserID.AutoSize = true;
            this.Lb_UserID.Location = new System.Drawing.Point(110, 172);
            this.Lb_UserID.Name = "Lb_UserID";
            this.Lb_UserID.Size = new System.Drawing.Size(44, 15);
            this.Lb_UserID.TabIndex = 0;
            this.Lb_UserID.Text = "User ID";
            // 
            // Lb_Password
            // 
            this.Lb_Password.AutoSize = true;
            this.Lb_Password.Location = new System.Drawing.Point(104, 240);
            this.Lb_Password.Name = "Lb_Password";
            this.Lb_Password.Size = new System.Drawing.Size(57, 15);
            this.Lb_Password.TabIndex = 1;
            this.Lb_Password.Text = "Password";
            // 
            // Button_Login
            // 
            this.Button_Login.Location = new System.Drawing.Point(72, 331);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(121, 23);
            this.Button_Login.TabIndex = 3;
            this.Button_Login.Text = "Conectar";
            this.Button_Login.UseVisualStyleBackColor = true;
            // 
            // TxtBox_UserID
            // 
            this.TxtBox_UserID.Location = new System.Drawing.Point(58, 203);
            this.TxtBox_UserID.Name = "TxtBox_UserID";
            this.TxtBox_UserID.PlaceholderText = "Digite sua matricula";
            this.TxtBox_UserID.Size = new System.Drawing.Size(146, 23);
            this.TxtBox_UserID.TabIndex = 1;
            // 
            // TxtBox_Password
            // 
            this.TxtBox_Password.Location = new System.Drawing.Point(58, 275);
            this.TxtBox_Password.Name = "TxtBox_Password";
            this.TxtBox_Password.PasswordChar = '*';
            this.TxtBox_Password.PlaceholderText = "Digite sua senha";
            this.TxtBox_Password.Size = new System.Drawing.Size(146, 23);
            this.TxtBox_Password.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(260, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtBox_Password);
            this.Controls.Add(this.TxtBox_UserID);
            this.Controls.Add(this.Button_Login);
            this.Controls.Add(this.Lb_Password);
            this.Controls.Add(this.Lb_UserID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_UserID;
        private System.Windows.Forms.Label Lb_Password;
        private System.Windows.Forms.Button Button_Login;
        private System.Windows.Forms.TextBox TxtBox_UserID;
        private System.Windows.Forms.TextBox TxtBox_Password;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}