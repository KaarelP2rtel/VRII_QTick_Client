using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTickWPF.Models
{
    public class Event 
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public string ImageLink { get; set; }
        public string EventDescription { get; set; }
        public string EventDuration { get; set; }
        public string EventPage { get; set; }
        public EventType EventType { get; set; }

        public override string ToString()
        {
            return $"{EventName} {EventDuration}";
        }


    }
}
