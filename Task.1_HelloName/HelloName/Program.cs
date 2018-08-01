using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
			//String Identifier declaring the variables to be used in the code. All on one line
            string Name, Age, Agenda, Address;
			//Use the "Console.WriteLine" method to display our line of text in the Console Window.
            Console.WriteLine("Hello, please enter your name : ");
			//Using the "Console.ReadLine" method to view the text typed in the console window.
            Name = Console.ReadLine();
			//The "{0}" inside the speech marks, telling the program to display our typed text
			//The "Name" after the speech marks and comma but still inside the brackets is letting us know the variable we are asking to display
            Console.WriteLine("Hello, {0}", Name);
            Console.WriteLine("Enter your age :  ");
            Age = Console.ReadLine();
            Console.WriteLine("What is your agenda : ");
            Agenda = Console.ReadLine();
            Console.WriteLine("Enter your address : ");
            Address = Console.ReadLine();
			//The 3 methods are used to create separation of your code in the Console Window
            Console.WriteLine("");
            Console.WriteLine("____________________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("So the details collected are: ");
            Console.WriteLine("Name: {0} ", Name);
            Console.WriteLine("Age: {0} ", Age);
            Console.WriteLine("Agenda: {0}", Agenda);
            Console.WriteLine("Address: {0}", Address);
			//The "Console Readline" method at the end of your code, lets you view the Console window, and keep it on screen until you close it
            Console.ReadLine();


            
        }
    }
}
