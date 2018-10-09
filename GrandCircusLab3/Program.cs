using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * prompt integer between 1 and 100
             * if odd print number entered and "odd"
             * if even 2<x<25 print "even and less than 25"
             * if even 26<x<60 print "even"
             * if even x>60 print number entered and "even"
             * if odd x>60 print number entered and "odd"
            */
            Console.WriteLine("Hello! What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hi, " + name + "!");
            string cont = "y";

            while (cont == "y")
            {
                try
                {
                    Console.Write("Enter a whole number between 1 and 100: ");
                    int num = int.Parse(Console.ReadLine());
                    if (num > 0 && num < 101)
                    {
                        if (num % 2 == 1)
                        {
                            if (num > 60)
                            {
                                Console.WriteLine(num + ", Odd.");
                            }
                            else
                            {
                                Console.WriteLine(num + ", Odd.");
                            }
                        }
                        else if (2 <= num && num < 26)
                        {
                            Console.WriteLine("Even and less than 25.");
                        }
                        else if (num >= 26 && num <= 60)
                        {
                            Console.WriteLine("Even.");
                        }
                        else if (num > 60)
                        {
                            Console.WriteLine(num + ", Even.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("This isn't a whole number between 1 and 100.");
                    }
                    
                }
                catch (Exception)
                {
                    Console.WriteLine("This isn't a whole number between 1 and 100.");
                    
                }
                Console.WriteLine("\n");
                Console.Write("Would you like to continue, " + name + "? y/n ");
                cont = Console.ReadLine();
                Console.WriteLine("\n");
            }
            Console.WriteLine("Goodbye!");
            Console.ReadKey();
        }
    }
}
