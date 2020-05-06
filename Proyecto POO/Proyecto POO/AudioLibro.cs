using System;
using WMPLib;
namespace Proyecto_POO
{
    public class AudioLibro : Archivo
    {
        public string Genero;
        public int Idioma;
        public Persona Lector;

        public AudioLibro(string titulo, int categoria, DateTime año, TimeSpan duracion, double ranking,
            int estado, string url, string genero, int idioma, Persona lector)
        {
            Titulo = titulo;
            Categoria = categoria;
            Año = año;
            Duracion = duracion;
            Ranking = ranking;
            Estado = estado;
            URL = url;
            Genero = genero;
            Idioma = idioma;
            Lector = lector;
        }

        //Console.WriteLine("AudioLibro: {0}, Categoria: {1}, Idioma: {2}, Duracion: {3}, Lector: {4}.", titulo, Categoria??, idioma??, duracion, lector);

    }
}
