using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Rent
    {
        public int RentID { get; set; }
        public int BookID { get; set; }
        public virtual ICollection<Book> Products { get; set; }
        public virtual int EmployeeId { get; set; }
        public virtual int CustomerId { get; set; }
    }
}
