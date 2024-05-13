using solucionarioExamenFinalProg.Controladores;
using solucionarioExamenFinalProg.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solucionarioExamenFinalProg.Sevicios
{
    /// <summary>
    /// Clase implementacion encargada de contener la logica de los métodos encargados de mostrar los menús
    /// </summary>
    internal class MenuImplementacion:MenuInterfaz
    {
        FicheroInterfaz fi = new FicheroImplementacion();
        OperativaInterfaz op= new OperativaImplementacion();
        public int mostrarMenuPrincipal()
        {
            int opc;
            Console.WriteLine("##################################");
            Console.WriteLine("Seleccione una opcion");
            Console.WriteLine("0.Cerrar menu");
            Console.WriteLine("1.Registro de llegada");
            Console.WriteLine("2.Listado consultas");
            Console.WriteLine("##################################");
            opc = Convert.ToInt32(Console.ReadLine());

            return opc;
        }
        public void mostrarMenuConsultas()
        {
            bool cerrarMenuConsultas = false;
            int opc;


            while (!cerrarMenuConsultas)
            {
                Console.WriteLine("#################################");
                Console.WriteLine("Seleccione una opcion");
                Console.WriteLine("0.Cerrar menu");
                Console.WriteLine("1.Mostrar consultas");
                Console.WriteLine("2.Imprimir consultas");
                Console.WriteLine("#################################");
                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 0:
                        Console.WriteLine("\tSe cerrara el menu");
                        fi.ficheroLog("Se cerrara el menu consultas");
                        cerrarMenuConsultas = true;
                        break;
                    case 1:
                        Console.WriteLine("\tAccedio a Mostrar consultas");
                        fi.ficheroLog("Accedio a Mostrar consultas");
                        menuMostrarEspecialidadConsultas();
                        
                        break;
                    case 2:
                        Console.WriteLine("\tAccedio a Imprimir consultas");
                        fi.ficheroLog("Accedio a Imprimir consultas");
                        menuImprimirEspecialidadConsultas();
                        break;
                    default:
                        Console.WriteLine("\tEsta opcion no existe");
                        fi.ficheroLog("Esta opcion no existe");
                        break;
                }
            }

        }
        /// <summary>
        /// Metodo que mostrar el menú de Mostrar la Especialidad de Consultas para el metodo mostrarMenuConsultas
        /// </summary>
        private void menuMostrarEspecialidadConsultas()
        {
            bool cerrarMenuEspecialidadesConsultas = false;
            int opc;

            Console.WriteLine("################################");
            Console.WriteLine("Seleccione una opcion");
            Console.WriteLine("0.Cerrar menu");
            Console.WriteLine("1.Psicología");
            Console.WriteLine("2.Traumatología");
            Console.WriteLine("3.Fsioterapia");
            Console.WriteLine("################################");
            opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 0:
                    Console.WriteLine("\tSe cerrara el menu");
                    fi.ficheroLog("Se cerrara el menu especialidad consultas");
                    cerrarMenuEspecialidadesConsultas = true;
                    break;
                case 1:
                    Console.WriteLine("\tAccedio a Psicología");
                    fi.ficheroLog("Accedio a Psicología");
                    op.mostrarConsultas(opc);
                    break;
                case 2:
                    Console.WriteLine("\tAccedio a Traumatología");
                    fi.ficheroLog("Accedio a Traumatología");
                    op.mostrarConsultas(opc);
                    break;
                case 3:
                    Console.WriteLine("\tAccedio a Fsioterapia");
                    fi.ficheroLog("Accedio a Fsioterapia");
                    op.mostrarConsultas(opc);
                    break;
                default:
                    Console.WriteLine("\tEsta opcion no existe");
                    fi.ficheroLog("Esta opcion no existe");
                    break;
            }
        }
        /// <summary>
        /// Metodo que mostrar el menú de Imprimir la Especialidad de Consultas para el metodo mostrarMenuConsultas
        /// </summary>
        private void menuImprimirEspecialidadConsultas()
        {
            bool cerrarMenuImprimirEspecialidadesConsultas = false;
            int opc;

            Console.WriteLine("################################");
            Console.WriteLine("Seleccione una opcion");
            Console.WriteLine("0.Cerrar menu");
            Console.WriteLine("1.Psicología");
            Console.WriteLine("2.Traumatología");
            Console.WriteLine("3.Fsioterapia");
            Console.WriteLine("################################");
            opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 0:
                    Console.WriteLine("\tSe cerrara el menu");
                    fi.ficheroLog("Se cerrara el menu especialidad consultas");
                    cerrarMenuImprimirEspecialidadesConsultas = true;
                    break;
                case 1:
                    Console.WriteLine("\tAccedio a Psicología");
                    fi.ficheroLog("Accedio a Psicología");
                    fi.imprimirConsultas(opc);
                    break;
                case 2:
                    Console.WriteLine("\tAccedio a Traumatología");
                    fi.ficheroLog("Accedio a Traumatología");
                    fi.imprimirConsultas(opc);
                    break;
                case 3:
                    Console.WriteLine("\tAccedio a Fsioterapia");
                    fi.ficheroLog("Accedio a Fsioterapia");
                    fi.imprimirConsultas(opc);
                    break;
                default:
                    Console.WriteLine("\tEsta opcion no existe");
                    fi.ficheroLog("Esta opcion no existe");
                    break;
            }
        }
    }
}
