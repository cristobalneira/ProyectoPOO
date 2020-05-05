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
        public int Tipo_de_Membresia;

        public string Editar_Informacion(string nombre, string apellido, int edad, string pais, string email, string contraseña)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Pais = pais;
            Email = email;
            Contraseña = contraseña;
            Tipo_de_Membresia = tipo_de_membresia; 
        
        }
        
      
    
}

    
}

    
}

    
}

    
}

    
}

    
}

    
}

    
}

    
}
