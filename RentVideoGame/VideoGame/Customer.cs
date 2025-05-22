using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGame
{
    public class Customer
    {
        int CustomerId { get; set; }
        public string CustomerName { get; set; }

        List<Game> Rentedgames { get; set; }

     
    }

}
