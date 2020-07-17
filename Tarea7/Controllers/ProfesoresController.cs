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
    public class ProfesoresController : Controller
    {
        private readonly IProfesoresRepo _repo;
        public static IQueryable<Profesor> profesores;
        public static List<Profesor> LProfesores;

        public ProfesoresController(IProfesoresRepo repo)
        {
            _repo = repo;
        }
        // GET: Profesores
        public ActionResult Index(string filter, int page = 1,
                                           string sortExpression = "Nombre")
        {
            profesores = _repo.BuscarTodo();
            LProfesores = profesores.ToList();
            List<Profesor> filtrada = LProfesores;

            if (!string.IsNullOrWhiteSpace(filter))
            {
                filtrada = LProfesores.FindAll(x => x.Nombre.ToUpper().Contains(filter.ToUpper()));
            }


            var model = PagingList.Create(filtrada, 5, page, sortExpression, "Nombre");
            model.RouteValue = new RouteValueDictionary {
                            { "filter", filter}
            };
            model.Action = "Index";
            return View(model);

        }
        // GET: Profesores/Details/5
        public async Task<ActionResult>  Details(int Id)
        {
            var modelo = await _repo.BuscarPorId(Id); //verifica si existe el id y lo busca en el arreglo
            if (modelo == null)
                return RedirectToAction(nameof(Index));

            return View(modelo); //nvia el modelo a la vista
        }

        // GET: Profesores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Profesores/Create
        [HttpPost]
        public async Task<ActionResult>  Create(Profesor collection)
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

        // GET: Profesores/Edit/5
        public async Task<ActionResult>  Edit(int Id)
        {
            var modelo = await _repo.BuscarPorId(Id);
            if (modelo == null)
                return RedirectToAction(nameof(Index));
            return View(modelo);
        }

        // POST: Profesores/Edit/5
        [HttpPost]
        public async Task<ActionResult>  Edit(Profesor modelo)
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

        // GET: Profesores/Delete/5
        public ActionResult Delete(int Id)
        {
            var modelo = LProfesores.Find(x => x.Codigo == Id);  //verifica si existe el id y lo busca en el arreglo
            if (modelo == null)
                return RedirectToAction(nameof(Index));
            return View(modelo);
        }

        // POST: Profesores/Delete/5
        [HttpPost]
        public async Task<ActionResult>  Delete(Profesor modelo)
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