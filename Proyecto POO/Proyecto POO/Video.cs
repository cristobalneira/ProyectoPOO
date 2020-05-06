using System;
using System.Collections.Generic;
using WMPLib;
namespace Proyecto_POO
{
    public class Video : Archivo
    {
        public List<Persona> Actores;
        public List<Persona> Directores;
        public string Estudio;
        public int Resolucion;
        public string Descripcion;
        public int Clasificacion;
        public string Genero;

        public Video(string titulo, int categoria, DateTime año, TimeSpan duracion, double ranking,
            int estado, string url, List<Persona> actores, List<Persona> directores, string estudio, int resolucion, string descripcion,
            int clasificacion, string genero)
        {

            Titulo = titulo;
            Categoria = categoria;
            Año = año;
            Duracion = duracion;
            Ranking = ranking;
            Estado = estado;
            URL = url;
            Actores = actores;
            Directores = directores;
            Estudio = estudio;
            Resolucion = resolucion;
            Descripcion = descripcion;
            Clasificacion = clasificacion;
            Genero = genero;
        }
    }
}
