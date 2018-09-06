using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Entities;

namespace BackEnd.DAL
{
   internal class MyDatabaseContext : DbContext
    {
        public MyDatabaseContext() : base("name=AdHocDb")
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
