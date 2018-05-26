using QTickWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTickWPF.Services
{
    public class PerformersService : BaseService
    {

        public async Task<List<Performer>> GetEventsAsync()
        {
            return await GetAsync<List<Performer>>("Performances/Performers");
        }
        public async Task<Event> GetPerformerByIdAsync(int id)
        {
            return await GetAsync<Event>($"Performances/Performers/{id}");
        }

    }
}
