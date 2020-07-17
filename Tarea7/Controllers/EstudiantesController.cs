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
    public class EstudiantesController : Controller
    {
        private readonly IEstudianteRepo _repo;
        public static IQueryable<Estudiantes> estudiantes;
        public static List<Estudiantes> Lestudiantes;

        public EstudiantesController(IEstudianteRepo repo)
        {
            _repo = repo;
        }

        // GET: Estudiantes
        public ActionResult Index(string filter, int page = 1,
                                           string sortExpression = "Nombre")
        {

            estudiantes = _repo.BuscarTodo();
            Lestudiantes = estudiantes.ToList();
            List<Estudiantes> filtrada = Lestudiantes;

            if (!string.IsNullOrWhiteSpace(filter))
            {
                filtrada = Lestudiantes.FindAll(x => x.Nombre.ToUpper().Contains(filter.ToUpper()));
            }


            var model = PagingList.Create(filtrada, 5, page, sortExpression, "Nombre");
            model.RouteValue = new RouteValueDictionary {
                            { "filter", filter}
            };
            model.Action = "Index";
            return View(model);

        }

        // GET: Estudiantes/Details/5
        public async Task<ActionResult> Details(int Id)
        {
            var modelo = await _repo.BuscarPorId(Id); //verifica si existe el id y lo busca en el arreglo
            if (modelo == null)
                return RedirectToAction(nameof(Index));

            return View(modelo); //envia el modelo a la vista
        }

        // GET: Estudiantes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Estudiantes/Create
        [HttpPost]
        public async Task<ActionResult> Create(Estudiantes collection)
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

        // GET: Estudiantes/Edit/5
        public async Task<ActionResult> Edit(int Id)
        {
            var modelo = await _repo.BuscarPorId(Id);
            if (modelo == null)
                return RedirectToAction(nameof(Index));
            return View(modelo);
        }

        // POST: Estudiantes/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(Estudiantes modelo)
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

        // GET: Estudiantes/Delete/5
        public ActionResult Delete(int Id)
        {
            var modelo = Lestudiantes.Find(x => x.IdEstudiantes == Id);  //verifica si existe el id y lo busca en el arreglo
            if (modelo == null)
                return RedirectToAction(nameof(Index));
            return View(modelo);
        }

        // POST: Estudiantes/Delete/5
        [HttpPost]
        public async Task<ActionResult> Delete(Estudiantes modelo)
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