using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.AdvancedUI.Controles_de_Usuario;

namespace UI.AdvancedUI
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();


            // inicializamos los colores de los botones
            buttonDatos.BackColor = Color.FromArgb(41, 44, 51);
            buttonEvaluacion.BackColor = Color.FromArgb(41, 44, 51);
            buttonSeleccionar.BackColor = Color.FromArgb(41, 44, 51);
            buttonVisua.BackColor = Color.FromArgb(41, 44, 51);

            buttonEvaluacion.ForeColor = Color.FromArgb(176, 196, 222);
            buttonSeleccionar.ForeColor = Color.FromArgb(176, 196, 222);
            buttonVisua.ForeColor = Color.FromArgb(176, 196, 222);
        }

        private void buttonDatos_Click(object sender, EventArgs e)
        {
            buttonDatos.BackColor = Color.FromArgb(125, 132, 146);
            buttonEvaluacion.BackColor = Color.FromArgb(41, 44, 51);
            buttonSeleccionar.BackColor = Color.FromArgb(41, 44, 51);
            buttonVisua.BackColor = Color.FromArgb(41, 44, 51);

            // añadimos el control de usuario
            if (!panelDatos.Controls.Contains(CargarDatosUC.Instancia))
            {
                panelDatos.Controls.Add(CargarDatosUC.Instancia);
                CargarDatosUC.Instancia.Dock = DockStyle.Fill;
                CargarDatosUC.Instancia.BringToFront();
            }
            else
                CargarDatosUC.Instancia.BringToFront();

        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            buttonDatos.BackColor = Color.FromArgb(41, 44, 51);
            buttonEvaluacion.BackColor = Color.FromArgb(41, 44, 51);
            buttonSeleccionar.BackColor = Color.FromArgb(125, 132, 146);
            buttonVisua.BackColor = Color.FromArgb(41, 44, 51);
        }

        private void buttonVisua_Click(object sender, EventArgs e)
        {
            buttonDatos.BackColor = Color.FromArgb(41, 44, 51);
            buttonEvaluacion.BackColor = Color.FromArgb(41, 44, 51);
            buttonSeleccionar.BackColor = Color.FromArgb(41, 44, 51);
            buttonVisua.BackColor = Color.FromArgb(125, 132, 146);
        }

        private void buttonEvaluacion_Click(object sender, EventArgs e)
        {
            buttonDatos.BackColor = Color.FromArgb(41, 44, 51);
            buttonEvaluacion.BackColor = Color.FromArgb(125, 132, 146);
            buttonSeleccionar.BackColor = Color.FromArgb(41, 44, 51);
            buttonVisua.BackColor = Color.FromArgb(41, 44, 51);
        }
    }
}
