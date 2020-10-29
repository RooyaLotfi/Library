using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.Dal.Models
{
    class Lending
    {
        public int Id { get; set; }

        public DateTime borrowDate { get; set; }

        public DateTime DueDate { get; set; }
        /*one lender is connected to a lending 
        // the relationship between user and lending?
        // one user can lend so many. one lending is done
        // by one user. This is a one to many relationship
        */ 
    }
}
