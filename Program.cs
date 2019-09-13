using System;

namespace Deliverable2_Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("display Letter grade");

            //begin try statement 
            try
            {
                string input = Console.ReadLine();
                int new_input = int.Parse(input);

                // if else statement for different grades 
                if (new_input >= 90)
                {
                    Console.WriteLine("You earned an A!");

                }
                else if (new_input >= 80)
                {
                    Console.WriteLine("You earned an B!");

                }
                else if (new_input >= 70)
                {
                    Console.WriteLine("You earned an C !");

                }
                else if (new_input >= 60)
                {
                    Console.WriteLine("You earned an D !");

                }
                else
                {
                    Console.WriteLine("you ave failed");
                }
                Console.ReadLine();

                // catch statement for errors             
            }
            catch
            {
                Console.WriteLine("Error accurated ");
            }
        }
    }
}
