using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first number: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter your last number: ");
            int n2= int.Parse(Console.ReadLine());
            int Sum =0;           
            for (int i = n1; i <= n2; i++)
            {
               for(int j = 1; j <= (i/2); j++)
                {
                    if (i % j== 0)
                    {
                        Sum = Sum + j;
                    }
                    
                }
                if (Sum == i)
                {
                    Console.WriteLine(Sum);
                    Sum = 0;
                }
                else
                {

                    Sum = 0;
                    continue;

                }
            }
            Console.WriteLine("are the perfect numbers");
            Console.ReadLine();
        }
    }
}
