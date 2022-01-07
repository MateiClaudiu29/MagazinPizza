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
    /// Interaction logic for AdaugareProduse.xaml
    /// </summary>
    public partial class AdaugareProduse : Window
    {

        private GestiuneMagazin.GestiuneMagazinEntities gest = new GestiuneMagazin.GestiuneMagazinEntities();
        
        public AdaugareProduse()
        {
            InitializeComponent();
            DataContext = this;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource tipProduseViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("tipProduseViewSource")));

            tipProduseViewSource.Source = gest.TipProduses.Local;
            gest.TipProduses.Load();
            
            cboCategorie.ItemsSource = gest.TipProduses.Local;
            cboCategorie.DisplayMemberPath = "NumeTipProdus";
            cboCategorie.SelectedValuePath = "TipProduseId";
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            GestiuneMagazin.Produse produs = new GestiuneMagazin.Produse();

            produs.NumeProdus = txtNume.Text;
            produs.GramajProdus = int.Parse(txtGramaj.Text);
            produs.PretProdus = decimal.Parse(txtPret.Text);
            produs.TipProdusId = (int)cboCategorie.SelectedValue;

            gest.Produses.Add(produs);
            gest.SaveChanges();

            MessageBox.Show("Produs Adaugat");
        }
    }
}
