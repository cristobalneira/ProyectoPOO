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
        // hacer playlist de todas las canciones, de todos los videos, todods los podcast todos los audiolibros etc.
        //public static string Reproducir_Cancion(Archivo archivo)
        //{            
        //}
        //Metodos:
        
        public static string Reproducir(Playlist playlist)
        {
            
            SoundPlayer Spotflix = new SoundPlayer();
            Spotflix.SoundLocation = playlist.Objetos[0].URL;
            Spotflix.Play();
            string a= "Reproduciendo: "+ playlist.Objetos[0].Titulo;
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
