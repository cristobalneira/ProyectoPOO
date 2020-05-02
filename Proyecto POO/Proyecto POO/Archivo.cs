using System;
using System.Media;
namespace Proyecto_POO
{
    public abstract class Archivo
    {
        public string Titulo;
        public enum Categoria
        {
            Cancion,
            Video,
            Podcast,
            Pelicula,
            AudioLibro
        };
        public DateTime año;
        public TimeSpan duracion;
        public double ranking;
        public int Estado;
        
        public string URL;

        public void Editar_Informacion()
        {
            //? Con parametros 
        }
    }
}
