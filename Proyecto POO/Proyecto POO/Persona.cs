using System;
using WMPLib;
namespace Proyecto_POO
{
    public class Persona
    {
        public string Nombre;
        public string Apellido;
        private string Sexo;
        private string Nacionalidad;
        private int Edad;
        private enum Profesion
        {
            Cantante = 1,
            Compositor = 2,
            Director = 3,
            Actor = 4,
            Locutor = 5,
        }


        public Persona(string nombre, string apellido, string sexo, string nacionalidad, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Sexo = sexo;
            Nacionalidad = nacionalidad;
            Edad = edad;
        }

        public string Informacion_Persona()
        {
            return " ";
        }
    }
}
