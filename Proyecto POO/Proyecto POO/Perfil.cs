using System;
using System.Collections.Generic;
using System.Runtime.Serialization;



namespace Proyecto_POO
{
    [Serializable()]
    public class Perfil:ISerializable
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
        public List<Cancion> Fav_Canciones = new List<Cancion>();
        public List<Pelicula> Fav_Pelicula = new List<Pelicula>();
        public List<Video> Fav_Videos = new List<Video>();
        public List<Podcast> Fav_Podcast = new List<Podcast>();
        public List<AudioLibro> Fav_AudioLibro = new List<AudioLibro>();

        public List<Playlist> Playlists_Canciones_Propias = new List<Playlist>();
        public List<Playlist> Playlists_Canciones_De_Otros = new List<Playlist>();

        public List<Perfil> Seguidos = new List<Perfil>();
        public List<Perfil> Seguidores = new List<Perfil>();
        public List<Persona> Personas_Seguidas = new List<Persona>();
        public List<Cancion> En_Cola_cancion = new List<Cancion>();
        public List<Video> En_Cola_video = new List<Video>();
        public List<Pelicula> En_Cola_pelicula = new List<Pelicula>();
        public List<Podcast> En_Cola_podcast = new List<Podcast>();
        public List<AudioLibro> En_Cola_audiolibro = new List<AudioLibro>();

        //Constructor
        public Perfil() { }
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
            foreach (var item in Playlists_Canciones_Propias)
            {
                a += i_1 + ". " + item.Informacion_Playlist();
                i_1 += 1;
            }
            int i_2 = 1;
            a += "\nPlaylist de otros: ";
            foreach (var item in Playlists_Canciones_De_Otros)
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

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Usuario_Asociado", Usuario_Asociado);
            info.AddValue("Nombre_perfil", Nombre_perfil);
            info.AddValue("Tipo_de_Perfil", Tipo_de_Perfil);
            info.AddValue("Fav_Canciones", Fav_Canciones);
            info.AddValue("Fav_Pelicula", Fav_Pelicula);
            info.AddValue("Fav_Videos", Fav_Videos);
            info.AddValue("Fav_Podcast", Fav_Podcast);
            info.AddValue("Fav_AudioLibro", Fav_AudioLibro);
            info.AddValue("Playlists_Canciones_Propias", Playlists_Canciones_Propias);
            info.AddValue("Playlists_Canciones_De_Otros", Playlists_Canciones_De_Otros);
            info.AddValue("Seguidos", Seguidos);
            info.AddValue("Seguidores", Seguidores);
            info.AddValue("Personas_Seguidas", Personas_Seguidas);
            info.AddValue("En_Cola_cancion", En_Cola_cancion);
            info.AddValue("En_Cola_video", En_Cola_video);
            info.AddValue("En_Cola_pelicula", En_Cola_pelicula);
            info.AddValue("En_Cola_podcast", En_Cola_podcast);
            info.AddValue("En_Cola_audiolibro", En_Cola_audiolibro);
        }
        public Perfil(SerializationInfo info, StreamingContext context)
        {
            Usuario_Asociado = (Usuario)info.GetValue("Usuario_Asociado", typeof(Usuario));
            Nombre_perfil = (string)info.GetValue("Nombre_perfil", typeof(string));
            Tipo_de_Perfil = (int)info.GetValue("Tipo_de_Perfil", typeof(int));
            Fav_Canciones = (List<Cancion>)info.GetValue("Fav_Canciones", typeof(List<Cancion>));
            Fav_Pelicula = (List<Pelicula>)info.GetValue("Fav_Pelicula", typeof(List<Pelicula>));
            Fav_Videos = (List<Video>)info.GetValue("Fav_Videos", typeof(List<Video>));
            Fav_Podcast = (List<Podcast>)info.GetValue("Fav_Podcast", typeof(List<Podcast>));
            Fav_AudioLibro = (List<AudioLibro>)info.GetValue("Fav_AudioLibro", typeof(List<AudioLibro>));
            Playlists_Canciones_Propias = (List<Playlist>)info.GetValue("Playlists_Canciones_Propias", typeof(List<Playlist>));
            Playlists_Canciones_De_Otros = (List<Playlist>)info.GetValue("Playlists_Canciones_De_Otros", typeof(List<Playlist>));
            Seguidos = (List<Perfil>)info.GetValue("Seguidos", typeof(List<Perfil>));
            Seguidores = (List<Perfil>)info.GetValue("Seguidores", typeof(List<Perfil>));
            Personas_Seguidas = (List<Persona>)info.GetValue("Personas_Seguidas", typeof(List<Persona>));
            En_Cola_cancion = (List<Cancion>)info.GetValue("En_Cola_cancion", typeof(List<Cancion>));
            En_Cola_video = (List<Video>)info.GetValue("En_Cola_video", typeof(List<Video>));
            En_Cola_pelicula = (List<Pelicula>)info.GetValue("En_Cola_pelicula", typeof(List<Pelicula>));
            En_Cola_podcast = (List<Podcast>)info.GetValue("En_Cola_podcast", typeof(List<Podcast>));
            En_Cola_audiolibro = (List<AudioLibro>)info.GetValue("En_Cola_audiolibro", typeof(List<AudioLibro>));

        }
    }
}
