using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Restaurant.Models
{
    public class Sitting
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
        public int NumerOfGuests { get; set; }

        [ForeignKey("Table")]
        public int TableId { get; set; }
        public virtual Table Table { get; set; }

        [ForeignKey("Guest")]
        public int GuestId { get; set; }
        public virtual Guest Guest { get; set; }






    }
}
