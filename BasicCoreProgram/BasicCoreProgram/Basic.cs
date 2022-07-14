using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class Basic
    {
        public void Core()
        {
            Console.WriteLine("Enter three numbers");
            int a = Convert.ToInt32(Console.ReadLine()); 
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if((a > b) && (a > c))
            {
                Console.WriteLine($"a={a} is the largest number among three");
            }
            else if((b > c) && (b > a))
            {
                Console.WriteLine($"b={b} is the largest number among three");
            }
            else
            {
                Console.WriteLine($"c={c} is the largest number among three");
            }
            
        }
    }
}
