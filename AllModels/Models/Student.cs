using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllModels.Models
{
    public class Student
    {
        public Guid StudId { get; set; }
        public string StudName { get; set; }
        public string Address { get; set; }
        public string MyProperty { get; set; }
       
    }
}
