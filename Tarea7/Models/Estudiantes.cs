using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea7.Models
{
    public class Estudiantes
    {
        [Key]
        [Required(ErrorMessage = "El campo {0} no puede estar en blanco.")]
        public int IdEstudiantes { get; set; }
        [Required(ErrorMessage = "El campo {0} no puede estar en blanco.")]
        public string Matricula { get; set; }
        [Required(ErrorMessage = "El campo {0} no puede estar en blanco.")]
        public string Cedula { get; set; }
        [Required(ErrorMessage = "El campo {0} no puede estar en blanco.")]
        public DateTime FechaNacimiento { get; set; }
        [Required(ErrorMessage = "El campo {0} no puede estar en blanco.")]
        public DateTime FechaIngreso { get; set; }
        [Required(ErrorMessage = "El campo {0} no puede estar en blanco.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo {0} no puede estar en blanco.")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "El campo {0} no puede estar en blanco.")]
        public string Sexo { get; set; }
        [Required(ErrorMessage = "El campo {0} no puede estar en blanco.")]
        public string EstadoCivil { get; set; }
        public string Ocupacion { get; set; }
        public string TipoSangre { get; set; }
        [Required(ErrorMessage = "El campo {0} no puede estar en blanco.")]
        public string Nacionalidad { get; set; }
        public string Religion { get; set; }
        [Required(ErrorMessage = "El campo {0} no puede estar en blanco.")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El campo {0} no puede estar en blanco.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "El campo {0} no puede estar en blanco.")]
        public string NombrePadre { get; set; }
        [Required(ErrorMessage = "El campo {0} no puede estar en blanco.")]
        public string NombreMadre { get; set; }
        [Required(ErrorMessage = "El campo {0} no puede estar en blanco.")]
        public string Direccion { get; set; }
        public string TipoColegio { get; set; }
        public string Carrera { get; set; }
        public string Observaciones { get; set; }
    }
}
