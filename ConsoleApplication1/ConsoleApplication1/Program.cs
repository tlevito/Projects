using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {



        static void Main(string[] args)
        {
            string inputstr = "n";
            int x = -1;
            int y = -1;
            int k = -1;
            DateTime startTime = DateTime.Now;
            DateTime endTime;

            do
            {
                y = -1;
                x = -1;

                while (x < 0)
                {
                    Console.WriteLine("What is the Min Value?");

                    if (!int.TryParse(Console.ReadLine(), out x))
                    {
                        Console.WriteLine("Please enter an Interger Min value");

                    }
                }

                while (y < 0)
                {
                    Console.WriteLine("What is the Max Value?");

                    if (!int.TryParse(Console.ReadLine(), out y))
                    {
                        Console.WriteLine("Please enter an Interger Max value");

                    }
                }

                k = x;

                long z = 0;

                z = GetCount(x, y);
                Console.WriteLine("Total Values : " + z.ToString());
                endTime = DateTime.Now;

                TimeSpan timeDif = endTime - startTime;
                Console.WriteLine("Program executed in : " + timeDif.ToString());

                Console.WriteLine("Enter n to end program");
                inputstr = Console.ReadLine();


            } while (inputstr != "n");

        }

        public static long GetCount(int xMin, int yMax)
        {
            long total = 0;


            for (int x = xMin; x <= yMax; x++)
            {

                    for (int k = 1; k <= yMax; k++)
                    {

                        if (x % k == 0)
                            total++;
                    }


            Console.WriteLine(x.ToString() + " : " + yMax.ToString());
 

            }

            return total;
        }
    }
}
