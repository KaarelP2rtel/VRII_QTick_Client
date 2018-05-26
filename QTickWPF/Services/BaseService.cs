using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace QTickWPF.Services
{
        public class BaseService
    {
        private HttpClient _client;

        public BaseService()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:44394/api/");
        }

        protected async Task<T> GetAsync<T>(string url)
        {
            var resp = await _client.GetAsync(url);
            return await resp.Content.ReadAsAsync<T>();
        }
    }
}
