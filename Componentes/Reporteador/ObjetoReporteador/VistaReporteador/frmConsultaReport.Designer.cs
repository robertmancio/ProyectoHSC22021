﻿namespace VistaReporteador
{
    partial class frmConsultaReport
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
            this.abrir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // abrir
            // 
            this.abrir.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abrir.Location = new System.Drawing.Point(336, 161);
            this.abrir.Margin = new System.Windows.Forms.Padding(2);
            this.abrir.Name = "abrir";
            this.abrir.Size = new System.Drawing.Size(119, 63);
            this.abrir.TabIndex = 60;
            this.abrir.Text = "Ver Reporte";
            this.abrir.UseVisualStyleBackColor = true;
            this.abrir.Click += new System.EventHandler(this.abrir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 268);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(692, 163);
            this.dataGridView1.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Ruta:";
            // 
            // txtRuta
            // 
            this.txtRuta.Enabled = false;
            this.txtRuta.Location = new System.Drawing.Point(128, 91);
            this.txtRuta.Margin = new System.Windows.Forms.Padding(2);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(342, 20);
            this.txtRuta.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(344, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "Consulta Reportes";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(498, 86);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(97, 32);
            this.btnFiltrar.TabIndex = 61;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // frmConsultaReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.abrir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.label1);
            this.Name = "frmConsultaReport";
            this.Text = "frmConsultaReport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button abrir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrar;
    }
}