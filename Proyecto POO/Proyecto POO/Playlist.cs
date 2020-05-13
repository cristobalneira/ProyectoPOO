using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Proyecto_POO
{
    public class Playlist
    {
        public enum enum_TipoDePlaylist
        {
            Publica = 1,
            Privada = 2,
        }
        public List<Cancion> Playlist_paralista;//listas de listas
        public string Nombre;
        public TimeSpan Duracion = TimeSpan.Zero;
        public int Tipo_De_Playlist;

        //Constructor
        public Playlist() { }
        public Playlist(List<Cancion> playlist_paralista, string nombre, int tipo_de_playlist)
        {
            Playlist_paralista = playlist_paralista;
            Nombre = nombre;
            Tipo_De_Playlist = tipo_de_playlist;
        }

        public string Informacion_Playlist()
        {
            string a = "Nombre playlist: " + Nombre + "Tipo de playlist" + (enum_TipoDePlaylist)Tipo_De_Playlist;
            a += "\n Nombre archivos en playlist: ";
            TimeSpan b = TimeSpan.Zero;
            for (int i = 0; i < Playlist_paralista.Count; i++)
            {
                a += (i+1) + ".  " + Playlist_paralista[i].Titulo;
                b += Playlist_paralista[i].Duracion;
            }
            a += "\nDuracion: " + b;
            return (a);
        }

    }
}
