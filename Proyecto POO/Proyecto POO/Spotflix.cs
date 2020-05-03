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
        public static Playlist Canciones;
        public static Playlist Videos;
        public static Playlist Peliculas;
        public static Playlist Podcast;
        public static Playlist Audiolibros;

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
