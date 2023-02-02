using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiMusica.Entidades
{
    public class Genero
    {
        public int Identificador { get; set; }
        public string Nombre { get; set;} 
    }
}
