using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookManagerApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Author Author { get; set; }
    }
}