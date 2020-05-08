using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using WMPLib;
using System.IO;


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

            Persona JustinBieber = new Persona("Justin Bieber", 1, "Canadiense", new DateTime(1996, 03, 01), new List<int> {1,2});

            Persona Adele = new Persona("Adele", 2, "Britanica", new DateTime(), new List<int> { 1, 2 });

            Persona Coolio = new Persona("Coolio", 1, "Estadounidense", new DateTime(1963, 08, 01),new List<int> { 1, 2 });

            Cancion Gangstas_paradise = new Cancion("Gangsta's paradise", 1, new DateTime(1995,08,08), new TimeSpan(0,4,0),10.0,2,
                Directory.GetCurrentDirectory() + @"\Musica\Coolio gangstas paradise.wav",
                new List<Persona> {Coolio}, new List<Persona> { Coolio }, "Gangsta's Paradise 2k11","Imagen","Letra","RAP");

            Persona Anuel = new Persona("Anuel AA", 1, "Puertorriqueño", new DateTime(1992, 11, 27), new List<int> { 1, 2 });

            Cancion Tres_de_abril = new Cancion("3 de Abril", 1, new DateTime(2020, 04, 03), new TimeSpan(0, 3, 44), 10.0, 2,
                Directory.GetCurrentDirectory() + @"\Musica\Anuel AA - 3 de abril.wav",
                new List<Persona> { Anuel }, new List<Persona> { Anuel }, "3 de Abril", "Imagen", "Letra", "TRAP");

            Cancion Keii = new Cancion("Keii", 1, new DateTime(2020, 02, 07), new TimeSpan(0, 3, 30), 10.0, 2,
                Directory.GetCurrentDirectory() + @"\Musica\Anuel AA - Keii.wav",
                new List<Persona> { Anuel }, new List<Persona> { Anuel }, "Keii", "Imagen", "Letra", "TRAP");

            Persona Karol_G = new Persona("Karol G", 2, "Colombiana", new DateTime(1991, 02, 14), new List<int> { 1, 2 });

            Cancion Follow = new Cancion("Follow", 1, new DateTime(2020, 04, 01), new TimeSpan(0, 3, 23), 10.0, 2,
                Directory.GetCurrentDirectory() + @"\Musica\KArol G, Anuel AA - Follow.wav",
                new List<Persona> { Karol_G, Anuel }, new List<Persona> { Karol_G}, "Keii", "Imagen", "Letra", "Regueton");

            Persona DripReport = new Persona("DripReport", 1, "Indio", new DateTime(1970, 06, 14), new List<int> { 1, 2 });

            Cancion Skechers = new Cancion("Follow", 1, new DateTime(2020, 01, 12), new TimeSpan(0, 1, 46), 10.0, 2,
                Directory.GetCurrentDirectory() + @"\Musica\DripReport - Skechers.wav",
                new List<Persona> { DripReport}, new List<Persona> { DripReport }, "Skechers", "Imagen", "Letra", "Pop, Rap, Trap");




            Console.WriteLine("Informacion Cantante:");
            Console.WriteLine(Coolio.Informacion_Persona());
            Console.WriteLine("\n\nInformacion Cancion:");
            Console.WriteLine(Gangstas_paradise.Informacion_Cancion());

            Console.WriteLine("Informacion Cantante:");
            Console.WriteLine(Anuel.Informacion_Persona());
            Console.WriteLine("\n\nInformacion Cancion:");
            Console.WriteLine(Tres_de_abril.Informacion_Cancion());
            Console.WriteLine("\n\nInformacion Cancion:");
            Console.WriteLine(Keii.Informacion_Cancion());

            Console.WriteLine("Informacion Cantante:");
            Console.WriteLine(Karol_G.Informacion_Persona());
            Console.WriteLine("\n\nInformacion Cancion:");
            Console.WriteLine(Follow.Informacion_Cancion());

            Console.WriteLine("Informacion Cantante:");
            Console.WriteLine(DripReport.Informacion_Persona());
            Console.WriteLine("\n\nInformacion Cancion:");
            Console.WriteLine(Skechers.Informacion_Cancion());

            Spotflix.Canciones.Objetos.Add(Gangstas_paradise);
            soundPlayer.SoundLocation = Spotflix.Canciones.Objetos[0].URL;
            soundPlayer.Play();



            Console.ReadLine();
        }
    }
    
}
