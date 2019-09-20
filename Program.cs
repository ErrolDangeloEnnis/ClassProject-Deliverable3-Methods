using System;

namespace ClassProject_Deliverable3_Methods
{
    class Program
    {
        /*
         * Author: Errol Ennis
         * Date: September 19, 2019
         * Comment: This is a method that prompts user for name and thenn says "hello" and displays the name the user has entered 
         */

            static void Main(string[] args)
            {
                Console.WriteLine("System Date/Time: " + DateTime.Now + Environment.NewLine);
                Console.Write("Please enter your full Name: ");
                Console.WriteLine("");

                {
                    string input = Console.ReadLine();
                    double Num;
                    bool isNum = double.TryParse(input, out Num);

                    if (isNum)
                    {
                        OtherInput(isNum);
                    }
                    else
                    {
                        CorrectText(input);
                    }
                }
            }

            //creates a method for an string input
            private static string CorrectText(string input)
            {
            //This input the string into a console writeline method
                Console.WriteLine("");
                Console.WriteLine("Hello, and welcome " + input + "!");
                Console.WriteLine("_____________________________________________________");
                Console.WriteLine("This is an example of a method created by Errol Ennis");
                Console.WriteLine("_____________________________________________________");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey(true);
                return input;
            }

            //creates a method for an integer or decimal input
            private static void OtherInput(bool isNum)
            {
                Console.WriteLine("Please enter a valid name !");
                Console.WriteLine("Press any key to exit the program ...");
                Console.WriteLine("_____________________________________");
                Console.ReadKey(true);
            }
        
    }
}
    