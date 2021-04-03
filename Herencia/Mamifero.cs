using System;

namespace Herencia
{
    public class Mamifero
    {
        public string NombreSerVivo;

        public Mamifero(string nombreSerVivo)
        {
            NombreSerVivo = nombreSerVivo;
        }

        public void Respirar()
        {
            Console.WriteLine("Puedo respirar");
        }

        public void CuidarCrias()
        {
            Console.WriteLine("Cuido a mis crias");
        }

        public virtual void Pensar()
        // virtual indica que este método debe de ser implementado en todas las clases que hereden de esta
        // pero modificandolo en la clase hija
        {
            Console.WriteLine("Pensamiento básico instintivo");
        }

        public string GetNombre()
        {
            return $"El nombre del mamifero es {this.NombreSerVivo}";
        }
    }
}