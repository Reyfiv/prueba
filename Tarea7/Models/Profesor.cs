using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea7.Models
{
    public class Profesor
    {
        [Key]
        [Required(ErrorMessage = "El campo {0} no puede estar en blanco.")]
        public int Codigo { get; set; }
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
        public string Direccion { get; set; }
        public string Carrera { get; set; }
        [Required(ErrorMessage = "El campo {0} no puede estar en blanco.")]
        public string TituloGrado { get; set; }
        public string MayorGrado { get; set; }
        public string CatProfesional { get; set; }
        public string Facultad { get; set; }
    }
}
