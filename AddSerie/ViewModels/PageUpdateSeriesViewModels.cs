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
    public class PageUpdateSeriesViewModels : PageSerie
    {
        public IRelayCommand BtnSearchSerie { get; }
        public IRelayCommand BtnUpdateSerie { get; }
        public IRelayCommand BtnDeleteSerie { get; }

        public PageUpdateSeriesViewModels() : base()
        {
            BtnSearchSerie = new RelayCommand(ActionSearchSeries);
            BtnUpdateSerie = new RelayCommand(ActionUpdateSeries);
            BtnDeleteSerie = new RelayCommand(ActionDeleteSeries);
            SerieToSearch = new Series();
        }

        public async void ActionSearchSeries()
        {
            WSService Service = new WSService("https://apiseriesrassat.azurewebsites.net");
            if (SerieToSearch.Serieid == 0)
                ShowAsync("Numéro de série requis");
            else
                SerieToSearch = await Service.GetSerieAsync(SerieToSearch.Serieid);
        }
        public async void ActionUpdateSeries()
        {
            WSService Service = new WSService("https://apiseriesrassat.azurewebsites.net");
            await Service.PutSerieAsync(SerieToSearch, SerieToSearch.Serieid);
        }
        public async void ActionDeleteSeries()
        {
            WSService Service = new WSService("https://apiseriesrassat.azurewebsites.net");
            await Service.DeleteSerieAsync(SerieToSearch.Serieid);
            SerieToSearch = null;
        }
    }
}