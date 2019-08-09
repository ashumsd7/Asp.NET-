using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Understand_model.Models;


namespace Understand_model.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
       


        public ActionResult GetBookDetails()
        {


            Books obj = new Books();
            obj.BookNumber = 1;
            obj.BookName = "Hello MVC";
            obj.BookAuthor = "Ak Kashyap";
            obj.Price = Convert.ToDecimal(222.90);

            return View(obj);
        }
    }
}