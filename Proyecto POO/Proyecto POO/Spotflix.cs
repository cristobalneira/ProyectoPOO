using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using WMPLib;
using System.Threading;

namespace Proyecto_POO
{
    public static class Spotflix
    {

        public static IWMPPlaylist Temporal;
        public static List<Usuario> Lista_Usuarios = new List<Usuario>();
        public static List<Perfil> Lista_Perfiles = new List<Perfil>();
        public static List<Persona> Lista_Personas = new List<Persona>();

        public static List<Cancion> Lista_Canciones =  new List<Cancion>();
        public static List<Video> Lista_Videos = new List<Video>();
        public static List<Podcast> Lista_Podcasts = new List<Podcast>();
        public static List<Pelicula> Lista_Peliculas = new List<Pelicula>();
        public static List<AudioLibro> Lista_AudioLibros = new List<AudioLibro>();
        public static List<Playlist> Lista_Playlists;

        //Metodos:

        

        public static WindowsMediaPlayer spotflix = new WindowsMediaPlayer();

        public static void Reproducir(IWMPPlaylist playlist, int v = 0)
        {
            Thread.Sleep(500);
            spotflix.currentPlaylist.clear();
            spotflix.currentPlaylist = playlist;
            spotflix.controls.play();
        }
        public static void Pausar()
        {
            spotflix.controls.pause();

        }
        public static void Reanudar()
        {
            spotflix.controls.play();

        }
        public static void Adelantar()
        {
            spotflix.controls.next();

        }
        public static void Retroceder()
        {
            spotflix.controls.previous();

        }
        public static void Info()
        {
            for (int i = 0; i < spotflix.currentPlaylist.count; i++)
            {
                Console.WriteLine(i + ". " + spotflix.currentPlaylist.Item[i].name);
            }
        }
        public static string Estado()
        {
            string a = spotflix.controls.currentPositionString + ". " + spotflix.status.Split(':')[0];
            return (a);
        }
    }
}
