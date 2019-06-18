using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.AdvancedUI.Controles_de_Usuario
{
    public partial class CargarDatosUC : UserControl
    {
        private static CargarDatosUC _instancia;


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
        

        public CargarDatosUC()
        {
            InitializeComponent();
        }
    }
}
