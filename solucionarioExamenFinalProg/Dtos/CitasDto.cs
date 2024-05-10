using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solucionarioExamenFinalProg.Dtos
{
    /// <summary>
    /// Clase Dto la cual contiene los campos donde contendra los datos de los usuarios
    /// </summary>
    internal class CitasDto
    {
        //Campos
        long id;
        string dni = "aaaa";
        string nombre = "aaaa";
        string apellidos = "aaaa";
        string especialidad = "aaaa";
        DateTime fechaCita = DateTime.Now;
        bool asistenciaCita=false;
        //Constructores
        public CitasDto()
        {
        }

        public CitasDto(long id, string dni, string nombre, string apellidos, string especialidad, DateTime fechaCita, bool asistenciaCita)
        {
            this.id = id;
            this.dni = dni;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.especialidad = especialidad;
            this.fechaCita = fechaCita;
            this.asistenciaCita = asistenciaCita;
        }
        //Getters y Setters
        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public DateTime FechaCita { get => fechaCita; set => fechaCita = value; }
        public bool AsistenciaCita { get => asistenciaCita; set => asistenciaCita = value; }
        public long Id  { get => id; set => id = value; }
    }
}
