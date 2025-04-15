using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApp_LigaPro.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        [DisplayName("Nombre del Equipo")]
        [Required]
        public string Nombre { get; set; }
        [Range(0, 100)]
        public int PartidosJugados { get; set; }
        [Range(0, 100)]
        public int PartidosGanados { get; set; }
        [Range (0, 100)]
        public int PartidosEmpatados { get; set; }
        [Range(0, 100)]
        public int PartidosPerdidos { get; set; }
        public int Puntos
        {
            get
            {
                int puntos = (PartidosGanados*3)+(PartidosEmpatados*1);
                return puntos;
            }
        }
    }
}
