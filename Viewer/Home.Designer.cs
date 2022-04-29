
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
            this.GroupTurno_Manha = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GrupoWellcome.SuspendLayout();
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
            this.GrupoWellcome.Controls.Add(this.ComboBox_Turno);
            this.GrupoWellcome.Controls.Add(this.label2);
            this.GrupoWellcome.Location = new System.Drawing.Point(12, 12);
            this.GrupoWellcome.Name = "GrupoWellcome";
            this.GrupoWellcome.Size = new System.Drawing.Size(1057, 163);
            this.GrupoWellcome.TabIndex = 5;
            this.GrupoWellcome.TabStop = false;
            this.GrupoWellcome.Text = "Bem vindo ao HBH";
            // 
            // GroupTurno_Manha
            // 
            this.GroupTurno_Manha.AutoSize = true;
            this.GroupTurno_Manha.Location = new System.Drawing.Point(12, 190);
            this.GroupTurno_Manha.Name = "GroupTurno_Manha";
            this.GroupTurno_Manha.Size = new System.Drawing.Size(1056, 616);
            this.GroupTurno_Manha.TabIndex = 6;
            this.GroupTurno_Manha.TabStop = false;
            this.GroupTurno_Manha.Text = "Turno - Manhã";
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
    }
}

