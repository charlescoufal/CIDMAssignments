using System;

namespace Assignment3
{
    class Project
    {
        static void Main(string[] args)
        {
            using(var db = new AppDbContext())
            {
                Project s = new Project()
                {
                    ProjectName = " ",
                    Leader = " ",
                    Description = " ",
                    ProjectClient = 3                    

                };
                db.Project.Add(s);

                db.SaveChanges();
            }
        }
    }
}