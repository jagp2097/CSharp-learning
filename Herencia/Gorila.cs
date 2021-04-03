using System;

namespace Herencia
{
    public class Gorila : Mamifero
    {
        // :base() hace la llamada al constructor de la superclase
        public Gorila(string nombreGorila) : base (nombreGorila)
        {}

        public void Trepar()
        {
            Console.WriteLine("Puedo trepar");
        }

        public override void Pensar()
        {
            Console.WriteLine("Pensamiento instintivo avanzado.");
        }
    }
}