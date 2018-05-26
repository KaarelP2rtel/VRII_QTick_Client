using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTickWPF.Models
{
    public class Performer
    {
        public int PerformerId { get; set; }

        public string PerformerName { get; set; }

        public string PerformerDescription { get; set; }

        public string PerformerPage { get; set; }

        public int PerformerTypeId { get; set; }
        public PerformerType PerformerType { get; set; }
    }
}
