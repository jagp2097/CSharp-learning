using System;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int max;

            Console.Write("Introduce un numero: ");
            max = Convert.ToInt32(Console.ReadLine());

            for (int counter = 0; counter <= max; counter++) {
                Console.Write("{0} ", counter * counter);
            }

        }
    }
}
