using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace Assignment1.Models
{
    public class MenuMethods
    {
        public static void CreateNewRecord(){
            bool exitCreation = false;
            while (exitCreation == false){
                Console.WriteLine("Which database will this take place in?");
                Console.WriteLine("\t1. UnderGrad\n\t2. Grad\n\t3. Exit");
                Console.Write("COMMAND: ");
                int command = Convert.ToInt32(Console.ReadLine());
                switch(command){
                    case 1:
                        CreateItems.CreateUnderGrad();
                        break;
                    case 2:
                        CreateItems.CreateGrad();
                        break;
                    case 3:
                        // Exit Menu
                        exitCreation = true;
                        break;
                    default:
                        // Default statement / Exception handling
                        Console.WriteLine("Please enter a valid command.");
                        break;
                }
            }
        }
        public static void ReadARecord(){
            bool exitRead = false;
            while (exitRead == false){
                Console.WriteLine("Which database will this take place in?");
                Console.WriteLine("\t1. UnderGrad\n\t2. Grad\n\t3. Exit");
                Console.Write("COMMAND: ");
                int command = Convert.ToInt32(Console.ReadLine());
                switch(command){
                    case 1:
                        Console.WriteLine("1. All Records\n2. Single Record");
                        int command2 = Convert.ToInt32(Console.ReadLine());
                        switch(command2){
                            case 1:
                                ReadItems.ReadStudentALL();
                                break;
                            case 2:
                                ReadItems.ReadStudentRecord();
                                break;
                            default:
                                Console.WriteLine("Please enter a valid command.");
                                break;
                        }
                        break;
                    case 2:
                        // Read a Team Record
                        Console.WriteLine("1. All Records\n2. Single Record");
                        int command3 = Convert.ToInt32(Console.ReadLine());
                        switch(command3){
                            case 1:
                                ReadItems.ReadTeamALL();
                                break;
                            case 2:
                                ReadItems.ReadTeamRecord();
                                break;
                            default:
                                Console.WriteLine("Please enter a valid command.");
                                break;
                        }
                        break;
                    
                    case 3:
                        // Exit Menu
                        exitRead = true;
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