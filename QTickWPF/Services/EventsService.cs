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
            return await GetAsync<List<Event>>("Events");
        }
        public async Task<Event> GetEventById(int id)
        {
            return await GetAsync<Event>($"Events/{id}");
        }
    }
}
