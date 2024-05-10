using solucionarioExamenFinalProg.Dtos;
using solucionarioExamenFinalProg.Sevicios;

namespace solucionarioExamenFinalProg.Controladores
{
    class Program
    {
        public static List<CitasDto> listaCitas = new List<CitasDto>();
        public static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            FicheroInterfaz fi = new FicheroImplementacion();
            OperativaInterfaz op = new OperativaImplementacion();
            try
            {
                fi.cargaDeDatosPorFichero();
            }
            catch (Exception ex) { Console.WriteLine("Ocurrio un problema en la carga del fichero"); }

            try
            {
               
                bool cerrarMenu = false;
                int opc;
                while (!cerrarMenu)
                {
                    opc = mi.mostrarMenuPrincipal();

                    switch (opc)
                    {
                        case 0:
                            Console.WriteLine("\tSe cerrara el menu");
                            cerrarMenu = true;
                           fi.ficheroLog("Se cerro el menu");
                            
                            break;
                        case 1:
                            Console.WriteLine("\tAccedio a registro llegada");
                            fi.ficheroLog("Accedio a registro llegada");
                            op.registroDeLlegada();

                           



                            break;
                        case 2:
                            Console.WriteLine("\tAccedio a listado consultas");
                            fi.ficheroLog("Accedio a listado consultas");
                            
                            mi.mostrarMenuConsultas();

                            break;
                        default:
                            Console.WriteLine("\tEsta opcion no existe");
                            fi.ficheroLog("Accedio a Esta opcion no existe");
                            
                            break;
                    }
                }
            }
            catch(Exception ex) { Console.WriteLine("Ocurrio un problema en la aplicación");
                fi.ficheroLog("Ocurrio un problema en la aplicación");
            }
        }
    }
}
