using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Linq;

namespace Assignment1.Models
{
    public class ReadItems
    {
        public static void ReadUnderGrad(){
            using(var db = new AppDbContext()){
            
                var UnderGrad = db.UnderGrad.ToList();

                foreach(UnderGrad t in UnderGrad){
                    Console.WriteLine(t);
                }
            }
        }

        public static void ReadGrad(){
            using(var db = new AppDbContext()){
            
                var Grad = db.Grad.ToList();

                foreach(Grad g in Grad){
                    Console.WriteLine(g);
                }
            }
        }

                
        
    }
}