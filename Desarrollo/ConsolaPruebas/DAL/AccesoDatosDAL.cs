using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class AccesoDatosDAL
    {
        #region Atributos 

        #endregion

        #region Constructor

        #endregion

        #region Propiedades

        #endregion

        #region Metodos

        /// <summary>
        /// Descarga los datos de la ULR que recibe por parametro
        /// </summary>
        /// <param name="url"></param>
        public static List<List<string>> DescargarDatosURLNavegador(string url)
        {
            // pedimos que descarge los datos
            return Navegador.DescargarURLNavegador.DescargarFicheroDatos(url);
                       
            
        }


        #endregion
    }
}
