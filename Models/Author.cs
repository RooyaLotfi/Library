using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.Dal.Models
{
    class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<AuthorBook> AuthorBooks { get; set; }
    }
}
