using System;
using System.Collections.Generic;
namespace Proyecto_POO
{
    public class Pelicula : Archivo
    {
        public List <Persona> actores;
        public List<Persona> directores;
        public string estudio;
        public string descripcion;
        public enum resolucion
        {
            Muybaja = 144,
            Baja= 360,
            Media =480,
            Alta=720,
            Muyalta=1080,
        }
        public int ano;
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
        public Pelicula(string titulo, string estudio, int ano, TimeSpan duracion) //falta genero
        {
            this.titulo = titulo;
            this.estudio = estudio;
            this.ano = ano;
            this.titulo = titulo;
            this.ano = ano;
        }
        public string Informacion_Pelicula()//falta genero en print
		{
            string actoreS = "";
            string directoreS = "";
            for (int i = 0; i < actores.Count; i++)
            {
                Persona persona = actores[i];
                actoreS += persona.Nombre + " "+ persona.Apellido+ ", ";
            }
            for (int i = 0; i < directores.Count; i++)
            {
                Persona persona = directores[i];
                directoreS += persona.Nombre + " " + persona.Apellido + ", ";
            }
            string a = "Titulo: " + titulo + ", Actores: "+actoreS+ ", Directores: " +directoreS+", Estudio "+estudio+", Genero: , Ano: "+ano+", Duracion: "+duracion+", Ranking: "+ranking+".";
            return a;
        }
    }
}
