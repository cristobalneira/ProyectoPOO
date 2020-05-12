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
            //Crear Personas:
            Persona Bad_Bunny = new Persona("Bad bunny", 1, "Puertorriqueño", new DateTime(1994, 03, 10), new List<int> { 1, 2 });
            Persona ShawnLevy = new Persona("Shawn Levy", 1, "Estadounidense", new DateTime(1968, 07, 23), new List<int> { 4 });
            Persona SteveMartin = new Persona("Steve Martin", 1, "Canadiense", new DateTime(1945, 08, 14), new List<int> { 3 });
            Persona BonnieHunt = new Persona("Bonnie Hunt", 2, "Estadounidense", new DateTime(1961, 09, 22), new List<int> { 3 });
            Persona PiperPerabo = new Persona("Piper Perabo", 2, "Estadounidense", new DateTime(1976, 10, 31), new List<int> { 3 });
            Persona HenryJoost = new Persona("Henry Joost", 1, "Estadounidense", new DateTime(1981, 07, 25), new List<int> { 4 });
            Persona EmmaRoberts = new Persona("Emma Roberts", 2, "Estadounidense", new DateTime(1991, 02, 10), new List<int> { 3 });
            Persona DaveFranco = new Persona("Dave Franco", 1, "Estadounidense", new DateTime(1985, 06, 2), new List<int> { 3 });
            Persona JulietteLewis = new Persona("Juliette Lewis", 2, "Estadounidense", new DateTime(1973, 06, 21), new List<int> { 3 });
            Persona KennethBranagh = new Persona("Kenneth Branagh", 1, "Britanico", new DateTime(1960, 12, 10), new List<int> { 4 });
            Persona LilyJames = new Persona("Lily James", 2, "Britanica", new DateTime(1989, 04, 05), new List<int> { 3 });
            Persona BenChaplin = new Persona("Ben Chaplin", 1, "Britanico", new DateTime(1969, 07, 31), new List<int> { 3 });
            Persona RichardMadden = new Persona("Richard Madden", 1, "Britanico", new DateTime(1986, 06, 18), new List<int> { 3 });
            Persona KennyOrtega = new Persona("Kenny Ortega", 1, "Estadounidense", new DateTime(1950, 04, 18), new List<int> { 4 });
            Persona ZacEfron = new Persona("Zac Efron", 1, "Estadounidense", new DateTime(1987, 10, 18), new List<int> { 3 });
            Persona VanessaHudgens = new Persona("Vanessa Hudgens", 2, "Estadounidense", new DateTime(1988, 12, 14), new List<int> { 3 });
            Persona AshleyTisdale = new Persona("Ashley Tisdale", 2, "Estadounidense", new DateTime(1985, 07, 02), new List<int> { 3 });
            Persona DennisDugan = new Persona("Dennis Dugan", 1, "Estadounidense", new DateTime(1946, 09, 05), new List<int> { 4 });
            Persona AdamSandler = new Persona("Adam Sandles", 1, "Estadounidense", new DateTime(1966, 09, 09), new List<int> { 3 });
            Persona KevinJames = new Persona("Kevin James", 1, "Estadounidense", new DateTime(1965, 04, 28), new List<int> { 3 });
            Persona ChrisRock = new Persona("Chris Rock", 1, "Estadounidense", new DateTime(1967, 02, 13), new List<int> { 3 });
            Persona Coolio = new Persona("Coolio", 1, "Estadounidense", new DateTime(1963, 08, 01), new List<int> { 1, 2 });
            Persona Anuel = new Persona("Anuel AA", 1, "Puertorriqueño", new DateTime(1992, 11, 27), new List<int> { 1, 2 });
            Persona Karol_G = new Persona("Karol G", 2, "Colombiana", new DateTime(1991, 02, 14), new List<int> { 1, 2 });
            Persona DripReport = new Persona("DripReport", 1, "Indio", new DateTime(1970, 06, 14), new List<int> { 1, 2 });
            Persona Roxana_Gonzalez = new Persona("Roxana Gonzalez", 1, "Española", new DateTime(1998, 2, 2), new List<int> { 6 });
            Persona Miguel_Granados = new Persona("Miguel Granados", 1, "Argentino", new DateTime(1986, 10, 25), new List<int> { 5 });

            //Agregar a lista:
            Spotflix.Lista_Personas.Add(Bad_Bunny);
            Spotflix.Lista_Personas.Add(ShawnLevy);
            Spotflix.Lista_Personas.Add(SteveMartin);
            Spotflix.Lista_Personas.Add(BonnieHunt);
            Spotflix.Lista_Personas.Add(PiperPerabo);
            Spotflix.Lista_Personas.Add(HenryJoost);
            Spotflix.Lista_Personas.Add(EmmaRoberts);
            Spotflix.Lista_Personas.Add(DaveFranco);
            Spotflix.Lista_Personas.Add(JulietteLewis);
            Spotflix.Lista_Personas.Add(KennethBranagh);
            Spotflix.Lista_Personas.Add(LilyJames);
            Spotflix.Lista_Personas.Add(BenChaplin);
            Spotflix.Lista_Personas.Add(RichardMadden);
            Spotflix.Lista_Personas.Add(KennyOrtega);
            Spotflix.Lista_Personas.Add(ZacEfron);
            Spotflix.Lista_Personas.Add(VanessaHudgens);
            Spotflix.Lista_Personas.Add(AshleyTisdale);
            Spotflix.Lista_Personas.Add(DennisDugan);
            Spotflix.Lista_Personas.Add(AdamSandler);
            Spotflix.Lista_Personas.Add(KevinJames);
            Spotflix.Lista_Personas.Add(ChrisRock);
            Spotflix.Lista_Personas.Add(Coolio);
            Spotflix.Lista_Personas.Add(Anuel);
            Spotflix.Lista_Personas.Add(Karol_G);
            Spotflix.Lista_Personas.Add(DripReport);
            Spotflix.Lista_Personas.Add(Roxana_Gonzalez);
            Spotflix.Lista_Personas.Add(Miguel_Granados);

            //Crear Canciones:
            Cancion Como_se_siente = new Cancion("Como se siente", 1, new DateTime(2020, 05, 11), TimeSpan.Zero, 10.0, 2,
                Directory.GetCurrentDirectory() + @"\Musica\Bad bunny - Como se siente.mp3"
                , new List<Persona> { Bad_Bunny }, new List<Persona> { Bad_Bunny }, "Las que no iban a salir", "Imagen", "Letra", "Trap");
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
                Directory.GetCurrentDirectory() + @"\Musica\Karol G, Anuel AA - Follow.wav",
                new List<Persona> { Karol_G, Anuel }, new List<Persona> { Karol_G }, "Keii", "Imagen", "Letra", "Regueton");
            Cancion Skechers = new Cancion("Skechers", 1, new DateTime(2020, 01, 12), TimeSpan.Zero, 10.0, 2,
                Directory.GetCurrentDirectory() + @"\Musica\DripReport - Skechers.wav",
                new List<Persona> { DripReport }, new List<Persona> { DripReport }, "Skechers", "Imagen", "Letra", "Rap");

            //Agregar Canciones:
            Spotflix.Lista_Canciones.Add(Como_se_siente);
            Spotflix.Lista_Canciones.Add(Gangstas_paradise);
            Spotflix.Lista_Canciones.Add(Tres_de_abril);
            Spotflix.Lista_Canciones.Add(Keii);
            Spotflix.Lista_Canciones.Add(Follow);
            Spotflix.Lista_Canciones.Add(Skechers);

            //Crear Peliculas:
            Pelicula MasBaratoPorDocena = new Pelicula("Mas Barato Por Docena", 4, new DateTime(2003, 12, 25), new TimeSpan(1, 46, 0), 10.0, 1,
                Directory.GetCurrentDirectory() + @"\Peliculas\Mas Barato por Docena - Trailer.mp4", new List<Persona> { SteveMartin, BonnieHunt, PiperPerabo }, new List<Persona> { ShawnLevy },
                "‎20th Century Fox Home Entertainment", 2, "Descripcion", 1, "Familiar");
            Pelicula Nerve = new Pelicula("Nerve", 4, new DateTime(2016, 09, 01), new TimeSpan(1, 36, 0), 10.0, 1,
                Directory.GetCurrentDirectory() + @"\Peliculas\Nerve - Trailer Oficial.mp4", new List<Persona> { EmmaRoberts, DaveFranco, JulietteLewis }, new List<Persona> { HenryJoost },
                "‎Allison Shearmur Productions", 2, "Descripcion", 1, "Accion");
            Pelicula LaCenicienta = new Pelicula("La Cenicienta", 4, new DateTime(2015, 03, 13), new TimeSpan(1, 54, 0), 10.0, 1,
                Directory.GetCurrentDirectory() + @"\Peliculas\La Cenicienta - Trailer Oficial.mp4", new List<Persona> { LilyJames, BenChaplin, RichardMadden }, new List<Persona> { KennethBranagh },
                "Walt Disney Productions", 2, "Descripcion", 1, "Fantasia");
            Pelicula HighSchoolMusical = new Pelicula("High School Musical", 4, new DateTime(2006, 01, 20), new TimeSpan(1, 38, 0), 10.0, 1,
                Directory.GetCurrentDirectory() + @"\Peliculas\High School Musical – Original Trailer.mp4", new List<Persona> { ZacEfron, VanessaHudgens, AshleyTisdale }, new List<Persona> { KennyOrtega },
                "Salty Films", 1, "Descripcion", 2, "Musical");
            Pelicula SonComoNiños = new Pelicula("Son Como Niños", 4, new DateTime(2010, 06, 24), new TimeSpan(1, 42, 0), 10.0, 1,
                Directory.GetCurrentDirectory() + @"\Peliculas\Son como Niños - Trailer Oficial.mp4", new List<Persona> { AdamSandler, KevinJames, ChrisRock }, new List<Persona> { DennisDugan },
                "Relativity Media", 2, "Descripcion", 1, "Comedia");

            //Agregar Peliculas:
            Spotflix.Lista_Peliculas.Add(MasBaratoPorDocena);
            Spotflix.Lista_Peliculas.Add(Nerve);
            Spotflix.Lista_Peliculas.Add(LaCenicienta);
            Spotflix.Lista_Peliculas.Add(HighSchoolMusical);
            Spotflix.Lista_Peliculas.Add(SonComoNiños);

            //Crear Audiolibros
            AudioLibro Azafata_Chistosa = new AudioLibro("Azafata chistosa", 3, new DateTime(2020, 05, 11), TimeSpan.Zero, 10.0, 2,
                Directory.GetCurrentDirectory() + @"\Audio libros\Azafata Chistosa\Azafata chistosa.mp3", 
                Directory.GetCurrentDirectory() + @"\Audio libros\Azafata Chistosa\Azafata chistosa.txt", "Comedia", 1, Roxana_Gonzalez);
            AudioLibro Hijo_Huerfano = new AudioLibro("Hijo huerfano", 3, new DateTime(2020, 05, 11), TimeSpan.Zero, 10.0, 2,
                Directory.GetCurrentDirectory() + @"\Audio libros\Hijo Huerfano\Hijo huerfano.mp3",
                Directory.GetCurrentDirectory() + @"\Audio libros\Hijo Huerfano\Hijo huerfano.txt", "Comedia", 1, Roxana_Gonzalez);
            
            //Agregar Audilibors:
            Spotflix.Lista_AudioLibros.Add(Azafata_Chistosa);
            Spotflix.Lista_AudioLibros.Add(Hijo_Huerfano);

            //Crear Videos:
            Video Como_Bajar_videos = new Video("Como bajar videos de youtube", 2, new DateTime(2020, 01, 15), TimeSpan.Zero, 10.0, 2,
                 Directory.GetCurrentDirectory() + @"\Videos\2 Formas Increibles de bajar videos en youtube sin programas 2020.mp4", 2, "", 2, "Informativo");
            
            //Agregar Videos:
            Spotflix.Lista_Videos.Add(Como_Bajar_videos);
            
            //Crear Podcast:
            Podcast Comedia_Miguel_Granados = new Podcast("Comedia Miguel Granados", 3, new DateTime(2019, 10, 17), TimeSpan.Zero, 10.0, 2,
                Directory.GetCurrentDirectory() + @"\Podcast\Comedia - Miguel Granados.mp3", new List<Persona> { Miguel_Granados }, "Imagen", "Comedia");
            
            //Agregar Podcast:
            Spotflix.Lista_Podcasts.Add(Comedia_Miguel_Granados);
            
            //Crear Usuarios:
            Usuario User_Ronca = new Usuario("Juan", "Roncagliolo", new DateTime(1998, 01, 16), 1, "Chile", "ronca@spotflix.com", "ronca", 2);

            //Agregar Usuarios:
            Spotflix.Lista_Usuarios.Add(User_Ronca);

            //Crear Perfil
            Perfil Perfil_Ronca = new Perfil(User_Ronca, "Ronca", 1);

            //Agregar perfil:
            Spotflix.Lista_Perfiles.Add(Perfil_Ronca);



            
           

            
            
            
            
            





            ////////////////MENU////////////////////////
            int entrada = -1;
            while (entrada != 0)
            {
                Console.Write("¡Bienvenidos a Spotflix! ");
                DateTime now = DateTime.Now;
                Console.WriteLine("{0} hrs : {1} mins : {2} secs", now.Hour, now.Minute, now.Second);
                Console.WriteLine("Iniciar session:");
                Console.WriteLine("Tiene cuenta? [1] Si, [2] No, [0] Para salir.");
                entrada = Convert.ToInt32(Console.ReadLine());
                if (entrada == 1)
                {
                    Console.WriteLine("Ingrese su correo de usuario:");
                    string correo = Console.ReadLine();
                    Console.WriteLine("Contraseña:");
                    string contraseña = Console.ReadLine();
                    int b_1 = 0;
                    foreach (var item in Spotflix.Lista_Usuarios)
                    {
                        if (correo == item.Email && contraseña == item.Contraseña)
                        {
                            b_1++;
                            Console.WriteLine("Ingresando a sesion...");
                            Thread.Sleep(2000);
                            int verperfiles = 1;
                            List<Perfil> perfilesdeusuario = new List<Perfil>();
                            foreach (var item2 in Spotflix.Lista_Perfiles)
                            {
                                if (item2.Usuario_Asociado == item)
                                {
                                    perfilesdeusuario.Add(item2);
                                    verperfiles += 1;
                                }
                            }
                            if (verperfiles == 1)
                            {
                                Console.WriteLine("No hay perfiles en su usuario, creando uno!");
                                Console.WriteLine("Ingrese nombre de perfil:");
                                string nperfil = Console.ReadLine();
                                int tipoperf = 1;
                                perfilesdeusuario.Add(new Perfil(item, nperfil, tipoperf));
                                Spotflix.Lista_Perfiles.Add(new Perfil(item, nperfil, tipoperf));
                                verperfiles += 1;
                            }
                            else
                            {
                                int c_1 = 1;
                                Console.WriteLine("Perfil/es disponible:");
                                foreach (var item3 in perfilesdeusuario)
                                {
                                    Console.WriteLine(c_1 + ". " + item3.Nombre_perfil);
                                    c_1 += 1;
                                }
                                Console.WriteLine("A cual perfil deseas ingresar?");
                                int perfilingresar = Convert.ToInt32(Console.ReadLine());
                                Perfil perfilenlinea = perfilesdeusuario[perfilingresar - 1];
                                Usuario usuarioenlinea = perfilenlinea.Usuario_Asociado;
                                Console.WriteLine("Ingresando a "+perfilenlinea.Nombre_perfil+"...");
                                Thread.Sleep(2000);
                                //Menu Principal
                                int a = -1;
                                while (a != 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Bienvenido " + perfilenlinea.Nombre_perfil + "\nQue desea hacer?");
                                    Console.WriteLine("1. Reproducir multimedia, 2. Buscar/seguir, 3. Editar informacion, 4. Agregar archivo, 5. Mostrar informacion, 0 Salir");
                                    a = Convert.ToInt32(Console.ReadLine());
                                    if (a == 1)
                                    {
                                        Console.WriteLine("Bienvenido al menu multimedia.");
                                        Console.WriteLine("Que desea reproducir:\n1. Canciones\n2. Peliculas\n3. Audiolibros\n4. Podcast\n5. Videos\n0. Para salir");
                                        int a_1 = Convert.ToInt32(Console.ReadLine());
                                        if (a_1 == 1)
                                        {
                                            int a_2 = -1;
                                            void Agregar_a_temportal(List<Cancion> canciones)
                                            {
                                                Spotflix.Temporal = new WindowsMediaPlayer().newPlaylist("Temporal", null);
                                                foreach (var item_4 in canciones)
                                                {
                                                    Spotflix.Temporal.appendItem(new WindowsMediaPlayer().newMedia(item_4.URL));
                                                }
                                            }
                                            Console.WriteLine("Que playlist de canciones desea reproducir:\n1. Todas\n2. Canciones favoritas\n3. En cola\n0. Salir");
                                            a_2 = Convert.ToInt32(Console.ReadLine());
                                            if (a_2 == 1)
                                            {
                                                int a_3 = -1;
                                                Agregar_a_temportal(Spotflix.Lista_Canciones);
                                                Spotflix.Reproducir(Spotflix.Temporal);
                                                while (a_3 != 0)
                                                {
                                                    Timer timer2 = new Timer(TimerCallback1, null, 1000, 15000);
                                                    void TimerCallback1(Object o)
                                                    {
                                                        Console.Write("Canciones en la lista");
                                                        foreach (var item_6 in Spotflix.Lista_Canciones)
                                                        {
                                                            Console.Write("| " +item_6.Cantante+" - "+ item_6.Titulo + " | ");
                                                        }
                                                        Console.WriteLine("\n1 para pausar 2 reanudar 3 adelantar 4 retroceder 0 salir");
                                                        GC.Collect();
                                                    }
                                                    Timer timer1 = new Timer(TimerCallback2, null, 1000, 1000);
                                                    void TimerCallback2(Object o)
                                                    {
                                                        Console.WriteLine(Spotflix.Estado());
                                                        GC.Collect();
                                                    }
                                                    a_3 = Convert.ToInt32(Console.ReadLine());
                                                    if (a_3 == 1)
                                                    {
                                                        Spotflix.Pausar();
                                                    }
                                                    else if (a_3 == 2)
                                                    {
                                                        Spotflix.Reanudar();
                                                    }
                                                    else if (a_3 == 3)
                                                    {
                                                        Spotflix.Adelantar();
                                                    }
                                                    else if (a_3 == 4)
                                                    {
                                                        Spotflix.Retroceder();
                                                    }
                                                    else if (a_3 == 0)
                                                    {
                                                        Spotflix.Pausar();
                                                        timer1.Dispose();
                                                    }
                                                }

                                            }
                                            else if (a_2 == 2)
                                            {
                                                int a_3 = -1;
                                                Agregar_a_temportal(perfilenlinea.Fav_Canciones);
                                                Spotflix.Reproducir(Spotflix.Temporal);
                                                while (a_3 != 0)
                                                {
                                                    Timer timer2 = new Timer(TimerCallback1, null, 1000, 15000);
                                                    void TimerCallback1(Object o)
                                                    {
                                                        Console.Write("Canciones en la lista");
                                                        foreach (var item_6 in perfilenlinea.Fav_Canciones)
                                                        {
                                                            Console.Write("| " + item_6.Cantante + " - " + item_6.Titulo + " | ");
                                                        }
                                                        Console.WriteLine("\n1 para pausar 2 reanudar 3 adelantar 4 retroceder 0 salir");
                                                        GC.Collect();
                                                    }
                                                    Timer timer1 = new Timer(TimerCallback2, null, 1000, 1000);
                                                    void TimerCallback2(Object o)
                                                    {
                                                        Console.WriteLine(Spotflix.Estado());
                                                        GC.Collect();
                                                    }
                                                    a_3 = Convert.ToInt32(Console.ReadLine());
                                                    if (a_3 == 1)
                                                    {
                                                        Spotflix.Pausar();
                                                    }
                                                    else if (a_3 == 2)
                                                    {
                                                        Spotflix.Reanudar();
                                                    }
                                                    else if (a_3 == 3)
                                                    {
                                                        Spotflix.Adelantar();
                                                    }
                                                    else if (a_3 == 4)
                                                    {
                                                        Spotflix.Retroceder();
                                                    }
                                                    else if (a_3 == 0)
                                                    {
                                                        Spotflix.Pausar();
                                                        timer1.Dispose();
                                                    }
                                                }
                                            }
                                            else if (a_2 == 3)
                                            {
                                                int a_3 = -1;
                                                Agregar_a_temportal(perfilenlinea.En_Cola_cancion);
                                                Spotflix.Reproducir(Spotflix.Temporal);
                                                while (a_3 != 0)
                                                {
                                                    Timer timer2 = new Timer(TimerCallback1, null, 1000, 15000);
                                                    void TimerCallback1(Object o)
                                                    {
                                                        Console.Write("Canciones en la lista");
                                                        foreach (var item_6 in perfilenlinea.En_Cola_cancion)
                                                        {
                                                            Console.Write("| " + item_6.Cantante + " - " + item_6.Titulo + " | ");
                                                        }
                                                        Console.WriteLine("\n1 para pausar 2 reanudar 3 adelantar 4 retroceder 0 salir");
                                                        GC.Collect();
                                                    }
                                                    Timer timer1 = new Timer(TimerCallback2, null, 1000, 1000);
                                                    void TimerCallback2(Object o)
                                                    {
                                                        Console.WriteLine(Spotflix.Estado());
                                                        GC.Collect();
                                                    }
                                                    a_3 = Convert.ToInt32(Console.ReadLine());
                                                    if (a_3 == 1)
                                                    {
                                                        Spotflix.Pausar();
                                                    }
                                                    else if (a_3 == 2)
                                                    {
                                                        Spotflix.Reanudar();
                                                    }
                                                    else if (a_3 == 3)
                                                    {
                                                        Spotflix.Adelantar();
                                                    }
                                                    else if (a_3 == 4)
                                                    {
                                                        Spotflix.Retroceder();
                                                    }
                                                    else if (a_3 == 0)
                                                    {
                                                        Spotflix.Pausar();
                                                        timer1.Dispose();
                                                    }
                                                }
                                            }
                                            else if (a_2 == 0)
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Opcion incorrecta, intente nuevamente");
                                                a_2 = Convert.ToInt32(Console.ReadLine());
                                            }

                                        }//Reproducir Canciones Listo

                                        else if (a_1 == 2)
                                        {
                                            int a_2 = -1;
                                            Console.WriteLine("De que playlist de peliculas desea reproducir:\n1. Todas\n2. Peliculas favoritas\n0. Salir");
                                            a_2 = Convert.ToInt32(Console.ReadLine());
                                            if (a_2 == 1)
                                            {
                                                Console.WriteLine("Elija la pelicula que desea ver");
                                                int i = 1;
                                                foreach (var item_5 in Spotflix.Lista_Peliculas)
                                                {
                                                    Console.WriteLine(i + ". " + item_5.Titulo);
                                                    i++;
                                                }
                                                int a_3 = Convert.ToInt32(Console.ReadLine());
                                                Spotflix.spotflix.openPlayer(Spotflix.Lista_Peliculas[a_3 - 1].URL);
                                            }
                                            else if (a_2 == 2)
                                            {
                                                Console.WriteLine("Elija la pelicula que desea ver");
                                                int i = 1;
                                                foreach (var item_5 in perfilenlinea.Fav_Pelicula)
                                                {
                                                    Console.WriteLine(i + ". " + item_5.Titulo);
                                                    i++;
                                                }
                                                int a_3 = Convert.ToInt32(Console.ReadLine());
                                                Spotflix.spotflix.openPlayer(perfilenlinea.Fav_Pelicula[a_3 - 1].URL);
                                            }
                                            else if (a_2 == 0)
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Opcion incorrecta, intente nuevamente");
                                                a_2 = Convert.ToInt32(Console.ReadLine());
                                            }


                                        }//Reproducir Peliculas Listo

                                        else if (a_1 == 3)
                                        {
                                            int a_2 = -1;
                                            Console.WriteLine("De que playlist de audiolibros desea reproducir:\n1. Todas\n2. Audiolibros favoritos\n0. Salir");
                                            a_2 = Convert.ToInt32(Console.ReadLine());
                                            if (a_2 == 1)
                                            {
                                                Console.WriteLine("Que Audiolibro desea ver de todos");
                                                for (int i = 0; i < Spotflix.Lista_AudioLibros.Count; i++)
                                                {
                                                    Console.WriteLine(i + 1 + ". " + Spotflix.Lista_AudioLibros[i].Titulo);
                                                }
                                                Console.WriteLine("0. Salir");
                                                int a_3 = Convert.ToInt32(Console.ReadLine());
                                                if (a_3 == 0)
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Spotflix.Temporal = new WindowsMediaPlayer().newPlaylist("Temporal", null);
                                                    Spotflix.Temporal.appendItem(new WindowsMediaPlayer().newMedia(Spotflix.Lista_AudioLibros[a_3 - 1].URL));
                                                    Spotflix.Reproducir(Spotflix.Temporal);
                                                    Thread.Sleep(1000);
                                                    string[] texto = File.ReadAllLines(Spotflix.Lista_AudioLibros[a_3 - 1].URL_Texto);
                                                    foreach (string line in texto)
                                                    {
                                                        Console.WriteLine("\t" + line);
                                                        Thread.Sleep(5000);
                                                    }
                                                }
                                            }
                                            else if (a_2 == 2)
                                            {
                                                Console.WriteLine("Que Audiolibro desea ver de favoritos");
                                                for (int i = 0; i < perfilenlinea.Fav_AudioLibro.Count; i++)
                                                {
                                                    Console.WriteLine(i + 1 + ". " + perfilenlinea.Fav_AudioLibro[i].Titulo);
                                                }
                                                Console.WriteLine("0. Salir");
                                                int a_3 = Convert.ToInt32(Console.ReadLine());
                                                if (a_3 == 0)
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Spotflix.Temporal.clear();
                                                    Spotflix.Temporal.appendItem(new WindowsMediaPlayer().newMedia(perfilenlinea.Fav_AudioLibro[a_3 - 1].URL));
                                                    Spotflix.Reproducir(Spotflix.Temporal);
                                                    Thread.Sleep(1000);
                                                    string[] texto = File.ReadAllLines(perfilenlinea.Fav_AudioLibro[a_3 - 1].URL_Texto);
                                                    foreach (string line in texto)
                                                    {
                                                        Console.WriteLine("\t" + line);
                                                        Thread.Sleep(5000);
                                                    }
                                                }
                                            }
                                            else if (a_2 == 0)
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Opcion incorrecta, intente nuevamente");
                                                a_2 = Convert.ToInt32(Console.ReadLine());
                                            }

                                        }//Reproducir AudioLibros

                                        else if (a_1 == 4)
                                        {
                                            int a_2 = -1;
                                            void Agregar_a_temportal(List<Podcast> podcasts)
                                            {
                                                Spotflix.Temporal = new WindowsMediaPlayer().newPlaylist("Temporal", null);
                                                foreach (var item_4 in podcasts)
                                                {
                                                    Spotflix.Temporal.appendItem(new WindowsMediaPlayer().newMedia(item_4.URL));
                                                }
                                            }
                                            Console.WriteLine("Que playlist de podcast desea reproducir:\n1. Todas\n2. Podcast favoritos\n3. En cola\n0. Salir");
                                            a_2 = Convert.ToInt32(Console.ReadLine());
                                            if (a_2 == 1)
                                            {
                                                int a_3 = -1;
                                                Agregar_a_temportal(Spotflix.Lista_Podcasts);
                                                Spotflix.Reproducir(Spotflix.Temporal);
                                                while (a_3 != 0)
                                                {
                                                    Timer timer = new Timer(TimerCallback, null, 1000, 5000);
                                                    void TimerCallback(Object o)
                                                    {
                                                        Console.WriteLine(Spotflix.Estado());
                                                        GC.Collect();
                                                    }
                                                    foreach (var item_6 in Spotflix.Lista_Podcasts)
                                                    {
                                                        Console.Write("| " + item_6.Titulo + " | ");
                                                    }
                                                    Console.WriteLine("\n1 para pausar 2 reanudar 3 adelantar 4 retroceder 0 salir");
                                                    a_3 = Convert.ToInt32(Console.ReadLine());
                                                    if (a_3 == 1)
                                                    {
                                                        Spotflix.Pausar();
                                                    }
                                                    else if (a_3 == 2)
                                                    {
                                                        Spotflix.Reanudar();
                                                    }
                                                    else if (a_3 == 3)
                                                    {
                                                        Spotflix.Adelantar();
                                                    }
                                                    else if (a_3 == 4)
                                                    {
                                                        Spotflix.Retroceder();
                                                    }
                                                    else if (a_3 == 0)
                                                    {
                                                        Spotflix.Pausar();
                                                        timer.Dispose();
                                                    }
                                                }
                                            }
                                            else if (a_2 == 2)
                                            {
                                                int a_3 = -1;
                                                Agregar_a_temportal(perfilenlinea.Fav_Podcast);
                                                Spotflix.Reproducir(Spotflix.Temporal);
                                                while (a_3 != 0)
                                                {
                                                    Timer timer = new Timer(TimerCallback, null, 1000, 5000);
                                                    void TimerCallback(Object o)
                                                    {
                                                        Console.WriteLine(Spotflix.Estado());
                                                        GC.Collect();
                                                    }
                                                    foreach (var item_6 in perfilenlinea.Fav_Podcast)
                                                    {
                                                        Console.Write(" " + item_6.Titulo + "|");
                                                    }
                                                    Console.WriteLine("1 para pausar 2 reanudar 3 adelantar 4 retroceder 0 salir");
                                                    a_3 = Convert.ToInt32(Console.ReadLine());
                                                    if (a_3 == 1)
                                                    {
                                                        Spotflix.Pausar();
                                                    }
                                                    else if (a_3 == 2)
                                                    {
                                                        Spotflix.Reanudar();
                                                    }
                                                    else if (a_3 == 3)
                                                    {
                                                        Spotflix.Adelantar();
                                                    }
                                                    else if (a_3 == 4)
                                                    {
                                                        Spotflix.Retroceder();
                                                    }
                                                    else if (a_3 == 0)
                                                    {
                                                        Spotflix.Pausar();
                                                        timer.Dispose();
                                                    }
                                                }
                                            }
                                            else if (a_2 == 3)
                                            {
                                                int a_3 = -1;
                                                Agregar_a_temportal(perfilenlinea.En_Cola_podcast);
                                                Spotflix.Reproducir(Spotflix.Temporal);
                                                while (a_3 != 0)
                                                {
                                                    Timer timer = new Timer(TimerCallback, null, 1000, 5000);
                                                    void TimerCallback(Object o)
                                                    {
                                                        Console.WriteLine(Spotflix.Estado());
                                                        GC.Collect();
                                                    }
                                                    foreach (var item_6 in perfilenlinea.En_Cola_podcast)
                                                    {
                                                        Console.Write(" " + item_6.Titulo + "|");
                                                    }
                                                    Console.WriteLine("1 para pausar 2 reanudar 3 adelantar 4 retroceder 0 salir");
                                                    a_3 = Convert.ToInt32(Console.ReadLine());
                                                    if (a_3 == 1)
                                                    {
                                                        Spotflix.Pausar();
                                                    }
                                                    else if (a_3 == 2)
                                                    {
                                                        Spotflix.Reanudar();
                                                    }
                                                    else if (a_3 == 3)
                                                    {
                                                        Spotflix.Adelantar();
                                                    }
                                                    else if (a_3 == 4)
                                                    {
                                                        Spotflix.Retroceder();
                                                    }
                                                    else if (a_3 == 0)
                                                    {
                                                        Spotflix.Pausar();
                                                        timer.Dispose();
                                                    }
                                                }
                                            }
                                            else if (a_2 == 0)
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Opcion incorrecta, intente nuevamente");
                                                a_2 = Convert.ToInt32(Console.ReadLine());
                                            }

                                        }//Reproducir Podcast Listo

                                        else if (a_1 == 5)
                                        {
                                            int a_2 = -1;
                                            Console.WriteLine("De que playlist de videos desea reproducir:\n1. Todas\n2. Videos favoritos\n0. Salir");
                                            a_2 = Convert.ToInt32(Console.ReadLine());
                                            if (a_2 == 1)
                                            {
                                                Console.WriteLine("Elija el video que desea ver");
                                                int i = 1;
                                                foreach (var item_5 in Spotflix.Lista_Videos)
                                                {
                                                    Console.WriteLine(i + ". " + item_5.Titulo);
                                                    i++;
                                                }
                                                int a_3 = Convert.ToInt32(Console.ReadLine());
                                                Spotflix.spotflix.openPlayer(Spotflix.Lista_Videos[a_3 - 1].URL);
                                            }
                                            else if (a_2 == 2)
                                            {
                                                Console.WriteLine("Elija el video que desea ver");
                                                int i = 1;
                                                foreach (var item_5 in perfilenlinea.Fav_Videos)
                                                {
                                                    Console.WriteLine(i + ". " + item_5.Titulo);
                                                    i++;
                                                }
                                                int a_3 = Convert.ToInt32(Console.ReadLine());
                                                Spotflix.spotflix.openPlayer(perfilenlinea.Fav_Videos[a_3 - 1].URL);
                                            }
                                            else if (a_2 == 0)
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Opcion incorrecta, intente nuevamente");
                                                a_2 = Convert.ToInt32(Console.ReadLine());
                                            }
                                        }//Reproducir Videos Listo

                                        else if (a_1 == 0)
                                        {
                                            break;
                                        }//Salir

                                    }//Reproducir multimedia Listo

                                    else if (a == 2)
                                    {
                                        Interaccion_Usuario.Buscar(perfilenlinea);
                                    }//Buscar y seguir Listo

                                    else if (a == 3)
                                    {
                                        int tipoperfil = perfilenlinea.Tipo_de_Perfil;
                                        if (tipoperfil == 3)
                                        {
                                            Interaccion_Usuario.Editar_Informacion_Admin();
                                        }
                                        else
                                        {
                                            Interaccion_Usuario.Editar_Informacion_Usuario(usuarioenlinea);
                                        }
                                    }//Editar informacion

                                    else if (a == 4)
                                    {
                                        //Agregar Archivo
                                    }//AGregar archivo

                                    else if (a==5)
                                    {

                                    }//Mostrar informacion:

                                    else if (a == 0)
                                    {
                                        break;
                                    }//Salir

                                    else
                                    {
                                        Console.WriteLine("Opcion invalida, intente nuevamente.");
                                    }
                                }
                                //Fin del menu principal.
                            }
                            break;
                        }
                    }
                    if (b_1 == 0)
                    {
                        Console.WriteLine("Error no se ha encontrado cuenta.");
                    }
                    break;
                }//Ingresar y usar cuenta.
                else if (entrada == 2)
                {
                    Console.WriteLine("Creando su propia cuenta!");
                    Console.WriteLine("Su nombre de usuario:");
                    string nomb = Console.ReadLine();
                    Console.WriteLine("Su apellido:");
                    string apell = Console.ReadLine();
                    Console.WriteLine("Su fecha de nacimiento:[DD/MM/AAAA]");
                    DateTime date = Convert.ToDateTime(Console.ReadLine());
                    DateTime dt = date;
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
                    while (contra != contra2)
                    {
                        Console.WriteLine("Distintas contraseñas! Intente nuevamente");
                        Console.WriteLine("Su contraseña:");
                        contra = Console.ReadLine();
                        Console.WriteLine("Su contraseña nuevamente:");
                        contra2 = Console.ReadLine();
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
                    Console.WriteLine("Nuevo perfil creado "+perfilenlinea.Nombre_perfil);
                    Thread.Sleep(2000);
                    Console.Clear();
                    
                }//Crear cuenta
                else
                {
                    Console.WriteLine("Error, introduzca informacion valida!");
                }
            }
        }
    }
}
