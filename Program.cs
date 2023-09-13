using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the for loop");
            for (int i = 0;1 <=50;i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("Hi we are loping");
                Console.WriteLine("This is i+2 " + Convert.ToInt32(i + 2));

            }
            Console.WriteLine("End of FOR loop");
            Console.WriteLine("*******************");
            Console.WriteLine("********END OF FOR loop**********");
            Console.WriteLine("This is the WHILE loop");
            int j = 0;
            while (j < 5)
            {
                Console.WriteLine(j);
                j++;

            }
            //freeze console
            Console.ReadLine();

        }
    }
}
