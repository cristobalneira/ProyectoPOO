using System;
using System.Collections.Generic;
using WMPLib;

namespace Proyecto_POO
{
    public class Podcast : Archivo
    {
        private List<Persona> Locutor;
        private string Imagen;
        private enum Genero
        {
            //chistes, historias divertidas
            Comedia = 0,
            //canciones, peliculas entre otros de los años 70, 80, 90
            Epocas = 1,
            //historias del mundo
            Historia = 2,
            //historias de viaje
            Bitacora = 3,
            //economia del mundo 
            Economia = 4,
            //noticias de los artistas mas famosos
            Artistas = 5,

        };

        public Podcast(List<Persona> locutor)
        {

            List<Persona> Locutor = locutor;
        }

        public string Informacion_Podcast()
        {
            return " ";
        }
    }
}
