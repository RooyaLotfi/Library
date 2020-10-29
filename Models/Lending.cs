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

        public DateTime? ReturnDate { get; set; }

        public float? Fee { get; set; }
        // we defined fee as nullable. 

        public byte Status { get; set; }

        public int UserID { get; set; }

        public User User { get; set; } 



        // when you wanna create a nullable data
        // you can use this: DateTime? ReturnDate;

        /*one lender is connected to a lending 
        // the relationship between user and lending?
        // one user can lend so many. one lending is done
        // by one user. This is a one to many relationship
        */ 
    }
}
