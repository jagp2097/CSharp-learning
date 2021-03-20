using System;

namespace PracticaMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            long longNum = 2L;

            float floatNum = 2F;

            bool isTrue = true;

            if (isTrue) {
                Console.WriteLine("Es verdad");
            }
            else {
                Console.WriteLine("No es verdad");
            }

            // ImprimeSaludo();

            // Console.WriteLine("Introduzca un nombre: ");

            // string nombre = Console.ReadLine();

            // ImprimeSaludoConNombre(nombre);

            // Console.WriteLine("Introduzca un numero: ");

            // double num1 = double.Parse(Console.ReadLine());

            // Console.WriteLine("Introduzca otro numero: ");

            // double num2 = double.Parse(Console.ReadLine());

            // Console.WriteLine($"EL resultado es {SumaDeNumeros(num1, num2)}");

        }

        static void ImprimeSaludo() 
        {
            Console.WriteLine("Hola, desde el metodo");
        }

        static void ImprimeSaludoConNombre(string nombre)
        {
            Console.WriteLine($"Hola, {nombre}");
        }

        static double SumaDeNumeros(double num1, double num2) => num1 + num2;

    }
}
