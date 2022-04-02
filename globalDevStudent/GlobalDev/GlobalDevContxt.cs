using globalDevStudent.GlobalDev.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace globalDevStudent.GlobalDev
{
    public class GlobalDevContxt : DbContext
    {
        public GlobalDevContxt(): base()
        {

        }
        public DbSet<Student> Students { get; set; }

    }
}