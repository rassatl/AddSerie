// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace AddSerie.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PageAddSeries : Page
    {
        public IRelayCommand BtnChangeWindowUpdate { get; }

        public PageAddSeries()
        {
            this.InitializeComponent();
            BtnChangeWindowUpdate = new RelayCommand(changepage);
            DataContext = ((App)Application.Current).PageAddSeriesFunc;
        }
        public static FrameworkElement MainRoot { get; private set; }

        public Window m_window;
        public void changepage()
        {
            m_window = new MainWindow();
            Frame rootFrame = new Frame();
            this.m_window.Content = rootFrame;
            MainRoot = m_window.Content as FrameworkElement;
            m_window.Activate();
            rootFrame.Navigate(typeof(PageUpdateSeries));
        }
    }
}
