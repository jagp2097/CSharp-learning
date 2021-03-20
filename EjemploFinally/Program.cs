using System;

namespace EjemploFinally
{
    class Program
    {
        static void Main(string[] args)
        {

            System.IO.StreamReader archivo = null;

            try
            {
                int cont = 0;
                string line = "";

                string path = @"/home/jagp/Desktop/tirar.txt";                
                archivo = new System.IO.StreamReader(path);

                while ((line = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(line);

                    cont++;

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (archivo != null) archivo.Close();
                Console.WriteLine("Se cerro el archivo");
            }
        }
    }
}
