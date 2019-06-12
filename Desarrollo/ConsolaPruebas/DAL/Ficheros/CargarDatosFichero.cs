using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Ficheros
{
    internal static class CargarDatosFichero
    {
        /// <summary>
        /// Carga los datos de un fichero ARFF
        /// </summary>
        /// <param name="directorio">Directorio del que tiene que cargar los datos</param>
        /// <returns></returns>
        internal static List<List<string>> CargarDatosFicheroARFF(string directorio)
        {
            return GeneracionModelos.Datos.AccesoDatos.CargarDatosFicheroARFF(directorio);
        }

        /// <summary>
        /// Carga los datos de un fichero CSV
        /// </summary>
        /// <param name="directorio">Directorio del que tiene que cargar los datos</param>
        /// <returns></returns>
        internal static List<List<string>> CargarDatosFicheroCSV(string directorio)
        {
            return GeneracionModelos.Datos.AccesoDatos.CargarDatosFicheroCSV(directorio);
        }
    }
}
