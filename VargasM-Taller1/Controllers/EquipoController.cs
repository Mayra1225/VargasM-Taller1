using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VargasM_Taller1.Models;
using VargasM_Taller1.Repositories;

namespace VargasM_Taller1.Controllers
{
    public class EquipoController : Controller
    {
        public EquipoRepository _repository;

        public EquipoController()
        {
            _repository = new EquipoRepository();
        }

        public ActionResult View()
        {
            return View();
        }

        public ActionResult List()
        {
            var equipos = _repository.DevuelveListadoEquipos();

            equipos = equipos.OrderBy(item => item.PartidosGanados);

            return View(equipos);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection colletion)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int Id)
        {
            var equipo = _repository.DevuelveEquipoporId(Id);

            return View(equipo);
        }

        [HttpPost]
        public ActionResult Edit(int Id, Equipo equipo)
        {
            // Guardar
            try
            {
                _repository.ActualizarEquipo(Id, equipo);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }
    }
}
