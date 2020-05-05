using System;
using System.Collections.Generic;
using WMPLib;
namespace Proyecto_POO
{
    public class Pelicula : Archivo
    {
        public List <Persona> actores;
        public List<Persona> directores;
        public string estudio;
        public string descripcion;
        public int resolucion;
        
            Romance = 10,
        }
        public Pelicula(string titulo, string estudio, int ano, TimeSpan duracion) //falta genero
        {
            this.Titulo = titulo;
            this.estudio = estudio;
            this.ano = ano;
            this.Titulo = titulo;
            this.ano = ano;
        }
        public string Informacion_Pelicula()//falta genero en print
		{
            string actoreS = "";
            string directoreS = "";
            for (int i = 0; i < actores.Count; i++)
            {
                Persona persona = actores[i];
                actoreS += persona.Nombre_y_Apellido+ ", ";
            }
            for (int i = 0; i < directores.Count; i++)
            {
                Persona persona = directores[i];
                directoreS += persona.Nombre_y_Apellido + ", ";
            }
            string a = "Titulo: " + Titulo + ", Actores: "+actoreS+ ", Directores: " +directoreS+", Estudio "+estudio+", Genero: , Ano: "+ano+", Duracion: "+duracion+", Ranking: "+ranking+".";
            return a;
        }
    }
}
