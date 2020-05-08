using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using WMPLib;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.ComponentModel;
using System.Runtime.InteropServices;

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
            
            //SoundPlayer soundPlayer = new SoundPlayer();
            
            //Personas: 
            Persona JustinBieber = new Persona("Justin Bieber", 1, "Canadiense", new DateTime(1996, 03, 01), new List<int> {1,2});
            Persona Adele = new Persona("Adele", 2, "Britanica", new DateTime(), new List<int> { 1, 2 });
            Persona Coolio = new Persona("Coolio", 1, "Estadounidense", new DateTime(1963, 08, 01),new List<int> { 1, 2 });
            Persona Anuel = new Persona("Anuel AA", 1, "Puertorriqueño", new DateTime(1992, 11, 27), new List<int> { 1, 2 });
            Persona Karol_G = new Persona("Karol G", 2, "Colombiana", new DateTime(1991, 02, 14), new List<int> { 1, 2 });
            Persona DripReport = new Persona("DripReport", 1, "Indio", new DateTime(1970, 06, 14), new List<int> { 1, 2 });

            //Canciones:
            Cancion Gangstas_paradise = new Cancion("Gangsta's paradise", 1, new DateTime(1995,08,08), TimeSpan.Zero, 10.0,2,
                Directory.GetCurrentDirectory() + @"\Musica\Coolio - gangstas paradise.wav",
                new List<Persona> {Coolio}, new List<Persona> { Coolio }, "Gangsta's Paradise 2k11","Imagen","Letra","RAP");
            Cancion Tres_de_abril = new Cancion("3 de Abril", 1, new DateTime(2020, 04, 03), TimeSpan.Zero, 10.0, 2,
                Directory.GetCurrentDirectory() + @"\Musica\Anuel AA - 3 de abril.wav",
                new List<Persona> { Anuel }, new List<Persona> { Anuel }, "3 de Abril", "Imagen", "Letra", "TRAP");
            Cancion Keii = new Cancion("Keii", 1, new DateTime(2020, 02, 07), TimeSpan.Zero, 10.0, 2,
                Directory.GetCurrentDirectory() + @"\Musica\Anuel AA - Keii.wav",
                new List<Persona> { Anuel }, new List<Persona> { Anuel }, "Keii", "Imagen", "Letra", "TRAP");
            Cancion Follow = new Cancion("Follow", 1, new DateTime(2020, 04, 01), TimeSpan.Zero, 10.0, 2,
                Directory.GetCurrentDirectory() + @"\Musica\KArol G, Anuel AA - Follow.wav",
                new List<Persona> { Karol_G, Anuel }, new List<Persona> { Karol_G}, "Keii", "Imagen", "Letra", "Regueton");
            Cancion Skechers = new Cancion("Skechers", 1, new DateTime(2020, 01, 12), TimeSpan.Zero, 10.0, 2,
                Directory.GetCurrentDirectory() + @"\Musica\DripReport - Skechers.wav",
                new List<Persona> { DripReport}, new List<Persona> { DripReport }, "Skechers", "Imagen", "Letra", "Pop, Rap, Trap");


            
            Spotflix.Canciones.Objetos.Add(Gangstas_paradise);
            Spotflix.Canciones.Objetos.Add(Tres_de_abril);
            Spotflix.Canciones.Objetos.Add(Keii);
            Spotflix.Canciones.Objetos.Add(Follow);
            Spotflix.Canciones.Objetos.Add(Skechers);


            Console.WriteLine(Spotflix.Reproducir(Spotflix.Canciones));
            int a_1 = -1;
            while (a_1!=0)
            {
                
                Console.WriteLine("1 para pausar 2 reanudar 3 adelantar 4 retroceder 0 salir");
                a_1=Convert.ToInt32(Console.ReadLine());
                if (a_1==1)
                {
                    Console.WriteLine(Spotflix.Pausar());
                }
                else if (a_1 == 2)
                {
                    Console.WriteLine(Spotflix.Reanudar());
                }
                else if (a_1==3)
                {
                    Console.WriteLine(Spotflix.Adelantar());
                }
                else if(a_1==4)
                {
                    Console.WriteLine(Spotflix.Retroceder());
                }

            }
            
        }
    }
    
}
