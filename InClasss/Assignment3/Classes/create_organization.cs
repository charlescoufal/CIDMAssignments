using System;

namespace Assignment3
{
    class Organization
    {
        public Organization()
        {
        }

        static void Main(string[] args)
        {
            using(var db = new AppDbContext())
            {
                Organization s = new Organization()
                {
                    Name = " ",
                    Business = " ",
                    Phone = " ",
                    Email = " ",
                    

                };
                db.Organization.Add(s);

                db.SaveChanges();
            }
        }
    }
}