using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;


namespace Proyecto_POO
{

    public class Perfil
    {
        public enum enum_TipoDePerfil
        {
            Artista = 1,
            Publico = 2,
            Privado = 3,

        }
        //Atributos
        public Usuario Usuario_Asociado;
        public string Nombre_perfil;
        public int Tipo_de_Perfil;
        public List<Cancion> Fav_Canciones;
        public List<Pelicula> Fav_Pelicula;
        public List<Video> Fav_Videos;
        public List<Podcast> Fav_Podcast;
        public List<AudioLibro> Fav_AudioLibro;
        public List<Playlist> Playlists_Propias = new List<Playlist>();
        public List<Playlist> Playlists_De_Otros = new List<Playlist>();
        public List<Perfil> Seguidos = new List<Perfil>();
        public List<Perfil> Seguidores = new List<Perfil>();
        public List<Persona> Personas_Seguidas = new List<Persona>();
        public List<Cancion> En_Cola_cancion = new List<Cancion>();
        public List<Video> En_Cola_video = new List<Video>();
        public List<Pelicula> En_Cola_pelicula = new List<Pelicula>();
        public List<Podcast> En_Cola_podcast = new List<Podcast>();
        public List<AudioLibro> En_Cola_audiolibro = new List<AudioLibro>();

        //Constructor

        public Perfil(Usuario usuario_asociado, string nombre_perfil,int tipo_de_Perfil)
            
        {
            Usuario_Asociado = usuario_asociado;
            Nombre_perfil = nombre_perfil;
            Tipo_de_Perfil = tipo_de_Perfil;

        }
        public string Informacion_de_Perfil()
        {
            string a = "Nombre Usuario: " + Usuario_Asociado.Nombre + " " + Usuario_Asociado.Apellido + "\nNombre de perfil: "
                + Nombre_perfil + "\nCanciones favoritas: ";
            int i = 0;
            foreach (var item in Fav_Canciones)
            {
                a += i + ". " + item.Informacion_Cancion();
            }
            //a += "\nVideos favoritos: " + Fav_Videos.Informacion_Playlist() + "\nPodcast favoritos: " + Fav_Podcast.Informacion_Playlist()
            //+ "\nAudiolibros favoritos: ";
            i = 0;
            foreach (var item in Fav_AudioLibro)
            {
                a += i + ". " + item.Informacion_AudioLibro();
            }
            int i_1 = 1;
            a += "\nPlaylist propias: ";
            foreach (var item in Playlists_Propias)
            {
                a += i_1 + ". " + item.Informacion_Playlist();
                i_1 += 1;
            }
            int i_2 = 1;
            a += "\nPlaylist de otros: ";
            foreach (var item in Playlists_De_Otros)
            {
                a += i_2 + ". " + item.Informacion_Playlist();
                i_2 += 1;
            }
            int i_3 = 1;
            a += "\nPerfiles seguidos: ";
            foreach (var item in Seguidos)
            {
                a += i_3 + ". " + item.Nombre_perfil;
                i_3 += 1;
            }
            int i_4 = 1;
            a += "\nSeguidores: ";
            foreach (var item in Seguidores)
            {
                a += i_4 + ". " + item.Nombre_perfil;
                i_4 += 1;
            }
            int i_5 = 1;
            a += "\nPersonas seguidas: ";
            foreach (var item in Personas_Seguidas)
            {
                a += i_5 + ". " + item.Nombre_y_Apellido;
                i_5 += 1;
            }
            a += "\nEn cola: ";
            int i_6 = 1;
            foreach (var item in En_Cola_cancion)
            {
                a+=i_6+". "+item.Informacion_Cancion();
            }
            
            
            return (a);
        }
        public string Editar_Informacion(Perfil p)
        {
            Usuario usuario=p.Usuario_Asociado;
            Usuario_Asociado = usuario;
            string nombrperf=p.Nombre_perfil;
            Nombre_perfil = nombrperf;
            int tipoperfil=p.Tipo_de_Perfil;
            Tipo_de_Perfil = tipoperfil;
            return "Cambios actualizados";
        }
    }
}
