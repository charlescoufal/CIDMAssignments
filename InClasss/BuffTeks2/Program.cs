using System;

namespace BuffTeks2
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new AppDbContext())
            {
                Student s = new Student()
                {
                    FirstName = "Jeff",
                    LastName = "Babb",
                    PhoneNumber = "123-555-2345",
                    Email = "blah@blah.blh",
                    Role = "Treasurer",

                };
                db.Students.Add(s);

                db.SaveChanges();
            }
        }
    }
}
