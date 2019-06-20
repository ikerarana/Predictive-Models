using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.VO
{
    public class CargarDatosFicheroVO : CargarDatosVO
    {

        #region Atributos

        private static TipoFichero tipoDeFichero;
        private static string directorio;


        #endregion

        #region Propiedades

        public static TipoFichero TipoDeFichero { get => tipoDeFichero; set => tipoDeFichero = value; }
        public static string Directorio { get => directorio; set => directorio = value; }


        #endregion

        #region Constructor

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tipoDeFichero"></param>
        /// <param name="directorio"></param>
        public CargarDatosFicheroVO(TipoFichero tipoDeFichero, string directorio) : base()
        {
            Tipo = TipoDatos.Fichero;
            TipoDeFichero = tipoDeFichero;
            Directorio = directorio;
        }

        #endregion

        #region Metodos

        #endregion

    }
}
