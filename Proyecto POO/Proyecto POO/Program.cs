﻿using System;
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
            Persona ShawnLevy = new Persona("Shawn Levy", 1, "Estadounidense", new DateTime(1968, 07, 23), new List<int> { 4 });
            Persona SteveMartin = new Persona("Steve Martin", 1, "Canadiense", new DateTime(1945, 08, 14), new List<int> { 3 });
            Persona BonnieHunt = new Persona("Bonnie Hunt", 2, "Estadounidense", new DateTime(1961, 09, 22), new List<int> { 3 });
            Persona PiperPerabo = new Persona("Piper Perabo", 2, "Estadounidense", new DateTime(1976, 10, 31), new List<int> { 3 });

            //Nerve

            Persona HenryJoost = new Persona("Henry Joost", 1, "Estadounidense", new DateTime(1981, 07, 25), new List<int> { 4 });
            Persona EmmaRoberts = new Persona("Emma Roberts", 2, "Estadounidense", new DateTime(1991, 02, 10), new List<int> { 3 });
            Persona DaveFranco = new Persona("Dave Franco", 1, "Estadounidense", new DateTime(1985, 06, 2), new List<int> { 3 });
            Persona JulietteLewis = new Persona("Juliette Lewis", 2, "Estadounidense", new DateTime(1973, 06, 21), new List<int> { 3 });

            //La Cenicienta

            Persona KennethBranagh = new Persona("Kenneth Branagh", 1, "Britanico", new DateTime(1960, 12, 10), new List<int> { 4 });
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



            Persona JustinBieber = new Persona("Justin Bieber", 1, "Canadiense", new DateTime(1996, 03, 01), new List<int> { 1, 2 });
            Persona Adele = new Persona("Adele", 2, "Britanica", new DateTime(), new List<int> { 1, 2 });
            Persona Coolio = new Persona("Coolio", 1, "Estadounidense", new DateTime(1963, 08, 01), new List<int> { 1, 2 });
            Persona Anuel = new Persona("Anuel AA", 1, "Puertorriqueño", new DateTime(1992, 11, 27), new List<int> { 1, 2 });
            Persona Karol_G = new Persona("Karol G", 2, "Colombiana", new DateTime(1991, 02, 14), new List<int> { 1, 2 });
            Persona DripReport = new Persona("DripReport", 1, "Indio", new DateTime(1970, 06, 14), new List<int> { 1, 2 });



            //Canciones:
            Cancion Gangstas_paradise = new Cancion("Gangsta's paradise", 1, new DateTime(1995, 08, 08), TimeSpan.Zero, 10.0, 2,
                Directory.GetCurrentDirectory() + @"\Musica\Coolio - gangstas paradise.wav",
                new List<Persona> { Coolio }, new List<Persona> { Coolio }, "Gangsta's Paradise 2k11", "Imagen", "Letra", "RAP");
            Cancion Tres_de_abril = new Cancion("3 de Abril", 1, new DateTime(2020, 04, 03), TimeSpan.Zero, 10.0, 2,
                Directory.GetCurrentDirectory() + @"\Musica\Anuel AA - 3 de abril.wav",
                new List<Persona> { Anuel }, new List<Persona> { Anuel }, "3 de Abril", "Imagen", "Letra", "TRAP");
            Cancion Keii = new Cancion("Keii", 1, new DateTime(2020, 02, 07), TimeSpan.Zero, 10.0, 2,
                Directory.GetCurrentDirectory() + @"\Musica\Anuel AA - Keii.wav",
                new List<Persona> { Anuel }, new List<Persona> { Anuel }, "Keii", "Imagen", "Letra", "TRAP");
            Cancion Follow = new Cancion("Follow", 1, new DateTime(2020, 04, 01), TimeSpan.Zero, 10.0, 2,
                Directory.GetCurrentDirectory() + @"\Musica\KArol G, Anuel AA - Follow.wav",
                new List<Persona> { Karol_G, Anuel }, new List<Persona> { Karol_G }, "Keii", "Imagen", "Letra", "Regueton");
            Cancion Skechers = new Cancion("Skechers", 1, new DateTime(2020, 01, 12), TimeSpan.Zero, 10.0, 2,
                Directory.GetCurrentDirectory() + @"\Musica\DripReport - Skechers.wav",
                new List<Persona> { DripReport }, new List<Persona> { DripReport }, "Skechers", "Imagen", "Letra", "Rap");

            //Peliculas

            Pelicula MasBaratoPorDocena = new Pelicula("Mas Barato Por Docena", 1, new DateTime(2003, 12, 25), new TimeSpan(1, 46, 0), 10.0, 1,
                Directory.GetCurrentDirectory() + @"\Peliculas\Mas Barato por Docena - Trailer.mp4", new List<Persona> { SteveMartin, BonnieHunt, PiperPerabo }, new List<Persona> { ShawnLevy },
                "‎20th Century Fox Home Entertainment", 1, "Descripcion", 1, "Familiar");

            Pelicula Nerve = new Pelicula("Nerve", 1, new DateTime(2016, 09, 01), new TimeSpan(1, 36, 0), 10.0, 1,
                Directory.GetCurrentDirectory() + @"\Peliculas\Nerve - Trailer Oficial.mp4", new List<Persona> { EmmaRoberts, DaveFranco, JulietteLewis }, new List<Persona> { HenryJoost },
                "‎Allison Shearmur Productions", 1, "Descripcion", 1, "Accion");

            Pelicula LaCenicienta = new Pelicula("La Cenicienta", 1, new DateTime(2015, 03, 13), new TimeSpan(1, 54, 0), 10.0, 1,
                Directory.GetCurrentDirectory() + @"\Peliculas\La Cenicienta - Trailer Oficial.mp4", new List<Persona> { LilyJames, BenChaplin, RichardMadden }, new List<Persona> { KennethBranagh },
                "Walt Disney Productions", 1, "Descripcion", 1, "Fantasia");

            Pelicula HighSchoolMusical = new Pelicula("High School Musical", 1, new DateTime(2006, 01, 20), new TimeSpan(1, 38, 0), 10.0, 1,
                Directory.GetCurrentDirectory() + @"\Peliculas\High School Musical – Original Trailer.mp4", new List<Persona> { ZacEfron, VanessaHudgens, AshleyTisdale }, new List<Persona> { KennyOrtega },
                "Salty Films", 1, "Descripcion", 1, "Musical");

            Pelicula SonComoNiños = new Pelicula("Son Como Niños", 1, new DateTime(2010, 06, 24), new TimeSpan(1, 42, 0), 10.0, 1,
                Directory.GetCurrentDirectory() + @"\Peliculas\Son como Niños - Trailer Oficial.mp4", new List<Persona> { AdamSandler, KevinJames, ChrisRock }, new List<Persona> { DennisDugan },
                "Relativity Media", 1, "Descripcion", 1, "Comedia");


            // Audiolibros
            Persona Neira = new Persona("Neira", 1, "Española", new DateTime(1998, 2, 2), new List<int> { 6});
            AudioLibro Azafata_Chistosa = new AudioLibro("Azafata chistosa", 3, new DateTime(2020, 05, 11), TimeSpan.Zero, 10.0, 2,
                Directory.GetCurrentDirectory() + @"\Audio libros\Azafata Chistosa\Azafata chistosa.mp3", 
                Directory.GetCurrentDirectory() + @"\Audio libros\Azafata Chistosa\Azafata chistosa.txt", "Comedia", 1, Neira);
            AudioLibro Hijo_Huerfano = new AudioLibro("Hijo huerfano", 3, new DateTime(2020, 05, 11), TimeSpan.Zero, 10.0, 2,
                Directory.GetCurrentDirectory() + @"\Audio libros\Hijo Huerfano\Hijo huerfano.mp3",
                Directory.GetCurrentDirectory() + @"\Audio libros\Hijo Huerfano\Hijo huerfano.txt", "Comedia", 1, Neira);


            Spotflix.Lista_AudioLibros.Add(Azafata_Chistosa);
            Spotflix.Lista_AudioLibros.Add(Hijo_Huerfano);


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




            Console.WriteLine("1 audio libro 0 salir");
            int a_321 = -1;
            a_321 = Convert.ToInt32(Console.ReadLine());
            if (a_321 == 1)
            {
                for (int i = 0; i < Spotflix.Lista_AudioLibros.Count; i++)
                {
                    Console.WriteLine(i+1+". "+Spotflix.Lista_AudioLibros[i].Titulo);
                }
                int a_21 = Convert.ToInt32(Console.ReadLine());
                Spotflix.Temporal.clear();
                Spotflix.Temporal.appendItem(new WindowsMediaPlayer().newMedia(Spotflix.Lista_AudioLibros[a_21-1].URL));
                Spotflix.Reproducir(Spotflix.Temporal);
                Thread.Sleep(1000);
                string[] texto = File.ReadAllLines(Spotflix.Lista_AudioLibros[a_21 - 1].URL_Texto);
                foreach (string line in texto)
                {
                    Console.WriteLine("\t"+line);
                    Thread.Sleep(5000);
                }

            }        

            
            //Spotflix.spotflix.openPlayer(Nerve.URL);
           

            

            //Agregar_a_temportal(Spotflix.Lista_Canciones);
            //Spotflix.Reproducir(Spotflix.Temporal);
            int a_1 = -1;


            ////////////////MENU////////////////////////
            ///
            Console.WriteLine("Bienvenidos a Spotiflix!");
            Usuario usuarioenlinea = new Usuario();
            DateTime now = DateTime.Now;
            Console.WriteLine(": {0} hrs ; {1} mins ; {2} secs", now.Hour, now.Minute, now.Second);
            Console.WriteLine("Iniciar session:");
            Console.WriteLine("Tiene cuenta? [0] si, [1] no");
            int usuario = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            if (usuario != 0 && usuario != 1)
            {
                while (usuario != 0 && usuario != 1)
                {
                    Console.WriteLine("Error, introduzca informacion valida!");
                    Console.WriteLine("Tiene cuenta? [0] si, [1] no");
                    a = Convert.ToInt32(Console.ReadLine());
                    usuario = a;
                }
            }
            else if (usuario == 0)
            {
                Console.WriteLine("Nombre de usuario:");
                string nombreusuario = Console.ReadLine();
                Console.WriteLine("Contraseña:");
                string contraseñausuario = Console.ReadLine();
                foreach (var item in Spotflix.Lista_Usuarios)
                {
                    if (nombreusuario == item.Nombre && contraseñausuario == item.Contraseña)
                    {
                        Console.WriteLine("Ingresando a sesion!");
                        Thread.Sleep(2000);
                        usuarioenlinea = item;
                        int verperfiles = 1;
                        List<Perfil> perfilesdeusuario = new List<Perfil>();
                        foreach (var item2 in Spotflix.Lista_Perfiles)
                        {
                            if (item2.Usuario_Asociado == usuarioenlinea)
                            {
                                Console.WriteLine("Perfil " + verperfiles);
                                perfilesdeusuario.Add(item2);
                                verperfiles += 1;
                            }
                        }
                        if (verperfiles == 1)
                        {
                            Console.WriteLine("No hay perfiles en su usuario, creando uno!");
                            Console.WriteLine("Su nombre de perfil:");
                            string nperfil = Console.ReadLine();
                            int tipoperf = 1;
                            Perfil perfilenlinea = new Perfil(item, nperfil, tipoperf);
                            Spotflix.Lista_Perfiles.Add(perfilenlinea);
                            Console.WriteLine("Perfil creado");
                        }
                        else
                        {
                            int c_1 = 1;
                            Console.WriteLine("Perfil/es:");
                            foreach (var item3 in perfilesdeusuario)
                            {
                                Console.WriteLine(c_1 + " " + item.Nombre);
                                c_1 += 1;
                            }
                            Console.WriteLine("A cual perfil deseas ingresar?");
                            int perfilingresar = Convert.ToInt32(Console.ReadLine());
                            Perfil perfilenlinea = perfilesdeusuario[c_1 - 1];
                        }

                        break;
                    }
                }
            }
            else if (usuario == 1)
            {
                Console.WriteLine("Creando su propia cuenta!");
                Console.WriteLine("Su nombrede usuario:");
                string nomb = Console.ReadLine();
                Console.WriteLine("Su apellido:");
                string apell = Console.ReadLine();
                Console.WriteLine("Su fecha de nacimiento:[DDMMAAAA]");
                string date = Console.ReadLine();
                int ano = date[4] + date[5] + date[6] + date[7];
                int mes = date[2] + date[3];
                int dia = date[0] + date[1];
                DateTime dt = new DateTime(ano, mes, dia);
                Console.WriteLine("Su sexo:");
                int sex = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Su pais:");
                string pais = Console.ReadLine();
                Console.WriteLine("Su email:");
                string email = Console.ReadLine();
                Console.WriteLine("Su contraseña:");
                string contra = Console.ReadLine();
                Console.WriteLine("Su contraseña nuevamente:");
                string contra2 = Console.ReadLine();
                if (contra != contra2)
                {
                    Console.WriteLine("Distintas contraseñas! Ultima vez y acuerdese!");
                    contra = Console.ReadLine();
                }
                int tipomemb = 1;
                Usuario u = new Usuario(nomb, apell, dt, sex, pais, email, contra, tipomemb);
                Spotflix.Lista_Usuarios.Add(u);
                Console.WriteLine("Usuario creado, ahora creando su propio perfil");
                Console.WriteLine("Su nombre de perfil:");
                string nperfil = Console.ReadLine();
                int tipoperf = 1;
                Perfil perfilenlinea = new Perfil(u, nperfil, tipoperf);
                Spotflix.Lista_Perfiles.Add(perfilenlinea);
                Console.WriteLine("Perfil creado");
                Console.Clear();
                Console.WriteLine("Que desea hacer?");
                Console.WriteLine("1. Reproducir multimedia, 2. Buscar/seguir, 3. EditarInfo, 4. Agregar Archivo, 0 Salir");
                int b = Convert.ToInt32(Console.ReadLine());
                if (b == 1)
                {
                    while (a_1 != 0)
                    {
                        Timer timer = new Timer(TimerCallback, null, 1000, 5000);
                        void TimerCallback(Object o)
                        {
                            Console.WriteLine(Spotflix.Estado());
                            GC.Collect();
                        }
                        Console.WriteLine("1 para pausar 2 reanudar 3 adelantar 4 retroceder 0 salir");
                        a_1 = Convert.ToInt32(Console.ReadLine());
                        if (a_1 == 1)
                        {
                            Spotflix.Pausar();
                        }
                        else if (a_1 == 2)
                        {
                            Spotflix.Reanudar();
                        }
                        else if (a_1 == 3)
                        {
                            Spotflix.Adelantar();
                        }
                        else if (a_1 == 4)
                        {
                            Spotflix.Retroceder();
                        }
                    }
                }
                else if (b == 2)
                {
                    //Buscar
                }
                else if (b == 3)
                {
                    int tipoperfil=perfilenlinea.Tipo_de_Perfil;
                    if (tipoperfil == 3)
                    {
                        Interaccion_Usuario.Editar_Informacion_Admin();
                    }
                    else
                    {
                        Interaccion_Usuario.Editar_Informacion_Usuario(usuarioenlinea);
                    }
                }
                else if (b == 4)
                {
                    //Agregar Archivo
                }
                else
                {
                    b = 0;
                }
            }
        }
    }
    
}
