using System.ComponentModel.DataAnnotations.Schema;

namespace ApiMusica.Entidades
{
    public class Artista
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Biografia { get; set; }
        public DateTime? FechaNacimiento { get; set; }
    }
}
