using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOP_01.Concrete
{
    public  class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }    
        public string CustomerSurname { get; set; }
        public string CustomerDistrict { get; set; }
        public string CustomerCity { get; set; }
        public List<Order> Orders { get; set; }

    }
}
