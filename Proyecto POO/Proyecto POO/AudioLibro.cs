using System;
using WMPLib;
namespace Proyecto_POO
{
    public class AudioLibro : Archivo
    {
        //Atributos

        public string Genero;
        public int Idioma;
        public Persona Lector;

        //Constructor

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

        public string Informacion_Audiolibro()
        {
            string datos = "Titulo: " + Titulo + "\nCategoria: " + Categoria + "\nAño: " + Año +
                "\nDuracion: " + Duracion + "\nRanking: " + Ranking + "\nGenero: " + Genero + "\nIdioma: " + Idioma + "\nLector: " + Lector;
            return datos;
        }
       

    }
}
