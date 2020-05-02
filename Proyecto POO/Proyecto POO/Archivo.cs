using System;
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
        public enum Estado
        {
            Pausa=1,
            Reproduciendose=2,
        }; //??

        public void Editar_Informacion()
        {
            //? Con parametros 
        }
    }
}
