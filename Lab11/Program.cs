using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввведите первый коэффициент");
            double k=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ввведите второй коэффициент");
            double b=Convert.ToDouble(Console.ReadLine());

            UR ur=new UR(k,b);
            Console.WriteLine(ur.Root());
            Console.ReadKey();
        }
    }
}
