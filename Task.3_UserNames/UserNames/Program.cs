using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserNames
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring my variables in one line
            string Fname, Lname;

            Console.Write("Enter Your First Name: ");
            Fname = Convert.ToString(Console.ReadLine());
            //Using the "Convert.ToString" method to convert the Lname to Last name
            //The "\n" is used to separate the lines of the code displayed in the Console Window
            Console.Write("\nEnter Your Last Name: ");
            Lname = Convert.ToString(Console.ReadLine());
            //The space in between the speech marks inside the brackets before and after the "+" signs is how I separated the First and Last name with a space
            Console.WriteLine("\nYour full name is: {0} ",  Fname + (" ") + Lname);

            Console.ReadLine();
        }
    }
}
