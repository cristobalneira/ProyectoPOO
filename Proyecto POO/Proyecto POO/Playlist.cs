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

        public List<IWMPPlaylist> Lista_Play_list;
        public IWMPPlaylist Play_list;

        public Playlist()
        {
            Play_list = new WindowsMediaPlayer().newPlaylist("Canciones", null); ;
        }

        public string Informacion_Playlist()
        {
            string a = "Nombre playlist: " + Play_list.name;
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
