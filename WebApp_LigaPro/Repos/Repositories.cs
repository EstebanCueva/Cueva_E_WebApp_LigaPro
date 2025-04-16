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
            Logo = "/Imagenes/liga_logo.png",
            Descripcion = "LDU (Liga Deportiva Universitaria) es uno de los equipos más importantes de Ecuador, conocido por su gran historia en el fútbol."
        },
        new Equipo
        {
            Id = 2,
            Nombre = "Aucas",
            PartidosJugados = 10,
            PartidosGanados = 2,
            PartidosEmpatados = 6,
            PartidosPerdidos = 2,
            Logo = "/Imagenes/Aucas_Logo.jpeg", 
            Descripcion = "Aucas es un club tradicional de Quito, Ecuador, con una gran pasión por el fútbol y su hinchada leal."
        },
        new Equipo
        {
            Id = 3,
            Nombre = "Barcelona SC",
            PartidosJugados = 12,
            PartidosGanados = 8,
            PartidosEmpatados = 2,
            PartidosPerdidos = 2,
            Logo = "/Imagenes/Barcelona_Logo.png", 
            Descripcion = "Barcelona SC es uno de los clubes más grandes y exitosos de Ecuador, con una gran trayectoria a nivel nacional e internacional."
        },
        new Equipo
        {
            Id = 4,
            Nombre = "Emelec",
            PartidosJugados = 12,
            PartidosGanados = 7,
            PartidosEmpatados = 3,
            PartidosPerdidos = 2,
            Logo = "/Imagenes/Emelec_Logo.jpeg", 
            Descripcion = "Emelec es otro de los gigantes del fútbol ecuatoriano, con una historia llena de éxitos y una afición muy apasionada."
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
