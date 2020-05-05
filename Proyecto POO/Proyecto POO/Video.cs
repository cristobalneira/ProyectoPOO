using System;
using System.Collections.Generic;
using WMPLib;
namespace Proyecto_POO
{
    public class Video
    {
        public List<Persona> Actores;
        public List<Persona> Directores;
        public string Estudio;
        public int Resolucion;
        public string Descripcion;
        private enum Clasificacion
        {
            //audiencia general con atracctivo infantil
            AA = 0,
            //Todo publico
            A = 1,
            //Adolescente de 12 años en adelante
            B = 2,
            //Mayores de 18 años
            C = 3,
            //Solo adultos, con sexo explicito, lenguaje procaz o alto grado de violencia
            D = 4,
        };
        
        
        private enum Genero
        {
            Comedia = 1,
            Accion = 2,
            Aventura = 3,
            Dramatica = 4,
            Terror = 5,
            Musicales = 6,
            CienciaFiccion = 7,
            Guerras = 8,
            Crimen = 9,
            Romance = 10,

        };

        public Video(List<Persona> actores, List<Persona> directores, string estudio,int resolucion, string descripcion)
        {
            List<Persona> Actores = actores;
            List<Persona> Directores = directores;
            Estudio = estudio;
            Resolucion = resolucion;
            Descripcion = descripcion;

        }
        public string Informacion_Video()
        {
            return " ";
        }
    }
}
