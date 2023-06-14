using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Accept the number & print its table 
namespace while_loop
{
    internal class assignment_4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int num = Convert.ToInt32(Console.ReadLine());

            int i = 1;
             while (i <= 10)
            {
                Console.WriteLine(num *i);
                i++;
            }
        }
    }
}
