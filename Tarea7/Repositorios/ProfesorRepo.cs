using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea7.Models;

namespace Tarea7.Repositorios
{
    public class ProfesorRepo : RepoBase<Profesor>, IProfesoresRepo
    {
        private readonly Contexto _context;
        public ProfesorRepo(Contexto context) : base(context)
        {
            _context = context;
        }
    }
}
