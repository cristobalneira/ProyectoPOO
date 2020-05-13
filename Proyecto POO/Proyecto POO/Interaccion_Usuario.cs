using System;
using System.Collections.Generic;
using System.Threading;
using WMPLib;

namespace Proyecto_POO
{
    public static class Interaccion_Usuario
    {
        public static void Crear_Playlist(Perfil p)
        {
            Console.WriteLine("Como desea que se llame la playlist");
            string nombre = Console.ReadLine();
            Playlist temp2 = new Playlist(new List<Cancion>(), nombre, 1);
            p.Playlists_Canciones_Propias.Add(temp2);
        }
        public static void Agregar_Cancion_a_Playlist(Perfil p, Cancion item)
        {
            int i = 1;
            foreach (var item_1 in p.Playlists_Canciones_Propias)
            {
                Console.Write(i + ". " + item_1.Nombre + " ");
                i++;
            }
            Console.WriteLine(i + ". Desea crear una nueva playlist");
            int i_1 = Convert.ToInt32(Console.ReadLine());
            if (i_1 == i)
            {
                Console.WriteLine("Como desea que se llame la playlist");
                string nombre = Console.ReadLine();
                Playlist temp2 = new Playlist(new List<Cancion>(), nombre, item.Categoria);
                temp2.Playlist_paralista.Add(item);
                p.Playlists_Canciones_Propias.Add(temp2);
            }
            p.Playlists_Canciones_Propias[(i_1 - 1)].Playlist_paralista.Add(item);
        }

