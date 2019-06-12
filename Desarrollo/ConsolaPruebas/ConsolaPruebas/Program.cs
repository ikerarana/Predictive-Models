using DAL;
using DAL.Navegador;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaPruebas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> datos;

            #region Acceso a Datos

            #region Descargar un fichero de UCI-ML

            #region Descargar Datos

            // introducimos URL donde encontrar el dataset

            //var url = "https://archive.ics.uci.edu/ml/machine-learning-databases/iris/";

            //// pedimos los datos al controlador
            //datos = BLL.ControladorBLL.DescargarDatosURL(url);

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

            // datos.Insert(0, new List<string>() { "sepal length", "sepal width", "petal length", "petal width", "class" });


            #endregion

            #endregion

            #region Cargar fichero arff

            //Console.WriteLine("Introduzca la ruta del fichero .arff");
            //string ruta = Console.ReadLine();

            //// Para la prueba cogemos una ruta en la que sepamos que hay un fichero
            //ruta = Path.GetFullPath
            //    (Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\..\Documentos\iris.arff")); ;

            //// Cargamos los datos del fichero
            //datos = BLL.ControladorBLL.CargarFicheroARFF(ruta);

            #endregion

            #region Cargar fichero CSV

            Console.WriteLine("Introduzca la ruta del fichero .csv");
            string ruta = Console.ReadLine();

            // Para la prueba cogemos una ruta en la que sepamos que hay un fichero
            ruta = Path.GetFullPath
                (Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\..\Documentos\iris.csv")); ;

            // 
            datos = BLL.ControladorBLL.CargarFicheroCSV(ruta);

            #endregion


            #region Pintamos los datos

            // pintamos los datos
            foreach (List<string> fila in datos)
            {
                Console.WriteLine(String.Join(",", fila));
            }

            #endregion


            #endregion

            #region Datos de configuracion del modelo

            #endregion

            #region Calculamos el modelo


            // Prueba generar modelo
            BLL.ControladorBLL.GenerarModelo(datos);

            // parseamos de string al tipo que corresponda
            //BLL.ControladorBLL.ConvertirDatos(datos);



            #endregion
            ;
            // convertimos el dataset

            // realizamos el modelo

            // pintamos los datos 

        }
    }
}
