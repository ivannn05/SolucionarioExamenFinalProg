using solucionarioExamenFinalProg.Dtos;
using solucionarioExamenFinalProg.Sevicios;

namespace solucionarioExamenFinalProg.Controladores
{
    /// <summary>
    /// Clase principal de la aplicacion y clae que se lanzará primero
    /// </summary>
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
            //#########################################################################################################################
            //Este bucle debe de estar en los metodos mostrar consultas y imprimir consultas
            string fecha;
            DateTime fechaUsu;
            do
            {
               
                Console.WriteLine("Elija una fecha (dd-MM-yyyy)");
                fecha = Console.ReadLine();
                fechaUsu = Convert.ToDateTime(fecha);
                Console.WriteLine(fecha[2]);
                Console.WriteLine(fecha[5]);
                if (!fecha[2].Equals("-") && fecha[5].Equals("-"))
                {
                    Console.WriteLine("Introduzca la fecha en el formato indicado,la introducida esta en otro formato");
                }
            } while (!fecha[2].Equals("-") && fecha[5].Equals("-"));


            string[] arrayPrueba;
            do
            {
               
                Console.WriteLine("Elija una fecha (dd-MM-yyyy)");
                fechaUsu = Convert.ToDateTime(Console.ReadLine());
                arrayPrueba = fechaUsu.ToString().Split('-');
                if (arrayPrueba.Length <= 0)
                {
                    Console.WriteLine("Introduzca la fecha en el formato indicado,la introducida esta en otro formato");
                }
            } while (arrayPrueba.Length <= 0);

            //#########################################################################################################################
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
