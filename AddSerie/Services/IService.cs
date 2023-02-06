using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddSerie.Views;
namespace AddSerie.Models;

public interface IService
{
    Task<List<Series>> GetSeriesAsync(string nomControleur);
}
