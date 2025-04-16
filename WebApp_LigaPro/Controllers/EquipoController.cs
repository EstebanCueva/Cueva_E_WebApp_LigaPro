using CuevaE_WebApp_LigaPro.Repos;
using Microsoft.AspNetCore.Mvc;
using WebApp_LigaPro.Models;

namespace CuevaE_WebApp_LigaPro.Controllers
{
    public class EquipoController : Controller
    {
        // ✅ Instancia única del repositorio
        Repositories repository = new Repositories();

        public IActionResult ListaEquipos()
        {
            var equipos = repository.DevuelveListadoEquipos();
            return View("List", equipos);
        }

        public IActionResult Edit(int Id)
        {
            var equipo = repository.DevuelveInfoEquipo(Id);
            if (equipo == null)
            {
                return NotFound();
            }
            return View("Edit", equipo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Equipo equipo)
        {
            if (ModelState.IsValid)
            {
                bool actualizado = repository.ActualizaEquipo(equipo);
                if (actualizado)
                    return RedirectToAction("ListaEquipos");
                else
                    return NotFound();
            }
            return View("Edit", equipo);
        }
    }
}
