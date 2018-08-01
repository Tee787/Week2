using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserEquations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring the method and variables to be used
            int num1, num2;
            //Writing text to display in our Console Window
            Console.WriteLine("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select the operation you want me to perform: ");
            //This Console Writeline with no text is to create seperation. Notice their are 2 lines exactly the same
            Console.WriteLine("_________________________________________");
            Console.WriteLine("1: Addition" + "\r\n" + "2: Subtraction" + "\r\n" + "3: Multiplication" + "\r\n" + "4: Division");
            Console.WriteLine("__________________________________________");

            Console.WriteLine("Now please enter your choice from: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            //Here is where the if and else if methods are being used for the users input equation to output a result (answer)
            if (choice == 1)
            {
                Console.WriteLine("The result is: " + (num1 + num2));
                Console.Read();
            }
            else if (choice == 2)
            {
                Console.WriteLine("The result is: " + (num1 - num2));

                Console.Read();
            }
            else if (choice == 3)
            {
                Console.WriteLine("The result is: " + (num1 * num2));

                Console.Read();
            }
            else if (choice == 4)
            {
                Console.WriteLine("The result is: " + (num1 / num2));

                Console.Read();
            }

           
        }
    }
}
