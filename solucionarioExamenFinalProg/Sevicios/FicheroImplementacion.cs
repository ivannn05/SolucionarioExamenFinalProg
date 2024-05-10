using solucionarioExamenFinalProg.Controladores;
using solucionarioExamenFinalProg.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solucionarioExamenFinalProg.Sevicios
{
    internal class FicheroImplementacion : FicheroInterfaz
    {
        public void ficheroLog(string mensaje)
        {
            try
            {
                DateTime fechaHoy = DateTime.Now;
            string ruta = $"C:\\Users\\IVAN IMFORMATICA\\Desktop\\log-{ fechaHoy.ToString("dd-MM-yyyy") }.txt";
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

                string ruta = "C:\\Users\\IVAN IMFORMATICA\\Desktop\\citas.txt";
                string[] fichero = File.ReadAllLines(ruta);
                long id = 0;
                foreach (string s in fichero)
                {
                    UsuarioDto usuario = new UsuarioDto();
                    string[] campos = s.Split(';');
                    usuario.Dni = campos[0];
                    usuario.Nombre = campos[1];
                    usuario.Apellidos = campos[2];
                    usuario.Especialidad = campos[3];
                    usuario.FechaCita = Convert.ToDateTime(campos[4]);

                    if (campos[5].Equals(""))
                    {
                        usuario.AsistenciaCita = false;
                    }
                    else { usuario.AsistenciaCita = Convert.ToBoolean(campos[5]); }
                    usuario.IdUsuario = id++;
                    Program.listaUsuarios.Add(usuario);

                }
            }
            catch (Exception e) { Console.WriteLine("No hay datos anteriores"); }
        }

        public void imprimirConsultas()
        {
            throw new NotImplementedException();
        }
    }
}
