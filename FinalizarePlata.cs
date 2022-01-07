using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazinPizza
{
    public partial class FinalizarePlata : Form
    {

        public delegate void PlataRealizataEvent(object sender, PlataRealizataEventArgs e);

        public event PlataRealizataEvent PlataRealizata;


        private decimal plata;

        public decimal SumePlata
        {
            get { return plata; }
            set
            {
                plata = value;
                txtSumaPlata.Text = String.Format("{0:c}", plata);
            }
        }
        public FinalizarePlata()
        {
            InitializeComponent();
        }

   
        private void Plata_Click(object sender, EventArgs e)
        {
            decimal suma = 0;

            try
            {
                suma = decimal.Parse(txtSumaPlata.Text.TrimStart('$')) - decimal.Parse(txtSumaPlatita.Text);
            }
            catch
            {
                MessageBox.Show("Introdu valori Valide");
                return;
            }
            if (suma > 0)
            {
                txtSumaPlata.Text = suma.ToString();
                MessageBox.Show("Mai aveti de platit suma de:" + String.Format("{0:c}", suma));
            }
            else
            {
                MessageBox.Show("Rest de plata" + String.Format("{0:c}", -suma));
                PlataRealizata(this, new PlataRealizataEventArgs() { PlataSucces = true });
                txtSumaPlata.Text = null;
                txtSumaPlatita.Text = null;
            }

            
        }
    }

    public class PlataRealizataEventArgs : EventArgs
    {
        private bool plataSucces;

        public bool PlataSucces
        {
            get { return plataSucces; }
            set
            {
                plataSucces = value;
            }
        }
    }
}
