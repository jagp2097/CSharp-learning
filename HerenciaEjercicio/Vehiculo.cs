using System;

namespace HerenciaEjercicio
{
    public class Vehiculo
    {
        public void ArrancarMotor()
        {
            Console.WriteLine("Arrancando el motor...");
        }

        public void DetenerMotor()
        {
            Console.WriteLine("Deteniendo el motor...");
        }

        public virtual void Conducir()
        {
            Console.WriteLine("Conduciendo el vehículo...");
        }
    }
}