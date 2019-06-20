using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.VO;

namespace UI.AdvancedUI.Controles_de_Usuario.CargarDatos
{
    public partial class InsertarURLUC : UserControl
    {
        #region Atributos 

        private static InsertarURLUC _instancia;

        #endregion

        #region Propiedades

        public static InsertarURLUC Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new InsertarURLUC();
                }

                return _instancia;
            }
        }



        #endregion

        #region Constructor

        public InsertarURLUC()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Si recibe un 0 cambia texto a URL si recibe un 1 cambia tecxto a Fichero
        /// </summary>
        /// <param name="numero"></param>
        public void CambiarTexto(int numero)
        {
            if (numero == 0)
            {
                labelInsertarURL.Text = "Introduce la URL para descargar el conjunto de datos";
                buttonDescargar.Text = "Descargar";
            }
            else if (numero == 1)
            {
                labelInsertarURL.Text = "Introduce el directorio del fichero para cargar los datos";
                buttonDescargar.Text = "Cargar";

            }

        }


        #endregion

        private void buttonDescargar_Click(object sender, EventArgs e)
        {
            if (!textBoxURL.Text.Equals("")) {

               CargarDatosNavegadorVO objetoDatosVista = new CargarDatosNavegadorVO(textBoxURL.Text);

            }


        }
}
}
