﻿using System;

namespace LanzamientoExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdice in nmimepr: ");

            int mesNum = int.Parse(Console.ReadLine());

            try {
                NombreMes(mesNum);
            }
            catch (ArgumentOutOfRangeException ex) 
            {
                Console.WriteLine(ex.Message);
            }


        }

        static string NombreMes(int mes) 
        {
            switch (mes) 
            {
                case 1:
                    return "enero";
                case 2:
                    return "febrero";
                case 3:
                    return "marzo";
                case 4:
                    return "abril";
                case 5:
                    return "mayo";
                case 6:
                    return "junio";
                case 7:
                    return "julio";
                case 8:
                    return "agosto";
                case 9:
                    return "septiembre";
                case 10:
                    return "octubre";
                case 11:
                    return "noviembre";
                case 12:
                    return "diciembre";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

    }
}