        public static void Buscar(Perfil p)
        {
            Console.WriteLine("1. Busqueda Simple \n2. Busqueda Compleja");
            int answer = Convert.ToInt32(Console.ReadLine());

            //Busqueda Simple
            if (answer == 1)
            {
                Console.WriteLine("Que desea buscar ?: ");
                Console.WriteLine("1. Multimedia \n2. Persona \n3. Perfil");

                int a = Convert.ToInt32(Console.ReadLine());

                if (a == 1)
                {
                    Console.WriteLine("Que desea escuchar/ver? : ");
                    Console.WriteLine("1. Canciones \n2. Videos \n3. Pelicula \n4. Podcast \n5. AudioLibro \n6. Playlist");
                    int answer2 = Convert.ToInt32(Console.ReadLine());

                    if (answer2 == 1)
                    {
                        int i = 1;
                        foreach (var item in Spotflix.Lista_Canciones)
                        {
                            Console.WriteLine("[" + i + "]. " + item.Titulo);
                            i += 1;
                        }
                        Console.WriteLine(" ");
                        Console.WriteLine("Escoger una cancion: ");
                        int cancion = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("1. Desea añadir a la cola? ");
                        Console.WriteLine("2. A otra playlist");
                        Console.WriteLine("0. Salir");
                        int opcion = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine(" ");
                        if (opcion == 1)
                        {

                            p.En_Cola_cancion.Add(Spotflix.Lista_Canciones[cancion - 1]);
                            Console.WriteLine("Cancion agregada a la cola");
                            Console.WriteLine(" ");
                            Thread.Sleep(1000);

                        }
                        else if (opcion == 2)
                        {
                            Console.WriteLine("Desea agregar esta cancion a favoritos?: ");
                            Console.WriteLine("1. Si \n2. No");
                            Console.WriteLine(" ");
                            int agregar = Convert.ToInt32(Console.ReadLine());
                            if (agregar == 1)
                            {
                                p.Fav_Canciones.Add(Spotflix.Lista_Canciones[cancion - 1]);
                                Console.WriteLine("Cancion agregada a favoritos ");
                                Thread.Sleep(2000);
                            }
                            else
                            {
                                Console.WriteLine("Desea añadir a una playlist:");
                                Console.WriteLine("1. Si \n2. No");
                                int añadir = Convert.ToInt32(Console.ReadLine());
                                if (añadir == 1)
                                {
                                    Agregar_Cancion_a_Playlist(p, Spotflix.Lista_Canciones[cancion - 1]);
                                    Thread.Sleep(1000);
                                }
                            }

                        }
                        else if (opcion == 0)
                        {
                            Thread.Sleep(1000);
                        }


                    }

                    else if (answer2 == 2)
                    {
                        int i = 1;
                        foreach (var item in Spotflix.Lista_Videos)
                        {
                            Console.WriteLine("[" + i + "]. " + item.Titulo);
                            i += 1;
                        }
                        Console.WriteLine(" ");
                        Console.WriteLine("Escoger un video: ");
                        int video = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("1. Desea añadir a la cola? ");
                        Console.WriteLine("2. Otro");
                        Console.WriteLine("0. Salir");
                        int opcion = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine(" ");
                        if (opcion == 1)
                        {

                            p.En_Cola_video.Add(Spotflix.Lista_Videos[video - 1]);
                            Console.WriteLine("Video agregado a la cola");
                            Console.WriteLine(" ");
                            Thread.Sleep(1000);

                        }
                        else if (opcion == 2)
                        {
                            Console.WriteLine("Desea agregar este video a favoritos?: ");
                            Console.WriteLine("1. Si \n2. No");
                            Console.WriteLine(" ");
                            int agregar = Convert.ToInt32(Console.ReadLine());
                            if (agregar == 1)
                            {
                                p.Fav_Videos.Add(Spotflix.Lista_Videos[video - 1]);
                                Console.WriteLine("Video agregado a favoritos ");
                                Thread.Sleep(2000);
                            }
                            else
                            {
                                Console.WriteLine("Desea añadir a una playlist:");
                                Console.WriteLine("1. Si \n2. No");
                                int añadir = Convert.ToInt32(Console.ReadLine());
                                if (añadir == 1)
                                {
                                    //añadir a una playlist
                                    Thread.Sleep(1000);
                                }
                            }

                        }
                        else if (opcion == 0)
                        {
                            Thread.Sleep(1000);
                        }


                    }

                    else if (answer2 == 3)
                    {
                        int i = 1;
                        foreach (var item in Spotflix.Lista_Peliculas)
                        {
                            Console.WriteLine("[" + i + "]. " + item.Titulo);
                            i += 1;
                        }
                        Console.WriteLine(" ");
                        Console.WriteLine("Escoger una pelicula: ");
                        int pelicula = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("1. Desea añadir a la cola? ");
                        Console.WriteLine("2. Otro");
                        Console.WriteLine("0. Salir");
                        int opcion = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine(" ");
                        if (opcion == 1)
                        {

                            p.En_Cola_pelicula.Add(Spotflix.Lista_Peliculas[pelicula - 1]);
                            Console.WriteLine("Pelicula agregada a la cola");
                            Console.WriteLine(" ");
                            Thread.Sleep(1000);

                        }
                        else if (opcion == 2)
                        {
                            Console.WriteLine("Desea agregar esta pelicula a favoritos?: ");
                            Console.WriteLine("1. Si \n2. No");
                            Console.WriteLine(" ");
                            int agregar = Convert.ToInt32(Console.ReadLine());
                            if (agregar == 1)
                            {
                                p.Fav_Pelicula.Add(Spotflix.Lista_Peliculas[pelicula - 1]);
                                Console.WriteLine("Cancion agregada a favoritos ");
                                Thread.Sleep(2000);
                            }
                            else
                            {
                                Console.WriteLine("Desea añadir a una playlist:");
                                Console.WriteLine("1. Si \n2. No");
                                int añadir = Convert.ToInt32(Console.ReadLine());
                                if (añadir == 1)
                                {
                                    //añadir a una playlist
                                    Thread.Sleep(1000);
                                }
                            }

                        }
                        else if (opcion == 0)
                        {
                            Thread.Sleep(1000);
                        }


                    }

                    else if (answer2 == 4)
                    {
                        int i = 1;
                        foreach (var item in Spotflix.Lista_Podcasts)
                        {
                            Console.WriteLine("[" + i + "]. " + item.Titulo);
                            i += 1;
                        }
                        Console.WriteLine(" ");
                        Console.WriteLine("Escoger una podcast: ");
                        int podcast = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("1. Desea añadir a la cola? ");
                        Console.WriteLine("2. Otro");
                        Console.WriteLine("0. Salir");
                        int opcion = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine(" ");
                        if (opcion == 1)
                        {

                            p.En_Cola_podcast.Add(Spotflix.Lista_Podcasts[podcast - 1]);
                            Console.WriteLine("Podcast agregada a la cola");
                            Console.WriteLine(" ");
                            Thread.Sleep(1000);

                        }
                        else if (opcion == 2)
                        {
                            Console.WriteLine("Desea agregar este podcast a favoritos?: ");
                            Console.WriteLine("1. Si \n2. No");
                            Console.WriteLine(" ");
                            int agregar = Convert.ToInt32(Console.ReadLine());
                            if (agregar == 1)
                            {
                                p.Fav_Podcast.Add(Spotflix.Lista_Podcasts[podcast - 1]);
                                Console.WriteLine("Cancion agregada a favoritos ");
                                Thread.Sleep(2000);
                            }
                            else
                            {
                                Console.WriteLine("Desea añadir a una playlist:");
                                Console.WriteLine("1. Si \n2. No");
                                int añadir = Convert.ToInt32(Console.ReadLine());
                                if (añadir == 1)
                                {
                                    //añadir a una playlist
                                    Thread.Sleep(1000);
                                }
                            }
;
                        }
                        else if (opcion == 0)
                        {
                            Thread.Sleep(1000);
                        }


                    }

                    else if (answer2 == 5)
                    {
                        int i = 1;
                        foreach (var item in Spotflix.Lista_AudioLibros)
                        {
                            Console.WriteLine("[" + i + "]. " + item.Titulo);
                            i += 1;
                        }
                        Console.WriteLine(" ");
                        Console.WriteLine("Escoger un audiolibro: ");
                        int audiolibro = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("1. Desea añadir a la cola? ");
                        Console.WriteLine("2. Otro");
                        Console.WriteLine("0. Salir");
                        int opcion = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine(" ");
                        if (opcion == 1)
                        {

                            p.En_Cola_audiolibro.Add(Spotflix.Lista_AudioLibros[audiolibro - 1]);
                            Console.WriteLine("Audiolibro agregado a la cola");
                            Console.WriteLine(" ");
                            Thread.Sleep(1000);

                        }
                        else if (opcion == 2)
                        {
                            Console.WriteLine("Desea agregar este audiolibro a favoritos?: ");
                            Console.WriteLine("1. Si \n2. No");
                            Console.WriteLine(" ");
                            int agregar = Convert.ToInt32(Console.ReadLine());
                            if (agregar == 1)
                            {
                                p.Fav_AudioLibro.Add(Spotflix.Lista_AudioLibros[audiolibro - 1]);
                                Console.WriteLine("Audiolibro agregado a favoritos ");
                                Thread.Sleep(2000);
                            }
                            else
                            {
                                Console.WriteLine("Desea añadir a una playlist:");
                                Console.WriteLine("1. Si \n2. No");
                                int añadir = Convert.ToInt32(Console.ReadLine());
                                if (añadir == 1)
                                {
                                    //añadir a una playlist
                                    Thread.Sleep(1000);
                                }
                            }

                        }
                        else if (opcion == 0)
                        {
                            Thread.Sleep(1000);
                        }

                    }

                    else if (answer2 == 6)
                    {
                        Console.WriteLine("Que tipo de playlist desea buscar: ");
                        Console.WriteLine("1. De canciones \n2. De videos \n3. De peliculas \n4. De podcast \n5. De audiolibros ");

                        int opcion = Convert.ToInt32(Console.ReadLine());
                        if (opcion == 1)
                        {
                            int i = 1;
                            Console.WriteLine("Nombre de la playlist: ");
                            string playlist = Console.ReadLine();

                            foreach (var item in Spotflix.Lista_Playlists)
                            {
                                if (playlist == item.Nombre)
                                {
                                    Console.WriteLine(Spotflix.Lista_Playlists[i - 1].Informacion_Playlist());
                                    Console.WriteLine("1. Seguir \n2. No seguir");
                                    Console.WriteLine("Desea seguir " + playlist + ": ");
                                    int seguir = Convert.ToInt32(Console.ReadLine());
                                    if (seguir == 1)
                                    {
                                        p.Playlists_Canciones_De_Otros.Add(item);
                                        Console.WriteLine("Playlist seguida");
                                        Thread.Sleep(2000);
                                    }
                                }
                                i++;
                            }

                        }
                        else if (opcion == 2)
                        {
                            //Playlist de videos
                        }
                        else if (opcion == 3)
                        {
                            //Playlist de peliculas
                        }
                        else if (opcion == 4)
                        {
                            //Playlist de podcast
                        }
                        else if (opcion == 5)
                        {
                            //Playlist de audiolibro
                        }

                    }

                }

                else if (a == 2)
                {
                    Console.WriteLine("1. Nombre \n2. Sexo \n3. Profesion \n4. Nacionalidad \nQue desea hacer: ");
                    int answer3 = Convert.ToInt32(Console.ReadLine());

                    if (answer3 == 1)
                    {

                        Console.WriteLine("Nombre y Apellido exacto de la persona: ");
                        Console.WriteLine("Ejemplo: Justin Bieber");
                        Console.WriteLine("Ejemplo: justin bieber no es valido");
                        Console.WriteLine(" ");

                        string nombre = Console.ReadLine();
                        int i = 1;
                        foreach (var item in Spotflix.Lista_Personas)
                        {
                            if (nombre == item.Nombre_y_Apellido)
                            {
                                Console.WriteLine(i + ". " + Spotflix.Lista_Personas[i - 1].Informacion_Persona());
                                Console.WriteLine(" ");
                                Console.WriteLine("1. Seguir \n2. No seguir");
                                Console.WriteLine("Desea seguir a " + item.Nombre_y_Apellido + ": ");
                                int seguir = Convert.ToInt32(Console.ReadLine());
                                if (seguir == 1)
                                {
                                    p.Personas_Seguidas.Add(item);
                                    Console.WriteLine("Has seguido a " + item.Nombre_y_Apellido);
                                    Thread.Sleep(2000);
                                }

                            }
                            i += 1;
                        }

                    }

                    else if (answer3 == 2)
                    {
                        Console.WriteLine("1. Mujer \n2. Hombre \nOpcion: ");
                        Console.WriteLine(" ");
                        int sexo = Convert.ToInt32(Console.ReadLine());
                        int i = 1;
                        foreach (var item in Spotflix.Lista_Personas)
                        {
                            if (sexo == item.Sexo)
                            {
                                Console.WriteLine(i + ". " + Spotflix.Lista_Personas[i - 1].Informacion_Persona());

                            }
                            i += 1;
                        }
                        Console.WriteLine(" ");
                        Console.WriteLine("Escoger a una persona: ");
                        int persona = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("1. Seguir \n2. No seguir");
                        Console.WriteLine("Desea seguir a " + Spotflix.Lista_Personas[persona - 1] + "?: ");
                        int seguir = Convert.ToInt32(Console.ReadLine());
                        if (seguir == 1)
                        {
                            p.Personas_Seguidas.Add(Spotflix.Lista_Personas[persona - 1]);
                            Thread.Sleep(2000);
                        }
                        else
                        {
                            Thread.Sleep(1000);
                        }

                    }

                    else if (answer3 == 3)
                    {
                        Console.WriteLine("1. Cantante \n2. Compositor \n3. Actor \n4. Director \n5. Locutor \n6. Lector" +
                         "\nQue desea buscar: ");
                        Console.WriteLine(" ");
                        int answer4 = Convert.ToInt32(Console.ReadLine());

                        if (answer4 == 1)
                        {
                            int i = 1;
                            foreach (var item in Spotflix.Lista_Personas)
                            {
                                if ((Persona.enum_Profesion)answer4 == Persona.enum_Profesion.Cantante)
                                {
                                    Console.WriteLine(i + ". " + Spotflix.Lista_Personas[i - 1].Informacion_Persona());
                                }
                                i++;
                            }
                            Console.WriteLine(" ");
                            Console.WriteLine("Escoger a una persona: ");
                            int persona = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("1. Seguir \n2. No seguir");
                            Console.WriteLine("Desea seguir a " + Spotflix.Lista_Personas[persona - 1] + "?: ");
                            int seguir = Convert.ToInt32(Console.ReadLine());
                            if (seguir == 1)
                            {
                                p.Personas_Seguidas.Add(Spotflix.Lista_Personas[persona - 1]);
                                Thread.Sleep(2000);
                            }
                            else
                            {
                                Thread.Sleep(1000);
                            }
                        }
                        else if (answer4 == 2)
                        {
                            int i = 1;
                            foreach (var item in Spotflix.Lista_Personas)
                            {

                                if ((Persona.enum_Profesion)answer4 == Persona.enum_Profesion.Compositor)
                                {
                                    Console.WriteLine(Spotflix.Lista_Personas[i - 1].Informacion_Persona());
                                    Thread.Sleep(1000);
                                }
                                i++;
                            }
                            Console.WriteLine(" ");
                            Console.WriteLine("Escoger a una persona: ");
                            int persona = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("1. Seguir \n2. No seguir");
                            Console.WriteLine("Desea seguir a " + Spotflix.Lista_Personas[persona - 1] + "?: ");
                            int seguir = Convert.ToInt32(Console.ReadLine());
                            if (seguir == 1)
                            {
                                p.Personas_Seguidas.Add(Spotflix.Lista_Personas[persona - 1]);
                                Thread.Sleep(2000);
                            }
                            else
                            {
                                Thread.Sleep(1000);
                            }

                        }
                        else if (answer4 == 3)
                        {
                            int i = 1;
                            foreach (var item in Spotflix.Lista_Personas)
                            {
                                if ((Persona.enum_Profesion)answer4 == Persona.enum_Profesion.Actor)
                                {
                                    Console.WriteLine(Spotflix.Lista_Personas[i - 1].Informacion_Persona());
                                    Thread.Sleep(1000);
                                }
                                i++;
                            }
                            Console.WriteLine(" ");
                            Console.WriteLine("Escoger a una persona: ");
                            int persona = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("1. Seguir \n2. No seguir");
                            Console.WriteLine("Desea seguir a " + Spotflix.Lista_Personas[persona - 1] + "?: ");
                            int seguir = Convert.ToInt32(Console.ReadLine());
                            if (seguir == 1)
                            {
                                p.Personas_Seguidas.Add(Spotflix.Lista_Personas[persona - 1]);
                                Thread.Sleep(2000);
                            }
                            else
                            {
                                Thread.Sleep(1000);
                            }

                        }
                        else if (answer4 == 4)
                        {
                            int i = 1;
                            foreach (var item in Spotflix.Lista_Personas)
                            {
                                if ((Persona.enum_Profesion)answer4 == Persona.enum_Profesion.Director)
                                {
                                    Console.WriteLine(Spotflix.Lista_Personas[i - 1].Informacion_Persona());
                                    Thread.Sleep(1000);
                                }
                                i++;
                            }
                            Console.WriteLine(" ");
                            Console.WriteLine("Escoger a una persona: ");
                            int persona = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("1. Seguir \n2. No seguir");
                            Console.WriteLine("Desea seguir a " + Spotflix.Lista_Personas[persona - 1] + "?: ");
                            int seguir = Convert.ToInt32(Console.ReadLine());
                            if (seguir == 1)
                            {
                                p.Personas_Seguidas.Add(Spotflix.Lista_Personas[persona - 1]);
                                Thread.Sleep(2000);
                            }
                            else
                            {
                                Thread.Sleep(1000);
                            }

                        }
                        else if (answer4 == 5)
                        {
                            int i = 1;
                            foreach (var item in Spotflix.Lista_Personas)
                            {
                                if ((Persona.enum_Profesion)answer4 == Persona.enum_Profesion.Locutor)
                                {
                                    Console.WriteLine(Spotflix.Lista_Personas[i - 1].Informacion_Persona());
                                    Thread.Sleep(1000);
                                }
                                i++;
                            }
                            Console.WriteLine(" ");
                            Console.WriteLine("Escoger a una persona: ");
                            int persona = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("1. Seguir \n2. No seguir");
                            Console.WriteLine("Desea seguir a " + Spotflix.Lista_Personas[persona - 1] + "?: ");
                            int seguir = Convert.ToInt32(Console.ReadLine());
                            if (seguir == 1)
                            {
                                p.Personas_Seguidas.Add(Spotflix.Lista_Personas[persona - 1]);
                                Thread.Sleep(2000);
                            }
                            else
                            {
                                Thread.Sleep(1000);
                            }

                        }
                        else if (answer4 == 6)
                        {
                            int i = 1;
                            foreach (var item in Spotflix.Lista_Personas)
                            {
                                if ((Persona.enum_Profesion)answer4 == Persona.enum_Profesion.Lector)
                                {
                                    Console.WriteLine(Spotflix.Lista_Personas[i - 1].Informacion_Persona());
                                    Thread.Sleep(1000);
                                }
                                i++;
                            }
                            Console.WriteLine(" ");
                            Console.WriteLine("Escoger a una persona: ");
                            int persona = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("1. Seguir \n2. No seguir");
                            Console.WriteLine("Desea seguir a " + Spotflix.Lista_Personas[persona - 1] + "?: ");
                            int seguir = Convert.ToInt32(Console.ReadLine());
                            if (seguir == 1)
                            {
                                p.Personas_Seguidas.Add(Spotflix.Lista_Personas[persona - 1]);
                                Thread.Sleep(2000);
                            }
                            else
                            {
                                Thread.Sleep(1000);
                            }
                        }


                    }

                    else if (answer3 == 4)
                    {
                        Console.WriteLine("Nacionalidad: ");
                        Console.WriteLine("Ejemplo válido: Estadounidense");
                        Console.WriteLine("Ejemplo no válido: estadounidense ");
                        Console.WriteLine(" ");
                        string nacionalidad = Console.ReadLine();
                        int i = 1;
                        foreach (var item in Spotflix.Lista_Personas)
                        {
                            if (nacionalidad == item.Nacionalidad)
                            {
                                Console.WriteLine(item.Profesion + ": ");
                                Console.WriteLine(" ");
                                Console.WriteLine(Spotflix.Lista_Personas[i - 1].Informacion_Persona());
                                Console.WriteLine(" ");
                            }
                        }
                        Console.WriteLine(" ");
                        Console.WriteLine("Escoger a una persona: ");
                        int persona = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("1. Seguir \n2. No seguir");
                        Console.WriteLine("Desea seguir a " + Spotflix.Lista_Personas[persona - 1] + "?: ");
                        int seguir = Convert.ToInt32(Console.ReadLine());
                        if (seguir == 1)
                        {
                            p.Personas_Seguidas.Add(Spotflix.Lista_Personas[persona - 1]);
                            Thread.Sleep(2000);
                        }
                        else
                        {
                            Thread.Sleep(1000);
                        }
                    }
                }

                else if (a == 3)

                {

                    int i = 1;
                    foreach (var item in Spotflix.Lista_Perfiles)
                    {
                        Console.WriteLine(i +". " + Spotflix.Lista_Perfiles[i - 1].Nombre_perfil);
                        i++;
                    }
                    Console.WriteLine("Que perfil desea ver: ");
                    Console.WriteLine(" ");
                    int perfil = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(Spotflix.Lista_Perfiles[perfil - 1].Informacion_de_Perfil());

                    Console.WriteLine("1. Seguir \n2. No seguir");
                    Console.WriteLine(" ");
                    Console.WriteLine("Desea seguir a " + Spotflix.Lista_Perfiles[perfil - 1] + ": ");
                    int seguir = Convert.ToInt32(Console.ReadLine());
                    if (seguir == 1)
                    {
                        p.Seguidos.Add(Spotflix.Lista_Perfiles[perfil - 1]);
                        Console.WriteLine("Perfil seguido");
                        Thread.Sleep(2000);
                    }


                }

            }
            //Busqueda Compleja 
            else if (answer == 2)
            {
                Console.WriteLine("Que desea buscar?: ");
                Console.WriteLine("1. Multimedia \n2. Persona \n3. Perfil ");

                int a = Convert.ToInt32(Console.ReadLine());

                if (a == 1)
                {
                    int i = 1;
                    Console.WriteLine("Como desea buscar: ");
                    Console.WriteLine("1. Titulo \n2. Categoria \n3. Año \n4. Ranking");
                    Console.WriteLine(" ");

                    Console.WriteLine("Criterio de busqueda 1: ");
                    int opcion1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Criterio de busqueda 2: ");
                    int opcion2 = Convert.ToInt32(Console.ReadLine());

                    if (opcion1 == 1 && opcion2 == 2 || opcion1 == 2 && opcion2 == 1)
                    {
                        Console.WriteLine("Titulo: ");
                        string titulo = Console.ReadLine();
                        Console.WriteLine("1.Canciones \n2.Videos \n3.Podcast \n4.Pelicula \n5.AudioLibro");
                        Console.WriteLine("Categoria:");
                        int categoria = Convert.ToInt32(Console.ReadLine());

                        if (categoria == 1)
                        {
                            int i_1 = 1;
                            foreach (var item in Spotflix.Lista_Canciones)
                            {
                                if (titulo == item.Titulo)
                                {
                                    Console.WriteLine(i_1 + ". " + item.Titulo);
                                    i_1 += 1;
                                }

                            }
                            Console.WriteLine(" ");
                            Console.WriteLine("1. Desea añadir a la cola? ");
                            Console.WriteLine("2. Otro");
                            Console.WriteLine("0. Salir");
                            int opcion = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine(" ");
                            if (opcion == 1)
                            {

                                p.En_Cola_cancion.Add(Spotflix.Lista_Canciones[i_1 - 1]);
                                Console.WriteLine("Cancion agregada a la cola");
                                Console.WriteLine(" ");
                                Thread.Sleep(1000);

                            }
                            else if (opcion == 2)
                            {
                                Console.WriteLine("Desea agregar esta cancion a favoritos?: ");
                                Console.WriteLine("1. Si \n2. No");
                                Console.WriteLine(" ");
                                int agregar = Convert.ToInt32(Console.ReadLine());
                                if (agregar == 1)
                                {
                                    p.Fav_Canciones.Add(Spotflix.Lista_Canciones[i_1 - 1]);
                                    Console.WriteLine("Cancion agregada a favoritos ");
                                    Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine("Desea añadir a una playlist:");
                                    Console.WriteLine("1. Si \n2. No");
                                    int añadir = Convert.ToInt32(Console.ReadLine());
                                    if (añadir == 1)
                                    {
                                        Agregar_Cancion_a_Playlist(p, Spotflix.Lista_Canciones[i_1 - 1]);
                                        Thread.Sleep(1000);
                                    }
                                }
    ;
                            }
                            else if (opcion == 0)
                            {
                                Thread.Sleep(1000);
                            }

                        }
                        else if (categoria == 2)
                        {
                            int i_1 = 1;
                            foreach (var item in Spotflix.Lista_Videos)
                            {
                                if (titulo == item.Titulo)
                                {
                                    Console.WriteLine(i_1 + ". " + item.Titulo);
                                    i_1 += 1;
                                }

                            }
                            Console.WriteLine(" ");
                            Console.WriteLine("1. Desea añadir a la cola? ");
                            Console.WriteLine("2. Otro");
                            Console.WriteLine("0. Salir");
                            int opcion = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine(" ");
                            if (opcion == 1)
                            {

                                p.En_Cola_video.Add(Spotflix.Lista_Videos[i_1 - 1]);
                                Console.WriteLine("Video agregado a la cola");
                                Console.WriteLine(" ");
                                Thread.Sleep(1000);

                            }
                            else if (opcion == 2)
                            {
                                Console.WriteLine("Desea agregar este video a favoritos?: ");
                                Console.WriteLine("1. Si \n2. No");
                                Console.WriteLine(" ");
                                int agregar = Convert.ToInt32(Console.ReadLine());
                                if (agregar == 1)
                                {
                                    p.Fav_Videos.Add(Spotflix.Lista_Videos[i_1 - 1]);
                                    Console.WriteLine("Video agregado a favoritos ");
                                    Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine("Desea añadir a una playlist:");
                                    Console.WriteLine("1. Si \n2. No");
                                    int añadir = Convert.ToInt32(Console.ReadLine());
                                    if (añadir == 1)
                                    {
                                        //añadir a una playlist
                                        Thread.Sleep(1000);
                                    }
                                }
    
                            }
                            else if (opcion == 0)
                            {
                                Thread.Sleep(1000);
                            }

                        }
                        else if (categoria == 3)
                        {
                            int i_1 = 1;
                            foreach (var item in Spotflix.Lista_Podcasts)
                            {
                                if (titulo == item.Titulo)
                                {
                                    Console.WriteLine(i_1 + ". " + item.Titulo);
                                    i_1 += 1;
                                }

                            }
                            Console.WriteLine(" ");
                            Console.WriteLine("1. Desea añadir a la cola? ");
                            Console.WriteLine("2. Otro");
                            Console.WriteLine("0. Salir");
                            int opcion = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine(" ");
                            if (opcion == 1)
                            {

                                p.En_Cola_podcast.Add(Spotflix.Lista_Podcasts[i_1 - 1]);
                                Console.WriteLine("Podcast agregada a la cola");
                                Console.WriteLine(" ");
                                Thread.Sleep(1000);

                            }
                            else if (opcion == 2)
                            {
                                Console.WriteLine("Desea agregar este podcast a favoritos?: ");
                                Console.WriteLine("1. Si \n2. No");
                                Console.WriteLine(" ");
                                int agregar = Convert.ToInt32(Console.ReadLine());
                                if (agregar == 1)
                                {
                                    p.Fav_Podcast.Add(Spotflix.Lista_Podcasts[i_1 - 1]);
                                    Console.WriteLine("Cancion agregada a favoritos ");
                                    Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine("Desea añadir a una playlist:");
                                    Console.WriteLine("1. Si \n2. No");
                                    int añadir = Convert.ToInt32(Console.ReadLine());
                                    if (añadir == 1)
                                    {
                                        //añadir a una playlist
                                        Thread.Sleep(1000);
                                    }
                                }
    
                            }
                            else if (opcion == 0)
                            {
                                Thread.Sleep(1000);
                            }


                        }
                        else if (categoria == 4)
                        {
                            int i_1 = 1;
                            foreach (var item in Spotflix.Lista_Peliculas)
                            {
                                if (titulo == item.Titulo)
                                {
                                    Console.WriteLine(i_1 + ". " + item.Titulo);
                                    i_1 += 1;
                                }

                            }
                            Console.WriteLine(" ");
                            Console.WriteLine("1. Desea añadir a la cola? ");
                            Console.WriteLine("2. Otro");
                            Console.WriteLine("0. Salir");
                            int opcion = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine(" ");
                            if (opcion == 1)
                            {

                                p.En_Cola_pelicula.Add(Spotflix.Lista_Peliculas[i_1 - 1]);
                                Console.WriteLine("Pelicula agregada a la cola");
                                Console.WriteLine(" ");
                                Thread.Sleep(1000);

                            }
                            else if (opcion == 2)
                            {
                                Console.WriteLine("Desea agregar esta pelicula a favoritos?: ");
                                Console.WriteLine("1. Si \n2. No");
                                Console.WriteLine(" ");
                                int agregar = Convert.ToInt32(Console.ReadLine());
                                if (agregar == 1)
                                {
                                    p.Fav_Pelicula.Add(Spotflix.Lista_Peliculas[i_1 - 1]);
                                    Console.WriteLine("Cancion agregada a favoritos ");
                                    Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine("Desea añadir a una playlist:");
                                    Console.WriteLine("1. Si \n2. No");
                                    int añadir = Convert.ToInt32(Console.ReadLine());
                                    if (añadir == 1)
                                    {
                                        //añadir a una playlist
                                        Thread.Sleep(1000);
                                    }
                                }
    
                            }
                            else if (opcion == 0)
                            {
                                Thread.Sleep(1000);
                            }
                        }
                        else if (categoria == 5)
                        {
                            int i_1 = 1;
                            foreach (var item in Spotflix.Lista_AudioLibros)
                            {
                                if (titulo == item.Titulo)
                                {

                                    Console.WriteLine(i_1 + ". " + item.Titulo);
                                    i_1 += 1;
                                }

                            }
                            Console.WriteLine(" ");
                            Console.WriteLine("1. Desea añadir a la cola? ");
                            Console.WriteLine("2. Otro");
                            Console.WriteLine("0. Salir");
                            int opcion = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine(" ");
                            if (opcion == 1)
                            {

                                p.En_Cola_audiolibro.Add(Spotflix.Lista_AudioLibros[i_1 - 1]);
                                Console.WriteLine("Audiolibro agregado a la cola");
                                Console.WriteLine(" ");
                                Thread.Sleep(1000);

                            }
                            else if (opcion == 2)
                            {
                                Console.WriteLine("Desea agregar este audiolibro a favoritos?: ");
                                Console.WriteLine("1. Si \n2. No");
                                Console.WriteLine(" ");
                                int agregar = Convert.ToInt32(Console.ReadLine());
                                if (agregar == 1)
                                {
                                    p.Fav_AudioLibro.Add(Spotflix.Lista_AudioLibros[i_1 - 1]);
                                    Console.WriteLine("Audiolibro agregado a favoritos ");
                                    Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine("Desea añadir a una playlist:");
                                    Console.WriteLine("1. Si \n2. No");
                                    int añadir = Convert.ToInt32(Console.ReadLine());
                                    if (añadir == 1)
                                    {
                                        //añadir a una playlist
                                        Thread.Sleep(1000);
                                    }
                                }

                            }
                            else if (opcion == 0)
                            {
                                Thread.Sleep(1000);
                            }
                        }

                    }
                    else if (opcion1 == 1 && opcion2 == 3 || opcion1 == 3 && opcion2 == 1)
                    {
                        Console.WriteLine("Titulo: ");
                        string titulo = Console.ReadLine();
                        Console.WriteLine("Año: ");
                        int año = Convert.ToInt32(Console.ReadLine());

                        int i_1 = 1;
                        foreach (var item in Spotflix.Lista_Canciones)
                        {

                            if (titulo == item.Titulo && año == item.Año.Year)
                            {
                                Console.WriteLine("Canciones");
                                Console.WriteLine(" ");
                                Console.WriteLine(i_1 + ". " + item.Titulo);
                                i_1 += 1;
                            }
                        }
                        int i_2 = 1;
                        foreach (var item in Spotflix.Lista_Videos)
                        {

                            if (titulo == item.Titulo && año == item.Año.Year)
                            {
                                Console.WriteLine("Videos");
                                Console.WriteLine(" ");
                                Console.WriteLine(i_2 + ". " + item.Titulo);
                                i_2 += 1;
                            }
                        }
                        int i_3 = 1;
                        foreach (var item in Spotflix.Lista_Podcasts)
                        {

                            if (titulo == item.Titulo && año == item.Año.Year)
                            {
                                Console.WriteLine("Podcast");
                                Console.WriteLine(" ");
                                Console.WriteLine(i_3 + ". " + item.Titulo);
                                i_3 += 1;
                            }
                        }
                        int i_4 = 1;
                        foreach (var item in Spotflix.Lista_Peliculas)
                        {

                            if (titulo == item.Titulo && año == item.Año.Year)
                            {
                                Console.WriteLine("Peliculas");
                                Console.WriteLine(" ");
                                Console.WriteLine(i_4 + ". " + item.Titulo);
                                i_4 += 1;
                            }
                        }
                        int i_5 = 1;
                        foreach (var item in Spotflix.Lista_AudioLibros)
                        {

                            if (titulo == item.Titulo && año == item.Año.Year)
                            {
                                Console.WriteLine("Audiolibros");
                                Console.WriteLine(" ");
                                Console.WriteLine(i_5 + ". " + item.Titulo);
                                i_5 += 1;
                            }
                        }
                        Thread.Sleep(2000);
                    }
                    else if (opcion1 == 1 && opcion2 == 4 || opcion1 == 4 && opcion2 == 1)
                    {
                        Console.WriteLine("Titulo: ");
                        string titulo = Console.ReadLine();
                        Console.WriteLine("Ranking: ");
                        double ranking = Convert.ToDouble(Console.ReadLine());
                        int i_1 = 1;
                        foreach (var item in Spotflix.Lista_Canciones)
                        {

                            if (titulo == item.Titulo && ranking == item.Ranking)
                            {
                                Console.WriteLine("Canciones");
                                Console.WriteLine(" ");
                                Console.WriteLine(i_1 + ". " + item.Titulo);
                                i_1 += 1;
                            }
                        }
                        int i_2 = 1;
                        foreach (var item in Spotflix.Lista_Videos)
                        {

                            if (titulo == item.Titulo && ranking == item.Ranking)
                            {
                                Console.WriteLine("Videos");
                                Console.WriteLine(" ");
                                Console.WriteLine(i_2 + ". " + item.Titulo);
                                i_2 += 1;
                            }
                        }
                        int i_3 = 1;
                        foreach (var item in Spotflix.Lista_Podcasts)
                        {

                            if (titulo == item.Titulo && ranking == item.Ranking)
                            {
                                Console.WriteLine("Podcast");
                                Console.WriteLine(" ");
                                Console.WriteLine(i_3 + ". " + item.Titulo);
                                i_3 += 1;
                            }
                        }
                        int i_4 = 1;
                        foreach (var item in Spotflix.Lista_Peliculas)
                        {

                            if (titulo == item.Titulo && ranking == item.Ranking)
                            {
                                Console.WriteLine("Peliculas");
                                Console.WriteLine(" ");
                                Console.WriteLine(i_4 + ". " + item.Titulo);
                                i_4 += 1;
                            }
                        }
                        int i_5 = 1;
                        foreach (var item in Spotflix.Lista_AudioLibros)
                        {

                            if (titulo == item.Titulo && ranking == item.Ranking)
                            {
                                Console.WriteLine("Audiolibros");
                                Console.WriteLine(" ");
                                Console.WriteLine(i_5 + ". " + item.Titulo);
                                i_5 += 1;
                            }
                        }
                        Thread.Sleep(2000);
                    }
                    else if (opcion1 == 2 && opcion2 == 3 || opcion1 == 4 && opcion2 == 2)
                    {
                        Console.WriteLine("1.Canciones \n2.Videos \n3.Podcast \n4.Pelicula \n5.AudioLibro");
                        Console.WriteLine("Categoria: ");
                        int categoria = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Año:");
                        int año = Convert.ToInt32(Console.ReadLine());

                        if (categoria == 1)
                        {
                            int i_1 = 1;
                            foreach (var item in Spotflix.Lista_Canciones)
                            {
                                if (año == item.Año.Year)
                                {
                                    Console.WriteLine("Canciones");
                                    Console.WriteLine(" ");
                                    Console.WriteLine(i_1 + ". " + item.Titulo);
                                    Console.WriteLine(" " + item.Año);
                                    i_1 += 1;
                                }

                            }
                            Console.WriteLine(" ");
                            Console.WriteLine("Escoger una cancion: ");
                            int cancion = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("1. Desea añadir a la cola? ");
                            Console.WriteLine("2. A otra playlist");
                            Console.WriteLine("0. Salir");
                            int opcion = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine(" ");
                            if (opcion == 1)
                            {

                                p.En_Cola_cancion.Add(Spotflix.Lista_Canciones[cancion - 1]);
                                Console.WriteLine("Cancion agregada a la cola");
                                Console.WriteLine(" ");
                                Thread.Sleep(1000);

                            }
                            else if (opcion == 2)
                            {
                                Console.WriteLine("Desea agregar esta cancion a favoritos?: ");
                                Console.WriteLine("1. Si \n2. No");
                                Console.WriteLine(" ");
                                int agregar = Convert.ToInt32(Console.ReadLine());
                                if (agregar == 1)
                                {
                                    p.Fav_Canciones.Add(Spotflix.Lista_Canciones[cancion - 1]);
                                    Console.WriteLine("Cancion agregada a favoritos ");
                                    Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine("Desea añadir a una playlist:");
                                    Console.WriteLine("1. Si \n2. No");
                                    int añadir = Convert.ToInt32(Console.ReadLine());
                                    if (añadir == 1)
                                    {
                                        Agregar_Cancion_a_Playlist(p, Spotflix.Lista_Canciones[cancion - 1]);
                                        Thread.Sleep(1000);
                                    }
                                }
    
                            }
                            else if (opcion == 0)
                            {
                                Thread.Sleep(1000);
                            }



                        }
                        else if (categoria == 2)
                        {
                            int i_1 = 1;
                            foreach (var item in Spotflix.Lista_Videos)
                            {
                                if (año == item.Año.Year)
                                {
                                    Console.WriteLine("Videos");
                                    Console.WriteLine(" ");
                                    Console.WriteLine(i_1 + ". " + item.Titulo);
                                    Console.WriteLine(" " + item.Año);
                                    i_1 += 1;
                                }

                            }
                            Console.WriteLine(" ");
                            Console.WriteLine("Escoger un video: ");
                            int video = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("1. Desea añadir a la cola? ");
                            Console.WriteLine("2. Otro");
                            Console.WriteLine("0. Salir");
                            int opcion = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine(" ");
                            if (opcion == 1)
                            {

                                p.En_Cola_video.Add(Spotflix.Lista_Videos[video - 1]);
                                Console.WriteLine("Video agregado a la cola");
                                Console.WriteLine(" ");
                                Thread.Sleep(1000);

                            }
                            else if (opcion == 2)
                            {
                                Console.WriteLine("Desea agregar este video a favoritos?: ");
                                Console.WriteLine("1. Si \n2. No");
                                Console.WriteLine(" ");
                                int agregar = Convert.ToInt32(Console.ReadLine());
                                if (agregar == 1)
                                {
                                    p.Fav_Videos.Add(Spotflix.Lista_Videos[video - 1]);
                                    Console.WriteLine("Video agregado a favoritos ");
                                    Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine("Desea añadir a una playlist:");
                                    Console.WriteLine("1. Si \n2. No");
                                    int añadir = Convert.ToInt32(Console.ReadLine());
                                    if (añadir == 1)
                                    {
                                        //añadir a una playlist
                                        Thread.Sleep(1000);
                                    }
                                }
    ;
                            }
                            else if (opcion == 0)
                            {
                                Thread.Sleep(1000);
                            }

                        }
                        else if (categoria == 3)
                        {
                            int i_1 = 1;
                            foreach (var item in Spotflix.Lista_Podcasts)
                            {
                                if (año == item.Año.Year)
                                {
                                    Console.WriteLine("Podcast");
                                    Console.WriteLine(" ");
                                    Console.WriteLine(i_1 + ". " + item.Titulo);
                                    Console.WriteLine(" " + item.Año);
                                    i_1 += 1;
                                }

                            }
                            Console.WriteLine(" ");
                            Console.WriteLine("Escoger una podcast: ");
                            int podcast = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("1. Desea añadir a la cola? ");
                            Console.WriteLine("2. Otro");
                            Console.WriteLine("0. Salir");
                            int opcion = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine(" ");
                            if (opcion == 1)
                            {

                                p.En_Cola_podcast.Add(Spotflix.Lista_Podcasts[podcast - 1]);
                                Console.WriteLine("Podcast agregada a la cola");
                                Console.WriteLine(" ");
                                Thread.Sleep(1000);

                            }
                            else if (opcion == 2)
                            {
                                Console.WriteLine("Desea agregar este podcast a favoritos?: ");
                                Console.WriteLine("1. Si \n2. No");
                                Console.WriteLine(" ");
                                int agregar = Convert.ToInt32(Console.ReadLine());
                                if (agregar == 1)
                                {
                                    p.Fav_Podcast.Add(Spotflix.Lista_Podcasts[podcast - 1]);
                                    Console.WriteLine("Cancion agregada a favoritos ");
                                    Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine("Desea añadir a una playlist:");
                                    Console.WriteLine("1. Si \n2. No");
                                    int añadir = Convert.ToInt32(Console.ReadLine());
                                    if (añadir == 1)
                                    {
                                        //añadir a una playlist
                                        Thread.Sleep(1000);
                                    }
                                }
    ;
                            }
                            else if (opcion == 0)
                            {
                                Thread.Sleep(1000);
                            }
                        }
                        else if (categoria == 4)
                        {
                            int i_1 = 1;
                            foreach (var item in Spotflix.Lista_Peliculas)
                            {
                                if (año == item.Año.Year)
                                {
                                    Console.WriteLine("Peliculas");
                                    Console.WriteLine(" ");
                                    Console.WriteLine(i_1 + ". " + item.Titulo);
                                    Console.WriteLine(" " + item.Año);
                                    i_1 += 1;
                                }

                            }
                            Console.WriteLine(" ");
                            Console.WriteLine("Escoger una pelicula: ");
                            int pelicula = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("1. Desea añadir a la cola? ");
                            Console.WriteLine("2. Otro");
                            Console.WriteLine("0. Salir");
                            int opcion = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine(" ");
                            if (opcion == 1)
                            {

                                p.En_Cola_pelicula.Add(Spotflix.Lista_Peliculas[pelicula - 1]);
                                Console.WriteLine("Pelicula agregada a la cola");
                                Console.WriteLine(" ");
                                Thread.Sleep(1000);

                            }
                            else if (opcion == 2)
                            {
                                Console.WriteLine("Desea agregar esta pelicula a favoritos?: ");
                                Console.WriteLine("1. Si \n2. No");
                                Console.WriteLine(" ");
                                int agregar = Convert.ToInt32(Console.ReadLine());
                                if (agregar == 1)
                                {
                                    p.Fav_Pelicula.Add(Spotflix.Lista_Peliculas[pelicula - 1]);
                                    Console.WriteLine("Cancion agregada a favoritos ");
                                    Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine("Desea añadir a una playlist:");
                                    Console.WriteLine("1. Si \n2. No");
                                    int añadir = Convert.ToInt32(Console.ReadLine());
                                    if (añadir == 1)
                                    {
                                        //añadir a una playlist
                                        Thread.Sleep(1000);
                                    }
                                }
    ;
                            }
                            else if (opcion == 0)
                            {
                                Thread.Sleep(1000);
                            }
                        }
                        else if (categoria == 5)
                        {
                            int i_1 = 1;
                            foreach (var item in Spotflix.Lista_AudioLibros)
                            {
                                if (año == item.Año.Year)
                                {
                                    Console.WriteLine("Audiolibros");
                                    Console.WriteLine(" ");
                                    Console.WriteLine(i_1 + ". " + item.Titulo);
                                    Console.WriteLine(" " + item.Año);
                                    i_1 += 1;
                                }

                            }
                            Console.WriteLine(" ");
                            Console.WriteLine("Escoger un audiolibro: ");
                            int audiolibro = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("1. Desea añadir a la cola? ");
                            Console.WriteLine("2. Otro");
                            Console.WriteLine("0. Salir");
                            int opcion = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine(" ");
                            if (opcion == 1)
                            {

                                p.En_Cola_audiolibro.Add(Spotflix.Lista_AudioLibros[audiolibro - 1]);
                                Console.WriteLine("Audiolibro agregado a la cola");
                                Console.WriteLine(" ");
                                Thread.Sleep(1000);

                            }
                            else if (opcion == 2)
                            {
                                Console.WriteLine("Desea agregar este audiolibro a favoritos?: ");
                                Console.WriteLine("1. Si \n2. No");
                                Console.WriteLine(" ");
                                int agregar = Convert.ToInt32(Console.ReadLine());
                                if (agregar == 1)
                                {
                                    p.Fav_AudioLibro.Add(Spotflix.Lista_AudioLibros[audiolibro - 1]);
                                    Console.WriteLine("Audiolibro agregado a favoritos ");
                                    Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine("Desea añadir a una playlist:");
                                    Console.WriteLine("1. Si \n2. No");
                                    int añadir = Convert.ToInt32(Console.ReadLine());
                                    if (añadir == 1)
                                    {
                                        //añadir a una playlist
                                        Thread.Sleep(1000);
                                    }
                                }

                            }
                            else if (opcion == 0)
                            {
                                Thread.Sleep(1000);
                            }

                        }
                    }
                    else if (opcion1 == 2 && opcion2 == 4 || opcion1 == 4 && opcion2 == 2)
                    {
                        Console.WriteLine("1.Canciones \n2.Videos \n3.Podcast \n4.Pelicula \n5.AudioLibro");
                        Console.WriteLine("Categoria: ");
                        int categoria = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ranking: ");
                        double ranking = Convert.ToDouble(Console.ReadLine());

                        if (categoria == 1)
                        {
                            int i_1 = 1;
                            foreach (var item in Spotflix.Lista_Canciones)
                            {
                                if (ranking == item.Ranking)
                                {
                                    Console.WriteLine("Canciones");
                                    Console.WriteLine(" ");
                                    Console.WriteLine(i_1 + ". " + item.Titulo);
                                    Console.WriteLine(" " + item.Ranking);
                                    i_1 += 1;
                                }

                            }
                            Console.WriteLine(" ");
                            Console.WriteLine("Escoger una cancion: ");
                            int cancion = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("1. Desea añadir a la cola? ");
                            Console.WriteLine("2. A otra playlist");
                            Console.WriteLine("0. Salir");
                            int opcion = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine(" ");
                            if (opcion == 1)
                            {

                                p.En_Cola_cancion.Add(Spotflix.Lista_Canciones[cancion - 1]);
                                Console.WriteLine("Cancion agregada a la cola");
                                Console.WriteLine(" ");
                                Thread.Sleep(1000);

                            }
                            else if (opcion == 2)
                            {
                                Console.WriteLine("Desea agregar esta cancion a favoritos?: ");
                                Console.WriteLine("1. Si \n2. No");
                                Console.WriteLine(" ");
                                int agregar = Convert.ToInt32(Console.ReadLine());
                                if (agregar == 1)
                                {
                                    p.Fav_Canciones.Add(Spotflix.Lista_Canciones[cancion - 1]);
                                    Console.WriteLine("Cancion agregada a favoritos ");
                                    Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine("Desea añadir a una playlist:");
                                    Console.WriteLine("1. Si \n2. No");
                                    int añadir = Convert.ToInt32(Console.ReadLine());
                                    if (añadir == 1)
                                    {
                                        Agregar_Cancion_a_Playlist(p, Spotflix.Lista_Canciones[cancion - 1]);
                                        Thread.Sleep(1000);
                                    }
                                }
    ;
                            }
                            else if (opcion == 0)
                            {
                                Thread.Sleep(1000);
                            }



                        }
                        else if (categoria == 2)
                        {
                            int i_1 = 1;
                            foreach (var item in Spotflix.Lista_Videos)
                            {
                                if (ranking == item.Ranking)
                                {
                                    Console.WriteLine("Videos");
                                    Console.WriteLine(" ");
                                    Console.WriteLine(i_1 + ". " + item.Titulo);
                                    Console.WriteLine(" " + item.Ranking);
                                    i_1 += 1;
                                }

                            }
                            Console.WriteLine(" ");
                            Console.WriteLine("Escoger un video: ");
                            int video = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("1. Desea añadir a la cola? ");
                            Console.WriteLine("2. Otro");
                            Console.WriteLine("0. Salir");
                            int opcion = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine(" ");
                            if (opcion == 1)
                            {

                                p.En_Cola_video.Add(Spotflix.Lista_Videos[video - 1]);
                                Console.WriteLine("Video agregado a la cola");
                                Console.WriteLine(" ");
                                Thread.Sleep(1000);

                            }
                            else if (opcion == 2)
                            {
                                Console.WriteLine("Desea agregar este video a favoritos?: ");
                                Console.WriteLine("1. Si \n2. No");
                                Console.WriteLine(" ");
                                int agregar = Convert.ToInt32(Console.ReadLine());
                                if (agregar == 1)
                                {
                                    p.Fav_Videos.Add(Spotflix.Lista_Videos[video - 1]);
                                    Console.WriteLine("Video agregado a favoritos ");
                                    Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine("Desea añadir a una playlist:");
                                    Console.WriteLine("1. Si \n2. No");
                                    int añadir = Convert.ToInt32(Console.ReadLine());
                                    if (añadir == 1)
                                    {
                                        //añadir a una playlist
                                        Thread.Sleep(1000);
                                    }
                                }
    ;
                            }
                            else if (opcion == 0)
                            {
                                Thread.Sleep(1000);
                            }


                        }
                        else if (categoria == 3)
                        {
                            int i_1 = 1;
                            foreach (var item in Spotflix.Lista_Podcasts)
                            {
                                if (ranking == item.Ranking)
                                {
                                    Console.WriteLine("Podcast");
                                    Console.WriteLine(" ");
                                    Console.WriteLine(i_1 + ". " + item.Titulo);
                                    Console.WriteLine(" " + item.Ranking);
                                    i_1 += 1;
                                }

                            }
                            Console.WriteLine(" ");
                            Console.WriteLine("Escoger una podcast: ");
                            int podcast = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("1. Desea añadir a la cola? ");
                            Console.WriteLine("2. Otro");
                            Console.WriteLine("0. Salir");
                            int opcion = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine(" ");
                            if (opcion == 1)
                            {

                                p.En_Cola_podcast.Add(Spotflix.Lista_Podcasts[podcast - 1]);
                                Console.WriteLine("Podcast agregada a la cola");
                                Console.WriteLine(" ");
                                Thread.Sleep(1000);

                            }
                            else if (opcion == 2)
                            {
                                Console.WriteLine("Desea agregar este podcast a favoritos?: ");
                                Console.WriteLine("1. Si \n2. No");
                                Console.WriteLine(" ");
                                int agregar = Convert.ToInt32(Console.ReadLine());
                                if (agregar == 1)
                                {
                                    p.Fav_Podcast.Add(Spotflix.Lista_Podcasts[podcast - 1]);
                                    Console.WriteLine("Cancion agregada a favoritos ");
                                    Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine("Desea añadir a una playlist:");
                                    Console.WriteLine("1. Si \n2. No");
                                    int añadir = Convert.ToInt32(Console.ReadLine());
                                    if (añadir == 1)
                                    {
                                        //añadir a una playlist
                                        Thread.Sleep(1000);
                                    }
                                }
    
                            }
                            else if (opcion == 0)
                            {
                                Thread.Sleep(1000);
                            }



                        }
                        else if (categoria == 4)
                        {
                            int i_1 = 1;
                            foreach (var item in Spotflix.Lista_Peliculas)
                            {
                                if (ranking == item.Ranking)
                                {
                                    Console.WriteLine("Peliculas");
                                    Console.WriteLine(" ");
                                    Console.WriteLine(i_1 + ". " + item.Titulo);
                                    Console.WriteLine(" " + item.Ranking);
                                    i_1 += 1;
                                }

                            }
                            Console.WriteLine(" ");
                            Console.WriteLine("Escoger una pelicula: ");
                            int pelicula = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("1. Desea añadir a la cola? ");
                            Console.WriteLine("2. Otro");
                            Console.WriteLine("0. Salir");
                            int opcion = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine(" ");
                            if (opcion == 1)
                            {

                                p.En_Cola_pelicula.Add(Spotflix.Lista_Peliculas[pelicula - 1]);
                                Console.WriteLine("Pelicula agregada a la cola");
                                Console.WriteLine(" ");
                                Thread.Sleep(1000);

                            }
                            else if (opcion == 2)
                            {
                                Console.WriteLine("Desea agregar esta pelicula a favoritos?: ");
                                Console.WriteLine("1. Si \n2. No");
                                Console.WriteLine(" ");
                                int agregar = Convert.ToInt32(Console.ReadLine());
                                if (agregar == 1)
                                {
                                    p.Fav_Pelicula.Add(Spotflix.Lista_Peliculas[pelicula - 1]);
                                    Console.WriteLine("Cancion agregada a favoritos ");
                                    Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine("Desea añadir a una playlist:");
                                    Console.WriteLine("1. Si \n2. No");
                                    int añadir = Convert.ToInt32(Console.ReadLine());
                                    if (añadir == 1)
                                    {
                                        //añadir a una playlist
                                        Thread.Sleep(1000);
                                    }
                                }
    ;
                            }
                            else if (opcion == 0)
                            {
                                Thread.Sleep(1000);
                            }


                        }
                        else if (categoria == 5)
                        {
                            int i_1 = 1;
                            foreach (var item in Spotflix.Lista_AudioLibros)
                            {
                                if (ranking == item.Ranking)
                                {
                                    Console.WriteLine("Audiolibros");
                                    Console.WriteLine(" ");
                                    Console.WriteLine(i_1 + ". " + item.Titulo);
                                    Console.WriteLine(" " + item.Ranking);
                                    i_1 += 1;
                                }

                            }
                            Console.WriteLine(" ");
                            Console.WriteLine("Escoger un audiolibro: ");
                            int audiolibro = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("1. Desea añadir a la cola? ");
                            Console.WriteLine("2. Otro");
                            Console.WriteLine("0. Salir");
                            int opcion = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine(" ");
                            if (opcion == 1)
                            {

                                p.En_Cola_audiolibro.Add(Spotflix.Lista_AudioLibros[audiolibro - 1]);
                                Console.WriteLine("Audiolibro agregado a la cola");
                                Console.WriteLine(" ");
                                Thread.Sleep(1000);

                            }
                            else if (opcion == 2)
                            {
                                Console.WriteLine("Desea agregar este audiolibro a favoritos?: ");
                                Console.WriteLine("1. Si \n2. No");
                                Console.WriteLine(" ");
                                int agregar = Convert.ToInt32(Console.ReadLine());
                                if (agregar == 1)
                                {
                                    p.Fav_AudioLibro.Add(Spotflix.Lista_AudioLibros[audiolibro - 1]);
                                    Console.WriteLine("Audiolibro agregado a favoritos ");
                                    Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine("Desea añadir a una playlist:");
                                    Console.WriteLine("1. Si \n2. No");
                                    int añadir = Convert.ToInt32(Console.ReadLine());
                                    if (añadir == 1)
                                    {
                                        //añadir a una playlist
                                        Thread.Sleep(1000);
                                    }
                                }

                            }
                            else if (opcion == 0)
                            {
                                Thread.Sleep(1000);
                            }


                        }
                    }
                    else if (opcion1 == 3 && opcion2 == 4 || opcion1 == 4 && opcion2 == 3)
                    {
                        Console.WriteLine("Año:");
                        int año = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ranking: ");
                        double ranking = Convert.ToDouble(Console.ReadLine());
                        foreach (var item in Spotflix.Lista_Canciones)
                        {
                            int i_1 = 1;
                            if (año == item.Año.Year && ranking == item.Ranking)
                            {
                                Console.WriteLine("Canciones");
                                Console.WriteLine(" ");
                                Console.WriteLine(i + ". " + item.Titulo);
                                Console.WriteLine("  " + item.Año);
                                Console.WriteLine("  " + item.Ranking);
                                i_1 += 1;
                            }
                        }
                        foreach (var item in Spotflix.Lista_Videos)
                        {
                            int i_1 = 1;
                            if (año == item.Año.Year && ranking == item.Ranking)
                            {
                                Console.WriteLine("Videos");
                                Console.WriteLine(" ");
                                Console.WriteLine(i + ". " + item.Titulo);
                                Console.WriteLine("  " + item.Año);
                                Console.WriteLine("  " + item.Ranking);
                                i_1 += 1;
                            }
                        }
                        foreach (var item in Spotflix.Lista_Podcasts)
                        {
                            int i_1 = 1;
                            if (año == item.Año.Year && ranking == item.Ranking)
                            {
                                Console.WriteLine("Podcast");
                                Console.WriteLine(" ");
                                Console.WriteLine(i + ". " + item.Titulo);
                                Console.WriteLine("  " + item.Año);
                                Console.WriteLine("  " + item.Ranking);
                                i_1 += 1;
                            }
                        }
                        foreach (var item in Spotflix.Lista_Peliculas)
                        {
                            int i_1 = 1;
                            if (año == item.Año.Year && ranking == item.Ranking)
                            {
                                Console.WriteLine("Peliculas");
                                Console.WriteLine(" ");
                                Console.WriteLine(i + ". " + item.Titulo);
                                Console.WriteLine("  " + item.Año);
                                Console.WriteLine("  " + item.Ranking);
                                i_1 += 1;
                            }
                        }
                        foreach (var item in Spotflix.Lista_AudioLibros)
                        {
                            int i_1 = 1;
                            if (año == item.Año.Year && ranking == item.Ranking)
                            {
                                Console.WriteLine("Audiolibros");
                                Console.WriteLine(" ");
                                Console.WriteLine(i + ". " + item.Titulo);
                                Console.WriteLine("  " + item.Año);
                                Console.WriteLine("  " + item.Ranking);
                                i_1 += 1;
                            }
                        }
                    }

                }
                else if (a == 2)
                {
                    Console.WriteLine("1. Categoria \n2. Sexo \n3. Profesion");
                    Console.WriteLine("Criterio de busqueda 1: ");
                    int opcion1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Criterio de busqueda 2: ");
                    int opcion2 = Convert.ToInt32(Console.ReadLine());
                    if (opcion1 == 1 && opcion2 == 2 || opcion1 == 2 && opcion2 == 1)
                    {
                        Console.WriteLine("1.Canciones \n2.Videos \n3.Podcast \n4.Pelicula \n5.AudioLibro");
                        Console.WriteLine("Categoria: ");
                        int categoria = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("1. Hombre \n2. Mujer");
                        Console.WriteLine("Sexo: ");
                        int sexo = Convert.ToInt32(Console.ReadLine());

                        if (categoria == 1)
                        {
                            Console.WriteLine("Nombre: ");
                            string nombre = Console.ReadLine();

                            int i_1 = 1;
                            foreach (var item in Spotflix.Lista_Personas)
                            {
                                if (nombre == item.Nombre_y_Apellido && sexo == item.Sexo && item.Profesion[0] == 1 || item.Profesion[0] == 2)
                                {
                                    Console.WriteLine(i_1 + ". " + item.Nombre_y_Apellido);
                                    Console.WriteLine("Sexo: " + item.Sexo);
                                    Console.WriteLine("Profesion: " + item.Profesion);
                                    Console.WriteLine("1. Seguir \n2. No seguir");
                                    Console.WriteLine("Desea seguir a " + item.Nombre_y_Apellido + ": ");

                                    int seguir = Convert.ToInt32(Console.ReadLine());
                                    if (seguir == 1)
                                    {
                                        p.Personas_Seguidas.Add(item);
                                    }
                                    i_1 += 1;

                                }

                            }
                        }
                        else if (categoria == 2 || categoria == 4)
                        {
                            Console.WriteLine("Nombre: ");
                            string nombre = Console.ReadLine();
                            int i_1 = 1;
                            foreach (var item in Spotflix.Lista_Personas)
                            {
                                if (nombre == item.Nombre_y_Apellido && sexo == item.Sexo && item.Profesion[0] == 3 || item.Profesion[0] == 4)
                                {
                                    Console.WriteLine(i_1 + ". " + item.Nombre_y_Apellido);
                                    Console.WriteLine("Sexo: " + item.Sexo);
                                    Console.WriteLine("Profesion: " + item.Profesion);
                                    Console.WriteLine("1. Seguir \n2. No seguir");
                                    Console.WriteLine("Desea seguir a " + item.Nombre_y_Apellido + ": ");
                                    int seguir = Convert.ToInt32(Console.ReadLine());
                                    if (seguir == 1)
                                    {
                                        p.Personas_Seguidas.Add(item);
                                    }
                                    i_1 += 1;
                                }

                            }
                        }
                        else if (categoria == 3)
                        {
                            Console.WriteLine("Nombre: ");
                            string nombre = Console.ReadLine();
                            int i_1 = 1;
                            foreach (var item in Spotflix.Lista_Personas)
                            {
                                if (nombre == item.Nombre_y_Apellido && sexo == item.Sexo && item.Profesion[0] == 5)
                                {
                                    Console.WriteLine(i_1 + ". " + item.Nombre_y_Apellido);
                                    Console.WriteLine("Sexo: " + item.Sexo);
                                    Console.WriteLine("Profesion: " + item.Profesion);
                                    Console.WriteLine("1. Seguir \n2. No seguir");
                                    Console.WriteLine("Desea seguir a " + item.Nombre_y_Apellido + ": ");
                                    int seguir = Convert.ToInt32(Console.ReadLine());
                                    if (seguir == 1)
                                    {
                                        p.Personas_Seguidas.Add(item);
                                    }
                                    i_1 += 1;
                                }

                            }
                        }
                        else if (categoria == 5)
                        {
                            Console.WriteLine("Nombre: ");
                            string nombre = Console.ReadLine();
                            int i_1 = 1;
                            foreach (var item in Spotflix.Lista_Personas)
                            {
                                if (nombre == item.Nombre_y_Apellido && sexo == item.Sexo && item.Profesion[0] == 6)
                                {
                                    Console.WriteLine(i_1 + ". " + item.Nombre_y_Apellido);
                                    Console.WriteLine("Sexo: " + item.Sexo);
                                    Console.WriteLine("Profesion: " + item.Profesion);
                                    Console.WriteLine("1. Seguir \n2. No seguir");
                                    Console.WriteLine("Desea seguir a " + item.Nombre_y_Apellido + ": ");
                                    int seguir = Convert.ToInt32(Console.ReadLine());
                                    if (seguir == 1)
                                    {
                                        p.Personas_Seguidas.Add(item);
                                    }
                                    i_1 += 1;
                                }

                            }
                        }

                    }
                    else if (opcion1 == 1 && opcion2 == 3 || opcion1 == 3 && opcion2 == 1)
                    {
                        Console.WriteLine("1.Canciones \n2.Videos \n3.Podcast \n4.Pelicula \n5.AudioLibro");
                        Console.WriteLine("Categoria: ");
                        int categoria = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("1. Cantante \n2. Compositor \n3. Actor \n4. Director \n5. Locutor \n6. Lector");
                        Console.WriteLine("Profesion: ");
                        int profesion = Convert.ToInt32(Console.ReadLine());

                        if (profesion == 1 && categoria == 1)
                        {
                            Console.WriteLine("Nombre del cantante: ");
                            string nombre = Console.ReadLine();

                            int x = 1;
                            foreach (var item in Spotflix.Lista_Personas)
                            {
                                if (nombre == item.Nombre_y_Apellido && profesion == item.Profesion[0])
                                {
                                    foreach (var item1 in Spotflix.Lista_Canciones)
                                    {
                                        Console.WriteLine("Cantante: " + item1.Cantante);
                                        Console.WriteLine(x + ". " + item1.Titulo);
                                    }
                                    x++;

                                }
                            }
                            Console.WriteLine(" ");
                            Console.WriteLine("Escoger una cancion: ");
                            int cancion = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("1. Desea añadir a la cola? ");
                            Console.WriteLine("2. A otra playlist");
                            Console.WriteLine("0. Salir");
                            int opcion = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine(" ");
                            if (opcion == 1)
                            {

                                p.En_Cola_cancion.Add(Spotflix.Lista_Canciones[cancion - 1]);
                                Console.WriteLine("Cancion agregada a la cola");
                                Console.WriteLine(" ");
                                Thread.Sleep(1000);

                            }
                            else if (opcion == 2)
                            {
                                Console.WriteLine("Desea agregar esta cancion a favoritos?: ");
                                Console.WriteLine("1. Si \n2. No");
                                Console.WriteLine(" ");
                                int agregar = Convert.ToInt32(Console.ReadLine());
                                if (agregar == 1)
                                {
                                    p.Fav_Canciones.Add(Spotflix.Lista_Canciones[cancion - 1]);
                                    Console.WriteLine("Cancion agregada a favoritos ");
                                    Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine("Desea añadir a una playlist:");
                                    Console.WriteLine("1. Si \n2. No");
                                    int añadir = Convert.ToInt32(Console.ReadLine());
                                    if (añadir == 1)
                                    {
                                        Agregar_Cancion_a_Playlist(p, Spotflix.Lista_Canciones[cancion - 1]);
                                        Thread.Sleep(1000);
                                    }
                                }

                            }
                            else if (opcion == 0)
                            {
                                Thread.Sleep(1000);
                            }




                        }
                        else if (profesion == 2 && categoria == 1)
                        {
                            Console.WriteLine("Nombre del compositor: ");
                            string nombre = Console.ReadLine();

                            int x = 1;
                            foreach (var item in Spotflix.Lista_Personas)
                            {
                                if (nombre == item.Nombre_y_Apellido && profesion == item.Profesion[0])
                                {
                                    foreach (var item1 in Spotflix.Lista_Canciones)
                                    {
                                        Console.WriteLine("Compositor: " + item1.Compositor);
                                        Console.WriteLine(x + ". " + item1.Titulo);
                                    }
                                    x++;

                                }
                            }
                            Console.WriteLine(" ");
                            Console.WriteLine("Escoger una cancion: ");
                            int cancion = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("1. Desea añadir a la cola? ");
                            Console.WriteLine("2. A otra playlist");
                            Console.WriteLine("0. Salir");
                            int opcion = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine(" ");
                            if (opcion == 1)
                            {

                                p.En_Cola_cancion.Add(Spotflix.Lista_Canciones[cancion - 1]);
                                Console.WriteLine("Cancion agregada a la cola");
                                Console.WriteLine(" ");
                                Thread.Sleep(1000);

                            }
                            else if (opcion == 2)
                            {
                                Console.WriteLine("Desea agregar esta cancion a favoritos?: ");
                                Console.WriteLine("1. Si \n2. No");
                                Console.WriteLine(" ");
                                int agregar = Convert.ToInt32(Console.ReadLine());
                                if (agregar == 1)
                                {
                                    p.Fav_Canciones.Add(Spotflix.Lista_Canciones[cancion - 1]);
                                    Console.WriteLine("Cancion agregada a favoritos ");
                                    Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine("Desea añadir a una playlist:");
                                    Console.WriteLine("1. Si \n2. No");
                                    int añadir = Convert.ToInt32(Console.ReadLine());
                                    if (añadir == 1)
                                    {
                                        Agregar_Cancion_a_Playlist(p, Spotflix.Lista_Canciones[cancion - 1]);
                                        Thread.Sleep(1000);
                                    }
                                }

                            }
                            else if (opcion == 0)
                            {
                                Thread.Sleep(1000);
                            }


                        }
                        else if (profesion == 3 && categoria == 2)
                        {
                            Console.WriteLine("Nombre del actor: ");
                            string nombre = Console.ReadLine();

                            int x = 1;
                            foreach (var item in Spotflix.Lista_Personas)
                            {
                                if (nombre == item.Nombre_y_Apellido && profesion == item.Profesion[0])
                                {
                                    foreach (var item1 in Spotflix.Lista_Videos)
                                    {
                                        Console.WriteLine("Actor: " + item.Nombre_y_Apellido);
                                        Console.WriteLine(x + ". " + item1.Titulo);
                                    }
                                    x++;

                                }
                            }



                        }
                        else if (profesion == 3 && categoria == 4)
                        {
                            Console.WriteLine("Nombre del actor: ");
                            string nombre = Console.ReadLine();

                            int x = 1;
                            foreach (var item in Spotflix.Lista_Personas)
                            {
                                if (nombre == item.Nombre_y_Apellido && profesion == item.Profesion[0])
                                {
                                    foreach (var item1 in Spotflix.Lista_Peliculas)
                                    {
                                        Console.WriteLine("Actor: " + item1.Actor);
                                        Console.WriteLine(x + ". " + item1.Titulo);
                                    }
                                    x++;

                                }
                            }

                        }
                        else if (profesion == 4 && categoria == 4)
                        {
                            Console.WriteLine("Nombre del director: ");
                            string nombre = Console.ReadLine();

                            int x = 1;
                            foreach (var item in Spotflix.Lista_Personas)
                            {
                                if (nombre == item.Nombre_y_Apellido && profesion == item.Profesion[0])
                                {
                                    foreach (var item1 in Spotflix.Lista_Peliculas)
                                    {
                                        Console.WriteLine("Director: " + item.Nombre_y_Apellido);
                                        Console.WriteLine(x + ". " + item1.Titulo);
                                    }
                                    x++;

                                }
                            }
                        }
                        else if (profesion == 4 && categoria == 2)
                        {
                            Console.WriteLine("Nombre del director: ");
                            string nombre = Console.ReadLine();

                            int x = 1;
                            foreach (var item in Spotflix.Lista_Personas)
                            {
                                if (nombre == item.Nombre_y_Apellido && profesion == item.Profesion[0])
                                {
                                    foreach (var item1 in Spotflix.Lista_Videos)
                                    {
                                        Console.WriteLine("Director: " + item.Nombre_y_Apellido);
                                        Console.WriteLine(x + ". " + item1.Titulo);
                                    }
                                    x++;

                                }
                            }

                        }
                        else if (profesion == 5 && categoria == 3)
                        {
                            Console.WriteLine("Nombre del locutor: ");
                            string nombre = Console.ReadLine();

                            int x = 1;
                            foreach (var item in Spotflix.Lista_Personas)
                            {
                                if (nombre == item.Nombre_y_Apellido && profesion == item.Profesion[0])
                                {
                                    foreach (var item1 in Spotflix.Lista_Podcasts)
                                    {
                                        Console.WriteLine("Locutor: " + item1.Locutor);
                                        Console.WriteLine(x + ". " + item1.Titulo);
                                    }
                                    x++;

                                }
                            }

                        }
                        else if (profesion == 6 && categoria == 5)
                        {
                            Console.WriteLine("Nombre del Lector: ");
                            string nombre = Console.ReadLine();

                            int x = 1;
                            foreach (var item in Spotflix.Lista_Personas)
                            {
                                if (nombre == item.Nombre_y_Apellido && profesion == item.Profesion[0])
                                {
                                    foreach (var item1 in Spotflix.Lista_AudioLibros)
                                    {
                                        Console.WriteLine("Lector: " + item.Nombre_y_Apellido);
                                        Console.WriteLine(x + ". " + item1.Titulo);
                                    }
                                    x++;

                                }
                            }
                        }

                    }
                    else if (opcion1 == 2 && opcion2 == 3 || opcion1 == 3 && opcion2 == 2)
                    {
                        Console.WriteLine("1. Hombre \n2. Mujer");
                        Console.WriteLine("Sexo: ");
                        int sexo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("1. Cantante \n2. Compositor \n3. Actor \n4. Director \n5. Locutor \n6. Lector");
                        Console.WriteLine("Profesion: ");
                        int profesion = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Nombre: ");
                        string nombre = Console.ReadLine();

                        int i_1 = 1;
                        foreach (var item in Spotflix.Lista_Personas)
                        {
                            if (nombre == item.Nombre_y_Apellido && sexo == item.Sexo && profesion == item.Profesion[0])
                            {
                                Console.WriteLine(i_1 + ". " + item.Nombre_y_Apellido);
                                Console.WriteLine("Sexo: " + item.Sexo);
                                Console.WriteLine("Profesion: " + item.Profesion);
                                Console.WriteLine("1. Seguir \n2. No seguir");
                                Console.WriteLine("Desea seguir a " + item.Nombre_y_Apellido + ": ");

                                int seguir = Convert.ToInt32(Console.ReadLine());
                                if (seguir == 1)
                                {
                                    p.Personas_Seguidas.Add(item);
                                }
                                i_1 += 1;

                            }

                        }
                    }
                }
                else if (a == 3)
                {
                    int i = 1;
                    foreach (var item in Spotflix.Lista_Perfiles)
                    {
                        Console.WriteLine(Spotflix.Lista_Perfiles[i - 1].Nombre_perfil);
                    }
                    Console.WriteLine("Que perfil desea ver: ");
                    Console.WriteLine(" ");
                    int perfil = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(Spotflix.Lista_Perfiles[perfil - 1].Informacion_de_Perfil());

                    Console.WriteLine("1. Seguir \n2. No seguir");
                    Console.WriteLine(" ");
                    Console.WriteLine("Desea seguir a " + Spotflix.Lista_Perfiles[perfil - 1] + ": ");
                    int seguir = Convert.ToInt32(Console.ReadLine());
                    if (seguir == 1)
                    {
                        p.Seguidos.Add(Spotflix.Lista_Perfiles[perfil - 1]);
                        Console.WriteLine("Perfil seguido");
                    }

                }
            }


        }

