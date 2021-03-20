using System;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {  
            /*
                operadores aritmeticos
                casting, conversion implicita y explicita
            */


            // int edadPersona1;
            // int edadPersona2;
            // int edadPersona3;
            // int edadPersona4;

            // edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 27;

            // Console.WriteLine($"La edad de la persona4 es {edadPersona4}");

            // Decalracion implicita de variables, utilizacion de la palabra var
            // var persona = "DAe";

            // Console.WriteLine(persona);

            // double temperatura = 34.2;

            // casting
            // conversión explicita, hay perdida de información
            // int temperaturaMonterrey = (int) temperatura;

            // // conversion implicita, 
            // int habitantes = 10000000;

            // long habitantesCiudad = habitantes;

            // float pesoMaterial = 5.711F;

            // double pesoMaterialPrec = pesoMaterial;

            // Console.WriteLine(temperaturaMonterrey);

            // Conversion de texto a numero, parse(), de valor primitico a tipo obj 

            // Console.WriteLine("Introdice el primer numero: ");

            // int num1 = int.Parse(Console.ReadLine());

            // Console.WriteLine("Indrrotice el segundo numero: ");

            // int num2 = int.Parse(Console.ReadLine());

            // Console.WriteLine($"La suma de los dos numeros es {num1 + num2}");

            /*
                Constantes
            */
            // const int VALOR = 44;

            // Console.WriteLine($"El valor de la constante es {VALOR}");
            
            // System.Console.WriteLine("El valode de la los nunomeros es; {0} {1}", 4, 5);

            const double PI = 3.1415;

            Console.WriteLine("Introduce el valor del radio del circulo: ");

            double radio = double.Parse(Console.ReadLine());

            double area = PI * (radio * radio);

            Console.WriteLine($"El área del circulo es: {area}");


        }   
    }
}
