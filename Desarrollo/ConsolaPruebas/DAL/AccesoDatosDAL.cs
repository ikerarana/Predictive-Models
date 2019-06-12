using System;
using System.Collections.Generic;
using System.IO;
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

        /// <summary>
        /// Carga los datos de un fichero ARFF
        /// </summary>
        /// <param name="directorio">Directorio del que tiene que cargar los datos</param>
        /// <returns></returns>
        public static List<List<string>> CargarDatosFicheroARFF(string directorio)
        {
            if (File.Exists(directorio))
            {
                // pedimos que descarge los datos
                return Ficheros.CargarDatosFichero.CargarDatosFicheroARFF(directorio);
            }
            else
            {
                // TODO: que retornar si es nulo?
                Console.WriteLine("El fichero no existe");
                throw new Exception("El fichero no existe");
            }




        }

        /// <summary>
        /// Carga los datos de un fichero CSV
        /// </summary>
        /// <param name="directorio">Directorio del que tiene que cargar los datos</param>
        /// <returns></returns>
        public static List<List<string>> CargarDatosFicheroCSV(string directorio)
        {
            // pedimos que descarge los datos
            return Ficheros.CargarDatosFichero.CargarDatosFicheroCSV(directorio);


        }

        #endregion
    }
}
