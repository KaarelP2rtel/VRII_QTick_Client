using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
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
#warning Hardcoded URI
            _client.BaseAddress = new Uri("https://localhost:44394/api/");
        }

        protected async Task<TResponse> GetAsync<TResponse>(string url)
        {
            var resp = await _client.GetAsync(url);
            return await resp.Content.ReadAsAsync<TResponse>();
        }
        protected async Task<TResponse> GetAsync<TResponse>(string url, string token)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var resp = await _client.GetAsync(url);
            return await resp.Content.ReadAsAsync<TResponse>();
        }

        protected async Task<TResponse> PostAsync<TRequest, TResponse>(string url, TRequest obj)
        {
            
            var response = await _client.PostAsJsonAsync(
               url, obj);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<TResponse>();
        }

        protected async Task<TResponse> PostAsync<TRequest,TResponse>(string url, TRequest obj, string token)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await _client.PostAsJsonAsync(
               url, obj);
            response.EnsureSuccessStatusCode();
            
            return await response.Content.ReadAsAsync<TResponse>();
        }
    }
}
