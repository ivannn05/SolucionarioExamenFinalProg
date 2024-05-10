using solucionarioExamenFinalProg.Controladores;
using solucionarioExamenFinalProg.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace solucionarioExamenFinalProg.Sevicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public string validacionDeDNI()
        {

            Console.WriteLine("Escriba su DNI");
            string dniUsu = Console.ReadLine();

            char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };

            int numerosDni = Convert.ToInt32(dniUsu.Substring(0, dniUsu.Length - 1));

            int resultado = numerosDni % 23;

            char LetraRealCalculo = letras[resultado];
            char letraDniUsuario = dniUsu[dniUsu.Length - 1];


            String DNI;


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
            foreach (UsuarioDto usuario in Program.listaUsuarios)
            {
                if (usuario.Dni.Equals(dniUsu) & (usuario.FechaCita.Day == fechaHoy.Day & usuario.FechaCita.Month == fechaHoy.Month & usuario.FechaCita.Year == fechaHoy.Year))
                {
                    Console.WriteLine($"Espere su turno para la consulta de {usuario.Especialidad} en la sala de espera. Su especialista le avisará.");
                    continue;
                }
                if (!(usuario.Dni.Equals(dniUsu)) && (usuario.FechaCita.Day == fechaHoy.Day & usuario.FechaCita.Month == fechaHoy.Month & usuario.FechaCita.Year == fechaHoy.Year))
                {
                    Console.WriteLine("No dispone de ninguna cita previa para hoy");
                }

            }

        }

        public void mostrarConsultas()
        {
            DateTime fechaUsu = new DateTime();


            Console.WriteLine("Elija una fecha (dd-MM-yyyy)");
            fechaUsu = Convert.ToDateTime(Console.ReadLine());



            foreach (UsuarioDto consulta in Program.listaUsuarios)
            {
                if (consulta.FechaCita.Day == fechaUsu.Day & consulta.FechaCita.Month == fechaUsu.Month & consulta.FechaCita.Year == fechaUsu.Year)
                {
                    if (consulta.Especialidad.Equals("Psicologia"))
                    {
                        Console.WriteLine($"Nombre completo: {consulta.Nombre} {consulta.Apellidos}, Hora: {consulta.FechaCita.Hour}:{consulta.FechaCita.Minute}");
                    }
                    else if (consulta.Especialidad.Equals("Traumatologia"))
                    {
                        Console.WriteLine($"Nombre completo: {consulta.Nombre} {consulta.Apellidos}, Hora: {consulta.FechaCita.Hour}:{consulta.FechaCita.Minute}");
                    }
                    else if (consulta.Especialidad.Equals("Fisioterapia"))
                    {
                        Console.WriteLine($"Nombre completo: {consulta.Nombre} {consulta.Apellidos}, Hora: {consulta.FechaCita.Hour}:{consulta.FechaCita.Minute}");
                    }
                    else
                    {
                        Console.WriteLine("No hay datos disponibles para la especialidad y fecha indicada");
                    }
                }




            }
        }
    }
}
