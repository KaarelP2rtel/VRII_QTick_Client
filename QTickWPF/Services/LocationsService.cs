using QTickWPF.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QTickWPF.Services
{
    public class LocationsService : BaseService
    {
        public async Task<List<Location>> GetEventsAsync()
        {
            return await GetAsync<List<Location>>("Performances/Locations");
        }
        public async Task<Location> GetPerformerByIdAsync(int id)
        {
            return await GetAsync<Location>($"Performances/Locations/{id}");
        }
    }
}
