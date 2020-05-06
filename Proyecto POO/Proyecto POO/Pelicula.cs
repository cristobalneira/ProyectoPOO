using System;
using System.Collections.Generic;
using WMPLib;
namespace Proyecto_POO
{
    public class Pelicula : Archivo
    {
        public List <Persona> Actores;
        public List<Persona> Directores;
        public string Estudio;
        public string Descripcion;
        public int Resolucion;
        public int Clasificacion;
        public string Genero;

        

        public Pelicula(string titulo, int categoria, DateTime año, TimeSpan duracion, double ranking,
            int estado, string url, List<Persona> actores, List<Persona> directores, string estudio,
            string descripcion, int resolucion, int clasificacion, string genero)
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
            Descripcion = descripcion;
            Resolucion = resolucion;
            Clasificacion = clasificacion;
            Genero = genero;
            
        }

        public string Informacion_Pelicula()//falta genero en print
		{
            string actoreS = "";
            string directoreS = "";
            for (int i = 0; i < Actores.Count; i++)
            {
                Persona persona = Actores[i];
                actoreS += persona.Nombre_y_Apellido+ ", ";
            }
            for (int i = 0; i < Directores.Count; i++)
            {
                Persona persona = Directores[i];
                directoreS += persona.Nombre_y_Apellido + ", ";
            }
            string a = "Titulo: " + Titulo + ", Actores: "+actoreS+ ", Directores: " +directoreS+", Estudio "+Estudio+", Genero: , Ano: "+ Año+", Duracion: "+Duracion+", Ranking: "+Ranking+".";
            return a;
        }
    }
}
