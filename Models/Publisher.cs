using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.Dal.Models
{
    class Publisher : EntityBase
    {
        public int Id { get; set; }
      
        public string Name { get; set; }
      
        public List<Book> Books { get; set; }
        // an object iside memory but wont be in database
        // this is only a navigation property it lets us navigate from 
        // one side to another
    }
}
