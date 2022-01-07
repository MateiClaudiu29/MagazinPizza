using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Drawing.Printing;

namespace MagazinPizza
{
    public partial class CasaMarc : Form
    {

        private BindingList<GestiuneMagazin.Produse> produse = new BindingList<GestiuneMagazin.Produse>();

        private GestiuneMagazin.GestiuneMagazinEntities gest = new GestiuneMagazin.GestiuneMagazinEntities();

        private decimal total;

        public decimal NotaTotala
        {
            get { return total; }
            set { 
                total = value;
                PretTotal.Text = String.Format("{0:c}",total);
            }
        }
        public CasaMarc()
        {
            InitializeComponent();

            lbProduseSelectate.DataSource = produse;
            lbProduseSelectate.DisplayMember = "NumeProduse";
            
            CreareTabelaProduse();
            AdaugareProduseTabel();
        }

        private void CreareTabelaProduse()
        {
            foreach (GestiuneMagazin.TipProduse p in gest.TipProduses)
            {
                tabControl1.TabPages.Add(p.TipProduseId.ToString(),p.NumeTipProdus);
            }
        }

        private void AdaugareProduseTabel()
        {
            int i = 1;
            foreach(TabPage tp in tabControl1.TabPages)
            {
                
                var produs = gest.Produses.SqlQuery("SELECT * FROM Produse WHERE TipProdusId = "+i.ToString()).ToList<GestiuneMagazin.Produse>();

                FlowLayoutPanel flo = new FlowLayoutPanel();

                flo.Dock = DockStyle.Fill;

                foreach(GestiuneMagazin.Produse tprod in produs)
                {
                    Button b = new Button();
                    b.Text = tprod.NumeProdus;
                    b.Tag = tprod;
                    b.Click += new EventHandler(SelecteazaProduse);
                    flo.Controls.Add(b);
                }

                tp.Controls.Add(flo);
                i++;
            }
        }

        void SelecteazaProduse(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            GestiuneMagazin.Produse p = (GestiuneMagazin.Produse)b.Tag;

            produse.Add(p);

            NotaTotala = NotaTotala + p.PretProdus;
        }

        private void FormatList(object sender, ListControlConvertEventArgs e)
        {
            string denumireCurenta = ((GestiuneMagazin.Produse)e.ListItem).NumeProdus;
            string pretCurent = String.Format("{0:c}",((GestiuneMagazin.Produse)e.ListItem).PretProdus);

            string denumireCurentaPadded = denumireCurenta.PadRight(30);

            e.Value = denumireCurentaPadded + pretCurent;
        }

        private void Delete(object sender, EventArgs e)
        {
            GestiuneMagazin.Produse p = (GestiuneMagazin.Produse)lbProduseSelectate.SelectedItem;
            produse.Remove(p);
            if (produse.Count == 0)
            {
                NotaTotala = 0;
            }
            else
            {
                NotaTotala = NotaTotala - p.PretProdus;
            }
        }

        private void PrintNota()
        {
            PrintDialog print = new PrintDialog();

            PrintDocument printDoc = new PrintDocument();

            printDoc.PrintPage += new PrintPageEventHandler(printDocument_PrintPagina);

            DialogResult result = print.ShowDialog();

            if(result == DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        void printDocument_PrintPagina(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Font font = new Font("Courier New", 12);

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphics.DrawString("Magazin Pizza", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);

            foreach(GestiuneMagazin.Produse p in produse)
            {
                string produs = p.NumeProdus.PadRight(30);
                string total = String.Format("{0:c}", p.PretProdus);

                string text = produs + total;

                graphics.DrawString(text, font, new SolidBrush(Color.Black), startX, startY + offset);

                offset = offset + (int)fontHeight + 5;
            }

            offset = offset + 20;

            graphics.DrawString("Total Plata".PadRight(30) + String.Format("{0:c}", NotaTotala), font, new SolidBrush(Color.Black), startX, startY + offset);
        }

        private void DeschidePlata(object sender, EventArgs e)
        {
            FinalizarePlata finalizarePlata = new FinalizarePlata();
            finalizarePlata.Show();
            finalizarePlata.PlataRealizata += new FinalizarePlata.PlataRealizataEvent(finalizarePlata_PlataRealizata);

            finalizarePlata.SumePlata = NotaTotala;
        }

        void finalizarePlata_PlataRealizata(object sender, PlataRealizataEventArgs e)
        {
            GestiuneMagazin.Comenzi comanda = new GestiuneMagazin.Comenzi();

            comanda.DataComanda = DateTime.Now;

            if (e.PlataSucces == true)
            {
                foreach(GestiuneMagazin.Produse p in produse)
                {
                    comanda.ProduseComandates.Add(new GestiuneMagazin.ProduseComandate() { ProdusID = p.ProdusId });
                }

                gest.Comenzis.Add(comanda);
                gest.SaveChanges();
                PrintNota();
            }
        }
    }
}
