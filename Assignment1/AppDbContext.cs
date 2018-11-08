using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace Assignment1
{
    
    public class AppDbContext : DbContext
    {
        
        private const string ConnectionString = @"Data Source=MyFirstEfCoreDb.db";

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlite(ConnectionString); 
        }        

        public DbSet<UnderGrad> UnderGrad { get; set; }  
        public DbSet<Grad> Grad {get; set; } 

      

    }    
}