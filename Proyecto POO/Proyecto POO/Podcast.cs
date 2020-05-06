using System;
using System.Collections.Generic;
using WMPLib;

namespace Proyecto_POO
{
    public class Podcast : Archivo
    {
        public List<Persona> Locutor;
        public string Imagen;
        public string Genero;

        public Podcast(string titulo, int categoria, DateTime año, TimeSpan duracion, double ranking,
            int estado, string url, List<Persona> locutor, string imagen, string genero)
        {
            Titulo = titulo;
            Categoria = categoria;
            Año = año;
            Duracion = duracion;
            Ranking = ranking;
            Estado = estado;
            URL = url;
            Locutor = locutor;
            Imagen = imagen;
            Genero = genero;
        }

    }
}
