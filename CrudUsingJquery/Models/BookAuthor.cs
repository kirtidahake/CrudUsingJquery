using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudUsingJquery.Models
{
    public class BookAuthor
    {
        public int AuthorId { get; set; }

        public string AuthorName { get; set; }

        public int BookId { get; set; }

        public string BookTitle { get; set; }

        public string Description { get; set; }


        public bool IsDeleted { get; set; }
    }
}