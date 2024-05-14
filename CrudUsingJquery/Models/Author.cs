using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrudUsingJquery.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        public string AuthorName { get; set; }

        

    }
}