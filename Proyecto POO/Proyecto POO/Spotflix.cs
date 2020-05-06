using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

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

        public static string Reproducir(Playlist playlist, int v = 0)
        {
            
            SoundPlayer Spotflix = new SoundPlayer();
            Spotflix.SoundLocation = playlist.Objetos[v].URL;
            Spotflix.Play();
            string a= "Reproduciendo: "+ playlist.Objetos[v].Titulo;
            return(a);
        }
        public static string Pausar(Playlist playlist)
        {
            SoundPlayer Spotflix = new SoundPlayer();
            Spotflix.SoundLocation = playlist.Objetos[0].URL;
            Spotflix.Stop();
            string a = "Reproduciendo: " + playlist.Objetos[0].Titulo;
            return (a);
        }
        public static string Adelantar(Playlist playlist)
        {
            SoundPlayer Spotflix = new SoundPlayer();
            
            Spotflix.SoundLocation = playlist.Objetos[0].URL;
            string a = "Reproduciendo: " + playlist.Objetos[0].Titulo;
            return (a);
        }
    }
}
