using System;

namespace Assignment3
{
    class Student
    {
        static void Main(string[] args)
        {
            using(var db = new AppDbContext())
            {
                Student s = new Student()
                {
                    FirstName = " ",
                    LastName = " ",
                    PhoneNumber = " ",
                    Email = " ",
                    Role = " "

                };
                db.Student.Add(s);

                db.SaveChanges();
            }
        }
    }
}