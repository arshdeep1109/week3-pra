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
            int[] red = new int[5];

            Console.WriteLine("enter some number");
            Console.WriteLine("enter fini number");
            string input = "";
            int product = 1;
            int i = 0;
            while(true)
            {
                input = Console.ReadLine();
                if (input.ToLower().Equals("fini")) 
                { break; }
                red[i++] = Convert.ToInt32(input);
                if (i == red.Length) ;
                {
                    Console.WriteLine("out of erray");

                    break;
                }

            }
            Console.WriteLine("out of erray{0}",product);

        }

    }
}
