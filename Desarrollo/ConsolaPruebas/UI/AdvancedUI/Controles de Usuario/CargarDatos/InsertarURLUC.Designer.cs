namespace UI.AdvancedUI.Controles_de_Usuario.CargarDatos
{
    partial class InsertarURLUC
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tLPInsertar = new System.Windows.Forms.TableLayoutPanel();
            this.labelInsertarURL = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDescargar = new System.Windows.Forms.Button();
            this.tLPInsertar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLPInsertar
            // 
            this.tLPInsertar.ColumnCount = 1;
            this.tLPInsertar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPInsertar.Controls.Add(this.labelInsertarURL, 0, 0);
            this.tLPInsertar.Controls.Add(this.textBoxURL, 0, 1);
            this.tLPInsertar.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tLPInsertar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPInsertar.Location = new System.Drawing.Point(0, 0);
            this.tLPInsertar.Name = "tLPInsertar";
            this.tLPInsertar.RowCount = 3;
            this.tLPInsertar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.25806F));
            this.tLPInsertar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tLPInsertar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.74194F));
            this.tLPInsertar.Size = new System.Drawing.Size(958, 310);
            this.tLPInsertar.TabIndex = 0;
            // 
            // labelInsertarURL
            // 
            this.labelInsertarURL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInsertarURL.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInsertarURL.ForeColor = System.Drawing.Color.White;
            this.labelInsertarURL.Location = new System.Drawing.Point(3, 0);
            this.labelInsertarURL.Name = "labelInsertarURL";
            this.labelInsertarURL.Size = new System.Drawing.Size(952, 83);
            this.labelInsertarURL.TabIndex = 0;
            this.labelInsertarURL.Text = "\"\"";
            this.labelInsertarURL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxURL
            // 
            this.textBoxURL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxURL.Location = new System.Drawing.Point(42, 96);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(873, 26);
            this.textBoxURL.TabIndex = 1;
            this.textBoxURL.Text = "https://archive.ics.uci.edu/ml/datasets.php";
            this.textBoxURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.buttonDescargar, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 138);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.3787F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.6213F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(952, 169);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // buttonDescargar
            // 
            this.buttonDescargar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDescargar.FlatAppearance.BorderSize = 0;
            this.buttonDescargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDescargar.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDescargar.ForeColor = System.Drawing.Color.White;
            this.buttonDescargar.Location = new System.Drawing.Point(320, 3);
            this.buttonDescargar.Name = "buttonDescargar";
            this.buttonDescargar.Size = new System.Drawing.Size(311, 69);
            this.buttonDescargar.TabIndex = 0;
            this.buttonDescargar.Text = "\"\"";
            this.buttonDescargar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDescargar.UseVisualStyleBackColor = true;
            this.buttonDescargar.Click += new System.EventHandler(this.buttonDescargar_Click);
            // 
            // InsertarURLUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.tLPInsertar);
            this.Name = "InsertarURLUC";
            this.Size = new System.Drawing.Size(958, 310);
            this.tLPInsertar.ResumeLayout(false);
            this.tLPInsertar.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLPInsertar;
        private System.Windows.Forms.Label labelInsertarURL;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonDescargar;
    }
}
