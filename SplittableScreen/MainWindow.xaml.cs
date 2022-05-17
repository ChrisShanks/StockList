using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SplittableScreen
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }


        public record Stock 
        {
            public string Symbol { get; set; }
            public double Price { get; set; }
            public string Full_Name { get; set; }

        }

        public ObservableCollection<Stock> Stocks { get; set; } = new ObservableCollection<Stock>();


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Stocks.Add(new Stock { Symbol = "CEPU", Price = 3.68, Full_Name = "Central Puerto" });
            Stocks.Add(new Stock { Symbol = "KEN", Price = 57.41, Full_Name = "Kenon Holdings"} );
            Stocks.Add(new Stock { Symbol = "VST", Price = 25.25, Full_Name = "Vista Corp" });
            Stocks.Add(new Stock { Symbol = "OTTR", Price = 63.64, Full_Name = "Otter Tail Corp" });
            Stocks.Add(new Stock { Symbol = "NRG", Price = 45.20, Full_Name = "Energy NRG" });
            Stocks.Add(new Stock { Symbol = "GCTK", Price = 3.08, Full_Name = "GlucoTrack" });
        }

        private void Button_Get_Stock_Click (object sender, RoutedEventArgs e)
        {
            Stocks.Add(new Stock { Symbol = "Connect To Internet" });

        }
    }
}
