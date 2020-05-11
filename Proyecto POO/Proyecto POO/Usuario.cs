using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Proyecto_POO
{
    public enum enum_TipoDeMembresia
    {
        Gratis = 1,
        Premium = 2,
    }
    public class Usuario
    {
        //Atributos:

        public string Nombre;
        public string Apellido;
        public DateTime Fecha_De_Nacimiento;
        public int Sexo;
        public string Pais;
        public string Email;
        public string Contraseña;
        public int Tipo_de_Membresia;
        //Constructor:
        public Usuario(){}
        public Usuario(string nombre, string apellido, DateTime fecha_de_nacimiento , int sexo, string pais, string email, string contraseña, int tipo_de_Membresia)
        {
            Nombre = nombre;
            Apellido = apellido;
            Fecha_De_Nacimiento = fecha_de_nacimiento;
            Sexo = sexo;
            Pais = pais;
            Email = email;
            Contraseña = contraseña;
            Tipo_de_Membresia = tipo_de_Membresia;
        }
        //Mostrar Info:

        public string Informacion_Usuario()
        {
            string datos = "Nombre: " + Nombre + " " + Apellido + "\nFecha de nacimiento: " + Fecha_De_Nacimiento +
                "\nSexo: " + Sexo + "\nPais: " + Pais + "\nEmail: " + Email + "\nContraseña: " + Contraseña +
                "\nTipo de membresia: " + (enum_TipoDeMembresia)Tipo_de_Membresia;
            return datos;
        }

        public string Editar_Informacion(Usuario u)
        {
            string nombre=u.Nombre;
            Nombre = nombre;
            string apellido=u.Apellido;
            Apellido = apellido;
            DateTime fecha= u.Fecha_De_Nacimiento;
            Fecha_De_Nacimiento = fecha;
            int sexo=u.Sexo;
            Sexo = sexo;
            string pais=u.Pais;
            Pais = pais;
            string email=u.Email;
            Email = email;
            string contraseña=u.Contraseña;
            Contraseña = contraseña;
            int memb=u.Tipo_de_Membresia;
            Tipo_de_Membresia = memb;
            return "Cambios actualizados";
    }
    }

    
}
