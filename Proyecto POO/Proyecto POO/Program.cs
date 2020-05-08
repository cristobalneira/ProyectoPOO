using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Media;
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
            SoundPlayer soundPlayer = new SoundPlayer();


            Persona Coolio = new Persona("Coolio", 1, "Estadounidense", new DateTime(1963, 08, 01),new List<int> { 1, 2 });
            Cancion Gangstas_paradise = new Cancion("Gangsta's paradise", 1, new DateTime(1995,08,08), new TimeSpan(0,4,0),10.0,2,
                @"C:\Users\juani\Desktop\POO\Prueba\Prueba reproducir video y sonido\Prueba reproducir video y sonido\bin\Debug\Musica\Coolio gangstas paradise1.wav",
                new List<Persona> {Coolio}, new List<Persona> { Coolio }, "Gangsta's Paradise 2k11","Imagen","Letra","RAP");




            Console.WriteLine("Informacion Cantante:");
            Console.WriteLine(Coolio.Informacion_Persona());
            Console.WriteLine("\n\nInformacion Cancion:");
            Console.WriteLine(Gangstas_paradise.Informacion_Cancion());


            Spotflix.Canciones.Objetos.Add(Gangstas_paradise);
            soundPlayer.SoundLocation = Spotflix.Canciones.Objetos[0].URL;
            soundPlayer.Play();



            Console.ReadLine();
        }
    }
    
}
