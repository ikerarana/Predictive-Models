using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using weka.core;
using static weka.core.converters.ConverterUtils;

namespace GeneracionModelos
{
    public static class Modelos
    {
        public static void GenerarModelo()
        {
            // Fuente de datos
            DataSource source = new DataSource(DirectorioDatosPrueba());

            // convertimos a instancias
            Instances data = source.getDataSet();

            // generamos una copia
            Instances dataCopy = new Instances(data);


        }

        /// <summary>
        /// Cogemos los datos de prueba del directorio del programa
        /// </summary>
        /// <returns></returns>
        private static string DirectorioDatosPrueba()
        {
            // cogemos la ruta del fichero
            return Path.GetFullPath
                (Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\..\Documentos\iris.arff"));
        }
    }
}
