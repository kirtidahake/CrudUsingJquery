using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;


namespace CrudUsingJquery.Models
{
    public class ContextServices : DbContext
    {
        public ContextServices() : base("Name=ContextServices")
        {
         
        }

        public DbSet<Book> books { get; set; }
        public DbSet<Author> author { get; set; }
    }
}