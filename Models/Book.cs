using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.Dal.Models
{
    class Book : EntityBase
    {
        public int ID { get; set; }
        public string Title { get; set; }
       
        public string Subject { get; set; }
       
        public string Description { get; set;}
      
        public short Edition { get; set; }
      
        public short Copies { get; set; }
      
        public double ReplacementCost { get; set; }
      
        public int ISBN { get; set; }
      
        public int PublisherId { get; set; }
        
        public Publisher Publisher { get; set; }
        //this will be in the class but wont be in the database 
        //everytime we had a many to one relationship we need to do this 
        //this is a good idea because suppose you want to load from data base
        // a list of all books with that title. if you select everything 
        //without having a property this list wont be good having access 
        // to other properties. The title of the book and the name of the 
        // publisher 

        public List<AuthorBook> AuthorBooks { get; set; }


        public Book()
        {
            // you can access publisher ID 
        }
    }
}
