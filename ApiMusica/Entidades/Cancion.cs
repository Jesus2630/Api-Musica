namespace ApiMusica.Entidades
{
    public class Cancion
    {
        public int Id { get; set; }
        public string Titulo{ get; set; }
        public bool Disponible { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public string  PosterURL { get; set; }
    }
}
