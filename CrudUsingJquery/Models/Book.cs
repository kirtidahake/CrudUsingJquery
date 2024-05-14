using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrudUsingJquery.Models
{
    public class Book
    {
        [Key] 
        public int BookId { get; set; }

        public string BookTitle { get; set; }

        public string Description { get; set; }

        public bool IsDeleted { get; set; }


        public Author Author { get; set; }
        [ForeignKey("Author")]
        public int AuthorId { get; set; }

    }
}