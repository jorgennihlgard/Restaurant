using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class Table
    {
        public int Id { get; set; }
        public int NumberOfSeats { get; set; }
        public bool Available { get; set; }


    }
}
