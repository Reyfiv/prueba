using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using ReflectionIT.Mvc.Paging;
using Tarea7.Models;
using Tarea7.Repositorios;

namespace Tarea7.Controllers
{
    public class EmpleadosController : Controller
    {
        private readonly IEmpleadosRepo _repo;
        public static IQueryable<Empleado> empleados;
        public static List<Empleado> LEmpleado;

        public EmpleadosController(IEmpleadosRepo repo)
        {
            _repo = repo;
        }

        // GET: Empleado
        public ActionResult  Index(string filter, int page = 1,
                                           string sortExpression = "Nombre")
        {
            empleados = _repo.BuscarTodo();
            LEmpleado = empleados.ToList();
            List<Empleado> filtrada = LEmpleado;

            if (!string.IsNullOrWhiteSpace(filter))
            {
                filtrada = LEmpleado.FindAll(x => x.Nombre.ToUpper().Contains(filter.ToUpper()));
            }


            var model = PagingList.Create(filtrada, 5, page, sortExpression, "Nombre");
            model.RouteValue = new RouteValueDictionary {
                            { "filter", filter}
            };
            model.Action = "Index";
            return View(model);

        }
        // GET: Empleados/Details/5
        public async Task<ActionResult>  Details(int Id)
        {
            var modelo = await _repo.BuscarPorId(Id); //verifica si existe el id y lo busca en el arreglo
            if (modelo == null)
                return RedirectToAction(nameof(Index));

            return View(modelo); ///envia el modelo a la vista
        }

        // GET: Empleados/Create
        public  ActionResult Create()
        {
            return View();
        }

        // POST: Empleados/Create
        [HttpPost]
        public async Task<ActionResult>  Create(Empleado collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _repo.Crear(collection);
                    return RedirectToAction(nameof(Index));
                }

            }
            catch
            {
                throw;
            }
            return View(collection);
        }

        // GET: Empleados/Edit/5
        public async Task<ActionResult>  Edit(int Id)
        {
            var modelo = await _repo.BuscarPorId(Id);
            if (modelo == null)
                return RedirectToAction(nameof(Index));
            return View(modelo);
        }

        // POST: Empleados/Edit/5
        [HttpPost]
        public async Task<ActionResult>  Edit(Empleado modelo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _repo.Modificar(modelo);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                return View(modelo);
            }
            return View(modelo);
        }

        // GET: Empleados/Delete/5
        public ActionResult Delete(int Id)
        {
            var modelo = LEmpleado.Find(x => x.Codigo == Id);  //verifica si existe el id y lo busca en el arreglo
            if (modelo == null)
                return RedirectToAction(nameof(Index));
            return View(modelo);
        }

        // POST: Empleados/Delete/5
        [HttpPost]
        public async Task<ActionResult>  Delete(Empleado modelo)
        {
            try
            {
                await _repo.Eliminar(modelo);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(modelo);
            }
        }
    }
}