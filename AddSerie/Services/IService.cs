using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AddSerie.Views;
namespace AddSerie.Models;

public interface IService
{
    Task<List<Series>> GetSeriesAsync();
    Task<Series> GetSerieAsync(int id);
    Task<HttpResponseMessage> PostSerieAsync(Series serie);
    Task<HttpResponseMessage> PutSerieAsync(Series serie, int id);
}
