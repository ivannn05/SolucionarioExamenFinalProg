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
    /// Clase emcargada de contener la logica de los metodos de fichero de la app
    /// </summary>
    internal class FicheroImplementacion : FicheroInterfaz
    {
        public void ficheroLog(string mensaje)
        {
            try
            {
                DateTime fechaHoy = DateTime.Now;
                string ruta = $"C:\\Users\\csi23-iloposa\\Desktop\\log-{ fechaHoy.ToString("dd-MM-yyyy") }.txt";
                StreamWriter escribe = new StreamWriter(ruta,true);
                escribe.WriteLine(mensaje);
                escribe.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocurrio un error en el fichero log"+e);

            }
        }

        public void cargaDeDatosPorFichero()
        {
            try
            {

                string ruta = "C:\\Users\\csi23-iloposa\\Desktop\\citas.txt";
                string[] fichero = File.ReadAllLines(ruta);
                long id = 0;
                foreach (string s in fichero)
                {
                    CitasDto cita = new CitasDto();
                    string[] campos = s.Split(';');
                    cita.Dni = campos[0];
                    cita.Nombre = campos[1];
                    cita.Apellidos = campos[2];
                    cita.Especialidad = campos[3].Trim();
                    cita.FechaCita = Convert.ToDateTime(campos[4]);

                    if (campos[5].Equals(""))
                    {
                        cita.AsistenciaCita = false;
                    }
                    else { cita.AsistenciaCita = Convert.ToBoolean(campos[5]); }
                    cita.Id = id++;
                    Program.listaCitas.Add(cita);

                }
            }
            catch (Exception e) { Console.WriteLine("No hay datos anteriores");
                ficheroLog("No hay datos anteriores");}
        }

        public void imprimirConsultas(int opcionEspecialidad)
        {
                DateTime fechaHoy = DateTime.Today;
               
                
                string ruta = $"C:\\Users\\csi23-iloposa\\Desktop\\citasConAsistencia-{fechaHoy.ToString("ddMMyyyy")}.txt";
               

            try
            {

                DateTime fechaUsu = new DateTime();
                try
                {


                    Console.WriteLine("Elija una fecha (dd-MM-yyyy):");
                    fechaUsu = Convert.ToDateTime(Console.ReadLine());

                }
                catch (Exception ex)
                {
                    Console.WriteLine("La fecha no esta en un formato correcto");
                    ficheroLog("La fecha no esta en un formato correcto");
                    imprimirConsultas(opcionEspecialidad);
                }

                bool aux = false;
                StreamWriter sw = new StreamWriter(ruta, true);
                foreach (CitasDto cita in Program.listaCitas)
                {
                    

                    if (cita.FechaCita.Day == fechaUsu.Day && cita.FechaCita.Month == fechaUsu.Month && cita.FechaCita.Year == fechaUsu.Year && cita.AsistenciaCita==true)
                    {
                       
                        if (cita.Especialidad.Equals("Psicología") && opcionEspecialidad==1)
                        {
                             aux = true;
                            sw.Write($"Nombre completo: {cita.Nombre} {cita.Apellidos}, Hora:{cita.FechaCita.Hour}:{cita.FechaCita.Minute} \n");

                        }
                        else if (cita.Especialidad.Equals("Traumatología") && opcionEspecialidad == 2)
                        {
                             
                            aux = true;
                            sw.Write($"Nombre completo: {cita.Nombre} {cita.Apellidos}, Hora: {cita.FechaCita.Hour}:{cita.FechaCita.Minute} \n");
                        }
                        else if (cita.Especialidad.Equals("Fisioterapia") && opcionEspecialidad == 3)
                        {
                             
                            aux = true;
                            sw.Write($"Nombre completo: {cita.Nombre} {cita.Apellidos}, Hora: {cita.FechaCita.Hour}:{cita.FechaCita.Minute}  \n");
                        }

                    }

                }
                if (aux == false)
                {
                    sw.Write("No hay datos disponibles para la especialidad y fecha disponibles");

                }
                sw.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine("Ha habido un error al guardar los datos de las consultas");
                ficheroLog("Ha habido un error al guardar los datos de las consultas");
            }
        }
    }
}
