using System;
using System.Collections.Generic;
using WMPLib;

namespace Proyecto_POO
{
    public class Cancion : Archivo
    {
        public List<Persona> Cantante;
        public List<Persona> Compositor;
        public string Album;
        public string Imagen;
        public string Letra;
        public string Genero;

        public Cancion(string titulo, int categoria, DateTime año, TimeSpan duracion, double ranking,
            int estado, string url, List<Persona> cantante, List<Persona> compositor, string album, string imagen, string letra, string genero)
        {
            Titulo = titulo;
            Categoria = categoria;
            Año = año;
            Duracion = duracion;
            Ranking = ranking;
            Estado = estado;
            URL = url;
            Cantante = cantante;
            Compositor = compositor;
            Album = album;
            Imagen = imagen;
            Letra = letra;
            Genero = genero;
        }
    }
}
