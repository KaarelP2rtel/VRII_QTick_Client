using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QTickWPF.Models;

namespace QTickWPF.Services
{

    public class EventsService : BaseService
    {
        public async Task<List<Event>> GetEventsAsync()
        { 
            return await base.GetAsync<List<Event>>("Event");
        }
    }
}
