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
        //Constructor:
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
        //Informacion_Cancion:
        public string Informacion_Cancion()
        {
            string a = "Titulo: " + Titulo + "\nCategoria: " + Categoria + "\nAño: " + Año.ToString("dd, MM, yyyy") + "\nDuracion: " + Duracion + "\nRanking: " + Ranking;
            a+= "\nCantante(s): ";
            int i_1 = 1;
            foreach (var item in Cantante)
            {
                a +=i_1+": " + item.Nombre_y_Apellido;
                i_1+=1;
            }
            a += "\nCompositor(es): ";
            int i_2 = 1;
            foreach (var item in Compositor)
            {
                a += i_2 + ": " + item.Nombre_y_Apellido;
                i_2 += 1;
            }
            a += "\nAlbum: " + Album + "\nImagen: " + Imagen + "\nLetra: " + Letra + "\nGenero: " + Genero;
            return a;
        }
        public string Editar_Informacion(Cancion c)
        {
            string titulo = c.Titulo;
            Titulo = titulo;
            int categoria = c.Categoria;
            Categoria = categoria;
            DateTime año = c.Año;
            Año = año;
            TimeSpan duracion = c.Duracion;
            Duracion = duracion;
            double ranking = c.Ranking;
            Ranking = ranking;
            int estado = c.Estado;
            Estado = estado;
            string url = c.URL;
            URL = url;
            List<Persona> cantante = c.Cantante;
            Cantante = cantante;
            List<Persona> compositor = c.Compositor;
            Compositor = compositor;
            string album= c.Album;
            Album = album;
            string imagen=c.Imagen;
            Imagen = imagen;
            string letra=c.Letra;
            Letra = letra;
            string genero=c.Genero;
            Genero = genero;
            return "Cambios actualizados";
        }
        

    }
}
