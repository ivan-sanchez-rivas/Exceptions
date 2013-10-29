using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.WriteLine("Escribe tu edad\n");
                    int edad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Correcto!\n");
                }
                catch
                {
                    CustomException nulo = new CustomException();
                }
            }
            while (true);
        }
    }
}
