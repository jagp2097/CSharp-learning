using System;

namespace Bucles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Adivina el nuemro de entre 1 y 100
            Random rand = new Random();

            int secret = rand.Next(0, 100);

            int intentos = 0;

            int numeroIntento;

            do {

                intentos++;

                Console.WriteLine("Introduce el numero que creas que sea: ");
                
                try {

                    numeroIntento = Int32.Parse(Console.ReadLine());

                } catch (SystemException ex) {
                    
                    Console.WriteLine(ex.Message);

                    Console.WriteLine("Introduce un valor numerico valido");

                    numeroIntento = 0;

                }

                if (numeroIntento < secret) Console.WriteLine("El número es más alto") ;
            
                if (numeroIntento > secret) Console.WriteLine("El número es más bajo");

            } while (secret != numeroIntento);

            Console.WriteLine($"Correcto, el numero secreto es {secret}");

            Console.WriteLine($"Lo lograste en {intentos} intentos");

        }
    }
}
