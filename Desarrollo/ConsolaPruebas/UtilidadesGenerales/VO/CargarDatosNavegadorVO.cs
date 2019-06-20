using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.VO
{
    public class CargarDatosNavegadorVO : CargarDatosVO
    {
        #region Atributos 

        private static string url;

        #endregion

        #region Propiedades

        public static string Url { get => url; set => url = value; }

        #endregion

        #region Constructor 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        public CargarDatosNavegadorVO(string url) : base()
        {
            Tipo = TipoDatos.URL;
            Url = url;

        }

        #endregion

        #region Metodos

        #endregion
    }
}
