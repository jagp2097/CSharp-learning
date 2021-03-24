using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {

            Caballo Spirit = new Caballo("Spirit");

            Humano Chito = new Humano("Chito");

            Gorila Copito = new Gorila("Copito");

            // Console.WriteLine(Spirit.GetNombre());

            // Console.WriteLine(Chito.GetNombre());

            // Console.WriteLine(Copito.GetNombre());

            // Principio de sustitución (es siempre un...)
            Mamiferos caballo = new Caballo("Ferrari"); // un Caballo SIEMPRE ES UN Mamifero

            Mamiferos humano = new Humano("Arnulfo"); // un Humano SIEMPRE ES UN Mamifero



        }
    }

    class Mamiferos
    {
        private string NombreSerVivo;

        public Mamiferos(string NombreSerVivo)
        {
            this.NombreSerVivo = NombreSerVivo;
        }


        public void Respirar()
        {
            Console.WriteLine("Puedo respirar");
        }

        public void CuidarCrias()
        {
            Console.WriteLine("Puedo criar");
        }

        public string GetNombre()
        {
            return $"El nombre del mamifero es: {this.NombreSerVivo}";  
        }
    }

    class Gorila : Mamiferos
    {
        // :base() , llamada al constructor de la superclase
        public Gorila(string NombreGorila) : base(NombreGorila) 
        {

        }

       public void Trepar()
        {
            Console.WriteLine("Puedo trepar");
        }
    }

    class Caballo : Mamiferos
    {

        public Caballo(string NombreCaballo) : base(NombreCaballo)
        {

        }

        public void Galopar()
        {
            Console.WriteLine("Puedo galopar");
        }
    }

    class Humano : Mamiferos
    {

        public Humano(string NombreHumano) : base(NombreHumano)
        {

        }

        public void Pensar()
        {
            Console.WriteLine("Puedo pensar");
        }
    }

}
