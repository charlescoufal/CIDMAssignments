using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace Assignment3
{
    public class AppDbContext : DbContext
    {
        private const string ConnectionString = @"Data Source=MyFirstEfCoreDb.db";

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(ConnectionString);
        }        
        public DbSet<Student> Student { get; set; }   
        public DbSet<Advisor> Advisor {get; set; }
        public DbSet<Team> Team {get; set; }
        public DbSet<Client> Client {get; set; }
        public DbSet<Project> Project {get; set; }
        public DbSet<Organization> Organization {get; set; }
} 
}