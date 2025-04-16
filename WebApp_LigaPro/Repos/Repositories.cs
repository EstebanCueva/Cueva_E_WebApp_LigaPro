using CuevaE_WebApp_LigaPro.Interface;
using WebApp_LigaPro.Models;

namespace CuevaE_WebApp_LigaPro.Repos
{

    public class Repositories : IEquipoRepository
    {
        private static List<Equipo> equipos = new List<Equipo>
    {
        new Equipo
        {
            Id = 1,
            Nombre = "Ldu",
            PartidosJugados = 10,
            PartidosGanados = 10,
            PartidosEmpatados = 0,
            PartidosPerdidos = 0,
        },
        new Equipo
        {
            Id = 2,
            Nombre = "Aucas",
            PartidosJugados = 10,
            PartidosGanados = 2,
            PartidosEmpatados = 6,
            PartidosPerdidos = 2,
        }
    };

        public bool ActualizaEquipo(Equipo equipoActualizado) 
        {
            var equipoExistente = equipos.FirstOrDefault(e => e.Id == equipoActualizado.Id);
            if (equipoExistente != null)
            {
                equipoExistente.Nombre = equipoActualizado.Nombre;
                equipoExistente.PartidosJugados = equipoActualizado.PartidosJugados;
                equipoExistente.PartidosGanados = equipoActualizado.PartidosGanados;
                equipoExistente.PartidosEmpatados = equipoActualizado.PartidosEmpatados;
                equipoExistente.PartidosPerdidos = equipoActualizado.PartidosPerdidos;
                return true;
            }
            return false;
        }


        public bool CrearEquipo()
        {
            throw new NotImplementedException();
        }

        public Equipo DevuelveInfoEquipo(int Id)
        {
            return equipos.FirstOrDefault(item => item.Id == Id);  
        }

        public List<Equipo> DevuelveListadoEquipos()
        {
            return equipos;
        }

        public bool EliminarEquipo()
        {
            throw new NotImplementedException();
        }
    }

}
