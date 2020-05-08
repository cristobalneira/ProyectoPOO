using System;
using WMPLib;
namespace Proyecto_POO
{
    public class Interaccion_Usuario
    {
        public Interaccion_Usuario()
        {
        }
        public void Buscar()
        {
            
        }
        public void Editar_Informacion()
        {
            Console.WriteLine("cual queri editar?");
            //1
            int i_1 = 1;
            foreach (var item in Spotflix.Audiolibros.Objetos)
            {
                Console.WriteLine((i_1)+". "+item.Titulo);
                i_1 += 1;
            }
            int i_2 = Convert.ToInt32(Console.ReadLine());
            _ = Spotflix.Audiolibros.Objetos[0];

            //escojer 1, imprima la informacion
            //cambiar
            //crear
            //AudioLibro a1 = new AudioLibro(año,cw,ValueTuple,base,e);

            //12345 pod,can,pel,aud,vid
            //
        }
    }
}
