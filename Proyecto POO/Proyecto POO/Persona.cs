using System;
using WMPLib;
namespace Proyecto_POO
{
    public class Persona
    {
        public enum enum_Sexo// De la persona/usuario.
        {
            Hombre = 1,
            Mujer = 2
        }
        public enum enum_Profesion
        {
            Cantante = 1,
            Compositor = 2,
            Actor = 3,
            Director = 4,
            Locutor = 5,
            Lector = 6
        }
        //Atributos

        public string Nombre_y_Apellido;
        public int Sexo; 
        public string Nacionalidad;
        public DateTime Fecha_De_Nacimiento;
        public int Profesion;

        //Constructor

        public Persona(string nombre_y_Apellido, int sexo, string nacionalidad, DateTime fecha_de_nacimiento, int profesion)
        {
            Nombre_y_Apellido = nombre_y_Apellido;
            Sexo = sexo;
            Nacionalidad = nacionalidad;
            Fecha_De_Nacimiento = fecha_de_nacimiento;
            Profesion = profesion;
        }

        public string Informacion_Persona()
        {
            string datos = "Nombre: " + Nombre_y_Apellido + "\nSexo: " + (enum_Sexo)Sexo + "\nNacionalidad: " + Nacionalidad +
                "\nFecha de nacimiento: " + Fecha_De_Nacimiento.ToString("dd, MMMM, yyyy") + "\nProfesion: " + (enum_Profesion)Profesion;
            return datos;
        }

    }
}
