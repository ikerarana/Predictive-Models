namespace UI.AdvancedUI.Controles_de_Usuario
{
    partial class CargarDatosUC
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
            this.tLPBase = new System.Windows.Forms.TableLayoutPanel();
            this.tLPSeleccionFuenteDatos = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCargarBD = new System.Windows.Forms.Button();
            this.buttonCargarFichero = new System.Windows.Forms.Button();
            this.buttonDatos = new System.Windows.Forms.Button();
            this.panelInsertarURL = new System.Windows.Forms.Panel();
            this.tLPBase.SuspendLayout();
            this.tLPSeleccionFuenteDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLPBase
            // 
            this.tLPBase.ColumnCount = 1;
            this.tLPBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPBase.Controls.Add(this.tLPSeleccionFuenteDatos, 0, 0);
            this.tLPBase.Controls.Add(this.panelInsertarURL, 0, 1);
            this.tLPBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPBase.Location = new System.Drawing.Point(0, 0);
            this.tLPBase.Name = "tLPBase";
            this.tLPBase.RowCount = 3;
            this.tLPBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tLPBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.52632F));
            this.tLPBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.28655F));
            this.tLPBase.Size = new System.Drawing.Size(1051, 684);
            this.tLPBase.TabIndex = 0;
            // 
            // tLPSeleccionFuenteDatos
            // 
            this.tLPSeleccionFuenteDatos.ColumnCount = 3;
            this.tLPSeleccionFuenteDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tLPSeleccionFuenteDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tLPSeleccionFuenteDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tLPSeleccionFuenteDatos.Controls.Add(this.buttonCargarBD, 0, 0);
            this.tLPSeleccionFuenteDatos.Controls.Add(this.buttonCargarFichero, 0, 0);
            this.tLPSeleccionFuenteDatos.Controls.Add(this.buttonDatos, 0, 0);
            this.tLPSeleccionFuenteDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPSeleccionFuenteDatos.Location = new System.Drawing.Point(20, 20);
            this.tLPSeleccionFuenteDatos.Margin = new System.Windows.Forms.Padding(20);
            this.tLPSeleccionFuenteDatos.Name = "tLPSeleccionFuenteDatos";
            this.tLPSeleccionFuenteDatos.RowCount = 1;
            this.tLPSeleccionFuenteDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPSeleccionFuenteDatos.Size = new System.Drawing.Size(1011, 187);
            this.tLPSeleccionFuenteDatos.TabIndex = 1;
            // 
            // buttonCargarBD
            // 
            this.buttonCargarBD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCargarBD.Enabled = false;
            this.buttonCargarBD.FlatAppearance.BorderSize = 0;
            this.buttonCargarBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCargarBD.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCargarBD.ForeColor = System.Drawing.Color.White;
            this.buttonCargarBD.Image = global::UI.Properties.Resources.database;
            this.buttonCargarBD.Location = new System.Drawing.Point(674, 0);
            this.buttonCargarBD.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCargarBD.Name = "buttonCargarBD";
            this.buttonCargarBD.Size = new System.Drawing.Size(337, 187);
            this.buttonCargarBD.TabIndex = 4;
            this.buttonCargarBD.Text = "Cargar de BD";
            this.buttonCargarBD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCargarBD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCargarBD.UseVisualStyleBackColor = true;
            this.buttonCargarBD.Click += new System.EventHandler(this.buttonCargarBD_Click);
            // 
            // buttonCargarFichero
            // 
            this.buttonCargarFichero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCargarFichero.FlatAppearance.BorderSize = 0;
            this.buttonCargarFichero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCargarFichero.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCargarFichero.ForeColor = System.Drawing.Color.White;
            this.buttonCargarFichero.Image = global::UI.Properties.Resources.file;
            this.buttonCargarFichero.Location = new System.Drawing.Point(337, 0);
            this.buttonCargarFichero.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCargarFichero.Name = "buttonCargarFichero";
            this.buttonCargarFichero.Size = new System.Drawing.Size(337, 187);
            this.buttonCargarFichero.TabIndex = 3;
            this.buttonCargarFichero.Text = "Cargar de Fichero";
            this.buttonCargarFichero.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCargarFichero.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCargarFichero.UseVisualStyleBackColor = true;
            this.buttonCargarFichero.Click += new System.EventHandler(this.buttonCargarFichero_Click);
            // 
            // buttonDatos
            // 
            this.buttonDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDatos.FlatAppearance.BorderSize = 0;
            this.buttonDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDatos.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDatos.ForeColor = System.Drawing.Color.White;
            this.buttonDatos.Image = global::UI.Properties.Resources.website;
            this.buttonDatos.Location = new System.Drawing.Point(0, 0);
            this.buttonDatos.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDatos.Name = "buttonDatos";
            this.buttonDatos.Size = new System.Drawing.Size(337, 187);
            this.buttonDatos.TabIndex = 2;
            this.buttonDatos.Text = "Descargar de URL";
            this.buttonDatos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDatos.UseVisualStyleBackColor = true;
            this.buttonDatos.Click += new System.EventHandler(this.buttonDatos_Click);
            // 
            // panelInsertarURL
            // 
            this.panelInsertarURL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInsertarURL.Location = new System.Drawing.Point(0, 227);
            this.panelInsertarURL.Margin = new System.Windows.Forms.Padding(0);
            this.panelInsertarURL.Name = "panelInsertarURL";
            this.panelInsertarURL.Size = new System.Drawing.Size(1051, 413);
            this.panelInsertarURL.TabIndex = 2;
            // 
            // CargarDatosUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.tLPBase);
            this.Name = "CargarDatosUC";
            this.Size = new System.Drawing.Size(1051, 684);
            this.tLPBase.ResumeLayout(false);
            this.tLPSeleccionFuenteDatos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLPBase;
        private System.Windows.Forms.TableLayoutPanel tLPSeleccionFuenteDatos;
        private System.Windows.Forms.Button buttonCargarBD;
        private System.Windows.Forms.Button buttonCargarFichero;
        private System.Windows.Forms.Button buttonDatos;
        private System.Windows.Forms.Panel panelInsertarURL;
    }
}
