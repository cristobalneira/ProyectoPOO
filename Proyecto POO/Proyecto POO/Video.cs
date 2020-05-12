using System;
using System.Collections.Generic;
using WMPLib;
namespace Proyecto_POO
{
    public class Video : Archivo
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

        public int Resolucion;
        public string Descripcion;
        public int Clasificacion;
        public string Genero;


        //Contructor:
        public Video(string titulo, int categoria, DateTime año, TimeSpan duracion, double ranking,
            int estado, string url, int resolucion, string descripcion,
            int clasificacion, string genero)
        {

            Titulo = titulo;
            Categoria = categoria;
            Año = año;
            Duracion = duracion;
            Ranking = ranking;
            Estado = estado;
            URL = url;
            Resolucion = resolucion;
            Descripcion = descripcion;
            Clasificacion = clasificacion;
            Genero = genero;
        }
        //Informacion_Video:
        public string Informacion_Video()
        {
            string a = "Titulo: " + Titulo + "\nCategoria: " + (enum_Categoria)Categoria + "\nAño: " + Año + "\nDuracion: " + Duracion + "\nRanking: " + Ranking;
            a+= "\nActor(es) :";
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
            a += "\nEstudio :" + Estudio + "\nResolucion :" + (enum_Resolucion)Resolucion + "\nDescripcion :" + Descripcion + "\nClasificacion :" + (enum_Clasificacion)Clasificacion;
            a += "\nGenero :" + Genero;
            return a;
        }
        public string Editar_Informacion(Video v)
        {
            string titulo = v.Titulo;
            Titulo = titulo;
            int categoria = v.Categoria;
            Categoria = categoria;
            DateTime año = v.Año;
            Año = año;
            TimeSpan duracion = v.Duracion;
            Duracion = duracion;
            double ranking = v.Ranking;
            Ranking = ranking;
            int estado = v.Estado;
            Estado = estado;
            string url = v.URL;
            URL = url;
            List<Persona> actor=v.Actor;
            Actor = actor;
            List<Persona> director=v.Director;
            Director = director;
            string estudio=v.Estudio;
            Estudio = estudio;
            int resolucion=v.Resolucion;
            Resolucion = resolucion;
            string descripcion=v.Descripcion;
            Descripcion = descripcion;
            int clasificacion=v.Clasificacion;
            Clasificacion = clasificacion;
            string genero=v.Genero;
            Genero = genero;
            return "Cambios actualizados";
        }
    }
}
