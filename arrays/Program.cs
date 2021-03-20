using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // array implicito
            // var datos = new[] { "Juan", "Diaz", 223 }; // error por ser de diferentes tipos
            // var datos = new[] { 233.2, 33, 423.3, 3332 }; // se convierte en un array de tipo double

            // // array de objetos
            // Empleados[] empleados = new Empleados[2];

            // empleados[0] = new Empleados("Quancy", 43);
            // empleados[1] = new Empleados("Reasa", 23);

            // // array de clases anonimas
            // var personas = new[] {
            //     new { Nombre = "Ana", Edad = 19 },
            //     new { Nombre = "Wasa", Edad = 50 }
            // };

            // Console.WriteLine(personas[1]);

            // for (int i = 0; i < datos.Length; i++)
            // {
            //     Console.WriteLine(datos[i]);
            // }

            // foreach (Empleados empleado in empleados)
            // {
            //     Console.WriteLine($"{empleado.nombre} {empleado.edad}");
            // }

            int [] datos = new int [2];

            datos[0] = 323;
            datos[1] = 23234;

            int [] arr = LeerDatos();

            foreach (int num in arr)
            {
                System.Console.WriteLine(num);
            }

        }

        static int [] LeerDatos()
        {
            System.Console.WriteLine("Cuantos elemetos quieres en el array : ");
            int nume = Int32.Parse(Console.ReadLine());

            int [] data = new int[nume];
            int res = 0;

            for (int i = 0; i < data.Length; i++)
            {
                System.Console.WriteLine("Introduce el numeros para la posicion " + i );
                res = Int32.Parse(Console.ReadLine());
                data[i] = res;
            }

            return data;

        }

    }

    // class Empleados
    // {
    //     public string nombre { get; private set; }
    //     public int edad { get; private set; }

    //     public Empleados(String nombre, int edad)
    //     {
    //         this.nombre = nombre;

    //         this.edad = edad;
    //     }

    // }

}
