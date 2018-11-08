using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace Ch2.Models
{
    public class AppDbContext : DbContext
    {

        //The connection string is used by the SQL Server database provider to find the database
        private const string ConnectionString = @"Data Source=WebAppEfCoreDb.db";

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            //Using the SQLite database provider’s UseSqlServer command sets up the options ready for creating the applications’s DBContext
            optionsBuilder.UseSqlite(ConnectionString); //#B
        }            

        public DbSet<Student> Students { get; set; }
            
        }
}