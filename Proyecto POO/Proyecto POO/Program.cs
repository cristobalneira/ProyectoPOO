using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Proyecto_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer player1 = new SoundPlayer();
            player1.SoundLocation = @"‎⁨ ‎⁨Macintosh HD⁩ ▸ ⁨Usuarios⁩ ▸ ⁨camilavillalobos⁩ ▸ ⁨Escritorio⁩ ▸ ⁨Canciones⁩ ▸Solo.wav";
            player1.Play();
            Console.ReadKey();
        }
    }
}
