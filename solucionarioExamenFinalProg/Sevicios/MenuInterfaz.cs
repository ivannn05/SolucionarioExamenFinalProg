using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solucionarioExamenFinalProg.Sevicios
{
    /// <summary>
    /// Clase interfaz encargada de contener las cabeceras de los metodos encargados de los menús 
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo encargado de mostrar el menù principal de la app
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuPrincipal();
        /// <summary>
        /// Metodo encargado de mostrar el menú de consultas
        /// </summary>
        public void mostrarMenuConsultas();
    }
}
