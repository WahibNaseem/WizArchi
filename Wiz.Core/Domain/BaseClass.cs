using System;
using System.Collections.Generic;
using System.Text;

namespace Wiz.Core.Domain
{
    public class BaseClass
    {
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
