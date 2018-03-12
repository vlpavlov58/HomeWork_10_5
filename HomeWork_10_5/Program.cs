using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_10_5
{
    class Program
    {
        static int GetMin(int x, int y)
        {
            //
            if (x>y)
            {
                Console.WriteLine("Min: "+y); 
            }
            return y;
        }
        static int GetMax(int x, int y)
        {

            if (x < y)
            {
                Console.WriteLine("Max: " + y);
            }
            else if (x==y)
            {
                Console.WriteLine(x +" Equals " + y);
            }
            return y;
        }

        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            GetMin(x, y);
            GetMax(x, y);
        }
    }
}
