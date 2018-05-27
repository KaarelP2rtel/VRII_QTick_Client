using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTickWPF.Models
{
    public class Performance
    {
        public int PerformanceId { get; set; }
        public string TicketInfo { get; set; }
        public string PerformanceDescription { get; set; }
        public DateTime PerformanceTime { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
        public List<Performer> Performers { get; set; }
    }
}
