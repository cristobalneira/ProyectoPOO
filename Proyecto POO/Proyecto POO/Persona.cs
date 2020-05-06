using System;
using WMPLib;
namespace Proyecto_POO
{
    public class Persona
    {
        public string Nombre_y_Apellido;
        public int Sexo; 
        public string Nacionalidad;
        public DateTime Edad;
        public int Profesion;

        public Persona(string nombre_y_Apellido, int sexo, string nacionalidad, DateTime edad, int profesion)
        {
            Nombre_y_Apellido = nombre_y_Apellido;
            Sexo = sexo;
            Nacionalidad = nacionalidad;
            Edad = edad;
            Profesion = profesion;
        }

    }
}
