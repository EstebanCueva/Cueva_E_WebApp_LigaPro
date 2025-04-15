using CuevaE_WebApp_LigaPro.Interface;
using WebApp_LigaPro.Models;

namespace CuevaE_WebApp_LigaPro.Repos
{
    public class Repositories : IEquipoRepository
    {

        public bool ActualizaEquipo()
        {
            throw new NotImplementedException();
        }

        public bool CrearEquipo()
        {
            throw new NotImplementedException();
        }

        public Equipo DevuelveInfoEquipo(int Id)
        {
            var equipos = DevuelveListadoEquipos();
            var equipo = equipos.Where(item => item.Id == Id).First();
            return equipo;

        }
        

        public List<Equipo> DevuelveListadoEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();
            Equipo ldu = new Equipo
            {
                Id = 1,
                Nombre = "Ldu",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0,



            };
            equipos.Add(ldu);

            Equipo bsc = new Equipo
            {
                Id = 1,
                Nombre = "Barcelona",
                PartidosJugados = 10,
                PartidosGanados = 1,
                PartidosEmpatados = 1,
                PartidosPerdidos = 8,



            };
            equipos.Add(bsc);

            return equipos;
        }

        public bool EliminarEquipo()
{
    throw new NotImplementedException();
}



    }
}
