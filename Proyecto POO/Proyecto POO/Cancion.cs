using System;
using System.Collections.Generic;

namespace Proyecto_POO
{
    public class Cancion
    {
        private List<Persona> Cantante;
        private List<Persona> Compositor;
        private string Album;
        private string Imagen;
        private string Letra;
        private enum Genero
        {
            Pop = 1,
            Rock = 2,
            Country = 3,
            Electronica = 4,
            Jazz = 5,
            Dubstep = 6,
            RythmAndBlues = 7,
            Techno = 8,
            HipHop = 9,
            HeavyMetal = 10,
            Clasica = 11,
            IndieRock = 12,

        };

        public Cancion(List<Persona> cantante, List<Persona> compositor, string album, string letra)
        {
            List<Persona> Cantante = cantante;
            List<Persona> Compositor = compositor;
            Album = album;
            Letra = letra;
        }
         public string Informacion_Cancion()
        {
            return " ";
        }

    }
}
