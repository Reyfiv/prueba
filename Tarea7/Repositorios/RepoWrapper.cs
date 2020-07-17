using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea7.Models;

namespace Tarea7.Repositorios
{
    public class RepoWrapper : IRepoWrapper
    {
        private readonly Contexto _repoContext;
        IEstudianteRepo _Estudiante;
        IProfesoresRepo _Profesor;
        IEmpleadosRepo _Empleado;
        public RepoWrapper(Contexto repoContext)
        {
            _repoContext = repoContext;
        }
        public IEstudianteRepo Estudiante 
        {
            get
            {
                if (_Estudiante == null)
                {
                    _Estudiante = new EstudianteRepo(_repoContext);
                }

                return _Estudiante;
            }
        }

        public IProfesoresRepo Profesores 
        {
            get
            {
                if (_Profesor == null)
                {
                    _Profesor = new ProfesorRepo(_repoContext);
                }

                return _Profesor;
            }
        }

        public IEmpleadosRepo Empleados 
        {
            get
            {
                if (_Empleado == null)
                {
                    _Empleado = new EmpleadosRepo(_repoContext);
                }

                return _Empleado;
            }
        }
    }
}
