using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.AdvancedUI.Controles_de_Usuario.PintarDatos
{
    public partial class PintarDatosUC : UserControl
    {

        #region Atributos 

        private static PintarDatosUC _instancia;
        private static List<List<string>> listaInstancias;

        #endregion

        #region Propiedades

        public static PintarDatosUC Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new PintarDatosUC(ListaInstancias);
                }

                return _instancia;
            }
        }

        public static List<List<string>> ListaInstancias { get => listaInstancias; set => listaInstancias = value; }

        #endregion

        #region Constructor

        public PintarDatosUC(List<List<string>> listaInstancias)
        {
            InitializeComponent();
        }

        #endregion

        #region Metodos

        private void AñadirDatosDGV()
        {
            

            dGVPintarDatos.Columns.Add("Column", "Test");


        }





        #endregion

        private void buttonAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
