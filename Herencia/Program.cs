using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {

            // Caballo Spirit = new Caballo("Spirit");

            // Humano Chito = new Humano("Chito");

            // Gorila Copito = new Gorila("Copito");

            // // Console.WriteLine(Spirit.GetNombre());

            // // Console.WriteLine(Chito.GetNombre());

            // // Console.WriteLine(Copito.GetNombre());

            // // Principio de sustitución (es siempre un...)
            // Mamiferos caballo = new Caballo("Ferrari"); // un Caballo SIEMPRE ES UN Mamifero

            // Mamiferos humano = new Humano("Arnulfo"); // un Humano SIEMPRE ES UN Mamifero

            Mamifero[] mamiferos = {
                new Humano("Chito"),
                new Caballo("Spirit"),
                new Gorila("Copito")
            };

            for (int i = 0; i < mamiferos.Length; i++)
            {
                mamiferos[i].Pensar();
            }

        }
    }
}