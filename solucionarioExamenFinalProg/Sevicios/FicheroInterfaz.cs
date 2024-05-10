using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solucionarioExamenFinalProg.Sevicios
{
    /// <summary>
    /// Clase interfaz encargada de contener las cabeceras de los metodos de fichero
    /// </summary>
    internal interface FicheroInterfaz
    {
        /// <summary>
        /// Metodo encargado de crear y escribir el fichero log
        /// </summary>
        /// <param name="message"></param>
        public void ficheroLog(string message);

        /// <summary>
        /// Metodo encargado de cargar los datos iniciales desde un fichero
        /// </summary>
        public void cargaDeDatosPorFichero();
        /// <summary>
        /// Metodo encargado de imprimir en un fichero las consultas de una especialidad
        /// </summary>
        public void imprimirConsultas(int opcionEspecialidad);
       
    }
}
