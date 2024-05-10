using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solucionarioExamenFinalProg.Sevicios
{
    internal interface FicheroInterfaz
    {
        public void ficheroLog(string message);

        public void cargaDeDatosPorFichero();
        public void imprimirConsultas();
    }
}
