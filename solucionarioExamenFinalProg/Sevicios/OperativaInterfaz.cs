using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solucionarioExamenFinalProg.Sevicios
{
    /// <summary>
    /// Clase interfaz encargada de contener las cabeceras de los metodos encargados del funcionamiento del menu
    /// </summary>
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Metodo encargado de validar la existencia del DNI que introduzca el usuario
        /// </summary>
        /// <returns></returns>
        public string validacionDeDNI();
        /// <summary>
        /// Metodo encargado de realizar la accion de registro de llegada
        /// </summary>
        public void registroDeLlegada();
        /// <summary>
        /// Metodo encargado de mostrar el listado de las consultas de una espcialidad específica
        /// </summary>
        /// <param name="opcioEspecialidad"></param>
        /// opcioEspecialidad=Es la opcion de la especialidad del menu de especialidades
        public void mostrarConsultas(int opcioEspecialidad);
    }
}
