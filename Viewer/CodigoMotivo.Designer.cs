
namespace Marelli___Hour_by_Hour.Viewer
{
    partial class CodigoMotivo
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
            this.DataGridMotivos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMotivos)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridMotivos
            // 
            this.DataGridMotivos.AllowUserToAddRows = false;
            this.DataGridMotivos.AllowUserToDeleteRows = false;
            this.DataGridMotivos.BackgroundColor = System.Drawing.Color.White;
            this.DataGridMotivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridMotivos.Location = new System.Drawing.Point(1, -1);
            this.DataGridMotivos.Name = "DataGridMotivos";
            this.DataGridMotivos.ReadOnly = true;
            this.DataGridMotivos.RowTemplate.Height = 25;
            this.DataGridMotivos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridMotivos.Size = new System.Drawing.Size(886, 526);
            this.DataGridMotivos.TabIndex = 0;
            // 
            // CodigoMotivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 537);
            this.Controls.Add(this.DataGridMotivos);
            this.Name = "CodigoMotivo";
            this.Text = "CodigoMotivo";
            this.Load += new System.EventHandler(this.CodigoMotivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMotivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridMotivos;
    }
}