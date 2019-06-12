using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using weka.core;

namespace GeneracionModelos.Conversion_de_Datos
{
    internal static class ConversionDatos
    {

        /// <summary>
        /// Convertir de Instancias a String
        /// </summary>
        /// <returns>Datos en formato string</returns>
        internal static List<List<string>> ConvertirInstancesString(Instances datos)
        {
            
            List<List<string>> datosString = new List<List<string>>();
            List<string> valor = new List<string>();

            // sacamos los nombres de los atributos
            for (int i = 0; i < datos.numAttributes(); i++)
            {
                // guardamos el nombre del atributo
                valor.Add(datos.attribute(i).name());

            }

            // añadimos las cabeceras a la lista
            datosString.Add(valor);

            // si no tiene ningun atributo marcado como el atributo de clase, le decimos que es el ultimo por defecto
            if (datos.classIndex() == -1)
                datos.setClassIndex(datos.numAttributes() - 1);

            // sacamos los valores que puede tener la clase
            List<string> valoresClase = new List<string>();

            for (int i = 0; i < datos.classAttribute().numValues(); i++)
            {
                valoresClase.Add(datos.classAttribute().value(i));
            }

            // guardamos los valores de las instancias
            for (int i = 0; i < datos.numInstances(); i++)
            {
                valor = new List<string>();

                for (int j = 0; j < datos.numAttributes(); j++)
                {
                    //siempre que no sea el atributo de clase guardamos el valor
                    if (j != datos.numAttributes() - 1)
                    {
                        valor.Add(datos.instance(i).value(j).ToString());

                    }
                    else
                    {
                        // buscamos el atributo que corresponde en la lista
                        valor.Add(valoresClase[Convert.ToInt32(datos.instance(i).value(j).ToString())].ToString());

                    }
                }

                datosString.Add(valor);

            }

            return datosString;
        }

    }
}
