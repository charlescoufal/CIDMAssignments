using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Linq;

namespace Assignment1.Models

{
    public class CreateItems
    {
        
        public static void CreateUnderGrad(){
        
        Console.Write("Student ID: ");
        long StudID = Console.ReadLine();
       
        Console.Write("Student Name: ");
        string StudName = Console.ReadLine();
      
        Console.Write("Date of Birth: ");
        date DateOfBirth = Console.ReadLine();
  
        Console.Write("Major: ");
        string Major = Console.ReadLine();
      
        Console.Write("GPA: ");
        float StuRole = Console.ReadLine();

        Console.Write("Previous High School: ");
        string PreviousHSchool = Console.ReadLine();

        Console.Write("Classification: ");
        string StudClass = Console.ReadLine();
   
        
        using(var db = new AppDbContext()){
            List<UnderGrad> UnderGrad = new List<UnderGrad>()
            {
                new UnderGrad()
                {
                    StudID = StudID,
                    StudName = StudName,
                    DateOfBirth = DateOfBirth,
                    Major = Major,
                    GPA = GPA,
                    PreviousHSchool = PreviousHSchool,
                    StudClass = StudClass
                }
            };
            db.UnderGrad.AddRange(UnderGrad);
            db.SaveChanges();
            }
            Console.WriteLine("Record has been added successfully.");
        }
        
        public static void CreateGrad(){
        
        Console.Write("Student ID: ");
        long StudID = Console.ReadLine();
       
        Console.Write("Student Name: ");
        string StudName = Console.ReadLine();
      
        Console.Write("Date of Birth: ");
        date DateOfBirth = Console.ReadLine();
  
        Console.Write("Major: ");
        string Major = Console.ReadLine();
      
        Console.Write("GPA: ");
        float StuRole = Console.ReadLine();

        Console.Write("Previous Degree: ");
        string PreviousDegree = Console.ReadLine();

        Console.Write("Previous Univeristy: ");
        string PreviousUniversity = Console.ReadLine();

        Console.Write("UnderGrad Major: ");
        string UndergradMajor = Console.ReadLine();

        Console.Write("UnderGrad GPA: ");
        string UndergradGPA = Console.ReadLine();
   
        
        using(var db = new AppDbContext()){
            List<Grad> Grad = new List<Grad>()
            {
                new Grad()
                {
                    StudID = StudID,
                    StudName = StudName,
                    DateOfBirth = DateOfBirth,
                    Major = Major,
                    GPA = GPA,
                    PreviousDegree = PreviousDegree,
                    PreviousUniversity = PreviousUniversity,
                    UndergradMajor = UndergradMajor,
                    UndergradGPA = UndergradGPA
                    
                }
            };
            db.Grad.AddRange(Grad);
            db.SaveChanges();
            }
            Console.WriteLine("Record has been added successfully.");
        }


        
    }


    
}