        public static void Editar_Informacion_Admin()
        {
            Console.Clear();
            Console.WriteLine("Que quieres editar?\n[1] Archivos\n[2] Usuarios/Perfiles\n[0] Salir");
            int x = Convert.ToInt32(Console.ReadLine());
            x -= 1;
            if (x == 0)
            {
                Console.WriteLine("Que quieres editar? \n[1] AudiLibro \n[2] Cancion \n[3] Pelicula\n[4] Podcast \n[5] Video \n [0] Salir?");
                int xy = Convert.ToInt32(Console.ReadLine());
                xy -= 1;
                if (xy == 0)//AL
                {
                    while (xy == 0)
                    {
                        int i = 1;
                        foreach (var item in Spotflix.Lista_AudioLibros)
                        {
                            Console.WriteLine("\n[" + i + "]. " + item.Titulo);
                            i += 1;
                        }
                        Console.WriteLine("Cual quieres editar? [x]\n[0] Salir");
                        int y = Convert.ToInt32(Console.ReadLine());
                        if (y >= 1 && y <= i)
                        {
                            AudioLibro c1 = Spotflix.Lista_AudioLibros[y - 1];
                            Console.WriteLine("Informacion del AudioLibro a editar: \n");
                            Console.WriteLine(Spotflix.Lista_AudioLibros[y - 1].Informacion_AudioLibro());
                            Console.WriteLine("Quieres editarlo? [si=0, no=1]");
                            int y2 = Convert.ToInt32(Console.ReadLine());
                            if (y2 == 0)
                            {
                                Console.WriteLine("\nEditando AudioLibro:");
                                Console.WriteLine("Titulo;");
                                string titulo = Console.ReadLine();
                                Console.WriteLine("Su fecha:[DD/MM/AAAA]");
                                DateTime dt = Convert.ToDateTime(Console.ReadLine());
                                Console.WriteLine("Idioma;");
                                string Album = Console.ReadLine();

                                Console.WriteLine("Genero;");
                                string genero = Console.ReadLine();

                                AudioLibro cc1 = new AudioLibro(titulo, c1.Categoria, dt, c1.Duracion, c1.Ranking, c1.Estado,
                                    c1.URL, c1.URL_Texto, genero, c1.Idioma, c1.Lector);

                                c1.Editar_Informacion(cc1);
                            }
                        }
                        else if (y == 0)
                        {
                            Console.WriteLine("Saliento...");
                            Thread.Sleep(1000);
                        }

                        Console.WriteLine("Quieres editar un AudioLibro denuevo? [0] si, [1] no");
                        xy = Convert.ToInt32(Console.ReadLine());
                    }
                }
                else if (xy == 1)//Canciones
                {
                    while (xy == 1)
                    {
                        int i = 1;
                        foreach (var item in Spotflix.Lista_Canciones)
                        {
                            Console.WriteLine("[" + i + "]. " + item.Titulo);
                            i += 1;
                        }
                        Console.WriteLine("Cual quieres editar? [x]\n[0] Salir");
                        int y = Convert.ToInt32(Console.ReadLine());
                        if (y >= 1 && y <= i)
                        {
                            Cancion c1 = Spotflix.Lista_Canciones[y - 1];
                            Console.WriteLine("Informacion de la cancion a editar: ");
                            Console.WriteLine(Spotflix.Lista_Canciones[y - 1].Informacion_Cancion());
                            Console.WriteLine("Quieres editarlo? \n[1] Si\n[1] No");
                            int y2 = Convert.ToInt32(Console.ReadLine());
                            y2 -= 1;
                            if (y2 == 0)
                            {
                                Console.WriteLine("Editando Cancion:");
                                Console.WriteLine("Titulo;");
                                string titulo = Console.ReadLine();
                                Console.WriteLine("Su fecha:[DD/MM/AAAA]");
                                DateTime dt = Convert.ToDateTime(Console.ReadLine());

                                Console.WriteLine("Album;");
                                string Album = Console.ReadLine();

                                Console.WriteLine("Genero;");
                                string genero = Console.ReadLine();

                                Cancion cc1 = new Cancion(titulo, c1.Categoria, dt, c1.Duracion, c1.Ranking, c1.Estado,
                                    c1.URL, c1.Cantante, c1.Compositor, Album, c1.Imagen, c1.Letra, genero);

                                c1.Editar_Informacion(cc1);
                            }
                        }
                        else if (y == 0)
                        {
                            Console.WriteLine("Saliento...");
                            Thread.Sleep(1000);
                        }
                        Console.WriteLine("Quieres editar una Cancion denuevo?\n[1] Si\n[0] No");
                        xy = Convert.ToInt32(Console.ReadLine());
                    }
                }
                else if (xy == 2) //Pel
                {
                    while (xy == 2)
                    {
                        int i = 1;
                        foreach (var item in Spotflix.Lista_Peliculas)
                        {
                            Console.WriteLine("[" + i + "]. " + item.Titulo);
                            i += 1;
                        }
                        Console.WriteLine("Cual quieres editar? [x]\n[0] Salir");
                        int y = Convert.ToInt32(Console.ReadLine());
                        if (y >= 1 && y <= i)
                        {
                            Pelicula c1 = Spotflix.Lista_Peliculas[y - 1];
                            Console.WriteLine("Informacion de la pelicula a editar: ");
                            Console.WriteLine(Spotflix.Lista_Peliculas[y - 1].Informacion_Pelicula());
                            Console.WriteLine("Quieres editarlo? [si=0, no=1]");
                            int y2 = Convert.ToInt32(Console.ReadLine());
                            if (y2 == 0)
                            {
                                Console.WriteLine("Editando Pelicula:");
                                Console.WriteLine("Titulo:");
                                string titulo = Console.ReadLine();
                                Console.WriteLine("Su fecha:[DD/MM/AAAA]");
                                DateTime dt = Convert.ToDateTime(Console.ReadLine());

                                Console.WriteLine("Descripcion:");
                                string descripcion = Console.ReadLine();

                                Pelicula cc1 = new Pelicula(titulo, c1.Categoria, dt, c1.Duracion, c1.Ranking, c1.Estado,
                                    c1.URL, c1.Actor, c1.Director, c1.Estudio, c1.Resolucion, descripcion, c1.Clasificacion, c1.Genero);

                                c1.Editar_Informacion(cc1);
                            }
                        }
                        else if (y == 0)
                        {
                            Console.WriteLine("Saliento...");
                            Thread.Sleep(1000);
                        }
                        Console.WriteLine("Quieres editar una Pelicula denuevo? \n[1] Si\n[0] No");
                        xy = Convert.ToInt32(Console.ReadLine());
                        xy -= 1;
                        if (xy == 0)
                        {
                            xy = 2;
                        }

                    }

                }
                else if (xy == 3) //podcast
                {
                    while (xy == 3)
                    {
                        int i = 1;
                        foreach (var item in Spotflix.Lista_Podcasts)
                        {
                            Console.WriteLine("[" + i + "]. " + item.Titulo);
                            i += 1;
                        }
                        Console.WriteLine("Cual quieres editar? [x]\n[0] Salir");
                        int y = Convert.ToInt32(Console.ReadLine());
                        if (y >= 1 && y <= i)
                        {
                            Podcast c1 = Spotflix.Lista_Podcasts[y - 1];
                            Console.WriteLine("Informacion del Podcast a editar: ");
                            Console.WriteLine(Spotflix.Lista_Podcasts[y - 1].Informacion_Podcast());
                            Console.WriteLine("Quieres editarlo? [si=0, no=1]");
                            int y2 = Convert.ToInt32(Console.ReadLine());
                            if (y2 == 0)
                            {
                                Console.WriteLine("Editando Podcast:");
                                Console.WriteLine("Titulo;");
                                string titulo = Console.ReadLine();


                                Console.WriteLine("Su fecha:[DD/MM/AAAA]");
                                DateTime dt = Convert.ToDateTime(Console.ReadLine());
                                Console.WriteLine("Genero;");
                                string genero = Console.ReadLine();

                                Podcast cc1 = new Podcast(titulo, c1.Categoria, dt, c1.Duracion, c1.Ranking, c1.Estado,
                                    c1.URL, c1.Locutor, c1.Imagen, genero);

                                c1.Editar_Informacion(cc1);
                            }
                        }
                        else if (y == 0)
                        {
                            Console.WriteLine("Saliento...");
                            Thread.Sleep(1000);
                        }
                        Console.WriteLine("Quieres editar un Podcast denuevo? \n[1] Si\n[0] No");
                        xy = Convert.ToInt32(Console.ReadLine());
                        xy -= 1;
                        if (xy == 0)
                        {
                            xy = 3;
                        }
                    }
                }
                else if (xy == 4)//video
                {
                    while (xy == 4)
                    {
                        int i = 1;
                        foreach (var item in Spotflix.Lista_Videos)
                        {
                            Console.WriteLine("[" + i + "]. " + item.Titulo);
                            i += 1;
                        }
                        Console.WriteLine("Cual quieres editar? [x]\n[0] Para salir");
                        int y = Convert.ToInt32(Console.ReadLine());
                        if (y >= 1 && y <= i)
                        {
                            Video c1 = Spotflix.Lista_Videos[y - 1];
                            Console.WriteLine("Informacion del Video a editar: ");
                            Console.WriteLine(Spotflix.Lista_Videos[y - 1].Informacion_Video());
                            Console.WriteLine("Quieres editarlo? \n[1] Si\n[0] No");
                            int y2 = Convert.ToInt32(Console.ReadLine());
                            y2 -= 1;
                            if (y2 == 0)
                            {
                                Console.WriteLine("Editando Video:");
                                Console.WriteLine("Titulo;");
                                string titulo = Console.ReadLine();
                                Console.WriteLine("Su fecha:[DD/MM/AAAA]");
                                DateTime dt = Convert.ToDateTime(Console.ReadLine());
                                Console.WriteLine("Descripcion:");
                                string descripcion = Console.ReadLine();
                                Console.WriteLine("Su fecha:[DD/MM/AAAA]");
                                DateTime dt2 = Convert.ToDateTime(Console.ReadLine());
                                Video cc1 = new Video(titulo, c1.Categoria, dt, c1.Duracion, c1.Ranking, c1.Estado, c1.URL, c1.Resolucion, descripcion, c1.Clasificacion, c1.Genero);
                                c1.Editar_Informacion(cc1);
                                Console.WriteLine("Informacion editandose...");
                                Thread.Sleep(3000);
                            }
                        }
                        else if (y == 0)
                        {
                            Console.WriteLine("Saliento...");
                            Thread.Sleep(1000);
                        }
                        Console.WriteLine("Quieres editar un Video denuevo?\n[1] Si\n[0] No ");
                        xy = Convert.ToInt32(Console.ReadLine());
                        if (xy == 1)
                        {
                            xy = 4;
                        }
                    }
                }
                else if (xy == -1)
                {
                    Console.WriteLine("Saliendo de editar archivos");
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("Error, ¡valor distinto de 0 a 5!");
                }
            }
            else if (x == 1)
            {
                Console.WriteLine("Que quieres editar?\n[1] Usuarios\n[2] Perfiles\n[0] Salir");
                int xy = Convert.ToInt32(Console.ReadLine());
                xy -= 1;
                if (xy == 0)//Usuario
                {
                    while (xy == 0)
                    {
                        int i = 1;
                        foreach (var item in Spotflix.Lista_Usuarios)
                        {
                            Console.WriteLine("[" + i + "]. " + item.Nombre + " " + item.Apellido);
                            i += 1;
                        }
                        Console.WriteLine("Cual quieres editar? [x]");
                        int y = Convert.ToInt32(Console.ReadLine());
                        if (y >= 1 && y <= i)
                        {
                            Console.WriteLine("Informacion del Usuario a editar: ");
                            Console.WriteLine(Spotflix.Lista_Usuarios[y - 1].Informacion_Usuario());
                            Console.WriteLine("Quieres editarlo? \n[1] Si\n[0] No");
                            int y2 = Convert.ToInt32(Console.ReadLine());
                            y2 -= 1;
                            if (y2 == 0)
                            {
                                Console.WriteLine("Editando Usuario:");
                                Console.WriteLine("Su nombre:");
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
                                Console.WriteLine("Su tipo de membresia:");
                                int tipomemb = Convert.ToInt32(Console.ReadLine());

                                Usuario u1 = new Usuario(nomb, apell, dt, sex, pais, email, contra, tipomemb);
                                Spotflix.Lista_Usuarios[y].Editar_Informacion(u1);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error, usuario no encontrado");
                            Thread.Sleep(1000);
                        }
                        Console.WriteLine("Quieres editar un Usuario denuevo? \n[1] Si \n[0] No");
                        xy = Convert.ToInt32(Console.ReadLine());
                        xy -= 1;
                    }
                }
                else if (xy == 1)//PERF
                {
                    while (xy == 1)
                    {
                        int i = 1;
                        foreach (var item in Spotflix.Lista_Perfiles)
                        {
                            Console.WriteLine("[" + i + "]. " + item.Nombre_perfil);
                            i += 1;
                        }
                        Console.WriteLine("Cual quieres editar? [x]\n[0] Salir");
                        int y = Convert.ToInt32(Console.ReadLine());
                        if (y >= 1 && y <= i)
                        {
                            Console.WriteLine("Informacion del Perfil a editar: ");
                            Console.WriteLine(Spotflix.Lista_Perfiles[y - 1].Informacion_de_Perfil());
                            Perfil per = Spotflix.Lista_Perfiles[y - 1];
                            Console.WriteLine("Quieres editarlo? \n[1] Si\n[2] No");
                            int y2 = Convert.ToInt32(Console.ReadLine());
                            y2 -= 1;
                            if (y2 == 0)
                            {
                                Console.WriteLine("Editando Perfil: ");
                                Console.WriteLine("Su nombre:");
                                string nomb = Console.ReadLine();
                                Console.WriteLine("Su tipo de perfil: ");
                                int tipoperf = Convert.ToInt32(Console.ReadLine());
                                Perfil p1 = new Perfil(per.Usuario_Asociado, nomb, tipoperf);
                                per.Editar_Informacion(p1);
                            }
                        }
                        else if (y == 0)
                        {
                            Console.WriteLine("Saliendo");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Error, Perfil no encontrado");
                            Thread.Sleep(1000);
                        }
                        Console.WriteLine("Quieres editar un Perfil denuevo? \n[1] Si \n[0] No");
                        xy = Convert.ToInt32(Console.ReadLine());
                        xy -= 1;
                        if (xy == 0)
                        {
                            xy = 1;
                        }
                    }
                }
                else if (xy == -1)
                {
                    Console.WriteLine("Saliendo");
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("Error, ¡valor distinto de 1 o 2!");
                    Thread.Sleep(1000);
                }
            }
            else if (x == -1)
            {
                Console.WriteLine("Saliendo...");
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("Numero no esta dentro del intervalo, Saliendo");
                Thread.Sleep(1000);
            }
        }

        public static void Editar_Informacion_Usuario(Usuario usuario)
        {
            Console.Clear();
            Console.WriteLine("Deseas cambiar la informacion de un: \n[1] Usuario\n[2] Perfil\n[0] Salir ?");
            int edituser = Convert.ToInt32(Console.ReadLine());
            edituser -= 1;
            if (edituser == 0)
            {
                Console.WriteLine("Informacion: ");
                Console.WriteLine(usuario.Informacion_Usuario());
                Console.WriteLine("Quieres modificarla? (Cuidado, vas a tener que modificar toda la informacion!)");
                Console.WriteLine("Si [1], No [0]");
                int edituser2 = Convert.ToInt32(Console.ReadLine());
                if (edituser2 == 1)
                {
                    Console.WriteLine("Su nombre:");
                    string nomb = Console.ReadLine();
                    Console.WriteLine("Su apellido:");
                    string apell = Console.ReadLine();
                    Console.WriteLine("Su fecha:[DD/MM/AAAA]");
                    DateTime dt = Convert.ToDateTime(Console.ReadLine());
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
                    Usuario u1 = new Usuario(nomb, apell, dt, sex, pais, email, contra, usuario.Tipo_de_Membresia);
                    usuario.Editar_Informacion(u1);
                }
                else
                {
                    Console.WriteLine("Informacion no modificada!");
                }
            }
            else if (edituser == 1)
            {
                Console.WriteLine("Acontinuacion se mostraran todos los perfil enlazados a tu usuario");
                int count = 0;
                foreach (var item in Spotflix.Lista_Perfiles)
                {
                    if (item.Usuario_Asociado == usuario)
                    {
                        Console.WriteLine("\n" + item.Informacion_de_Perfil());
                        Console.WriteLine("Desea [0] Cambiar Nombre, [1] Resetear todas las listas, [2] Eliminarlo");
                        int editprofile = Convert.ToInt32(Console.ReadLine());
                        if (editprofile == 0)
                        {

                            Console.WriteLine("Su nombre de perfil:");
                            string nperfil = Console.ReadLine();
                            item.Nombre_perfil = nperfil;
                            Console.WriteLine("Perfil actualizado");
                        }
                        else if (editprofile == 1)
                        {
                            Perfil perfil2 = new Perfil(usuario, item.Nombre_perfil, item.Tipo_de_Perfil);
                            Spotflix.Lista_Perfiles[count] = perfil2;
                            Console.WriteLine("Listas reseteadas!");
                        }
                        else if (editprofile == 2)
                        {
                            Spotflix.Lista_Perfiles.Remove(item);
                        }
                        else
                        {
                            Console.WriteLine("Numero no dentro de intervalo 0-2");
                        }
                    }
                    count += 1;
                }
            }
            else if (edituser == -1)
            {
                Console.WriteLine("Saliendo...");
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("Error, numero no esta dentro de intervalo.\nSaliendo...");
                Thread.Sleep(1000);
            }
        }

        public static void Agregar_Archivo(Perfil p)
        {
            Console.Clear();
            Console.WriteLine("Que quieres editar?\n[1] AudiLibro\n[2] Cancion\n[3] Pelicula\n[4] Podcast\n[5] Video\n[0] Salir");
            int aarchivo = Convert.ToInt32(Console.ReadLine());
            aarchivo -= 1;
            if (aarchivo == 0)
            {
                Console.WriteLine("Creando AudioLibro");
                Console.WriteLine("Titulo;");
                string titulo = Console.ReadLine();
                Console.WriteLine("Su fecha:[DD/MM/AAAA]");
                DateTime date = Convert.ToDateTime(Console.ReadLine());
                DateTime dt = date;
                Console.WriteLine("Idioma; [1] Español, [2] Ingles, [3] Portugues. ");
                int idioma = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Genero;");
                string genero = Console.ReadLine();
                Console.WriteLine("Url mp3:");
                string url1 = Console.ReadLine();
                Console.WriteLine("Url txt:");
                string url2 = Console.ReadLine();
                Console.WriteLine("Nombre+Apellido Lector");
                string nombre = Console.ReadLine();
                Console.WriteLine("Nacionalidad?");
                string defualtstring = Console.ReadLine();
                Persona Person = new Persona(nombre, 35, defualtstring, new DateTime(2020, 05, 11), new List<int> { 6 });
                AudioLibro NuevoAL = new AudioLibro(titulo, 3, dt, TimeSpan.Zero, 10.0, 2, url1, url2, genero, idioma, Person);
                Console.WriteLine("AudioLibro crendose...");
                Thread.Sleep(3000);
                Spotflix.Lista_AudioLibros.Add(NuevoAL);
                Console.WriteLine("Introduzca el archivo en '/Proyecto POO/bin/Debug/AudioLibro' para poder reproducirlo!");
                Thread.Sleep(3000);
            }
            else if (aarchivo == 1)//\Proyecto POO\bin\Debug\Musica
            {
                List<Persona> cantantes = new List<Persona>();
                List<Persona> compositores = new List<Persona>();
                Console.WriteLine("Creando Cancion:");
                Console.WriteLine("Titulo;");
                string titulo = Console.ReadLine();
                Console.WriteLine("Su fecha:[DD/MM/AAAA]");
                DateTime date = Convert.ToDateTime(Console.ReadLine());
                DateTime dt = date;
                Console.WriteLine("Url mp3:");
                string url1 = Console.ReadLine();
                Console.WriteLine("Url txt:");
                string url2 = Console.ReadLine();
                Console.WriteLine("Album:");
                string album = Console.ReadLine();
                Console.WriteLine("Imagen:");
                string imagen = Console.ReadLine();
                Console.WriteLine("Genero:");
                string genero = Console.ReadLine();
                int looop = 0;
                //creando cantantes y compostorees
                while (looop == 0)
                {
                    Console.WriteLine("Creando cantantes/ compositores");
                    Console.WriteLine("[1] Cantante / [2] compositor");
                    int desicion = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nombre:");
                    string nombre2 = Console.ReadLine();
                    Console.WriteLine("Sexo [1] H / [2] M");
                    int sexo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nacionalidad?");
                    string defualtstring2 = Console.ReadLine();
                    Console.WriteLine("Su fecha:[DD/MM/AAAA]");
                    DateTime date2 = Convert.ToDateTime(Console.ReadLine());
                    DateTime dt2 = date2;
                    Persona persona11 = new Persona(nombre2, sexo, defualtstring2, dt2, new List<int> { desicion });
                    Spotflix.Lista_Personas.Add(persona11);
                    if (desicion == 1)
                    {
                        cantantes.Add(persona11);
                    }
                    else if (desicion == 2)
                    {
                        compositores.Add(persona11);
                    }
                    Console.WriteLine("Crear otro cantante/compositor? 'Si' o 'No'");
                    string desicion2 = Console.ReadLine();
                    if (desicion2 == "No")
                    {
                        looop = 3;
                    }
                }
                Cancion c4 = new Cancion(titulo, 1, dt, TimeSpan.Zero, 10.0, 2, url1, cantantes, compositores, album, imagen, url2, genero);
                Spotflix.Lista_Canciones.Add(c4);
                Console.WriteLine("Archivo creandose...");
                Thread.Sleep(3000);
                Console.WriteLine("Agregue la cancion a carpeta: /Proyecto POO/bin/Debug/Musica");
                Console.WriteLine("Pulse 1 para agregar a lista favoritas");
                int pregunta = Convert.ToInt32(Console.ReadLine());
                if (pregunta == 1)
                {
                    p.Fav_Canciones.Add(c4);
                }
            }
            else if (aarchivo == 2)
            {
                List<Persona> cantantes = new List<Persona>();
                List<Persona> compositores = new List<Persona>();
                Console.WriteLine("Creando Pelicula");
                Console.WriteLine("Titulo;");
                string titulo = Console.ReadLine();
                Console.WriteLine("Su fecha:[DD/MM/AAAA]");
                DateTime date = Convert.ToDateTime(Console.ReadLine());
                DateTime dt = date;
                Console.WriteLine("Url mp4:");
                string url1 = Console.ReadLine();
                Console.WriteLine("Estudio;");
                string estudio = Console.ReadLine();
                Console.WriteLine("Genero;");
                string genero = Console.ReadLine();

                int looop = 0;
                while (looop == 0)
                {
                    Console.WriteLine("Creando actores/ directores");
                    Console.WriteLine("[1] actor / [2] director");
                    int desicion = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Nombre:");
                    string nombre2 = Console.ReadLine();
                    Console.WriteLine("Sexo [1] H / [2] M");
                    int sexo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Nacionalidad?");
                    string defualtstring2 = Console.ReadLine();
                    Console.WriteLine("Su fecha:[DD/MM/AAAA]");
                    DateTime date2 = Convert.ToDateTime(Console.ReadLine());
                    DateTime dt2 = date2;
                    Persona persona11 = new Persona(nombre2, sexo, defualtstring2, dt2, new List<int> { desicion + 1 });
                    Spotflix.Lista_Personas.Add(persona11);
                    if (desicion == 1)
                    {
                        cantantes.Add(persona11);
                    }
                    else if (desicion == 2)
                    {
                        compositores.Add(persona11);
                    }
                    Console.WriteLine("Crear otro actor/director? 'Si' o 'No'");
                    string desicion2 = Console.ReadLine();
                    if (desicion2 == "No")
                    {
                        looop = 3;
                    }
                }
                Pelicula peli = new Pelicula(titulo, 4, date, TimeSpan.Zero, 10.0, 1,
                url1, cantantes, compositores, estudio, 2, "Descripcion", 1, genero);
                Spotflix.Lista_Peliculas.Add(peli);
                Console.WriteLine("Pelicula creandose...");
                Thread.Sleep(3000);
                Console.WriteLine("Introduzca el archivo mp4 en la carpeta /Proyecto POO/bin/Debug/Peliculas");
                Console.WriteLine("Desea introducirla en su lista de peliculas favoritas? 'Si' o 'No'");
                string desicion3 = Console.ReadLine();
                if (desicion3 == "Si")
                {
                    p.Fav_Pelicula.Add(peli);
                }

            }
            else if (aarchivo == 3)
            {
                List<Persona> Locutores = new List<Persona>();
                Console.WriteLine("Creando Podcast");
                Console.WriteLine("Titulo;");
                string titulo = Console.ReadLine();
                Console.WriteLine("Su fecha:[DD/MM/AAAA]");
                DateTime date = Convert.ToDateTime(Console.ReadLine());
                DateTime dt = date;
                Console.WriteLine("Url mp3:");
                string url1 = Console.ReadLine();
                Console.WriteLine("Url txt:");
                string url2 = Console.ReadLine();
                Console.WriteLine("Album:");
                string album = Console.ReadLine();
                Console.WriteLine("Imagen:");
                string imagen = Console.ReadLine();
                Console.WriteLine("Genero:");
                string genero = Console.ReadLine();
                int looop = 0;
                //creando locutores
                while (looop == 0)
                {
                    Console.WriteLine("Creando locutores");
                    Console.WriteLine("Nombre:");
                    string nombre2 = Console.ReadLine();
                    Console.WriteLine("Sexo [1] H / [2] M");
                    int sexo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Nacionalidad?");
                    string defualtstring2 = Console.ReadLine();
                    Console.WriteLine("Su fecha:[DD/MM/AAAA]");
                    DateTime date2 = Convert.ToDateTime(Console.ReadLine());
                    DateTime dt2 = date2;
                    Persona persona11 = new Persona(nombre2, sexo, defualtstring2, dt2, new List<int> { 5 });
                    Spotflix.Lista_Personas.Add(persona11);
                    Locutores.Add(persona11);
                    Console.WriteLine("Crear otro locutor? 'Si' o 'No'");
                    string desicion2 = Console.ReadLine();
                    if (desicion2 == "No")
                    {
                        looop = 3;
                    }
                }
                Podcast pod1 = new Podcast(titulo, 3, dt, TimeSpan.Zero, 10.0, 2, url1, Locutores, "Imagen", genero);
                Spotflix.Lista_Podcasts.Add(pod1);
                Console.WriteLine("Creando podcast...");
                Console.WriteLine("Introduzca el archivo mp3 en el archivo /Proyecto POO/bin/Debug/Podcasts");
                Thread.Sleep(3000);
                Console.WriteLine("Desea introducirla en su lista de podcasts favoritas? 'Si' o 'No'");
                string desicion3 = Console.ReadLine();
                if (desicion3 == "Si")
                {
                    p.Fav_Podcast.Add(pod1);
                }


            }
            else if (aarchivo == 4)//Proyecto POO/bin/Debug/Musica
            {

                List<Persona> cantantes = new List<Persona>();
                List<Persona> compositores = new List<Persona>();
                Console.WriteLine("Creando Video");
                Console.WriteLine("Titulo;");
                string titulo = Console.ReadLine();
                Console.WriteLine("Su fecha:[DD/MM/AAAA]");
                DateTime date = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Url mp4:");
                string url1 = Console.ReadLine();
                Console.WriteLine("Genero;");
                string genero = Console.ReadLine();
                Console.WriteLine("Descripcion;");
                string descrip = Console.ReadLine();

                Video video1 = new Video(titulo, 2, date, TimeSpan.Zero, 10.0, 2, url1, 2, descrip, 2, genero);
                Spotflix.Lista_Videos.Add(video1);
                Console.WriteLine("Video creandose...");
                Thread.Sleep(3000);
                Console.WriteLine("Introduzca el archivo mp4 en la carpeta /Proyecto POO/bin/Debug/Videos");
                Console.WriteLine("Desea introducirla en su lista de Video favoritos? 'Si' o 'No'");
                string desicion3 = Console.ReadLine();
                if (desicion3 == "Si")
                {
                    p.Fav_Videos.Add(video1);
                }
            }
            else if (aarchivo == -1)
            {
                Console.WriteLine("Saliendo...");
                Thread.Sleep(3000);
            }
            else
            {
                Console.WriteLine("Numero no esta dentro de intervalo de numeros!");
                Console.WriteLine("Saliendo...");
                Thread.Sleep(3000);
            }
        }
        public static void Informacion(Perfil p)
        {
            Console.Clear();
            int x = 0;
            while (x == 0)
            {
                Console.WriteLine("Que Informacion deseas obtener?");
                Console.WriteLine("[1] Usuarios/Perfiles \n[2] Multimedia\n[3] Persona\n[4] Tu Perfil\n[0] Salir");
                int ojo = Convert.ToInt32(Console.ReadLine());
                ojo -= 1;
                int count = 1;
                if (ojo == 0)
                {
                    Console.WriteLine("Ver Informacion de: \n[1] Usuarios\n[2] Perfiles\n[0] Salir");
                    int ojo2 = Convert.ToInt32(Console.ReadLine());
                    ojo2 -= 1;
                    if (ojo2 == 0 && p.Usuario_Asociado.Tipo_de_Membresia == 3)
                    {
                        foreach (var item in Spotflix.Lista_Usuarios)
                        {
                            Console.WriteLine("\n" + count + ". " + item.Informacion_Usuario());
                            count += 1;
                        }
                    }
                    else if (ojo2 == 0)
                    {
                        Console.WriteLine("Error! Su cuenta no es administrador");
                        Thread.Sleep(1000);
                    }
                    else if (ojo2 == 1)
                    {
                        foreach (var item in Spotflix.Lista_Perfiles)
                        {
                            if (item.Tipo_de_Perfil == 3)
                            {
                                Console.WriteLine("\n" + count + ". Perfil privado");
                            }
                            else
                            {
                                Console.WriteLine("\n" + count + ". " + item.Informacion_de_Perfil());
                            }
                            count += 1;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error! Valor no disponible!");
                        Console.WriteLine("Saliendo...");
                        Thread.Sleep(3000);
                    }
                    Console.WriteLine("Quiere salir de Informacion? \n[1] No \n[0] Si");
                    int salida = Convert.ToInt32(Console.ReadLine());
                    if (salida == 0)
                    {
                        Thread.Sleep(3000);
                        x = 99;
                    }
                }
                else if (ojo == 1)
                {
                    Console.WriteLine("Ver Informacion de:[1] AudiLibro\n[2] Cancion \n[3] Pelicula \n[4] Podcast\n[5] Video\n[0] Salir");
                    int ojo2 = Convert.ToInt32(Console.ReadLine());
                    ojo2 -= 1;
                    if (ojo2 == 0)
                    {
                        foreach (var item in Spotflix.Lista_AudioLibros)
                        {
                            Console.WriteLine("\n" + count + ". " + item.Informacion_AudioLibro());
                            count += 1;
                        }
                    }
                    else if (ojo2 == 1)
                    {
                        foreach (var item in Spotflix.Lista_Canciones)
                        {
                            Console.WriteLine("\n" + count + ". " + item.Informacion_Cancion());
                            count += 1;
                        }
                    }
                    else if (ojo2 == 2)
                    {
                        foreach (var item in Spotflix.Lista_Peliculas)
                        {
                            Console.WriteLine("\n" + count + ". " + item.Informacion_Pelicula());
                            count += 1;
                        }
                    }
                    else if (ojo2 == 3)
                    {
                        foreach (var item in Spotflix.Lista_Podcasts)
                        {
                            Console.WriteLine("\n" + count + ". " + item.Informacion_Podcast());
                            count += 1;
                        }
                    }
                    else if (ojo2 == 4)
                    {
                        foreach (var item in Spotflix.Lista_Videos)
                        {
                            Console.WriteLine("\n" + count + ". " + item.Informacion_Video());
                            count += 1;
                        }
                    }

                    else
                    {
                        Console.WriteLine("Error valor disponible");
                    }

                    Console.WriteLine("Quiere salir de Informacion? \n[1] No\n[0] Si");
                    int salida = Convert.ToInt32(Console.ReadLine());
                    if (salida == 0)
                    {
                        x = 99;
                        Console.WriteLine("Saliendo...");
                        Thread.Sleep(1000);
                    }
                }
                else if (ojo == 2)
                {
                    foreach (var item in Spotflix.Lista_Personas)
                    {
                        Console.WriteLine("\n" + count + ". " + item.Informacion_Persona());
                        count += 1;
                    }

                    Console.WriteLine("Quiere salir de Informacion? \n[1] No\n[0] Si");
                    int salida = Convert.ToInt32(Console.ReadLine());
                    if (salida == 0)
                    {
                        x = 99;
                        Console.WriteLine("Saliendo...");
                        Thread.Sleep(1000);
                    }
                }
                else if (ojo == 3)
                {
                    Console.WriteLine("Tu informacion es:");
                    Console.WriteLine(p.Informacion_de_Perfil());
                    Thread.Sleep(3000);
                }
                else
                {
                    Console.WriteLine("Error valor no encontrado");
                    Console.WriteLine("Quiere salir? \n[1] No\n[0] Si");
                    int salida = Convert.ToInt32(Console.ReadLine());
                    if (salida == 0)
                    {
                        x = 99;
                    }

                }
            }
        }

        public static void CambiodeCuenta(Perfil p)
        {
            Console.Clear();
            if (p.Usuario_Asociado.Tipo_de_Membresia == 2)
            {
                Console.WriteLine("Desea convertir tipo de cuenta a gratis?\n[1] Si\n[0] No");
                int g = Convert.ToInt32(Console.ReadLine());
                if (g == 1)
                {
                    p.Usuario_Asociado.Tipo_de_Membresia = 1;
                    Console.WriteLine("Realizando cambios...");
                    Console.WriteLine("Se ha enviado la copida al email:" + p.Usuario_Asociado.Email);
                    Console.WriteLine("No se cobrara $100 a su cuenta bancaria al mes");
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("Cambios no realizados");
                    Thread.Sleep(1000);
                }
            }
            else if (p.Usuario_Asociado.Tipo_de_Membresia == 1)
            {
                Console.WriteLine("Desea convertir tipo de cuenta a premium?\n[1] Si\n[0] No");
                int g = Convert.ToInt32(Console.ReadLine());
                if (g == 1)
                {
                    p.Usuario_Asociado.Tipo_de_Membresia = 2;
                    Console.WriteLine("Realizando cambios...");
                    Console.WriteLine("Se ha enviado la copida al email:" + p.Usuario_Asociado.Email);
                    Console.WriteLine("Se cobrara $100 a su cuenta bancaria al mes");
                    Thread.Sleep(1000);

                }
                else
                {
                    Console.WriteLine("Cambios no realizados");
                    Thread.Sleep(1000);
                }
            }
            else if (p.Usuario_Asociado.Tipo_de_Membresia == 3)
            {
                Console.WriteLine("Usted es administrador. No decide eso!");
                Thread.Sleep(1000);
            }
        }
    }
}