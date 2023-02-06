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
        public IRelayCommand BtnSetConversion { get; }

        public PageSerie()
        {
            GetDataOnLoadAsync();
            //Boutons
            //BtnSetConversion = new RelayCommand(ActionSetConversion);
        }
        public abstract void ActionSetSeries();

        /* private double montantEuro;
         public double MontantEuro
         {
             get { return montantEuro; }
             set
             {
                 montantEuro = value;
                 OnPropertyChanged();
             }
         }
        */
         private ObservableCollection<Series> valeurs;

         public ObservableCollection<Series> Valeurs
         {
             get { return valeurs; }
             set
             {
                 valeurs = value;
                 OnPropertyChanged();
             }
         }
        /*
         private Devise selectedCurrency;

         public Devise SelectedCurrency
         {
             get { return selectedCurrency; }
             set
             {
                 selectedCurrency = value;
                 OnPropertyChanged();
             }
         }

         private double res;

         public double Res
         {
             get { return res; }
             set
             {
                 res = value;
                 OnPropertyChanged();
             }
         }*/
        public async void GetDataOnLoadAsync()
        {
            WSService service = new WSService("https://apiseriesrassat.azurewebsites.net/api/series");
            List<Series> result = await service.GetSeriesAsync("series");
            if (result == null)
                ShowAsync("API non disponible !");
            else
                Valeurs = new ObservableCollection<Series>(result);
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
