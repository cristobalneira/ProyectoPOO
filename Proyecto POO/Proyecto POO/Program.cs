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
using System.Threading;

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

            //Mas barato por docena

            Persona ShawnLevy = new Persona("Shawn Levy", 1, "Estadounidense", new DateTime(1968, 07,23), new List<int> {4});
            Persona SteveMartin = new Persona("Steve Martin", 1, "Canadiense", new DateTime(1945, 08, 14), new List<int> { 3 });
            Persona BonnieHunt = new Persona("Bonnie Hunt", 2, "Estadounidense", new DateTime(1961, 09, 22), new List<int> { 3 });
            Persona PiperPerabo = new Persona("Piper Perabo", 2, "Estadounidense", new DateTime(1976, 10, 31), new List<int> { 3 });

            //Nerve

            Persona HenryJoost = new Persona("Henry Joost", 1, "Estadounidense", new DateTime(1981, 07, 25), new List<int> { 4 });
            Persona EmmaRoberts = new Persona("Emma Roberts", 2, "Estadounidense", new DateTime(1991, 02, 10), new List<int> { 3 });
            Persona DaveFranco = new Persona("Dave Franco", 1, "Estadounidense", new DateTime(1985, 06, 2), new List<int> { 3 });
            Persona JulietteLewis = new Persona("Juliette Lewis", 2, "Estadounidense", new DateTime(1973, 06, 21), new List<int> { 3 });

            //La Cenicienta

            Persona KennethBranagh = new Persona("Kenneth Branagh", 1, "Britanico", new DateTime(1960, 12, 10), new List<int> {4});
            Persona LilyJames = new Persona("Lily James", 2, "Britanica", new DateTime(1989, 04, 05), new List<int> { 3 });
            Persona BenChaplin = new Persona("Ben Chaplin", 1, "Britanico", new DateTime(1969, 07, 31), new List<int> { 3 });
            Persona RichardMadden = new Persona("Richard Madden", 1, "Britanico", new DateTime(1986, 06, 18), new List<int> { 3 });

            //High School Musical

            Persona KennyOrtega = new Persona("Kenny Ortega", 1, "Estadounidense", new DateTime(1950, 04, 18), new List<int> { 4 });
            Persona ZacEfron = new Persona("Zac Efron", 1, "Estadounidense", new DateTime(1987, 10, 18), new List<int> { 3 });
            Persona VanessaHudgens = new Persona("Vanessa Hudgens", 2, "Estadounidense", new DateTime(1988, 12, 14), new List<int> { 3 });
            Persona AshleyTisdale = new Persona("Ashley Tisdale", 2, "Estadounidense", new DateTime(1985, 07, 02), new List<int> { 3 });

            //Son como niños

            Persona DennisDugan = new Persona("Dennis Dugan", 1, "Estadounidense", new DateTime(1946, 09, 05), new List<int> { 4 });
            Persona AdamSandler = new Persona("Adam Sandles", 1, "Estadounidense", new DateTime(1966, 09, 09), new List<int> { 3 });
            Persona KevinJames = new Persona("Kevin James", 1, "Estadounidense", new DateTime(1965, 04, 28), new List<int> { 3 });
            Persona ChrisRock = new Persona("Chris Rock", 1, "Estadounidense", new DateTime(1967, 02, 13), new List<int> { 3 });



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
                new List<Persona> { DripReport}, new List<Persona> { DripReport }, "Skechers", "Imagen", "Letra", "Rap");

            //Peliculas

            Pelicula MasBaratoPorDocena = new Pelicula("Mas Barato Por Docena", 1, new DateTime(2003, 12, 25), new TimeSpan(1,46,0), 10.0, 1,
                "", new List<Persona> {SteveMartin, BonnieHunt, PiperPerabo }, new List<Persona> { ShawnLevy},
                "‎20th Century Fox Home Entertainment", 1, "Descripcion", 1, "Familiar");

            Pelicula Nerve = new Pelicula("Nerve", 1, new DateTime(2016, 09, 01), new TimeSpan(1,36,0), 10.0, 1,
                "", new List<Persona> { EmmaRoberts, DaveFranco, JulietteLewis }, new List<Persona> { HenryJoost },
                "‎Allison Shearmur Productions", 1, "Descripcion", 1, "Accion");

            Pelicula LaCenicienta = new Pelicula("La Cenicienta", 1, new DateTime(2015, 03, 13), new TimeSpan(1, 54, 0), 10.0, 1,
                "", new List<Persona> { LilyJames, BenChaplin, RichardMadden }, new List<Persona> { KennethBranagh },
                "Walt Disney Productions", 1, "Descripcion", 1, "Fantasia");

            Pelicula HighSchoolMusical = new Pelicula("High School Musical", 1, new DateTime(2006, 01, 20), new TimeSpan(1, 38, 0), 10.0, 1,
                "", new List<Persona> {ZacEfron, VanessaHudgens, AshleyTisdale}, new List<Persona> { KennyOrtega },
                "Salty Films", 1, "Descripcion", 1, "Musical");

            Pelicula SonComoNiños = new Pelicula("Son Como Niños", 1, new DateTime(2010, 06, 24), new TimeSpan(1, 42, 0), 10.0, 1,
                "", new List<Persona> { AdamSandler, KevinJames, ChrisRock}, new List<Persona> { DennisDugan },
                "Relativity Media", 1, "Descripcion", 1, "Comedia");



            

            


            Spotflix.Lista_Canciones.Add(Gangstas_paradise);
            Spotflix.Lista_Canciones.Add(Tres_de_abril);
            Spotflix.Lista_Canciones.Add(Keii);
            Spotflix.Lista_Canciones.Add(Follow);
            Spotflix.Lista_Canciones.Add(Skechers);

            Spotflix.Lista_Personas.Add(JustinBieber);
            Spotflix.Lista_Personas.Add(Adele);
            Spotflix.Lista_Personas.Add(Coolio);
            Spotflix.Lista_Personas.Add(Anuel);
            Spotflix.Lista_Personas.Add(Karol_G);
            Spotflix.Lista_Personas.Add(DripReport);


            
            void Agregar_a_temportal(List<Cancion> canciones)
            {
                Spotflix.Temporal.clear();
                foreach (var item in canciones)
                {
                    Spotflix.Temporal.appendItem(new WindowsMediaPlayer().newMedia(item.URL));
                }
            }

            Agregar_a_temportal(Spotflix.Lista_Canciones);
            Spotflix.Reproducir(Spotflix.Temporal);
            int a_1 = -1;
            while (a_1!=0)
            {
                Timer timer = new Timer(TimerCallback, null, 1000, 5000);
                void TimerCallback(Object o)
                {
                    Console.WriteLine(Spotflix.Estado());
                    GC.Collect();
                }
                Console.WriteLine("1 para pausar 2 reanudar 3 adelantar 4 retroceder 0 salir");
                a_1=Convert.ToInt32(Console.ReadLine());
                if (a_1==1)
                {
                    Spotflix.Pausar();
                }
                else if (a_1 == 2)
                {
                    Spotflix.Reanudar();
                }
                else if (a_1==3)
                {
                    Spotflix.Adelantar();
                }
                else if(a_1==4)
                {
                    Spotflix.Retroceder();
                }

            }
            
        }
    }
    
}
