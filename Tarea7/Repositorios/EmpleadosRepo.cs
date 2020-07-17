using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea7.Models;

namespace Tarea7.Repositorios
{
    public class EmpleadosRepo : RepoBase<Empleado>, IEmpleadosRepo
    {
        private readonly Contexto _context;
        public EmpleadosRepo(Contexto context) : base(context)
        {
            _context = context;
        }
    }
}
