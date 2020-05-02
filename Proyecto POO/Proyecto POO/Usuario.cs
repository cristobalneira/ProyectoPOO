using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Proyecto_POO
{
    public class Usuario
    {
        //Atributos:
        public string Nombre;
        public string Apellido;
        public int Edad;
        public enum Sexo
        {
            Hombre,
            Mujer,
            Otro
        }
        public string Pais;
        public string Email;
        public string Contraseña;
        public enum Tipo_de_Membresia
        {
            Gratis,
            Premium
        }

        
        //Metodos:
        public string Informacion_de_Usuario()
        {
            string a = "Nombre: " + Nombre + "\nApellido: " + Apellido + "\nEdad: " + Edad + "\nPais: " + Pais + "\nEmail: " + Email 
                + "\nContraseña: " + Contraseña;
            return (a);
        }
        public string Editar_Informacion(string nombre, string apellido, int edad, string pais, string email, string contraseña)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Pais = pais;
            Email = email;
            Contraseña = contraseña;
            return ("Datos actualizados");
            
        }
    


    }
}
