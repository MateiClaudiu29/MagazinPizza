using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.Entity;

namespace MagazinPizza
{
    /// <summary>
    /// Interaction logic for ProduseVandute.xaml
    /// </summary>
    public partial class ProduseVandute : Window
    {
        private GestiuneMagazin.GestiuneMagazinEntities gest = new GestiuneMagazin.GestiuneMagazinEntities();
        public ProduseVandute()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource produseComandateViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("produseComandateViewSource")));

            produseComandateViewSource.Source = gest.ProduseComandates.Local;
            gest.ProduseComandates.Load();
        }
    }
}
