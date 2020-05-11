using System;
using System.Collections.Generic;
using WMPLib;
namespace Proyecto_POO
{
    public class AudioLibro : Archivo
    {
        //Atributos

        public string Genero;
        public int Idioma;
        public string URL_Texto;
        public Persona Lector;

        //Constructor

        public AudioLibro(string titulo, int categoria, DateTime año, TimeSpan duracion, double ranking,
            int estado, string url, string url_texto, string genero, int idioma, Persona lector)
        {
            Titulo = titulo;
            Categoria = categoria;
            Año = año;
            Duracion = duracion;
            Ranking = ranking;
            Estado = estado;
            URL = url;
            URL_Texto = url_texto;
            Genero = genero;
            Idioma = idioma;
            Lector = lector;
        }
        //Editar informacion:
        public string Editar_Informacion(AudioLibro AL)
        {
            string titulo = AL.Titulo;
            Titulo = titulo;
            int categoria = AL.Categoria;
            Categoria = categoria;
            DateTime año = AL.Año;
            Año = año;
            TimeSpan duracion = AL.Duracion;
            Duracion = duracion;
            double ranking = AL.Ranking;
            Ranking = ranking;
            int estado=AL.Estado;
            Estado = estado;
            string url =AL.URL;
            URL = url;

            string genero = AL.Genero;
            Genero = genero;
            int idioma = AL.Idioma;
            Idioma = idioma;
            Persona lector = AL.Lector;
            Lector = lector;
            return "Cambios actualizados";
        }
        public string Informacion_AudioLibro()
        {
            string datos = "Titulo: " + Titulo + "\nCategoria: " + Categoria + "\nAño: " + Año +
                "\nDuracion: " + Duracion + "\nRanking: " + Ranking + "\nGenero: " + Genero + "\nIdioma: " + Idioma + "\nLector: " + Lector;
            return datos;
        }
    }
}
