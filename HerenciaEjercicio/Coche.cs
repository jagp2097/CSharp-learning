using System;

namespace HerenciaEjercicio
{
    public class Coche : Vehiculo
    {
        public override void Conducir()
        {
            // base.Conducir();
            Console.WriteLine("Corriendo el coche...");
        }
    }
}