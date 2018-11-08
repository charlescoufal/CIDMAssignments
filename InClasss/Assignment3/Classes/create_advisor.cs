using System;

namespace Assignment3
{
    class Advisor
    {
        static void Main(string[] args)
        {
            using(var db = new AppDbContext())
            {
                Advisor s = new Advisor()
                {
                    FirstName = " ",
                    LastName = " ",
                    PhoneNumber = " ",
                    Email = " "
                    

                };
                db.Advisor.Add(s);

                db.SaveChanges();
            }
        }
    }
}