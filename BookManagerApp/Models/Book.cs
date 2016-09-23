using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookManagerApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}