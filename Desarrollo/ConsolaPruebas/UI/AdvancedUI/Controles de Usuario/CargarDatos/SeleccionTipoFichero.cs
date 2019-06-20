using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UI.AdvancedUI.Controles_de_Usuario.CargarDatos
{
    public partial class SeleccionTipoFichero : UserControl
    {

        #region Atributos 
        private static SeleccionTipoFichero _instancia;
        private string directorio;

        #endregion

        #region Propiedades

        public static SeleccionTipoFichero Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new SeleccionTipoFichero();
                }

                return _instancia;
            }
        }

        #endregion

        #region Constructor

        public SeleccionTipoFichero()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Click boton cargar CSV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCSV_Click(object sender, EventArgs e)
        {
            // activamos el botor de buscar
            //buttonBuscar.Enabled = true;
            textBoxDirectorio.Enabled = true;
            buttonCSV.BackColor = Color.FromArgb(125, 132, 146);
            buttonCargarARFF.BackColor = Color.FromArgb(41, 44, 51);


            BuscarFichero(".csv");

        }

        /// <summary>
        /// Click boton cargar ARFF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCargarARFF_Click(object sender, EventArgs e)
        {
            //buttonBuscar.Enabled = true;
            textBoxDirectorio.Enabled = true;
            buttonCargarARFF.BackColor = Color.FromArgb(125, 132, 146);
            buttonCSV.BackColor = Color.FromArgb(41, 44, 51);

            BuscarFichero(".arff");

        }


        private void buttonCargarDatos_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Metodos

        /// <summary>
        /// en funcion de que boton este pulsado, sacamos uno u otro directorio
        /// </summary>
        /// <param name="tipoFichero"></param>
        private void BuscarFichero(string tipoFichero)
        {

            // buscamos el fichero
            OpenFileDialog buscarDirectorio = new OpenFileDialog
            {
                InitialDirectory = Path.GetFullPath
                (Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\..\Documentos")),
                Title = "Buscar Fichero",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = tipoFichero,
                Filter = tipoFichero + " files (*" + tipoFichero + ")|*" + tipoFichero,
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (buscarDirectorio.ShowDialog() == DialogResult.OK)
            {
                textBoxDirectorio.Text = directorio = buscarDirectorio.FileName;
                buttonCargarDatos.Enabled = true;
                buttonCargarDatos.Text = "Cargar Datos";

            }



        }

        #endregion

    }
}
