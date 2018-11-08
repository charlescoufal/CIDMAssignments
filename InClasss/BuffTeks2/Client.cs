using System;

namespace BuffTeks2
{
    class Client
    {
        static void Main(string[] args)
        {
            using(var db = new AppDbContext())
            {
                Client s = new Client()
                {
                    FirstName = " ",
                    LastName = " ",
                    PhoneNumber = " ",
                    Email = "",
                    Organization = "",

                };
                db.Client.Add(s);

                db.SaveChanges();
            }
        }
    }
}