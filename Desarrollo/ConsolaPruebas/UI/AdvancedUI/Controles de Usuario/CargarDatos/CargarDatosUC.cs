using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.AdvancedUI.Controles_de_Usuario.CargarDatos;

namespace UI.AdvancedUI.Controles_de_Usuario
{
    public partial class CargarDatosUC : UserControl
    {
        #region Atributos 

        private static CargarDatosUC _instancia;


        #endregion

        #region Propiedades

        public static CargarDatosUC Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new CargarDatosUC();
                }

                return _instancia;
            }
        }

        #endregion

        #region Constructor

        public CargarDatosUC()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        private void buttonDatos_Click(object sender, EventArgs e)
        {
            // cambiamos los botones de color
            buttonDatos.BackColor = Color.FromArgb(125, 132, 146);
            buttonCargarFichero.BackColor = Color.FromArgb(41, 44, 51);
            buttonCargarBD.BackColor = Color.FromArgb(41, 44, 51);

            // Cargamos el panel
            // añadimos el control de usuario
            if (!panelInsertarURL.Controls.Contains(InsertarURLUC.Instancia))
            {
                panelInsertarURL.Controls.Add(InsertarURLUC.Instancia);
                InsertarURLUC.Instancia.Dock = DockStyle.Fill;
                InsertarURLUC.Instancia.BringToFront();

            }
            else
                InsertarURLUC.Instancia.BringToFront();
            // metemos el texto para ese 
            InsertarURLUC.Instancia.CambiarTexto(0);

        }

        private void buttonCargarFichero_Click(object sender, EventArgs e)
        {
            // cambiamos los botones de color
            buttonDatos.BackColor = Color.FromArgb(41, 44, 51);
            buttonCargarFichero.BackColor = Color.FromArgb(125, 132, 146);
            buttonCargarBD.BackColor = Color.FromArgb(41, 44, 51);

            // añadimos el control de usuario
            if (!panelInsertarURL.Controls.Contains(SeleccionTipoFichero.Instancia))
            {
                SeleccionTipoFichero.Instancia.Dock = DockStyle.Fill;
                //SeleccionTipoFichero.Instancia.BringToFront();
                panelInsertarURL.Controls.Add(SeleccionTipoFichero.Instancia);


            }
            else
                SeleccionTipoFichero.Instancia.BringToFront();

        }

        private void buttonCargarBD_Click(object sender, EventArgs e)
        {
            // cambiamos los botones de color
            buttonDatos.BackColor = Color.FromArgb(41, 44, 51);
            buttonCargarFichero.BackColor = Color.FromArgb(41, 44, 51);
            buttonCargarBD.BackColor = Color.FromArgb(125, 132, 146);


        }

        #endregion

        #region Metodos

        /// <summary>
        /// Cargar el panel
        /// </summary>
        private void CargarPanel()
        {
            // añadimos el control de usuario
            if (!panelInsertarURL.Controls.Contains(InsertarURLUC.Instancia))
            {
                panelInsertarURL.Controls.Add(InsertarURLUC.Instancia);
                InsertarURLUC.Instancia.Dock = DockStyle.Fill;
                InsertarURLUC.Instancia.BringToFront();

            }
            else
                InsertarURLUC.Instancia.BringToFront();

        }


        #endregion


    }
}

