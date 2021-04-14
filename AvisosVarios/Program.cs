using System;

namespace AvisosVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            AvisosTrafico aviso1 = new AvisosTrafico();

            aviso1.MostrarAviso();

            AvisosTrafico aviso2 = new AvisosTrafico("Transito Monterrey", "Aliento alcoholico, sanción de $4990.", "13-04-2021");

            Console.WriteLine(aviso2.GetFecha());

            aviso2.MostrarAviso();

        }
    }
}
