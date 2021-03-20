using System;

namespace ConceptosPOO
{
    class Punto
    {
        private double x;

        private double y;

        private static int contadorPuntos = 0;

        public const int constantePrueba = 9; // las constantes son static por defecto

        public Punto()
        {
            this.x = 0;

            this.y = 0;

            contadorPuntos++;
        }

        public Punto(double x, double y)
        {
            this.x = x;

            this.y = y;

            contadorPuntos++;
        }

        public double DistanciaHasta(Punto otroPunto)
        {
            double xDif = this.x  - otroPunto.x;

            double yDif = this.y - otroPunto.y;

            double distaciaPuntos = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));

            return distaciaPuntos;
        }

        public static int ContadorPuntos() => contadorPuntos;

    }
}