using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea7.Models;

namespace Tarea7.Repositorios
{
    public class EstudianteRepo : RepoBase<Estudiantes>, IEstudianteRepo
    {
        private readonly Contexto _context;
        public EstudianteRepo(Contexto context) : base(context)
        {
            _context = context;
        }
    }
}
