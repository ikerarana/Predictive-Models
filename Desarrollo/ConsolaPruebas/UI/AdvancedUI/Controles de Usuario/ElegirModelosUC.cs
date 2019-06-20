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
    public partial class ElegirModelosUC : UserControl
    {

        #region Atributos 

        private static ElegirModelosUC _instancia;


        #endregion

        #region Propiedades

        public static ElegirModelosUC Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ElegirModelosUC();
                }

                return _instancia;
            }
        }

        #endregion

        #region Constructor

        public ElegirModelosUC()
        {
            InitializeComponent();
        }

        #endregion
    }
}
