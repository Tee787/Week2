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
            string Fname, Lname;
            Console.Write("Enter Your First Name: ");
            Fname = Convert.ToString(Console.ReadLine());
            Console.Write("\nEnter Your Last Name: ");
            Lname = Convert.ToString(Console.ReadLine());

            Console.WriteLine("\nYour full name is: {0} ",  Fname + (" ") + Lname);
            Console.ReadLine();
        }
    }
}
