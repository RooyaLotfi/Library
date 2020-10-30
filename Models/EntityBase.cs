using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.Dal.Models
{
    class EntityBase
    {

        public string CreatedBy { get; set; }
        
        public DateTime CreatedDatetime { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedDatetime { get; set; }
        
    }
}
