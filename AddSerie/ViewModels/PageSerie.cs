using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddSerie.Models;
using AddSerie.Services;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AddSerie.ViewModels
{
    public abstract class PageSerie : ObservableObject
    {
        public PageSerie()
        {
            GetDataOnLoadAsync();
        }
        private Series serieToAdd;

        public Series SerieToAdd
        {
            get { return serieToAdd; }
            set { serieToAdd = value; }
        }

        private Series serieToSearch;

        public Series SerieToSearch
        {
            get { return serieToSearch; }
            set
            {
                serieToSearch = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Series> series;

        public ObservableCollection<Series> Series
        {
            get { return series; }
            set
            {
                series = value;
                OnPropertyChanged();
            }
        }

        private string titre;
        public string Titre
        {
            get { return titre; }
            set
            {
                titre = value;
                OnPropertyChanged();
            }
        }

        private string resume;
        public string Resume
        {
            get { return resume; }
            set
            {
                resume = value;
                OnPropertyChanged();
            }
        }
        private int nbsaisons;
        public int Nbsaisons
        {
            get { return nbsaisons; }
            set
            {
                nbsaisons = value;
                OnPropertyChanged();
            }
        }
        private int nbepisodes;
        public int Nbepisodes
        {
            get { return nbepisodes; }
            set
            {
                nbepisodes = value;
                OnPropertyChanged();
            }
        }
        private int anneecreation;
        public int Anneecreation
        {
            get { return anneecreation; }
            set
            {
                anneecreation = value;
                OnPropertyChanged();
            }
        }
        private string network;
        public string Network
        {
            get { return network; }
            set
            {
                network = value;
                OnPropertyChanged();
            }
        }

        public async void GetDataOnLoadAsync()
        {
            WSService service = new WSService("https://apiseriesrassat.azurewebsites.net");
            List<Series> result = await service.GetSeriesAsync();
            if (result == null)
                ShowAsync("API non disponible !");
        }

        public async void ShowAsync(string errorMessage)
        {
            ContentDialog noWifiDialog = new ContentDialog
            {
                Title = "Erreur !",
                Content = errorMessage,
                CloseButtonText = "Ok"
            };

            noWifiDialog.XamlRoot = App.MainRoot.XamlRoot;
            ContentDialogResult result = await noWifiDialog.ShowAsync();
        }
    }
}
