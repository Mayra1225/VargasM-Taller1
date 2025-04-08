using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VargasM_Taller1.Models;
using VargasM_Taller1.Repositories;

namespace VargasM_Taller1.Controllers
{
    public class EquipoController : Controller
    {
        public ActionResult View()
        {
            return View();
        }

        public ActionResult List()
        {
            EquipoRepository repository = new EquipoRepository();
            var equipos = repository.DevuelveListadoEquipos();

            equipos = equipos.OrderBy(item => item.PartidosGanados);

            return View(equipos);
        }
    }
}
