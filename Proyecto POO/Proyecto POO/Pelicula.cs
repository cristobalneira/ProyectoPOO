using System;
using System.Collections.Generic;
using WMPLib;
namespace Proyecto_POO
{
    public class Pelicula : Archivo
    {
        public enum enum_Resolucion
        {
            Baja = 1,
            Normal = 2,
            HD = 3,
        }
        public enum enum_Clasificacion
        {
            AA = 1,
            A = 2,
            B = 3,
            C = 4,
            D = 5,
        }

        public List<Persona> Actor;
        public List<Persona> Director;
        public string Estudio;
        public string Descripcion;
        public int Resolucion;
        public int Clasificacion;
        public string Genero;

        //Contructor:
        public Pelicula(string titulo, int categoria, DateTime año, TimeSpan duracion, double ranking,
            int estado, string url, List<Persona> actor, List<Persona> director, string estudio, int resolucion, string descripcion,
            int clasificacion, string genero)
        {

            Titulo = titulo;
            Categoria = categoria;
            Año = año;
            Duracion = duracion;
            Ranking = ranking;
            Estado = estado;
            URL = url;
            Actor = actor;
            Director = director;
            Estudio = estudio;
            Resolucion = resolucion;
            Descripcion = descripcion;
            Clasificacion = clasificacion;
            Genero = genero;
        }
        //Informacion_Pelicula:
        public string Informacion_Pelicula()
        {
            string a = "Titulo: " + Titulo + "\nCategoria: " + Categoria + "\nAño: " + Año + "\nDuracion: " + Duracion + "\nRanking: " + Ranking;
            a += "\nActor(es) :";
            int i_1 = 1;
            foreach (var item in Actor)
            {
                a += i_1 + ". :" + item.Nombre_y_Apellido;
                i_1 += 1;
            }
            a += "\nDirector(es): ";
            int i_2 = 1;
            foreach (var item in Director)
            {
                a += i_2 + ". :" + item.Nombre_y_Apellido;
                i_2 += 1;
            }
            a += "\nEstudio :" + Estudio + "\nResolucion :" + Resolucion + "\nDescripcion :" + Descripcion + "\nClasificacion :" + Clasificacion;
            a += "\nGenero :" + Genero;
            return a;
        }
        public string Editar_Informacion(Pelicula pe)
        {
            string titulo = pe.Titulo;
            Titulo = titulo;
            int categoria = pe.Categoria;
            Categoria = categoria;
            DateTime año = pe.Año;
            Año = año;
            TimeSpan duracion = pe.Duracion;
            Duracion = duracion;
            double ranking = pe.Ranking;
            Ranking = ranking;
            int estado = pe.Estado;
            Estado = estado;
            string url = pe.URL;
            URL = url;
            List<Persona> actor=pe.Actor;
            Actor = actor;
            List<Persona> director=pe.Director;
            Director = director;
            string estudio=pe.Estudio;
            Estudio = estudio;
            string descripcion=pe.Descripcion;
            Descripcion = descripcion;
            int resolucion=pe.Resolucion;
            Resolucion = resolucion;
            int clasificacion=pe.Clasificacion;
            Clasificacion = clasificacion;
            string genero=pe.Genero;
            Genero = genero;

            return "Cambios actualizados";
        }
    }
}