using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Workdays { get; set; }
        public int PhoneNumber { get; set; }
        public string Mail { get; set; }

        public virtual ICollection<Rent> Rents { get; set; }
    }
}
