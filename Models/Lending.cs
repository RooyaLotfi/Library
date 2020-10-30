using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.Dal.Models
{
    public enum LendingStatus : byte
    {
        Borrowed = 0,
        Delayed = 1,
        ReturnedNoDelay = 2,
        ReturnedWithDelay = 3
    }

    class Lending : EntityBase
    {
        public int Id { get; set; }

        public DateTime borrowDate { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        public float? Fee { get; set; }
        // we defined fee as nullable. 

        public LendingStatus Status { get; set; }


        public int UserID { get; set; }

        public User User { get; set; } 

        public List<LendingBook> LendingBooks { get; set; }

        public Lending()
        {
            this.Status = LendingStatus.Borrowed;
        }
        

        // when you wanna create a nullable data
        // you can use this: DateTime? ReturnDate;

        /*one lender is connected to a lending 
        // the relationship between user and lending?
        // one user can lend so many. one lending is done
        // by one user. This is a one to many relationship
        */ 

        public int StaffID { get; set; }

        public Staff Staff { get; set; }

    }
}
