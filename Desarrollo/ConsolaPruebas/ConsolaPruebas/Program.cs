using DAL;
using DAL.Navegador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaPruebas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Descargar Datos

            // introducimos URL donde encontrar el dataset

            var url = "https://archive.ics.uci.edu/ml/machine-learning-databases/iris/";

            // pedimos los datos al controlador
            List<List<string>> datos = BLL.ControladorBLL.DescargarDatosURL(url);

            #endregion

            #region Pintamos los datos

            // pintamos los datos
            foreach (List<string> fila in datos)
            {
                Console.WriteLine(String.Join(",", fila));
            }

            #endregion

            #region Pedimos las cabeceras de los datos

            //int numeroCabeceras = datos[1].Count();

            ////Pedimos al usuario que introduzca las cabeceras
            //Console.WriteLine("Introduce los nombres de las " + numeroCabeceras + " cabeceras");
            //Console.WriteLine();

            //List<string> nombresCabeceras = new List<string>();

            //for (int i = 0; i < numeroCabeceras; i++)
            //{
            //    Console.WriteLine("Introduce el nombre de la cabecera numero " + (i + 1));
            //    string nombre = Console.ReadLine();
            //    nombresCabeceras.Add(nombre);
            //}

            //// insertamos los nombres en la primera posicion de la lista de datos
            //datos.Insert(0, nombresCabeceras);

            datos.Insert(0, new List<string>() { "sepal length", "sepal width", "petal length", "petal width", "class" });


            #endregion

            #region Datos de configuracion del modelo

            #endregion

            #region Calculamos el modelo

            // parseamos de string al tipo que corresponda
            BLL.ControladorBLL.ConvertirDatos(datos);

            #endregion
            ;
            // convertimos el dataset

            // realizamos el modelo

            // pintamos los datos 

        }
    }
}
