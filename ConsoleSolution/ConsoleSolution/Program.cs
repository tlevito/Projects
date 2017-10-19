using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSolution
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
                k = -1;

                while (x < 0)
                {
                    Console.WriteLine("What is the Min Value?");

                    if (!int.TryParse(Console.ReadLine(), out x))
                    {
                        Console.WriteLine("Please enter an Integer Min value");
                        x = -1;

                    }
                    else if (x < 0 || x > 2000000000)
                    {
                        {
                            Console.WriteLine("Please enter an Integer Min value that is within the range 0 and 2000000000");
                            x = -1;
                        }

                    }

                    while (y < 0)
                    {
                        Console.WriteLine("What is the Max Value?");

                        if (!int.TryParse(Console.ReadLine(), out y))
                        {
                            Console.WriteLine("Please enter an Integer Max value");
                            y = -1;

                        }
                        else if (y <= x)
                        {

                            Console.WriteLine("Please enter an Integer Max value That is Greater than or equal to Min Value : " + x.ToString());
                            y = -1;

                        }
                        else if (y < 0 || y > 2000000000)
                        {
                            Console.WriteLine("Please enter an Integer Max value that is within the range 0 and 2000000000");
                            y = -1;
                        }

                    }

                    while (k < 0)
                    {
                        Console.WriteLine("What is the Value you will divide by?");

                        if (!int.TryParse(Console.ReadLine(), out k))
                        {
                            Console.WriteLine("Please enter an Interger  value");
                            k = -1;
                        }

                        else if (k < 0 || k > 2000000000)
                        {
                            Console.WriteLine("Please enter an Integer Divisor value that is within the range 0 and 2000000000");
                            k = -1;
                        }
                    }

                    long z = 0;

                    z = GetCount(x, y, k);
                    Console.WriteLine("Total Values : " + z.ToString());
                    endTime = DateTime.Now;

                    TimeSpan timeDif = endTime - startTime;
                    Console.WriteLine("Program executed in : " + timeDif.ToString());

                    Console.WriteLine("Enter n to end program");
                    inputstr = Console.ReadLine();
                    z = 0;

                }
            } while (inputstr != "n");

        }


        public static long GetCount(int xMin, int yMax, int div)
        {
            long total = 0;


            total = (yMax / div) - (xMin / div) + (xMin % div == 0 ? 1 : 0);




            //Console.WriteLine(x.ToString() + " : " + yMax.ToString());
 


            return total;
        }

    }
}
