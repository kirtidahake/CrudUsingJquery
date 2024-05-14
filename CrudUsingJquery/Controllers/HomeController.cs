using CrudUsingJquery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudUsingJquery.Controllers
{
    public class HomeController : Controller
    {
        ContextServices db = new ContextServices();
        public ActionResult Index()
        {

            List<Author> authorList = db.author.ToList();
            ViewBag.Author = new SelectList(authorList, "AuthorId", "AuthorName");


            List<BookAuthor> booklist = db.books.Where(x => x.IsDeleted == false)
            .Select(x => new BookAuthor { BookId = x.BookId, BookTitle = x.BookTitle, AuthorName = x.Author.AuthorName, Description = x.Description }).ToList();
            ViewBag.Book = booklist;

            return View();
        }
        
        public ActionResult Create(BookAuthor bk)
        {
            try
            {
                List<Author> authorList = db.author.ToList();
                ViewBag.Author = new SelectList(authorList, "AuthorId", "AuthorName");

                Author newauthor = new Author();

                newauthor.AuthorId = bk.AuthorId;
                newauthor.AuthorName = bk.AuthorName;
                db.author.Add(newauthor);
                db.SaveChanges();

                Book newbook = new Book();
                newbook.BookId = bk.BookId;
                newbook.BookTitle = bk.BookTitle;
                newbook.Description = bk.Description;
                newbook.AuthorId = bk.AuthorId;

                db.books.Add(newbook);
                db.SaveChanges();
                List<BookAuthor> booklist = db.books.Where(x => x.IsDeleted == false)
                .Select(x => new BookAuthor { BookId = x.BookId, BookTitle = x.BookTitle, AuthorName = x.Author.AuthorName, Description = x.Description }).ToList();
                ViewBag.Book = booklist;


            }
            catch (Exception ex)

            { throw ex; }

            return View();
        }

           
     
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}