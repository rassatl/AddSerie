using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddSerie.Models;
using AddSerie.Services;
using CommunityToolkit.Mvvm.Input;

namespace AddSerie.ViewModels
{
    public class PageAddSeriesViewModels : PageSerie
    {
        public IRelayCommand BtnPostSerie { get; }

        public PageAddSeriesViewModels() : base()
        {
            BtnPostSerie = new RelayCommand(ActionSetSeries);
            SerieToAdd = new Series();
        }

        public void ActionSetSeries()
        {
            WSService Service = new WSService("https://apiseriesrassat.azurewebsites.net");

            if (SerieToAdd.Titre == null)
                ShowAsync("Il faut un titre !");
            else
            {
                Service.PostSerieAsync(SerieToAdd);
                ShowAsync("Le Push à marché ! :)");
            }
        }
    }
}
