using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;


namespace DAL.Navegador
{
    internal static class DescargarURLNavegador
    {
        #region Atributos 

        private static string[] filas;
        private static string rutaGuardarArchivo;

        #endregion

        #region Propiedades 
        internal static string[] Filas { get => filas; set => filas = value; }
        internal static string RutaGuardarArchivo { get => rutaGuardarArchivo; set => rutaGuardarArchivo = value; }

        #endregion

        #region Constructor 


        #endregion

        #region Metodos

        /// <summary>
        /// Descarga el fichero de datos de la URL que se ha solicitado.
        /// </summary>
        /// <param name="url">URL de la que se quiere descargar el fichero</param>
        internal static List<List<string>> DescargarFicheroDatos(string url)
        {

            // dividimos la Url por los Slash
            string[] parts = url.Split('/');

            // saltar 3 directorios para atras e ir a Ficheros temporales de datos
            RutaGuardarArchivo = Path.GetFullPath
                (Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\Ficheros Temporales Datos"));

            // creamos la url con el nombre del dataset 
            url = string.Concat(url, parts[parts.Count() - 2], ".data");

            // creamos la ruta donde lo queremos guardar
            RutaGuardarArchivo = string.Concat(RutaGuardarArchivo,
                @"\", parts[parts.Count() - 2], ".data");

            // miramos si existe el archivo en la ruta
            if (File.Exists(rutaGuardarArchivo))
            {
                // TODO: Sacar un Mensaje de que el fichero existe
                Console.WriteLine("¡El Archivo ya existe en este directorio.");
                Console.WriteLine("Pulse S si desea sobreescribirlo o cualquier otra tecla para utilizar el fichero ya existente");

                string sobreescritura = Console.ReadLine();

                if (sobreescritura.Equals("s") || sobreescritura.Equals("S"))
                {
                    // Descargamos los datos de la URL
                    DescargarDatosURL(url);

                    // cargamos los datos del fichero en una Lista
                    return CargarDatosFichero(RutaGuardarArchivo);
                }
                else
                {
                    Console.WriteLine("El archivo ya existe en el escritorio y no se ha sobreescrito, se usara el fichero existente");
                }


            }

            // cargamos los datos del fichero en una Lista
            return CargarDatosFichero(RutaGuardarArchivo);

        }

        /// <summary>
        /// Carga los datos del fichero descargado a una lista
        /// </summary>
        /// <returns>Lista con el fichero de datos en formato string</returns>
        private static List<List<string>> CargarDatosFichero(string direccionFichero)
        {
            if (File.Exists(direccionFichero))
            {
                List<List<string>> contenidoFichero = new List<List<string>>();

                // Leemos las lineas del fichero.  
                string[] lines = File.ReadAllLines(direccionFichero);

                // iteramos cada linea
                foreach (string line in lines)
                {
                    // separamso por coma
                    string[] split = line.Split(',');

                    // convertimos a lista y añadimos a la estructura de datos
                    contenidoFichero.Add(split.ToList());
                }

                return contenidoFichero;
            }
            else
            {
                throw new Exception("Problema al cargar los datos del fichero");
            }
        }

        /// <summary>
        /// Descargamos los datos de la URL que nos han pasado
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private static void DescargarDatosURL(string url)
        {
            try
            {
                // bajamos el dataset
                using (WebClient request = new WebClient())
                {
                    // pedimos que se descargue el fichero
                    request.DownloadFile(url, RutaGuardarArchivo);
                }

                // TODO: sacar Mensaje de error
                Console.WriteLine("Archivo descargado con Exito.");

                // cargamos los datos del fichero en una Lista
                //return CargarDatosFichero(RutaGuardarArchivo);
            }
            catch (Exception e)
            {
                // TODO: sacar Mensaje de error
                Console.WriteLine("¡Error al descargar archivo desde la web!");
                throw new Exception("¡Error al descargar archivo desde la web!");
            }

        }

        #endregion
    }
}
