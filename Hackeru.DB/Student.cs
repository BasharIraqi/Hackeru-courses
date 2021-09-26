using Home_Work_Forms_6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackeru.DB
{
   public class Student
    {
       
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string City { get; set; }

        public string[] Course { get; set; } = new string[5];
    }
}
