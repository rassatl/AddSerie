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
        //public IRelayCommand BtnUpdateSerie { get; }
        //public IRelayCommand BtnDeleteSerie { get; }

        public PageUpdateSeriesViewModels() : base()
        {
            BtnSearchSerie = new RelayCommand(ActionSearchSeries);
            //BtnUpdateSerie = new RelayCommand(ActionUpdateSeries);
            //BtnDeleteSerie = new RelayCommand(ActionDeleteSeries);
            SerieToSearch = new Series();
        }

        public async void ActionSearchSeries()
        {
            WSService Service = new WSService("https://apiseriesrassat.azurewebsites.net");
            SerieToSearch = await Service.GetSerieAsync(SerieToSearch.Serieid);
        }
        /*public void ActionUpdateSeries()
        {
        }
        public void ActionDeleteSeries()
        {
        }*/
    }
}