using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddSerie.Models;
using AddSerie.Services;

namespace AddSerie.ViewModels
{
    public class PageAddSeriesViewModels : PageSerie
    {
        public PageAddSeriesViewModels() : base()
        {
            SerieToAdd = new Series();
        }

        public override void ActionSetSeries()
        {
            WSService Service = new WSService("https://apiseriesrassat.azurewebsites.net");

            if (SerieToAdd.Titre == null)
                ShowAsync("Il faut un titre !");
            else
                Service.PostSerieAsync(SerieToAdd);

        }
    }
}
