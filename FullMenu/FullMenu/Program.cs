﻿//Full menu with all three exercises included
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name, Age, Agenda, Address, Fname, Lname;
            int num1, num2;
            Boolean Menu = true;
            
            do
            { 
            Console.WriteLine("--------------Full Menu Program---------------------");
            Console.WriteLine("\nPlease choose a task from the menu: ");
            Console.WriteLine("____________________________________________________");
            Console.WriteLine("\n1. Task_1\n2. Task_2\n3. Task_3\n4. Exit");
            Console.WriteLine("____________________________________________________");
            Console.WriteLine("\nNow please enter your choice: ");
            int task = Convert.ToInt32(Console.ReadLine());

                if (task == 1) //Basic information exercise
                {
                    Console.WriteLine("Hello, please enter your name : ");
                    Name = Console.ReadLine();
                    Console.WriteLine("Hello, {0}", Name);
                    Console.WriteLine("Enter your age :  ");
                    Age = Console.ReadLine();
                    Console.WriteLine("What is your agenda : ");
                    Agenda = Console.ReadLine();
                    Console.WriteLine("Enter your address : ");
                    Address = Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine("____________________________________________________________");
                    Console.WriteLine("");
                    Console.WriteLine("So the details collected are: ");
                    Console.WriteLine("Name: {0} ", Name);
                    Console.WriteLine("Age: {0} ", Age);
                    Console.WriteLine("Agenda: {0}", Agenda);
                    Console.WriteLine("Address: {0}", Address);
                    Console.Read();
                }

                else if (task == 2) //Select working operation exercise
                {
                    
                    Console.WriteLine("Enter the first number: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the second number: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Select the operation you want me to perform: ");
                    Console.WriteLine("_________________________________________");
                    Console.WriteLine("1: Addition" + "\r\n" + "2: Subtraction" + "\r\n" + "3: Multiplication" + "\r\n" + "4: Division");
                    Console.WriteLine("__________________________________________");

                    Console.WriteLine("Now please enter your choice from: ");
                    int item = Convert.ToInt32(Console.ReadLine());

                    int choice = 0;
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
                
                else if (task == 3) //Enter First name, Last name, and display both in a single line exercise
                {

                    Console.Write("Enter Your First Name: ");
                    Fname = Convert.ToString(Console.ReadLine());
                    Console.Write("\nEnter Your Last Name: ");
                    Lname = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("\nYour full name is: {0} ", Fname + (" ") + Lname);
                    Console.ReadLine();
                }

                else if (task == 4)
                    Menu = false;

            } while (Menu);
        }
    }
}