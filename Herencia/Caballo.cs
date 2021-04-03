using System;

namespace Herencia
{
    public class Caballo : Mamifero
    {
        public Caballo(string nombreCaballo) : base(nombreCaballo)
        {}

        public void Galopar()
        {
            Console.WriteLine("Puedo galopar");
        }
    }
}