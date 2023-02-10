using AddSerie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace AddSerie.Services
{
    public class WSService : IService
    {
        private HttpClient client;
        public WSService(string url)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<List<Series>> GetSeriesAsync()
        {
            try
            {
                return await client.GetFromJsonAsync<List<Series>>("/api/series");
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<Series> GetSerieAsync(int id)
        {
            return await client.GetFromJsonAsync<Series>($"/api/series/{id}");
        }

        public async Task<HttpResponseMessage> DeleteSerieAsync(int id)
        {
            using var response = await client.DeleteAsync($"/api/series/{id}");

            if (response.IsSuccessStatusCode)
            {
                return response;
            }
            else
            {
                return null;
            }
        }

        public async Task<HttpResponseMessage> PostSerieAsync(Series serie)
        {
            using var response = await client.PostAsJsonAsync("/api/series", serie);
            if (response.IsSuccessStatusCode)
            {
                return response;
            }
            else
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.NotModified);
            }
        }

        public async Task<HttpResponseMessage> PutSerieAsync(Series serie, int id)
        {
            using var response = await client.PutAsJsonAsync($"/api/series/{id}", serie);
            if (response.IsSuccessStatusCode)
            {
                return response;
            }
            else
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.NotModified);
            }
        }
    }
}
