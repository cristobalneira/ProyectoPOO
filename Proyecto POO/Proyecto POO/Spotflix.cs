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

        public static IWMPPlaylist Canciones = new WindowsMediaPlayer().newPlaylist("Canciones", null);


        public static List<Usuario> Lista_Usuarios;
        public static List<Perfil> Lista_Perfil;




        //Metodos:
        public static WindowsMediaPlayer spotflix = new WindowsMediaPlayer();

        public static void Reproducir(IWMPPlaylist playlists, int v = 0)
        {
            Thread.Sleep(500);
            spotflix.currentPlaylist.clear();
            spotflix.currentPlaylist = playlists;
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
