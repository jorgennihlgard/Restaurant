using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class OpeningHour
    {
        public int Id { get; set; }
        public DateTime Opening { get; set; }
        public DateTime Closing { get; set; }
        public DateTime DayOpen { get; set; }
        public DateTime DateClosed { get; set; }



        
    }
}