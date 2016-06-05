using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicing_the_divisibility_function
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            Console.Write("Welcome, please input the number to be tested: ");
            num = Convert.ToDouble(Console.ReadLine());
            if (num > 0)
            {
                if (num % 8 == 0) 
                {
                    Console.WriteLine("this value is divisible by 2,4 and 8");
                    Console.ReadLine();
                }
                else 
                {
                    Console.WriteLine("this value is not divisible by 2,4 and 8");
                    Console.ReadLine(); 
                }
            }
            else {
                   Console.WriteLine("any number less than 0 is not premitted for testing");
                   Console.ReadLine();
            }
        }
    } 
 }
    

