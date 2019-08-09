using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Understand_model.Models
{
    public class Books
    {
        //bookno, bookname,book suthor, book pice
        public int BookNumber { get; set; }

        public string BookName{ get; set; }

        public string BookAuthor { get; set; }

        public decimal Price { get; set; }



    }
}