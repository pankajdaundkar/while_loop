using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Print the even numbers from 1 to 100
namespace while_loop
{
    internal class assignment_3
    {
        static void Main(string[] args)
        {
            int i = 1;
             while (i <= 100)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    
                }
                i++;
            }
        }
    }
}
