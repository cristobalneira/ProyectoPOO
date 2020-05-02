using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Proyecto_POO
{
    public class Perfil : Usuario
    {
        public string Nombre_perfil;
        public enum Tipo_de_Perfil 
        {
            Artista,
            Publico,
            Privado
        }
        public Playlist Fav_Canciones;
        public Playlist Fav_Videos;
        public Playlist Fav_Podcast;
        public Playlist Fav_AudioLibro;
        public List<Playlist> Playlists_Propias;
        public List<Playlist> Playlists_de_Otros;
        public List<Perfil> Seguidos;
        public List<Perfil> Seguidores;
        public List<Persona> Personas_Seguidas;
        public List<Archivo> En_Cola;

        public Perfil(string nombre, string apellido, int edad, string pais, string email, string contraseña, string nombre_perfil)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Pais = pais;
            Email = email;
            Contraseña = contraseña;
            Nombre_perfil = nombre_perfil;
        }
        public string Informacio_de_Perfil()
        {
            string a = "Nombre de perfil: " + Nombre_perfil + "\nCanciones favoritas: " + Fav_Canciones.Informacion_Playlist()
                + "\nVideos favoritos: " + Fav_Videos.Informacion_Playlist() + "\nPodcast favoritos: " + Fav_Podcast.Informacion_Playlist()
                + "\nAudiolibros favoritos: " + Fav_AudioLibro.Informacion_Playlist();
            a += "\nPlaylists propias: ";
            int i_1 = 1;
            foreach (var item in Playlists_Propias)
            {
                a += i_1 + item.Nombre;
                i_1 += 1;
            }
            a += "\nPlaylists de otros: ";
            int i_2 = 1;
            foreach (var item in Playlists_de_Otros)
            {
                a += i_2 + item.Nombre;
                i_2 += 1;
            }
            int i_3 = 1;
            a += "\nPerfiles seguidos: ";
            foreach (var item in Seguidos)
            {
                a += i_3 + item.Nombre_perfil;
                i_3 += 1;
            }
            int i_4 = 1;
            a += "\nSeguidores: ";
            foreach (var item in Seguidores)
            {
                a += i_4 + item.Nombre_perfil;
                i_4 += 1;
            }
            int i_5 = 1;
            a += "\nPersonas seguidas: ";
            foreach (var item in Personas_Seguidas)
            {
                a += i_5 + item.Nombre;
                i_5 += 1;
            }
            int i_6 = 1;
            a += "\nEn cola: ";
            foreach (var item in En_Cola)
            {
                a += i_6 + item.Titulo;
                i_6 += 1;
            }
            return (a);
        }

    }
}
