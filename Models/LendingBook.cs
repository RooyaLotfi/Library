using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.Dal.Models
{
    class LendingBook : EntityBase
    {
        public int LendingID { get; set; }
        
        public Lending Lending { get; set; }

        public int BookId { get; set; }

        public Book Book { get; set; }
    }
}
