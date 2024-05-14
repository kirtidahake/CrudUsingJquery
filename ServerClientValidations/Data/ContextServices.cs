using ServerClientValidations.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServerClientValidations.Data
{
    public class ContextServices : DbContext
    {

        public DbSet<Employee> employee { get; set; }

        public DbSet<Department> department { get; set; }

        public DbSet<Site> site { get; set; }
    }
}