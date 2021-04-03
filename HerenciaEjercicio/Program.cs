using System;
using System.Collections.Generic;

namespace HerenciaEjercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>
            {
                new Avion(),
                new Coche()
            };

            foreach (var vehiculo in vehiculos)
            {
                vehiculo.ArrancarMotor();
                vehiculo.Conducir();
                vehiculo.DetenerMotor();
                Console.WriteLine("-------");
            }
        }
    }
}
