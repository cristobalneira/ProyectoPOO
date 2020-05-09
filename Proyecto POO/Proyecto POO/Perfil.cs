﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;


namespace Proyecto_POO
{
    public class Perfil
    {
        public Usuario Usuario_Asociado;
        public string Nombre_perfil;
        public int Tipo_de_Perfil; 
        public Playlist Fav_Canciones;
        public Playlist Fav_Videos;
        public Playlist Fav_Podcast;
        public Playlist Fav_AudioLibro;
        public Playlist Playlists_Propias;
        public Playlist Playlists_de_Otros;
        public List<Perfil> Seguidos;
        public List<Perfil> Seguidores;
        public List<Persona> Personas_Seguidas;
        public Playlist En_Cola;

        public Perfil(Usuario usuario_asociado, string nombre_perfil,int tipo_de_Perfil, Playlist fav_Canciones, Playlist fav_Videos, Playlist fav_Podcast, Playlist fav_AudioLibro,
            Playlist playlists_Propias, Playlist playlists_de_Otros, List<Perfil> seguidos, List<Perfil> seguidores,
            List<Persona> personas_Seguidas, Playlist en_Cola)
        {
            Usuario_Asociado = usuario_asociado;
            Nombre_perfil = nombre_perfil;
            Tipo_de_Perfil = tipo_de_Perfil;
            Fav_Canciones = fav_Canciones;
            Fav_Videos = fav_Videos;
            Fav_Podcast = fav_Podcast;
            Fav_AudioLibro = fav_AudioLibro;
            Playlists_Propias = playlists_Propias;
            Playlists_de_Otros = playlists_de_Otros;
            Seguidos = seguidos;
            Seguidores = seguidores;
            Personas_Seguidas = personas_Seguidas;
            En_Cola = en_Cola;
        }


        public string Informacio_de_Perfil()
        {
            string a ="Nombre Usuario: " +Usuario_Asociado.Nombre + " " + Usuario_Asociado.Apellido + "\nNombre de perfil: " 
                + Nombre_perfil + "\nCanciones favoritas: " + Fav_Canciones.Informacion_Playlist()+ "\nVideos favoritos: " 
                + Fav_Videos.Informacion_Playlist() + "\nPodcast favoritos: " + Fav_Podcast.Informacion_Playlist()
                + "\nAudiolibros favoritos: " + Fav_AudioLibro.Informacion_Playlist()+ "\nPlaylists propias: "+Playlists_Propias.Informacion_Playlist()
                + "\nPlaylists de otros: "+Playlists_de_Otros.Informacion_Playlist();
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
            a += "\nEn cola: "+ En_Cola.Informacion_Playlist();
            
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
