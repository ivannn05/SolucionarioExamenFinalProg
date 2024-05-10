using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solucionarioExamenFinalProg.Sevicios
{
    /// <summary>
    /// Clase interfaz encargada de contener las cabeceras de los metodos encargados de los menus 
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo encargado de mostrar el menu principal de la app
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuPrincipal();
        /// <summary>
        /// Metodo encargado de mostrar el menu de consultas
        /// </summary>
        public void mostrarMenuConsultas();
    }
}
