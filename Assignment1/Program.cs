using System;
using System.Collections.Generic;
using System.Linq;
using Assignment04.Models;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
             
            
            // Initialize Menu Commands and Options to the Console
            bool endMenu = false;
            while(endMenu == false){
                Console.WriteLine("Please select a command");
                Console.WriteLine("\t1. Create Record\n\t2. Read Record\n\t3. Exit");
                Console.Write("COMMAND: ");
                int command = Convert.ToInt32(Console.ReadLine());
                switch (command){
                    case 1:
                        // Create a record
                        MenuMethods.CreateNewRecord();
                        break;
                    case 2:
                        // Read a record
                        MenuMethods.ReadARecord();
                        break;
                    case 3:
                        // Exit the program
                        endMenu = true;
                        break;
                    default:
                        // Default statement / Exception handling
                        Console.WriteLine("Please enter a valid command.");
                        break;
                }
            }
        }
    }
}