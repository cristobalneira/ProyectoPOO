using System;
using WMPLib;

namespace Proyecto_POO
{
    public class Interaccion_Usuario
    {
        public Interaccion_Usuario()
        {
        }

        public void Buscar(Perfil p)
        {
            Console.WriteLine("1. Busqueda Simple \n2. Busqueda Compleja");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1)
            {
                Console.WriteLine("1. Multimedia \n2. Persona \n3. Perfil \nQue desea buscar?: ");

                int a = Convert.ToInt32(Console.ReadLine());

                if (a == 1)
                {
                    Console.WriteLine("1. Canciones \n2. Videos \n3.Podcast \n4.AudioLibro \n5.Playlist \nQue desea buscar?: ");
                    int answer2 = Convert.ToInt32(Console.ReadLine());

                    if (answer2 == 1)
                    {

                        Console.WriteLine("Nombre de la cancion: ");
                        string song = Console.ReadLine();
                        int i = 1;
                        foreach (var item in Spotflix.Canciones)
                        {
                            if (song == item.Titulo)
                            {
                                Console.WriteLine(Spotflix.Canciones[i - 1].Informacion_Cancion());
                                i++;
                            }

                        }

                    }

                    else if (answer2 == 2)
                    {

                    }

                    else if (answer2 == 3)
                    {

                    }

                    else if (answer2 == 4)
                    {

                    }
                    else if (answer2 == 5)
                    {
                        Console.WriteLine("1. Playlist de canciones \n2.Playlist de Videos");
                        Console.WriteLine("Que desea buscar: ");
                        int opcion = Convert.ToInt32(Console.ReadLine());
                        if (opcion == 1)
                        {
                            int i = 1;
                            Console.WriteLine("Nombre de la playlist: ");
                            string playlist = Console.ReadLine();

                            foreach (var item in Spotflix.Lista_Playlists)
                            {
                                Console.WriteLine(Spotflix.Lista_Playlists[i - 1].Informacion_Playlist());
                                i++;
                            }
                        }

                    }

                    //int i = 1;
                    //foreach (var item in Spotflix.Lista_Cantantes)
                    //{
                    //    Console.WriteLine("[" + i + "]. " + item.Nombre_y_Apellido);

                    //    i += 1;
                    //}

                }
                else if (a == 2)
                {

                    Console.WriteLine("1. Nombre \n2. Sexo \n3. Profesion \n4. Nacionalidad \nQue desea hacer: ");
                    int answer3 = Convert.ToInt32(Console.ReadLine());

                    if (answer3 == 1)
                    {
                        Console.WriteLine("Nombre de la persona: ");
                        string nombre = Console.ReadLine();
                        int i = 1;
                        foreach (var item in Spotflix.Lista_Personas)
                        {
                            if (nombre == item.Nombre_y_Apellido)
                            {
                                Console.WriteLine(Spotflix.Lista_Personas[i - 1].Informacion_Persona());

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
                        int sexo = Convert.ToInt32(Console.ReadLine());
                        int i = 1;
                        foreach (var item in Spotflix.Lista_Personas)
                        {
                            if (sexo == item.Sexo)
                            {
                                Console.WriteLine(Spotflix.Lista_Personas[i - 1].Informacion_Persona());
                            }
                            i += 1;
                        }
                    }

                    else if (answer3 == 3)
                    {
                        Console.WriteLine("1. Cantante \n2. Compositor \n3. Actor \n4. Director \n5. Locutor \n6. Lector" +
                         "\nQue desea buscar: ");
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
                        string nacionalidad = Console.ReadLine();
                        int i = 1;
                        foreach (var item in Spotflix.Lista_Personas)
                        {
                            if (nacionalidad == item.Nacionalidad)
                            {
                                Console.WriteLine(Spotflix.Lista_Personas[i - 1].Informacion_Persona());
                            }
                            i += 1;
                        }

                    }

                    else if (a == 3)
                    {
                        Console.WriteLine("Nombre usuario: ");
                    }

                    //int i = 1;
                    //foreach (var item in Spotflix.Lista_Cantantes)
                    //{
                    //    Console.WriteLine("[" + i + "]. " + item.Nombre_y_Apellido);

                    //    i += 1;
                    //}

                    //Console.WriteLine("Numero del artista que estas buscando: ");
                    //int b = Convert.ToInt16(Console.ReadLine());
                    //Console.WriteLine(Spotflix.Canciones[b - 1].Informacion_Persona());


                }




            }
        }


        public void Editar_Informacion()//Falta cordinar
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

                                Console.WriteLine("Idioma;");
                                string Album = Console.ReadLine();

                                Console.WriteLine("Genero;");
                                string genero = Console.ReadLine();

                                AudioLibro cc1 = new AudioLibro(titulo, categoria, dt, c1.Duracion, c1.Ranking, c1.Estado,
                                    c1.URL, genero, c1.Idioma, c1.Lector);
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
                                    c1.URL, c1.Actor, c1.Director, c1.Estudio, c1.Resolucion, descripcion, c1.Clasificacion, c1.Genero);
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
                            Console.WriteLine(Spotflix.Lista_Perfiles[y - 1].Informacio_de_Perfil());
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

                                Perfil p1 = new Perfil(per.Usuario_Asociado, nomb, tipoperf, per.Fav_Canciones,
                                    per.Fav_Videos, per.Fav_Podcast, per.Fav_AudioLibro, per.Playlists_Propias,
                                    per.Playlists_de_Otros, per.Seguidos, per.Seguidores, per.Personas_Seguidas, per.En_Cola);
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

    }
}
