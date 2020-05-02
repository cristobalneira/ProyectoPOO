using System;
using WMPLib;
namespace Proyecto_POO
{
    public class Persona
    {
        public string Nombre_y_Apellido;
        public int Sexo; 
        private string Nacionalidad;
        private int Edad;
        private enum Profesion
        {
            Cantante = 1,
            Compositor = 2,
            Director = 3,
            Actor = 4,
            Locutor = 5
        }


        public Persona(string nombre_y_apellido,int sexo, string nacionalidad, int edad)
        {
            Nombre_y_Apellido = nombre_y_apellido;
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
