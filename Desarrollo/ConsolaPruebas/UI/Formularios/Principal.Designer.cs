namespace UI.Formularios
{
    partial class Principal
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
            this.tLP_1 = new System.Windows.Forms.TableLayoutPanel();
            this.tLP_PintarDatos = new System.Windows.Forms.TableLayoutPanel();
            this.tLP_Empezar = new System.Windows.Forms.TableLayoutPanel();
            this.tLP_CargarDatos = new System.Windows.Forms.TableLayoutPanel();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tLP_Progreso = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labProgeso = new System.Windows.Forms.Label();
            this.tLP_1.SuspendLayout();
            this.tLP_PintarDatos.SuspendLayout();
            this.tLP_Empezar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tLP_Progreso.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLP_1
            // 
            this.tLP_1.ColumnCount = 1;
            this.tLP_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLP_1.Controls.Add(this.tLP_PintarDatos, 0, 1);
            this.tLP_1.Controls.Add(this.tLP_CargarDatos, 0, 0);
            this.tLP_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_1.Location = new System.Drawing.Point(0, 0);
            this.tLP_1.Name = "tLP_1";
            this.tLP_1.RowCount = 2;
            this.tLP_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.66003F));
            this.tLP_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.33997F));
            this.tLP_1.Size = new System.Drawing.Size(1165, 675);
            this.tLP_1.TabIndex = 0;
            // 
            // tLP_PintarDatos
            // 
            this.tLP_PintarDatos.ColumnCount = 1;
            this.tLP_PintarDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.93874F));
            this.tLP_PintarDatos.Controls.Add(this.tLP_Empezar, 0, 1);
            this.tLP_PintarDatos.Controls.Add(this.dataGridView1, 0, 0);
            this.tLP_PintarDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_PintarDatos.Location = new System.Drawing.Point(3, 236);
            this.tLP_PintarDatos.Name = "tLP_PintarDatos";
            this.tLP_PintarDatos.RowCount = 2;
            this.tLP_PintarDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.8866F));
            this.tLP_PintarDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.1134F));
            this.tLP_PintarDatos.Size = new System.Drawing.Size(1159, 436);
            this.tLP_PintarDatos.TabIndex = 0;
            // 
            // tLP_Empezar
            // 
            this.tLP_Empezar.ColumnCount = 2;
            this.tLP_Empezar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.11275F));
            this.tLP_Empezar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.887251F));
            this.tLP_Empezar.Controls.Add(this.buttonIniciar, 1, 0);
            this.tLP_Empezar.Controls.Add(this.tLP_Progreso, 0, 0);
            this.tLP_Empezar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_Empezar.Location = new System.Drawing.Point(3, 386);
            this.tLP_Empezar.Name = "tLP_Empezar";
            this.tLP_Empezar.RowCount = 1;
            this.tLP_Empezar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLP_Empezar.Size = new System.Drawing.Size(1153, 47);
            this.tLP_Empezar.TabIndex = 0;
            // 
            // tLP_CargarDatos
            // 
            this.tLP_CargarDatos.ColumnCount = 2;
            this.tLP_CargarDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLP_CargarDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLP_CargarDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_CargarDatos.Location = new System.Drawing.Point(3, 3);
            this.tLP_CargarDatos.Name = "tLP_CargarDatos";
            this.tLP_CargarDatos.RowCount = 2;
            this.tLP_CargarDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLP_CargarDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLP_CargarDatos.Size = new System.Drawing.Size(1159, 227);
            this.tLP_CargarDatos.TabIndex = 1;
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonIniciar.Enabled = false;
            this.buttonIniciar.Location = new System.Drawing.Point(1041, 3);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(109, 41);
            this.buttonIniciar.TabIndex = 0;
            this.buttonIniciar.Text = "Iniciar";
            this.buttonIniciar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1153, 377);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tLP_Progreso
            // 
            this.tLP_Progreso.ColumnCount = 3;
            this.tLP_Progreso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.34884F));
            this.tLP_Progreso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.65116F));
            this.tLP_Progreso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 601F));
            this.tLP_Progreso.Controls.Add(this.progressBar, 0, 1);
            this.tLP_Progreso.Controls.Add(this.labProgeso, 1, 1);
            this.tLP_Progreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_Progreso.Location = new System.Drawing.Point(3, 3);
            this.tLP_Progreso.Name = "tLP_Progreso";
            this.tLP_Progreso.RowCount = 2;
            this.tLP_Progreso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.39024F));
            this.tLP_Progreso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.60976F));
            this.tLP_Progreso.Size = new System.Drawing.Size(1032, 41);
            this.tLP_Progreso.TabIndex = 1;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(3, 12);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(232, 26);
            this.progressBar.TabIndex = 0;
            // 
            // labProgeso
            // 
            this.labProgeso.AutoSize = true;
            this.labProgeso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labProgeso.Location = new System.Drawing.Point(241, 9);
            this.labProgeso.Name = "labProgeso";
            this.labProgeso.Size = new System.Drawing.Size(186, 32);
            this.labProgeso.TabIndex = 1;
            this.labProgeso.Text = "Cargando...";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 675);
            this.Controls.Add(this.tLP_1);
            this.Name = "Principal";
            this.tLP_1.ResumeLayout(false);
            this.tLP_PintarDatos.ResumeLayout(false);
            this.tLP_Empezar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tLP_Progreso.ResumeLayout(false);
            this.tLP_Progreso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLP_1;
        private System.Windows.Forms.TableLayoutPanel tLP_PintarDatos;
        private System.Windows.Forms.TableLayoutPanel tLP_Empezar;
        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tLP_CargarDatos;
        private System.Windows.Forms.TableLayoutPanel tLP_Progreso;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labProgeso;
    }
}