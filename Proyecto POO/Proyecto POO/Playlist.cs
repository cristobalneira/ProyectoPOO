﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Proyecto_POO
{
    public class Playlist
    {
        public string Nombre;
        public List<Archivo> Objetos;
        public double Calificacion;
        public string Tipo;
        public TimeSpan Duracion;

        public Playlist(string nombre, List<Archivo> objetos, double calificacion, string tipo, TimeSpan duracion)
        {
            Nombre = nombre;
            Objetos = objetos;
            Calificacion = calificacion;
            Tipo = tipo;
            Duracion = duracion;
        }

        public string Informacion_Playlist()
        {
            string a = "Nombre playlist: " + Nombre;
            int i_7 = 1;
            a += "\n Nombre archivos en playlist: ";
            foreach (var item in Objetos)
            {
                a += i_7 + item.Titulo;
                i_7 += 1;
            }
            a += "\nCalificacion: " + Calificacion + "\nTipo de playlist: " + Tipo + "\nDuracion: " + Duracion;
            return (a);
        }
    }
}
