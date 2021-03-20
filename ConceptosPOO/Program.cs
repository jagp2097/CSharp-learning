using System;

// using static System.Math; // importa los metodos estatico y solo llamamo a los metodos

namespace ConceptosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // realizarTarea();

            // double raiz = Sqrt(9);

            // clase anonima
            // Solo pueden contener campos públicos
            // Todos los campos deben de estar iniciados
            // Los campos no pueden ser static
            // No se pueden definir métodos
            var miVar = new { Nombre = "Oso", Edad = 13 };

            Console.WriteLine(miVar.Nombre + " " + miVar.Edad);

        }

        static void realizarTarea()
        {
            // TODO: Este comentario nos indica una tarea por hacer (lista de tareas en Visual Studio)
            Punto origen = new Punto(2.55, 840.7);

            Punto destino = new Punto();

            double distacia = origen.DistanciaHasta(destino);

            Console.WriteLine(distacia);

            Console.WriteLine($"Contador de puntos: {Punto.ContadorPuntos()}");

        }
        
    }
}
