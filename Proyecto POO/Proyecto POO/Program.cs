using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Proyecto_POO
{
    class Program
    {
        public enum Estado //Del Archivo
        {
            Pausa = 1,
            Reproduciendose = 2
        }
        public enum Sexo// De la persona/usuario.
        {
            Hombre=1,
            Mujer=2
        }
        static void Main(string[] args)
        {
            
            Persona Coolio = new Persona("Coolio", (int)Sexo.Hombre, "Estadounidense", 56);
            Console.WriteLine((Sexo)Coolio.Sexo);
            
            //Cancion Coolio_gangstas_paradise = new Cancion(Coolio gangstas paradise1)
            Console.ReadLine();
        }
    }
}
