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
using System.Data;


namespace MagazinPizza
{
    /// <summary>
    /// Interaction logic for VizualizareCatalog.xaml
    /// </summary>
    public partial class VizualizareCatalog : Window
    {

        private GestiuneMagazin.GestiuneMagazinEntities gest = new GestiuneMagazin.GestiuneMagazinEntities();
        public VizualizareCatalog()
        {
            InitializeComponent();
           

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource produseViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("produseViewSource")));

            produseViewSource.Source = gest.Produses.Local;
            gest.Produses.Load();
            System.Windows.Data.CollectionViewSource tipProduseViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("tipProduseViewSource")));

            tipProduseViewSource.Source = gest.TipProduses.Local;
            gest.TipProduses.Load();

            cboCategorie.ItemsSource = gest.TipProduses.Local;
            cboCategorie.DisplayMemberPath = "NumeTipProdus";
            cboCategorie.SelectedValuePath = "TipProduseId";
        }

        private void FiltruCatalog(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource produseViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("produseViewSource")));

            produseViewSource.Source = gest.Produses.Where(x => x.TipProdusId == (int)cboCategorie.SelectedValue).ToList();
            gest.Produses.Load();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GestiuneMagazin.Produse produs = new GestiuneMagazin.Produse();

            try
            {
                produs = (GestiuneMagazin.Produse)produseDataGrid.SelectedItem;
                gest.Produses.Remove(produs);
                gest.SaveChanges();
            }
            catch(DataException ex)
            {         
                MessageBox.Show(ex.Message);
            }
        }
    }
}
