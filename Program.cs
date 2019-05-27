using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rehan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            String num1 = Console.ReadLine();
            Console.WriteLine("enter a number");
            String num2 = Console.ReadLine();
            int sum = Convert.ToInt32(num1) + Convert.ToInt32(num2);
            Console.WriteLine("sum is "+sum);
        }
    }
}
