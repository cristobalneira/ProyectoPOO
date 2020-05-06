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
        //Editar informacion:
        public string Editar_infromacion(List<string> info_audiolibro)
        {
            Titulo = info_audiolibro[0];
            Categoria = Convert.ToInt32(info_audiolibro[1]);
            Año = Convert.ToDateTime(info_audiolibro[2]);
            Duracion = info_audiolibro[3];
            Ranking = info_audiolibro[4];
            Estado = info_audiolibro[5];
            URL = info_audiolibro[6];
            Genero = info_audiolibro[7];
            Idioma = info_audiolibro[8];
            Lector = info_audiolibro[9];
            string a = "Cambios actualizados";
            return a;
        }
        public string Informacion_Audiolibro()
        {
            string datos = "Titulo: " + Titulo + "\nCategoria: " + Categoria + "\nAño: " + Año +
                "\nDuracion: " + Duracion + "\nRanking: " + Ranking + "\nGenero: " + Genero + "\nIdioma: " + Idioma + "\nLector: " + Lector;
            return datos;
        }
       

    }
}
