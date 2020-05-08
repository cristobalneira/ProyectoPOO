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
        public static Playlist Canciones = new Playlist("Canciones", new List<Archivo>(),10, "Cancion", new TimeSpan(0,4,0));
        public static Playlist Videos = new Playlist("Videos", new List<Archivo>(), 10, "Video", new TimeSpan(0, 4, 0));
        public static Playlist Peliculas = new Playlist("Peliculas", new List<Archivo>(), 10, "Pelicula", new TimeSpan(0, 4, 0));
        public static Playlist Podcast = new Playlist("Podcast", new List<Archivo>(), 10, "Podcast", new TimeSpan(0, 4, 0));
        public static Playlist Audiolibros = new Playlist("Audiolibros", new List<Archivo>(), 10, "Audiolibro", new TimeSpan(0, 4, 0));

        //Metodos:
        public static WindowsMediaPlayer spotflix = new WindowsMediaPlayer();
        public static IWMPMedia media;
        public static string Reproducir(Playlist playlist, int v = 0)
        {
            spotflix.currentPlaylist.clear();
            spotflix.currentPlaylist = spotflix.playlistCollection.newPlaylist("Canciones");
            for (int i = 0; i < playlist.Objetos.Count; i++)
            {
                media= spotflix.newMedia(playlist.Objetos[i].URL);
                media.name = playlist.Objetos[i].Titulo;
                spotflix.currentPlaylist.appendItem(media);
                
            }
            for (int i = 0; i < v; i++)
            {
                spotflix.controls.next();
            }
            
            spotflix.controls.play();
            Thread.Sleep(300);
            string a = spotflix.controls.currentPositionString+". "+ spotflix.status.Split(':')[0];
            return (a);
            
        }
        public static string Pausar()
        {
            spotflix.controls.pause();
            Thread.Sleep(300);
            string a = spotflix.controls.currentPositionString + ". " + spotflix.status.Split(':')[0];
            return (a);
        }
        public static string Reanudar()
        {
            spotflix.controls.play();
            Thread.Sleep(300);
            string a = spotflix.controls.currentPositionString + ". " + spotflix.status.Split(':')[0];
            return (a);
        }
        public static string Adelantar()
        {
            spotflix.controls.next();
            Thread.Sleep(300);
            string a = spotflix.controls.currentPositionString + ". " + spotflix.status.Split(':')[0];
            return (a);
        }
        public static string Retroceder()
        {
            spotflix.controls.previous();
            Thread.Sleep(300);
            string a = spotflix.controls.currentPositionString + ". " + spotflix.status.Split(':')[0];
            return (a);
        }
        public static void Info()
        {
            for (int i = 0; i < spotflix.currentPlaylist.count; i++)
            {
                Console.WriteLine(i + ". " + spotflix.currentPlaylist.Item[i].name);
            }
        }

    }
}
