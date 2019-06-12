using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class ControladorBLL
    {

        #region Atributos 

        #endregion

        #region Constructor


        #endregion

        #region Propiedades

        #endregion

        #region Metodos


        /// <summary>
        /// Baja los datos de la URL que recibe por parametro
        /// </summary>
        /// <param name="url"></param>
        public static List<List<string>> DescargarDatosURL(string url)
        {
            // pasamos los datos al BLL
            return DAL.AccesoDatosDAL.DescargarDatosURLNavegador(url);
        }

        /// <summary>
        /// Metodo para cargar los datos de un fichero ARFF
        /// </summary>
        /// <param name="ruta">Directorio donde se encuentra el fichero</param>
        /// <returns></returns>
        public static List<List<string>> CargarFicheroARFF(string ruta)
        {

            return DAL.AccesoDatosDAL.CargarDatosFicheroARFF(ruta);

        }

        /// <summary>
        /// Metodo para cargar los datos de un fichero CSV
        /// </summary>
        /// <param name="ruta">Directorio donde se encuentra el fichero</param>
        /// <returns></returns>
        public static List<List<string>> CargarFicheroCSV(string ruta)
        {

            return DAL.AccesoDatosDAL.CargarDatosFicheroCSV(ruta);

        }

        /// <summary>
        /// Convertimos los datos del modelo a la estructura de datos que corresponda
        /// </summary>
        /// <param name="datos"></param>
        public static void ConvertirDatos(List<List<string>> datos)
        {



            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="datos"></param>
        public static void GenerarModelo(List<List<string>> datos)
        {

            GeneracionModelos.Modelos.GenerarModelo();

        }





        #endregion
    }
}
