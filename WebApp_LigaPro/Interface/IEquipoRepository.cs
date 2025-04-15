using WebApp_LigaPro.Models;

namespace CuevaE_WebApp_LigaPro.Interface
{
    public interface IEquipoRepository
    {
        List<Equipo> DevuelveListadoEquipos();
        Equipo DevuelveInfoEquipo(int Id);
        bool CrearEquipo();
        bool ActualizaEquipo();
        bool EliminarEquipo();
    }
}
