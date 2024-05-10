using solucionarioExamenFinalProg.Controladores;
using solucionarioExamenFinalProg.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace solucionarioExamenFinalProg.Sevicios
{

    /// <summary>
    /// Clase implementacion encargada de contener la logica de los metodos del fucnionamiento de la app
    /// </summary>
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public string validacionDeDNI()
        {
            String DNI;
            char LetraRealCalculo;
            char letraDniUsuario;
             
            string dniUsu;
            do
            {
                Console.WriteLine("Escriba su DNI");
                 dniUsu = Console.ReadLine();

                char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };

                int numerosDni = Convert.ToInt32(dniUsu.Substring(0, dniUsu.Length - 1));

                int resultado = numerosDni % 23;

                  LetraRealCalculo = letras[resultado];
                  letraDniUsuario = dniUsu[dniUsu.Length - 1];

                
                
                if (!LetraRealCalculo.Equals(letraDniUsuario))
                {
                    Console.WriteLine("\tEscriba su DNI correctamente,el escrito no existe");
                }

            } while(!LetraRealCalculo.Equals(letraDniUsuario));

            if (LetraRealCalculo.Equals(letraDniUsuario))
            {
                DNI = dniUsu;
            }
            else
            {
                DNI = "";
            }
            return DNI;
        }
        public void registroDeLlegada()
        {
            string dniUsu = validacionDeDNI();
            DateTime fechaHoy = DateTime.Today;
            bool aux=false;
            foreach (CitasDto cita in Program.listaCitas)
            {
                if (cita.Dni.Equals(dniUsu) & (cita.FechaCita.Day == fechaHoy.Day & cita.FechaCita.Month == fechaHoy.Month & cita.FechaCita.Year == fechaHoy.Year))
                {
                    Console.WriteLine($"Espere su turno para la consulta de {cita.Especialidad} en la sala de espera. Su especialista le avisará.");
                   aux = true;
                    break;
                }
               

            }
            if (aux== false)
            {
                Console.WriteLine("No dispone de ninguna cita previa para hoy");
            }
        }

        public void mostrarConsultas(int opcionMenuEspecialidad)
        {
            DateTime fechaUsu = new DateTime();


            Console.WriteLine("Elija una fecha (dd-MM-yyyy):");
            fechaUsu = Convert.ToDateTime(Console.ReadLine());


            bool aux = false;
            foreach (CitasDto consulta in Program.listaCitas)
            {
               
                if (consulta.FechaCita.Day == fechaUsu.Day && consulta.FechaCita.Month == fechaUsu.Month && consulta.FechaCita.Year == fechaUsu.Year)
                {
                    
                    
                    if (consulta.Especialidad.Equals("Psicología") & opcionMenuEspecialidad==1)
                    {
                        Console.WriteLine($"Nombre completo: {consulta.Nombre} {consulta.Apellidos}, Hora: {consulta.FechaCita.Hour}:{consulta.FechaCita.Minute}");
                        
                        aux = true;
                    }
                    if (consulta.Especialidad.Equals("Traumatología") & opcionMenuEspecialidad == 2)
                    {
                        Console.WriteLine($"Nombre completo: {consulta.Nombre} {consulta.Apellidos}, Hora: {consulta.FechaCita.Hour}:{consulta.FechaCita.Minute}");
                        aux = true;
                    }
                     if (consulta.Especialidad.Equals("Fisioterapia") & opcionMenuEspecialidad == 3)
                     {
                        Console.WriteLine($"Nombre completo: {consulta.Nombre} {consulta.Apellidos}, Hora: {consulta.FechaCita.Hour}:{consulta.FechaCita.Minute}");
                        aux = true;
                     }

                }




            }
            if (aux == false)
            {
                Console.WriteLine("No hay datos disponibles para la especialidad y fecha indicada");
            }
        }
    }
}
