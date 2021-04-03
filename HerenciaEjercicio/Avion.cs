using System;

namespace HerenciaEjercicio
{
    public class Avion : Vehiculo
    {
        public override void Conducir()
        {
            // base.Conducir();
            Console.WriteLine("Conduciendo el avión...");
        }
    }
}