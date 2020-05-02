using System;
namespace Proyecto_POO
{
    public class AudioLibro : Archivo
    {
        private enum Genero
        {
            Comedia = 1,
            Accion = 2,
            Aventura = 3,
            Dramatica = 4,
            Terror = 5,
            Musicales = 6,
            CienciaFiccion = 7,
            Guerras = 8,
            Crimen = 9,
            Romance = 10,
        }
        public enum idioma
        {
            Ingles, Español, Chino
        }
        public Persona lector;

        public AudioLibro(Persona lector)
        {
            this.lector = lector;
        }
        public void Informacion_AudioLibro()
        {
            //Console.WriteLine("AudioLibro: {0}, Categoria: {1}, Idioma: {2}, Duracion: {3}, Lector: {4}.", titulo, Categoria??, idioma??, duracion, lector);
        }
    }
}
