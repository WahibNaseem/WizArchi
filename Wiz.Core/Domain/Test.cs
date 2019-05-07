using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Wiz.Core.Domain
{
   public class Test
    {
        [Key]
        public int Id { get; set; }
        public DateTime ConductedDate { get; set; }

        //public ICollection<User> Users { get; set; }
        public ICollection<TestType> TestTypes { get; set; }
    }
}
