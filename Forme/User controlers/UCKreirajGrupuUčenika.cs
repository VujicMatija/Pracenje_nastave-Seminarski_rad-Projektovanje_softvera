using BrokerBazePodataka;
using Domeni;
using Forme.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme.User_controlers
{
    public partial class UCKreirajGrupuUčenika : UserControl
    {
        List<string> sati = new List<string>() { "10:00h", "12:00h", "14:00h", "16:00h", "18:00h", "20:00h" };
        Broker broker = new Broker();
        public UCKreirajGrupuUčenika(WorkMode mode = )
        {
            InitializeComponent();
            cbKursevi.DataSource = broker.vratiListuSviKursevi();
            cbDani.DataSource = Enum.GetNames(typeof(Dani));
            cbSati.DataSource = sati;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOznaka.Text = formirajOznakuGrupe();
        }

        private string formirajOznakuGrupe()
        {
            if (cbKursevi.SelectedItem != null && cbDani.SelectedItem != null && cbSati.SelectedItem != null)
            {
                return $"{((Kurs)(cbKursevi.SelectedItem)).OznakaKursa}_{(cbDani.SelectedItem).ToString().Substring(0, 3)}_{cbSati.SelectedItem.ToString().Substring(0, 2)}";
            }
            else
            {
                return string.Empty;
            }


        }

        private void cbKursevi_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOznaka.Text = formirajOznakuGrupe();
        }

        private void cbDani_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOznaka.Text = formirajOznakuGrupe();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            GrupaUcenika grupa = new GrupaUcenika()
            {
                BrojUcenika = (int)numBrojUcenika.Value,
                Kurs = new Kurs
                {
                    IdKursa = ((Kurs)cbKursevi.SelectedItem).IdKursa
                },
                Termin = cbDani.SelectedItem + " " + cbSati.SelectedItem,
                OznakaGrupe = txtOznaka.Text
            };

            try
            {
                broker.KreirajGrupuUcenika(grupa);
                MessageBox.Show("Grupa učenika je uspešno kreirana!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
