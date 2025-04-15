using CuevaE_WebApp_LigaPro.Repos;
using Microsoft.AspNetCore.Mvc;
using WebApp_LigaPro.Models;

namespace CuevaE_WebApp_LigaPro.Controllers
{
    public class EquipoController : Controller
    {
        public IActionResult ListaEquipos()
        {
            Repositories repository = new Repositories();
            var equipos = repository.DevuelveListadoEquipos();
            return View("List",equipos);
        }

        public IActionResult Edit(int Id)
        {
            Repositories repository = new Repositories();
            var equipo = repository.DevuelveInfoEquipo(Id);
            return View("List",equipo);
        }



    }
}
