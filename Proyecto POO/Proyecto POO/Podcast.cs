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

        public string Informacion_Podcast()
        {
            string datos = "Titulo: " + Titulo + "\nCategoria: " + (enum_Categoria)Categoria + "\nAño: " + Año + "\nDuracion: " + Duracion +
                "\nRanking: " + Ranking;

            datos += "\nLocutor: ";

            int i_1 = 1;
            foreach (var item in Locutor)
            {
                datos += i_1 + ". " + item.Nombre_y_Apellido;
                i_1 += 1;
            }

            datos += "\nImagen: " + Imagen + "\nGenero: " + Genero;

            return datos;
        }
        public string Editar_Informacion(Podcast p)
        {
            string titulo = p.Titulo;
            Titulo = titulo;
            int categoria = p.Categoria;
            Categoria = categoria;
            DateTime año = p.Año;
            Año = año;
            TimeSpan duracion = p.Duracion;
            Duracion = duracion;
            double ranking = p.Ranking;
            Ranking = ranking;
            int estado = p.Estado;
            Estado = estado;
            string url = p.URL;
            URL = url;
            List<Persona> locutor=p.Locutor;
            Locutor = locutor;
            string imagen=p.Imagen;
            Imagen = imagen;
            string genero=p.Genero;
            Genero = genero;
            return "Cambios actualizados";

        }

    }
}
