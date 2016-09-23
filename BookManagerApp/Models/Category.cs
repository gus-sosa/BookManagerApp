﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookManagerApp.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<Book> Books { get; set; }
    }
}