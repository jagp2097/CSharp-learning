using System;

namespace UsoChecked
{
    class Program
    {
        static void Main(string[] args)
        {

            checked {
                
                int num = int.MaxValue;
                
                int res = num + 20;

                Console.WriteLine(res);

            }


        }
    }
}
