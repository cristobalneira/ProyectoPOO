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
        private enum Genero { };

        public Cancion()
        {
        }
         public string Informacion_Cancion()
        {
            return " ";
        }

    }
}
