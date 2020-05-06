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
        static void Main(string[] args)
        {
            
            
            Persona Coolio1 = new Persona("Coolio", 1, "Estadounidense", new DateTime(1963, 08, 01), 1);
            Persona Coolio2 = new Persona("Coolio", 1, "Estadounidense", new DateTime(1963, 08, 01), 2);
            List<Persona> Cantantes_cancion_1 = new List<Persona>();
            Cantantes_cancion_1.Add(Coolio1);
            List<Persona> Compositores_cancion_1 = new List<Persona>();
            Compositores_cancion_1.Add(Coolio2);


            Cancion cancion_1 = new Cancion("Gangsta's paradise", 1, new DateTime(1995,08,08), new TimeSpan(0,4,0),10.0,2,
                @"C:\Users\juani\Desktop\POO\Prueba\Prueba reproducir video y sonido\Prueba reproducir video y sonido\bin\Debug\Musica",
                Cantantes_cancion_1, Compositores_cancion_1, "Gangsta's Paradise 2k11","Imagen","Letra","RAP");


            Console.WriteLine("Informacion Cantante:");
            Console.WriteLine(Coolio1.Informacion_Persona());
            Console.WriteLine("\n\nInformacion Cancion:");
            Console.WriteLine(cancion_1.Informacion_Cancion());




            Console.ReadLine();
        }
    }
    
}
