﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.Dal.Models
{
    class AuthorBook : EntityBase
    {
        public int AuthorId { get; set; }
       
        public int BookId { get; set; }

        public Author Author { get; set; }
       
        public Book Book { get; set; }

    }
}
