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
        public List<IWMPPlaylist> Lista_Play_list;//listas de listas
        public IWMPPlaylist Play_list;
        public int Tipo_De_Playlist;


        public Playlist(string Nombre, int tipo_de_playlist)
        {
            Play_list = new WindowsMediaPlayer().newPlaylist(Nombre, null);
//<<<<<<< HEAD
            //Lista_Play_list.Add(Play_list);
            //=======
            //Lista_Play_list.Add(Play_list);
            //Tipo_De_Playlist = tipo_de_playlist;
//>>>>>>> 9282fc15fbe368e52cdafe943053befa8c959ce2
        }

        public string Informacion_Playlist()
        {
            string a = "Nombre playlist: " + Play_list.name + "Tipo de playlist" + (enum_TipoDePlaylist)Tipo_De_Playlist;
            a += "\n Nombre archivos en playlist: ";
            double b = 0;
            for (int i = 0; i < Play_list.count; i++)
            {
                a += i + " " + Play_list.attributeName[i];
                b+= Play_list.Item[i].duration;
            }
            a += "\nDuracion: " + b;
            return (a);
        }

    }
}
