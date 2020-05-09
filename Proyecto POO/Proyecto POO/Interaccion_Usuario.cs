using System;
using WMPLib;
namespace Proyecto_POO
{
    public class Interaccion_Usuario
    {
        public Interaccion_Usuario()
        {
        }
        public void Buscar()
        {
            
        }
        public void Editar_Informacion()
        {
            Console.WriteLine("Quieres editar los archivos [0] o los usuarios/perfiles [1]?");
            //1
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 0)
            {
                //foreach (var item in Spotflix.cancion.Objetos)
                //{

                //}
            }
            else if (x == 1)
            {
                Console.WriteLine("Quieres editar Usuarios [0] o Perfiles [1]?");
                int xy = Convert.ToInt32(Console.ReadLine());
                if (xy == 0)
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
                            int ano = date[4] + date[5]+date[6]+date[7];
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
                else if (xy == 1)
                {
                    int i = 1;
                    foreach (var item in Spotflix.Lista_Perfil)
                    {
                        Console.WriteLine("[" + i + "]. " + item.Nombre_perfil);
                        i += 1;
                    }
                    Console.WriteLine("Cual quieres editar? [x]");
                    int y = Convert.ToInt32(Console.ReadLine());
                    if (y >= 1 && y <= i)
                    {
                        Console.WriteLine("Informacion del Usuario a editar: ");
                        Console.WriteLine(Spotflix.Lista_Perfil[y - 1].Informacio_de_Perfil());
                        Perfil per = Spotflix.Lista_Perfil[y - 1];
                        Console.WriteLine("Quieres editarlo? [si=0, no=1]");
                        int y2 = Convert.ToInt32(Console.ReadLine());
                        if (y2 == 0)
                        {
                            Console.WriteLine("Editando Usuario:");
                            Console.WriteLine("Su nombre:");
                            string nomb = Console.ReadLine();

                            Console.WriteLine("Su tipo de perfil:");
                            int tipoperf = Convert.ToInt32(Console.ReadLine());

                            Perfil p1 = new Perfil(per.Usuario_Asociado, nomb, tipoperf, per.Fav_Canciones,
                                per.Fav_Videos, per.Fav_Podcast, per.Fav_AudioLibro, per.Playlists_Propias,
                                per.Playlists_de_Otros, per.Seguidos, per.Seguidores, per.Personas_Seguidas, per.En_Cola);
                            Spotflix.Lista_Perfil[y].Editar_Informacion(p1);
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
