using System;

namespace EjemplosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche = new Coche();

            Console.WriteLine(coche.getInfoCoche());

            // Console.WriteLine(coche.getInfoCoche());
        }
    }

    partial class Coche // partial divide la clase en trozos
    {
        private int ruedas;

        private double largo;

        private double ancho;

        private bool climatizador;

        private string tapiceria;

        public Coche()
        {
            ruedas = 4;

            largo = 2300.4;

            ancho = 0.800;

            tapiceria = "tela";
        }   
    }

    partial class Coche {
        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            
            largo = largoCoche;

            ancho = anchoCoche;
        }

        public String getInfoCoche()
        {
            return $"Info del coche: \nRuedas: {ruedas} Largo: {largo} Ancho: {ancho} Tapiceria: {tapiceria}";
        }

        public void setExtras(bool climatizador, string tapiceria)
        {
            this.climatizador = climatizador;

            this.tapiceria = tapiceria;
        }

        public string getExtras()
        {
            return $"Extras del coche: \nClimatizador: {climatizador} Tapiceria: {tapiceria}";
        }

    }

}
