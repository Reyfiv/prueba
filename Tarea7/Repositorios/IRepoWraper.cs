using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea7.Repositorios
{
    public interface IRepoWrapper
    {
        IEstudianteRepo Estudiante { get; }
        IProfesoresRepo Profesores { get; }
        IEmpleadosRepo Empleados { get; }
    }
}
