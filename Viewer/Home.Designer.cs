
namespace Marelli___Hour_by_Hour
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lb_user = new System.Windows.Forms.Label();
            this.ComboBox_Turno = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GrupoWellcome = new System.Windows.Forms.GroupBox();
            this.Lb_DateToday = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.GroupTurno_Manha = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GrupoWellcome.SuspendLayout();
            this.GroupTurno_Manha.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(729, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(774, 816);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1165, 791);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Todos os direitos reservados Marelli";
            // 
            // Lb_user
            // 
            this.Lb_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_user.AutoSize = true;
            this.Lb_user.Location = new System.Drawing.Point(1364, 791);
            this.Lb_user.Name = "Lb_user";
            this.Lb_user.Size = new System.Drawing.Size(102, 15);
            this.Lb_user.TabIndex = 2;
            this.Lb_user.Text = "-     Desconectado";
            // 
            // ComboBox_Turno
            // 
            this.ComboBox_Turno.FormattingEnabled = true;
            this.ComboBox_Turno.Items.AddRange(new object[] {
            "Manhã",
            "Tarde",
            "Noite"});
            this.ComboBox_Turno.Location = new System.Drawing.Point(147, 52);
            this.ComboBox_Turno.Name = "ComboBox_Turno";
            this.ComboBox_Turno.Size = new System.Drawing.Size(147, 23);
            this.ComboBox_Turno.TabIndex = 3;
            this.ComboBox_Turno.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Turno_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecione o turno";
            // 
            // GrupoWellcome
            // 
            this.GrupoWellcome.AutoSize = true;
            this.GrupoWellcome.Controls.Add(this.Lb_DateToday);
            this.GrupoWellcome.Controls.Add(this.label23);
            this.GrupoWellcome.Controls.Add(this.ComboBox_Turno);
            this.GrupoWellcome.Controls.Add(this.label2);
            this.GrupoWellcome.Location = new System.Drawing.Point(12, 12);
            this.GrupoWellcome.Name = "GrupoWellcome";
            this.GrupoWellcome.Size = new System.Drawing.Size(1057, 163);
            this.GrupoWellcome.TabIndex = 5;
            this.GrupoWellcome.TabStop = false;
            this.GrupoWellcome.Text = "Bem vindo ao HBH";
            // 
            // Lb_DateToday
            // 
            this.Lb_DateToday.AutoSize = true;
            this.Lb_DateToday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lb_DateToday.Location = new System.Drawing.Point(99, 93);
            this.Lb_DateToday.Name = "Lb_DateToday";
            this.Lb_DateToday.Size = new System.Drawing.Size(94, 21);
            this.Lb_DateToday.TabIndex = 6;
            this.Lb_DateToday.Text = "00/00/0000";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(10, 93);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(83, 21);
            this.label23.TabIndex = 5;
            this.label23.Text = "Data atual:";
            // 
            // GroupTurno_Manha
            // 
            this.GroupTurno_Manha.AutoSize = true;
            this.GroupTurno_Manha.Controls.Add(this.label22);
            this.GroupTurno_Manha.Controls.Add(this.label21);
            this.GroupTurno_Manha.Controls.Add(this.label20);
            this.GroupTurno_Manha.Controls.Add(this.label19);
            this.GroupTurno_Manha.Controls.Add(this.label26);
            this.GroupTurno_Manha.Controls.Add(this.label11);
            this.GroupTurno_Manha.Controls.Add(this.label12);
            this.GroupTurno_Manha.Controls.Add(this.label13);
            this.GroupTurno_Manha.Controls.Add(this.label14);
            this.GroupTurno_Manha.Controls.Add(this.label15);
            this.GroupTurno_Manha.Controls.Add(this.label16);
            this.GroupTurno_Manha.Controls.Add(this.label17);
            this.GroupTurno_Manha.Controls.Add(this.label18);
            this.GroupTurno_Manha.Controls.Add(this.label10);
            this.GroupTurno_Manha.Controls.Add(this.label9);
            this.GroupTurno_Manha.Controls.Add(this.label8);
            this.GroupTurno_Manha.Controls.Add(this.label7);
            this.GroupTurno_Manha.Controls.Add(this.label6);
            this.GroupTurno_Manha.Controls.Add(this.label5);
            this.GroupTurno_Manha.Controls.Add(this.label4);
            this.GroupTurno_Manha.Controls.Add(this.label3);
            this.GroupTurno_Manha.Location = new System.Drawing.Point(12, 190);
            this.GroupTurno_Manha.Name = "GroupTurno_Manha";
            this.GroupTurno_Manha.Size = new System.Drawing.Size(1056, 616);
            this.GroupTurno_Manha.TabIndex = 6;
            this.GroupTurno_Manha.TabStop = false;
            this.GroupTurno_Manha.Text = "Turno - Manhã";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(860, 56);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(43, 15);
            this.label22.TabIndex = 20;
            this.label22.Text = "Tempo";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(727, 56);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(78, 15);
            this.label21.TabIndex = 19;
            this.label21.Text = "Equipamento";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(606, 56);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 15);
            this.label20.TabIndex = 18;
            this.label20.Text = "Retrabalho";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(494, 56);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 15);
            this.label19.TabIndex = 17;
            this.label19.Text = "Produção";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(279, 56);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(163, 15);
            this.label26.TabIndex = 16;
            this.label26.Text = "Código - Descrição da parada";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(130, 481);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "Horario Fim";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(130, 412);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 15);
            this.label12.TabIndex = 14;
            this.label12.Text = "Horario Fim";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(130, 344);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 15);
            this.label13.TabIndex = 13;
            this.label13.Text = "Horario Fim";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(130, 285);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 15);
            this.label14.TabIndex = 12;
            this.label14.Text = "Horario Fim";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(130, 226);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 15);
            this.label15.TabIndex = 11;
            this.label15.Text = "Horario Fim";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(130, 168);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 15);
            this.label16.TabIndex = 10;
            this.label16.Text = "Horario Fim";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(130, 111);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 15);
            this.label17.TabIndex = 9;
            this.label17.Text = "Horario Fim";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(130, 56);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 15);
            this.label18.TabIndex = 8;
            this.label18.Text = "Horario Fim";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 481);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "Horario Inicio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 412);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Horario Inicio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Horario Inicio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Horario Inicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Horario Inicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Horario Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Horario Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Horario Inicio";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1503, 816);
            this.Controls.Add(this.GroupTurno_Manha);
            this.Controls.Add(this.GrupoWellcome);
            this.Controls.Add(this.Lb_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HBH - Hour by Hour";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GrupoWellcome.ResumeLayout(false);
            this.GrupoWellcome.PerformLayout();
            this.GroupTurno_Manha.ResumeLayout(false);
            this.GroupTurno_Manha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label Lb_user;
        private System.Windows.Forms.ComboBox ComboBox_Turno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GrupoWellcome;
        private System.Windows.Forms.GroupBox GroupTurno_Manha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label Lb_DateToday;
        private System.Windows.Forms.Label label23;
    }
}

