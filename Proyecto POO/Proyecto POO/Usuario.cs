using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using WMPLib;
using System.Runtime.Serialization;

namespace Proyecto_POO
{
    public enum enum_TipoDeMembresia
    {
        Gratis = 1,
        Premium = 2,
    }
    [Serializable()]
    public class Usuario: ISerializable
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
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Nombre", Nombre);
            info.AddValue("Apellido", Apellido);
            info.AddValue("Fecha_De_Nacimiento", Fecha_De_Nacimiento);
            info.AddValue("Sexo", Sexo);
            info.AddValue("Pais", Pais);
            info.AddValue("Email", Email);
            info.AddValue("Contraseña", Contraseña);
            info.AddValue("Tipo_de_Membresia", Tipo_de_Membresia);
        }
        public Usuario(SerializationInfo info, StreamingContext context)
        {
            Nombre = (string)info.GetValue("Nombre", typeof(string));
            Apellido = (string)info.GetValue("Apellido", typeof(string));
            Fecha_De_Nacimiento = (DateTime)info.GetValue("Fecha_De_Nacimiento", typeof(DateTime));
            Sexo = (int)info.GetValue("Sexo", typeof(int));
            Pais = (string)info.GetValue("Pais", typeof(string));
            Email = (string)info.GetValue("Email", typeof(string));
            Contraseña = (string)info.GetValue("Contraseña", typeof(string));
            Tipo_de_Membresia = (int)info.GetValue("Tipo_de_Membresia", typeof(int));
        }

    }

    
}
