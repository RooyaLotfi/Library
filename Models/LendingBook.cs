using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.Dal.Models
{
    class LendingBook
    {
        public int LendingID { get; set; }
        
        public Lending Lending { get; set; }

        public int BookId { get; set; }

        public Book Book { get; set; }
    }
}
