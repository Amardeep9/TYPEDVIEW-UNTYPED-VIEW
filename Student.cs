using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TypedandUntypedView.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public long MobileNo { get; set; }
        public string Address { get; set; }

        public string Image { get; set; }
    }
}