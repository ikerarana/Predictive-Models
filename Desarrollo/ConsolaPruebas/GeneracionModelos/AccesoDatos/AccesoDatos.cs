using java.io;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using weka.core;
using weka.core.converters;
using static weka.core.converters.ConverterUtils;

namespace GeneracionModelos.Datos
{
    public static class AccesoDatos
    {
        /// <summary>
        /// Carga los datos de un fichero ARFF
        /// </summary>
        /// <param name="sirectorio">Directorio donde se encuentra el fichero ARFF</param>
        /// <returns></returns>
        public static List<List<string>> CargarDatosFicheroARFF(string directorio)
        {
            // creamos el cargador de ficheros
            ArffLoader ficheroArff = new ArffLoader();

            // le pasamos el directorio con el fichero ARFF
            ficheroArff.setSource(new File(directorio));

            // lo convertimos a instancias
            Instances data = ficheroArff.getDataSet();

            //// Fuente de datos
            //DataSource source = new DataSource(directorio);

            //// convertimos a instancias
            //Instances data = source.getDataSet();
            
            return Conversion_de_Datos.ConversionDatos.ConvertirInstancesString(data);

        }

        /// <summary>
        /// Carga los datos de un fichero CSV
        /// </summary>
        /// <param name="sirectorio">Directorio donde se encuentra el fichero ARFF</param>
        /// <returns></returns>
        public static List<List<string>> CargarDatosFicheroCSV(string directorio)
        {
            // creamos el cargador de ficheros
            CSVLoader ficheroCSV = new CSVLoader();

            // le pasamos el directorio con el fichero ARFF
            ficheroCSV.setSource(new File(directorio));

            // lo convertimos a instancias
            Instances data = ficheroCSV.getDataSet();


            return Conversion_de_Datos.ConversionDatos.ConvertirInstancesString(data);

        }

        /// <summary>
        /// Guardamos los datos como ARFF
        /// </summary>
        /// <returns></returns>
        public static bool GuardarComoARFF(Instances datos, string directorio)
        {
            // TODO: Cambiar esto de workspace??? Probar si funciona

            // objeto para guardar
            ArffSaver guardar = new ArffSaver();

            // guardamos las instancias en el objeto para guardar
            guardar.setInstances(datos);

            // Creamos el directorio donde se quiere escribir
            guardar.setFile(new File(directorio));

            // escribir
            guardar.writeBatch();

            throw new Exception();
        }

        /// <summary>
        /// Guardamos los datos como CSV
        /// </summary>
        /// <returns></returns>
        public static bool GuardarComoCSV(Instances datos, string directorio)
        {
            // TODO: Cambiar esto de workspace??? Probar si funciona

            // objeto para guardar
            CSVSaver guardar = new CSVSaver();

            // guardamos las instancias en el objeto para guardar
            guardar.setInstances(datos);

            // Creamos el directorio donde se quiere escribir
            guardar.setFile(new File(directorio));

            // escribir
            guardar.writeBatch();

            throw new Exception();
        }

    }
}
