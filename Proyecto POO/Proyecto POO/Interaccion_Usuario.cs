using System;
using System.Collections.Generic;
using WMPLib;

namespace Proyecto_POO
{
    public static class Interaccion_Usuario
    {
        public static void Crear_Playlist(Perfil p)
        {
            Console.WriteLine("De que desea crear la playlist?: ");
            Console.WriteLine("1. Cancion \n2. Video \n3. Podcast \n4. Pelicula \n5. Audiolibro");
            Console.WriteLine("Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Tipo de Playlist");
            Console.WriteLine("1. Publica \n2. Privada");
            int tipo = Convert.ToInt32(Console.ReadLine());

            List<Cancion> Playlist1 = new List<Cancion>();

            Playlist playlistcreada = new Playlist(nombre, tipo);

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
                    Console.WriteLine("1. Canciones \n2. Videos \n3. Pelicula \n4.Podcast \n5.AudioLibro \n6.Playlist");
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
                        Console.WriteLine("Que cancion desea escuchar: ");
                        Console.WriteLine(" ");
                        int cancion = Convert.ToInt32(Console.ReadLine());
                        p.En_Cola_cancion.Add(Spotflix.Lista_Canciones[cancion - 1]);
                        Console.WriteLine("Cancion agregada a la cola");
                        Console.WriteLine(" ");
                        Console.WriteLine("Desea agregar esta cancion a favoritos?: ");
                        Console.WriteLine("1. Si \n2. No");
                        Console.WriteLine(" ");
                        int agregar = Convert.ToInt32(Console.ReadLine());
                        if (agregar == 1)
                        {
                            p.Fav_Canciones.Add(Spotflix.Lista_Canciones[cancion - 1]);
                            Console.WriteLine("Cancion agregada a favoritos ");
                        }
                        else
                        {
                            ;
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
                        Console.WriteLine("Que video desea ver?: ");
                        int video = Convert.ToInt32(Console.ReadLine());
                        p.En_Cola_video.Add(Spotflix.Lista_Videos[video - 1]);
                        Console.WriteLine(" ");
                        Console.WriteLine("Desea agregar este video a favoritos?: ");
                        Console.WriteLine("1. Si \n2. No");
                        Console.WriteLine(" ");
                        int agregar = Convert.ToInt32(Console.ReadLine());
                        if (agregar == 1)
                        {
                            p.Fav_Videos.Add(Spotflix.Lista_Videos[video - 1]);
                            Console.WriteLine("Video agregado a favoritos ");
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
                        Console.WriteLine("Que pelicula desea ver?: ");
                        int pelicula = Convert.ToInt32(Console.ReadLine());
                        p.En_Cola_pelicula.Add(Spotflix.Lista_Peliculas[pelicula - 1]);
                        Console.WriteLine(" ");
                        Console.WriteLine("Desea agregar esta pelicula a favoritos?: ");
                        Console.WriteLine("1. Si \n2. No");
                        int agregar = Convert.ToInt32(Console.ReadLine());
                        if (agregar == 1)
                        {
                            Console.WriteLine(" ");
                            p.Fav_Pelicula.Add(Spotflix.Lista_Peliculas[pelicula - 1]);
                            Console.WriteLine("Pelicula agregada a favoritos ");
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
                        Console.WriteLine("Que podcast desea escuchar: ");
                        int podcast = Convert.ToInt32(Console.ReadLine());
                        p.En_Cola_podcast.Add(Spotflix.Lista_Podcasts[podcast - 1]);
                        Console.WriteLine(" ");
                        Console.WriteLine("Desea agregar este podcast a favoritos?: ");
                        Console.WriteLine("1. Si \n2. No");
                        int agregar = Convert.ToInt32(Console.ReadLine());
                        if (agregar == 1)
                        {
                            Console.WriteLine(" ");
                            p.Fav_Podcast.Add(Spotflix.Lista_Podcasts[podcast - 1]);
                            Console.WriteLine("Podcast agregado a favoritos ");
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
                        Console.WriteLine("Que audiolibro desea escuchar: ");
                        int audiolibro = Convert.ToInt32(Console.ReadLine());
                        p.En_Cola_audiolibro.Add(Spotflix.Lista_AudioLibros[audiolibro - 1]);
                        Console.WriteLine(" ");
                        Console.WriteLine("Desea agregar este audiolibro a favoritos?: ");
                        Console.WriteLine("1. Si \n2. No");
                        int agregar = Convert.ToInt32(Console.ReadLine());
                        if (agregar == 1)
                        {
                            Console.WriteLine(" ");
                            p.Fav_AudioLibro.Add(Spotflix.Lista_AudioLibros[audiolibro - 1]);
                            Console.WriteLine("Audilibro agregado a favoritos");
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
                                if (playlist == item.Play_list.name)
                                {
                                    Console.WriteLine(Spotflix.Lista_Playlists[i - 1].Informacion_Playlist());
                                    Console.WriteLine("1. Seguir \n2. No seguir");
                                    Console.WriteLine("Desea seguir a" + playlist + ": ");
                                    int seguir = Convert.ToInt32(Console.ReadLine());
                                    if (seguir == 1)
                                    {
                                        p.Playlists_De_Otros.Add(item);
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
                                Console.WriteLine("Desea seguir a" + item.Nombre_y_Apellido + ": ");
                                int seguir = Convert.ToInt32(Console.ReadLine());
                                if (seguir == 1)
                                {
                                    p.Personas_Seguidas.Add(item);
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
                                    Console.WriteLine(Spotflix.Lista_Personas[i - 1].Informacion_Persona());
                                }
                                i++;
                            }
                        }

                        else if (answer4 == 2)
                        {
                            foreach (var item in Spotflix.Lista_Personas)
                            {
                                int i = 1;
                                if ((Persona.enum_Profesion)answer4 == Persona.enum_Profesion.Compositor)
                                {
                                    Console.WriteLine(Spotflix.Lista_Personas[i - 1].Informacion_Persona());
                                }
                                i++;
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
                                }
                                i++;
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
                                }
                                i++;
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
                                }
                                i++;
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
                                }
                                i++;
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
                        Console.WriteLine("Desea seguir a" + Spotflix.Lista_Perfiles[perfil - 1] + ": ");
                        int seguir = Convert.ToInt32(Console.ReadLine());
                        if (seguir == 1)
                        {
                            p.Seguidos.Add(Spotflix.Lista_Perfiles[perfil - 1]);
                            Console.WriteLine("Perfil seguido");
                        }


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

                    if (opcion1 == 1 && opcion2 == 2)
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
                                    Console.WriteLine(i + ". " + item.Titulo);
                                    i_1 += 1;
                                }

                            }
                        }
                        else if (categoria == 2)
                        {
                            int i_1 = 1;
                            foreach (var item in Spotflix.Lista_Videos)
                            {
                                if (titulo == item.Titulo)
                                {
                                    Console.WriteLine(i + ". " + item.Titulo);
                                    i_1 += 1;
                                }

                            }
                        }
                        else if (categoria == 3)
                        {
                            int i_1 = 1;
                            foreach (var item in Spotflix.Lista_Podcasts)
                            {
                                if (titulo == item.Titulo)
                                {
                                    Console.WriteLine(i + ". " + item.Titulo);
                                    i_1 += 1;
                                }

                            }
                        }
                        else if (categoria == 4)
                        {
                            int i_1 = 1;
                            foreach (var item in Spotflix.Lista_Peliculas)
                            {
                                if (titulo == item.Titulo)
                                {
                                    Console.WriteLine(i + ". " + item.Titulo);
                                    i_1 += 1;
                                }

                            }
                        }
                        else if (categoria == 5)
                        {
                            int i_1 = 1;
                            foreach (var item in Spotflix.Lista_AudioLibros)
                            {
                                if (titulo == item.Titulo)
                                {

                                    Console.WriteLine(i + ". " + item.Titulo);
                                    i_1 += 1;
                                }

                            }
                        }


                    }
                    else if (opcion1 == 1 && opcion2 == 3)
                    {
                        Console.WriteLine("Titulo: ");
                        string titulo = Console.ReadLine();
                        Console.WriteLine("Año: ");
                        int año = Convert.ToInt32(Console.ReadLine());

                        foreach(var item in Spotflix.Lista_Canciones)
                        {
                            int i_1 = 1;
                            if (titulo == item.Titulo && año == item.Año.Year)
                            {
                                Console.WriteLine("Canciones");
                                Console.WriteLine(" ");
                                Console.WriteLine(i + ". " + item.Titulo);
                                i_1 += 1;
                            }
                        }
                        foreach (var item in Spotflix.Lista_Videos)
                        {
                            int i_1 = 1;
                            if (titulo == item.Titulo && año == item.Año.Year)
                            {
                                Console.WriteLine("Videos");
                                Console.WriteLine(" ");
                                Console.WriteLine(i + ". " + item.Titulo);
                                i_1 += 1;
                            }
                        }
                        foreach (var item in Spotflix.Lista_Podcasts)
                        {
                            int i_1 = 1;
                            if (titulo == item.Titulo && año == item.Año.Year)
                            {
                                Console.WriteLine("Podcast");
                                Console.WriteLine(" ");
                                Console.WriteLine(i + ". " + item.Titulo);
                                i_1 += 1;
                            }
                        }
                        foreach (var item in Spotflix.Lista_Peliculas)
                        {
                            int i_1 = 1;
                            if (titulo == item.Titulo && año == item.Año.Year)
                            {
                                Console.WriteLine("Peliculas");
                                Console.WriteLine(" ");
                                Console.WriteLine(i + ". " + item.Titulo);
                                i_1 += 1;
                            }
                        }
                        foreach (var item in Spotflix.Lista_AudioLibros)
                        {
                            int i_1 = 1;
                            if (titulo == item.Titulo && año == item.Año.Year)
                            {
                                Console.WriteLine("Audiolibros");
                                Console.WriteLine(" ");
                                Console.WriteLine(i + ". " + item.Titulo);
                                i_1 += 1;
                            }
                        }
                    }
                    else if (opcion1 == 1 && opcion2 == 4)
                    {
                        Console.WriteLine("Titulo: ");
                        string titulo = Console.ReadLine();
                        Console.WriteLine("Ranking: ");
                        double ranking = Convert.ToDouble(Console.ReadLine());

                        foreach (var item in Spotflix.Lista_Canciones)
                        {
                            int i_1 = 1;
                            if (titulo == item.Titulo && ranking == item.Ranking)
                            {
                                Console.WriteLine("Canciones");
                                Console.WriteLine(" ");
                                Console.WriteLine(i + ". " + item.Titulo);
                                i_1 += 1;
                            }
                        }
                        foreach (var item in Spotflix.Lista_Videos)
                        {
                            int i_1 = 1;
                            if (titulo == item.Titulo && ranking == item.Ranking)
                            {
                                Console.WriteLine("Videos");
                                Console.WriteLine(" ");
                                Console.WriteLine(i + ". " + item.Titulo);
                                i_1 += 1;
                            }
                        }
                        foreach (var item in Spotflix.Lista_Podcasts)
                        {
                            int i_1 = 1;
                            if (titulo == item.Titulo && ranking == item.Ranking)
                            {
                                Console.WriteLine("Podcast");
                                Console.WriteLine(" ");
                                Console.WriteLine(i + ". " + item.Titulo);
                                i_1 += 1;
                            }
                        }
                        foreach (var item in Spotflix.Lista_Peliculas)
                        {
                            int i_1 = 1;
                            if (titulo == item.Titulo && ranking == item.Ranking)
                            {
                                Console.WriteLine("Peliculas");
                                Console.WriteLine(" ");
                                Console.WriteLine(i + ". " + item.Titulo);
                                i_1 += 1;
                            }
                        }
                        foreach (var item in Spotflix.Lista_AudioLibros)
                        {
                            int i_1 = 1;
                            if (titulo == item.Titulo && ranking == item.Ranking)
                            {
                                Console.WriteLine("Audiolibros");
                                Console.WriteLine(" ");
                                Console.WriteLine(i + ". " + item.Titulo);
                                i_1 += 1;
                            }
                        }
                    }
                    else if (opcion1 == 2 && opcion2 == 3)
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
                                    Console.WriteLine(i + ". " + item.Titulo);
                                    Console.WriteLine(" " + item.Año);
                                    i_1 += 1;
                                }

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
                                    Console.WriteLine(i + ". " + item.Titulo);
                                    Console.WriteLine(" " + item.Año);
                                    i_1 += 1;
                                }

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
                                    Console.WriteLine(i + ". " + item.Titulo);
                                    Console.WriteLine(" " + item.Año);
                                    i_1 += 1;
                                }

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
                                    Console.WriteLine(i + ". " + item.Titulo);
                                    Console.WriteLine(" " + item.Año);
                                    i_1 += 1;
                                }

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
                                    Console.WriteLine(i + ". " + item.Titulo);
                                    Console.WriteLine(" " + item.Año);
                                    i_1 += 1;
                                }

                            }
                        }
                    }
                    else if (opcion1 == 2 && opcion2 == 4)
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
                                    Console.WriteLine(i + ". " + item.Titulo);
                                    Console.WriteLine(" " + item.Ranking);
                                    i_1 += 1;
                                }

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
                                    Console.WriteLine(i + ". " + item.Titulo);
                                    Console.WriteLine(" " + item.Ranking);
                                    i_1 += 1;
                                }

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
                                    Console.WriteLine(i + ". " + item.Titulo);
                                    Console.WriteLine(" " + item.Ranking);
                                    i_1 += 1;
                                }

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
                                    Console.WriteLine(i + ". " + item.Titulo);
                                    Console.WriteLine(" " + item.Ranking);
                                    i_1 += 1;
                                }

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
                                    Console.WriteLine(i + ". " + item.Titulo);
                                    Console.WriteLine(" " + item.Ranking);
                                    i_1 += 1;
                                }

                            }
                        }
                    }
                    else if (opcion1 == 3 && opcion2 == 4)
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
            }
        

        }

        public static void Editar_Informacion_Admin()//Admin
        {
            Console.WriteLine("Quieres editar los archivos [0] o los usuarios/perfiles [1]?");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 0)
            {
                Console.WriteLine("Quieres editar un AudiLibro [0], Cancion [1], Pelicula [2], Podcast [3], Video [4]?");
                int xy = Convert.ToInt32(Console.ReadLine());

                if (xy == 0)//AL
                {
                    while (xy == 0)
                    {
                        int i = 1;
                        foreach (var item in Spotflix.Lista_AudioLibros)
                        {
                            Console.WriteLine("[" + i + "]. " + item.Titulo);
                            i += 1;
                        }
                        Console.WriteLine("Cual quieres editar? [x]");
                        int y = Convert.ToInt32(Console.ReadLine());
                        if (y >= 1 && y <= i)
                        {
                            AudioLibro c1 = Spotflix.Lista_AudioLibros[y - 1];
                            Console.WriteLine("Informacion del AudioLibro a editar: ");
                            Console.WriteLine(Spotflix.Lista_AudioLibros[y - 1].Informacion_AudioLibro());
                            Console.WriteLine("Quieres editarlo? [si=0, no=1]");
                            int y2 = Convert.ToInt32(Console.ReadLine());
                            if (y2 == 0)
                            {
                                Console.WriteLine("Editando AudioLibro:");
                                Console.WriteLine("Titulo;");
                                string titulo = Console.ReadLine();
                                Console.WriteLine("Categoria;");
                                int categoria = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Su fecha:[DDMMAAAA]");
                                string date = Console.ReadLine();
                                int ano = date[4] + date[5] + date[6] + date[7];
                                int mes = date[2] + date[3];
                                int dia = date[0] + date[1];
                                DateTime dt = new DateTime(ano, mes, dia);

                                Console.WriteLine("Idioma;");
                                string Album = Console.ReadLine();

                                Console.WriteLine("Genero;");
                                string genero = Console.ReadLine();

                                AudioLibro cc1 = new AudioLibro(titulo, categoria, dt, c1.Duracion, c1.Ranking, c1.Estado,
                                    c1.URL, c1.URL_Texto, genero, c1.Idioma, c1.Lector);
                                ;
                                Spotflix.Lista_AudioLibros[y].Editar_Informacion(cc1);
                            }
                        }

                        Console.WriteLine("Quieres editar un AudioLibro denuevo? [0] si, [1] no");
                        xy = Convert.ToInt32(Console.ReadLine());
                    }
                }
                if (xy == 1)//Canciones
                {
                    while (xy == 1)
                    {
                        int i = 1;
                        foreach (var item in Spotflix.Lista_Canciones)
                        {
                            Console.WriteLine("[" + i + "]. " + item.Titulo);
                            i += 1;
                        }
                        Console.WriteLine("Cual quieres editar? [x]");
                        int y = Convert.ToInt32(Console.ReadLine());
                        if (y >= 1 && y <= i)
                        {
                            Cancion c1 = Spotflix.Lista_Canciones[y - 1];
                            Console.WriteLine("Informacion de la cancion a editar: ");
                            Console.WriteLine(Spotflix.Lista_Canciones[y - 1].Informacion_Cancion());
                            Console.WriteLine("Quieres editarlo? [si=0, no=1]");
                            int y2 = Convert.ToInt32(Console.ReadLine());
                            if (y2 == 0)
                            {
                                Console.WriteLine("Editando Cancion:");
                                Console.WriteLine("Titulo;");
                                string titulo = Console.ReadLine();
                                Console.WriteLine("Categoria;");
                                int categoria = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Su fecha:[DDMMAAAA]");
                                string date = Console.ReadLine();
                                int ano = date[4] + date[5] + date[6] + date[7];
                                int mes = date[2] + date[3];
                                int dia = date[0] + date[1];
                                DateTime dt = new DateTime(ano, mes, dia);

                                Console.WriteLine("Album;");
                                string Album = Console.ReadLine();

                                Console.WriteLine("Genero;");
                                string genero = Console.ReadLine();

                                Cancion cc1 = new Cancion(titulo, categoria, dt, c1.Duracion, c1.Ranking, c1.Estado,
                                    c1.URL, c1.Cantante, c1.Compositor, Album, c1.Imagen, c1.Letra, genero);
                                ;
                                Spotflix.Lista_Canciones[y].Editar_Informacion(cc1);
                            }
                        }
                        Console.WriteLine("Quieres editar una Cancion denuevo? [0] si, [1] no");
                        xy = Convert.ToInt32(Console.ReadLine());
                        if (xy == 0)
                        {
                            xy = 1;
                        }
                    }
                }
                if (xy == 2) //Pel
                {
                    while (xy == 2)
                    {
                        int i = 1;
                        foreach (var item in Spotflix.Lista_Peliculas)
                        {
                            Console.WriteLine("[" + i + "]. " + item.Titulo);
                            i += 1;
                        }
                        Console.WriteLine("Cual quieres editar? [x]");
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
                                Console.WriteLine("Categoria:");
                                int categoria = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Su fecha:[DDMMAAAA]");
                                string date = Console.ReadLine();
                                int ano = date[4] + date[5] + date[6] + date[7];
                                int mes = date[2] + date[3];
                                int dia = date[0] + date[1];
                                DateTime dt = new DateTime(ano, mes, dia);

                                Console.WriteLine("Descripcion:");
                                string descripcion = Console.ReadLine();

                                Pelicula cc1 = new Pelicula(titulo, categoria, dt, c1.Duracion, c1.Ranking, c1.Estado,
                                    c1.URL, c1.Actor, c1.Director, c1.Estudio, c1.Resolucion, descripcion, c1.Clasificacion, c1.Genero);
                                ;
                                Spotflix.Lista_Peliculas[y].Editar_Informacion(cc1);
                            }
                        }
                        Console.WriteLine("Quieres editar una Pelicula denuevo? [0] si, [1] no");
                        xy = Convert.ToInt32(Console.ReadLine());
                        if (xy == 0)
                        {
                            xy = 2;
                        }

                    }

                }
                if (xy == 3) //podcast
                {
                    while (xy == 3)
                    {
                        int i = 1;
                        foreach (var item in Spotflix.Lista_Podcasts)
                        {
                            Console.WriteLine("[" + i + "]. " + item.Titulo);
                            i += 1;
                        }
                        Console.WriteLine("Cual quieres editar? [x]");
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
                                Console.WriteLine("Categoria;");
                                int categoria = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Su fecha:[DDMMAAAA]");
                                string date = Console.ReadLine();
                                int ano = date[4] + date[5] + date[6] + date[7];
                                int mes = date[2] + date[3];
                                int dia = date[0] + date[1];
                                DateTime dt = new DateTime(ano, mes, dia);

                                Console.WriteLine("Genero;");
                                string genero = Console.ReadLine();

                                Podcast cc1 = new Podcast(titulo, categoria, dt, c1.Duracion, c1.Ranking, c1.Estado,
                                    c1.URL, c1.Locutor, c1.Imagen, genero);
                                ;
                                Spotflix.Lista_Podcasts[y].Editar_Informacion(cc1);
                            }
                        }
                        Console.WriteLine("Quieres editar un Podcast denuevo? [0] si, [1] no");
                        xy = Convert.ToInt32(Console.ReadLine());
                        if (xy == 0)
                        {
                            xy = 3;
                        }
                    }
                }
                if (xy == 4)//video
                {
                    while (xy == 4)
                    {
                        int i = 1;
                        foreach (var item in Spotflix.Lista_Videos)
                        {
                            Console.WriteLine("[" + i + "]. " + item.Titulo);
                            i += 1;
                        }
                        Console.WriteLine("Cual quieres editar? [x]");
                        int y = Convert.ToInt32(Console.ReadLine());
                        if (y >= 1 && y <= i)
                        {
                            Video c1 = Spotflix.Lista_Videos[y - 1];
                            Console.WriteLine("Informacion del Video a editar: ");
                            Console.WriteLine(Spotflix.Lista_Videos[y - 1].Informacion_Video());
                            Console.WriteLine("Quieres editarlo? [si=0, no=1]");
                            int y2 = Convert.ToInt32(Console.ReadLine());
                            if (y2 == 0)
                            {
                                Console.WriteLine("Editando Video:");
                                Console.WriteLine("Titulo;");
                                string titulo = Console.ReadLine();
                                Console.WriteLine("Categoria;");
                                int categoria = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Su fecha:[DDMMAAAA]");
                                string date = Console.ReadLine();
                                int ano = date[4] + date[5] + date[6] + date[7];
                                int mes = date[2] + date[3];
                                int dia = date[0] + date[1];
                                DateTime dt = new DateTime(ano, mes, dia);

                                Console.WriteLine("Descripcion:");
                                string descripcion = Console.ReadLine();
                                Video cc1 = new Video(titulo, categoria, dt, c1.Duracion, c1.Ranking, c1.Estado,
                                    c1.URL, c1.Resolucion, descripcion, c1.Clasificacion, c1.Genero);
                                ;
                                ;
                                Spotflix.Lista_Videos[y].Editar_Informacion(cc1);
                            }
                        }
                        Console.WriteLine("Quieres editar un Video denuevo? [0] si, [1] no");
                        xy = Convert.ToInt32(Console.ReadLine());
                        if (xy == 0)
                        {
                            xy = 4;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Error, ¡valor distinto a 0 o 1!");
                }
            }
            else if (x == 1)
            {
                Console.WriteLine("Quieres editar Usuarios [0] o Perfiles [1]?");
                int xy = Convert.ToInt32(Console.ReadLine());
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
                            Console.WriteLine("Quieres editarlo? [si=0, no=1]");
                            int y2 = Convert.ToInt32(Console.ReadLine());
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
                            Console.WriteLine("Error, ¡valor distinto a 0 o 1!");
                        }
                        Console.WriteLine("Quieres editar un Usuario denuevo? [0] si, [1] no");
                        xy = Convert.ToInt32(Console.ReadLine());


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
                        Console.WriteLine("Cual quieres editar? [x]");
                        int y = Convert.ToInt32(Console.ReadLine());
                        if (y >= 1 && y <= i)
                        {
                            Console.WriteLine("Informacion del Perfil a editar: ");
                            Console.WriteLine(Spotflix.Lista_Perfiles[y - 1].Informacion_de_Perfil());
                            Perfil per = Spotflix.Lista_Perfiles[y - 1];
                            Console.WriteLine("Quieres editarlo? [si=0, no=1]");
                            int y2 = Convert.ToInt32(Console.ReadLine());
                            if (y2 == 0)
                            {
                                Console.WriteLine("Editando Perfil: ");
                                Console.WriteLine("Su nombre:");
                                string nomb = Console.ReadLine();


                                Console.WriteLine("Su tipo de perfil: ");
                                int tipoperf = Convert.ToInt32(Console.ReadLine());
                                //escojer 1, imprima la informacion
                                //cambiar
                                //crear
                                //AudioLibro a1 = new AudioLibro(año,cw,ValueTuple,base,e);

                                Perfil p1 = new Perfil(per.Usuario_Asociado, nomb, tipoperf);
                                Spotflix.Lista_Perfiles[y].Editar_Informacion(p1);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error, ¡valor distinto a 0 o 1!");
                        }

                        Console.WriteLine("Quieres editar un Perfil denuevo? [0] si, [1] no");
                        xy = Convert.ToInt32(Console.ReadLine());
                        if (xy == 0)
                        {
                            xy = 1;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Error, ¡valor distinto a 0 o 1!");
                }
            }
            else
            {
                Console.WriteLine("Error, ¡valor distinto a 0 o 1!");
            }
        }

        public static void Editar_Informacion_Usuario(Usuario usuario)
        {
            Console.WriteLine("Deseas cambiar la informacion de: [0] usuario, [1] de algun perfil ,[otro numero] salir ?");
            int edituser = Convert.ToInt32(Console.ReadLine());
            if (edituser == 0)
            {
                Console.WriteLine("Informacion: ");
                Console.WriteLine(usuario.Informacion_Usuario());
                Console.WriteLine("Quieres modificarla? (Cuidado, vas a tener que modificar toda la informacion!)");
                Console.WriteLine("Si [0], No [0]");
                int edituser2 = Convert.ToInt32(Console.ReadLine());
                if (edituser2 == 0)
                {
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
                        Console.WriteLine(item.Informacion_de_Perfil());
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
        }

        public static void Agregar_Archivo(Perfil p)
        {
            Console.Clear();
            Console.WriteLine("Quieres editar un AudiLibro [0] \nCancion [1] \nPelicula [2] \nPodcast [3] \nVideo [4]?");
            int aarchivo = Convert.ToInt32(Console.ReadLine());
            if (aarchivo == 0)
            {
                Console.WriteLine("Creando AudioLibro");
                Console.WriteLine("Titulo;");
                string titulo = Console.ReadLine();
                Console.WriteLine("Categoria;");
                int categoria = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Su fecha:[DDMMAAAA]");
                string date = Console.ReadLine();
                int ano = date[4] + date[5] + date[6] + date[7];
                int mes = date[2] + date[3];
                int dia = date[0] + date[1];
                DateTime dt = new DateTime(ano, mes, dia);
                Console.WriteLine("Idioma;");
                string Album = Console.ReadLine();
                Console.WriteLine("Genero;");
                string genero = Console.ReadLine();

            }
            else if (aarchivo == 1)
            {

            }
            else if (aarchivo == 2)
            {

            }
            else if (aarchivo == 3)
            {

            }
            else if (aarchivo == 4)
            {

            }

        }
            
    }
}




            

