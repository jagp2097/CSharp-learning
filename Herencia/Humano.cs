using System;

namespace Herencia
{
    public class Humano : Mamifero
    {
        public Humano(string nombreHumano) : base(nombreHumano)
        {}
        public override void Pensar()
        {
            base.Pensar();
            Console.WriteLine("Puedo pensar y razonar");
        }
    }
}