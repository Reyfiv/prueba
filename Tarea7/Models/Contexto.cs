using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea7.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {
        }

        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Estudiantes> Estudiantes { get; set; }
        public virtual DbSet<Profesor> Profesor { get; set; }
    }
}
