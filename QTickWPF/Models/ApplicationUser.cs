using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTickWPF.Models
{
    class ApplicationUser
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public DateTime Registered { get; set; }
        public bool Active { get; set; }
    }
}
