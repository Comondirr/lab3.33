using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите n");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите x");
                double x = double.Parse(Console.ReadLine());
                double S = 0;
                {
                    S += Math.Cos(2 * x) / 3 + Math.Cos(4 * x) / 15 + Math.Cos(6 * x) / 35;
                }
                Console.WriteLine("S={0:F2}", S);
            }
            catch
            {
            }

        }
    }
}

