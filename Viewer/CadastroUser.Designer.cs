﻿
namespace Marelli___Hour_by_Hour.Viewer
{
    partial class CadastroUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroUser));
            this.Button_Cancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtBox_Password = new System.Windows.Forms.TextBox();
            this.TxtBox_UserID = new System.Windows.Forms.TextBox();
            this.Button_Cad = new System.Windows.Forms.Button();
            this.Lb_Password = new System.Windows.Forms.Label();
            this.Lb_UserID = new System.Windows.Forms.Label();
            this.TxtBox_Turno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBox_Funcao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Cancelar
            // 
            this.Button_Cancelar.BackColor = System.Drawing.Color.Transparent;
            this.Button_Cancelar.Location = new System.Drawing.Point(137, 390);
            this.Button_Cancelar.Name = "Button_Cancelar";
            this.Button_Cancelar.Size = new System.Drawing.Size(65, 23);
            this.Button_Cancelar.TabIndex = 11;
            this.Button_Cancelar.Text = "Cancelar";
            this.Button_Cancelar.UseVisualStyleBackColor = false;
            this.Button_Cancelar.Click += new System.EventHandler(this.Button_Cancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // TxtBox_Password
            // 
            this.TxtBox_Password.Location = new System.Drawing.Point(56, 210);
            this.TxtBox_Password.Name = "TxtBox_Password";
            this.TxtBox_Password.PasswordChar = '*';
            this.TxtBox_Password.PlaceholderText = " ";
            this.TxtBox_Password.Size = new System.Drawing.Size(146, 23);
            this.TxtBox_Password.TabIndex = 9;
            // 
            // TxtBox_UserID
            // 
            this.TxtBox_UserID.Location = new System.Drawing.Point(56, 163);
            this.TxtBox_UserID.Name = "TxtBox_UserID";
            this.TxtBox_UserID.PlaceholderText = " ";
            this.TxtBox_UserID.Size = new System.Drawing.Size(146, 23);
            this.TxtBox_UserID.TabIndex = 7;
            // 
            // Button_Cad
            // 
            this.Button_Cad.BackColor = System.Drawing.Color.Transparent;
            this.Button_Cad.ForeColor = System.Drawing.Color.Black;
            this.Button_Cad.Location = new System.Drawing.Point(56, 390);
            this.Button_Cad.Name = "Button_Cad";
            this.Button_Cad.Size = new System.Drawing.Size(65, 23);
            this.Button_Cad.TabIndex = 10;
            this.Button_Cad.Text = "Cadastrar";
            this.Button_Cad.UseVisualStyleBackColor = false;
            this.Button_Cad.Click += new System.EventHandler(this.Button_Cad_Click);
            // 
            // Lb_Password
            // 
            this.Lb_Password.AutoSize = true;
            this.Lb_Password.Location = new System.Drawing.Point(56, 192);
            this.Lb_Password.Name = "Lb_Password";
            this.Lb_Password.Size = new System.Drawing.Size(57, 15);
            this.Lb_Password.TabIndex = 8;
            this.Lb_Password.Text = "Password";
            // 
            // Lb_UserID
            // 
            this.Lb_UserID.AutoSize = true;
            this.Lb_UserID.Location = new System.Drawing.Point(56, 145);
            this.Lb_UserID.Name = "Lb_UserID";
            this.Lb_UserID.Size = new System.Drawing.Size(44, 15);
            this.Lb_UserID.TabIndex = 6;
            this.Lb_UserID.Text = "User ID";
            // 
            // TxtBox_Turno
            // 
            this.TxtBox_Turno.Location = new System.Drawing.Point(56, 259);
            this.TxtBox_Turno.Name = "TxtBox_Turno";
            this.TxtBox_Turno.PlaceholderText = " ";
            this.TxtBox_Turno.Size = new System.Drawing.Size(146, 23);
            this.TxtBox_Turno.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Turno";
            // 
            // TxtBox_Funcao
            // 
            this.TxtBox_Funcao.Location = new System.Drawing.Point(56, 310);
            this.TxtBox_Funcao.Name = "TxtBox_Funcao";
            this.TxtBox_Funcao.PlaceholderText = " ";
            this.TxtBox_Funcao.Size = new System.Drawing.Size(146, 23);
            this.TxtBox_Funcao.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Funçao";
            // 
            // CadastroUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(264, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBox_Funcao);
            this.Controls.Add(this.TxtBox_Turno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Cancelar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtBox_Password);
            this.Controls.Add(this.TxtBox_UserID);
            this.Controls.Add(this.Button_Cad);
            this.Controls.Add(this.Lb_Password);
            this.Controls.Add(this.Lb_UserID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroUser";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Cancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtBox_Password;
        private System.Windows.Forms.TextBox TxtBox_UserID;
        private System.Windows.Forms.Button Button_Cad;
        private System.Windows.Forms.Label Lb_Password;
        private System.Windows.Forms.Label Lb_UserID;
        private System.Windows.Forms.TextBox TxtBox_Turno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBox_Funcao;
        private System.Windows.Forms.Label label2;
    }
}