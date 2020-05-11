using System;
using System.Media;
namespace Proyecto_POO
{
    public abstract class Archivo
    {
        public enum enum_Categoria
        {
            Cancion = 1,
            Video = 2,
            Podcast = 3,
            Pelicula = 4,
            Audiolibro = 5,
        }
        public string Titulo;
        public int Categoria;
        public DateTime Año;
        public TimeSpan Duracion;
        public double Ranking;
        public int Estado;
        public string URL;

    }
}
