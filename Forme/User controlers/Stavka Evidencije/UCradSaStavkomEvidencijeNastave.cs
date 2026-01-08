using BrokerBazePodataka;
using Domeni;
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
    public partial class UCradSaStavkomEvidencijeNastave : UserControl
    {
        Broker broker = new Broker();
        EvidencijaNastave globalnaEvidencija = new EvidencijaNastave();
        StavkaEvidencijeNastave globalnaStavka = new StavkaEvidencijeNastave();
        public UCradSaStavkomEvidencijeNastave(EvidencijaNastave evidencija)
        {
            InitializeComponent();
            globalnaEvidencija = evidencija;
            txtEvidencija.Text = evidencija.ToString();
            txtEvidencija.Enabled = false;
            cbUcenik.DataSource = broker.vratiListuUcenika(evidencija.Grupa);
            Kurs k = broker.pretraziKurs(new Kurs() { IdKursa = evidencija.Grupa.Kurs.IdKursa });
            cbRedniBrojCasa.DataSource = Enumerable.Range(1, broker.pretraziKurs(k).TrajanjeKursa).ToList();
            dateDatum.MaxDate = DateTime.Today;
        }

        public UCradSaStavkomEvidencijeNastave(StavkaEvidencijeNastave stavka)
        {
            InitializeComponent();
            globalnaStavka = stavka;
            txtEvidencija.Enabled = false;
            txtEvidencija.Text = stavka.Evidencija.ToString();
            btnOmoguciIzmenu.Visible = true;
            txtKomentar.Text = stavka.Komentar;
            cbUcenik.DataSource = broker.vratiListuUcenika(stavka.Evidencija.Grupa);
            cbUcenik.SelectedItem = stavka.Ucenik;
            Kurs k = broker.pretraziKurs(new Kurs() { IdKursa = stavka.Evidencija.Grupa.Kurs.IdKursa });
            cbRedniBrojCasa.DataSource = Enumerable.Range(1, broker.pretraziKurs(k).TrajanjeKursa).ToList();
            dateDatum.Value = stavka.DatumOdrzavanja;
            chDomaci.Checked = stavka.UradjenDomaci;
            chPrisustvo.Checked = stavka.Prisustvo;
            btnDodaj.Visible = false;
            omoguciPolja(false);


        }

        private void omoguciPolja(bool x)
        {
            cbUcenik.Enabled = x;
            cbRedniBrojCasa.Enabled = x;
            txtKomentar.Enabled = x;
            chDomaci.Enabled = x;
            chPrisustvo.Enabled = x;
            dateDatum.Enabled = x;

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            StavkaEvidencijeNastave stavka = new StavkaEvidencijeNastave()
            {
                Evidencija = new EvidencijaNastave() { IdEvidencijeNastave = globalnaEvidencija.IdEvidencijeNastave },
                Ucenik = (Ucenik)cbUcenik.SelectedItem,
                RedniBrojCasa = (int)cbRedniBrojCasa.SelectedItem,
                Prisustvo = chPrisustvo.Checked,
                UradjenDomaci = chDomaci.Checked,
                Komentar = txtKomentar.Text,
                DatumOdrzavanja = dateDatum.Value,

            };
            try
            {
                broker.kreirajStavkuEvidencijeNastave(stavka);
                MessageBox.Show("Stavka je dodata");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOmoguciIzmenu_Click(object sender, EventArgs e)
        {
            btnOmoguciIzmenu.Visible = false;
            btnPromeni.Visible = true;
            omoguciPolja(true);
            cbUcenik.Enabled = false;
        }

        private void btnPromeni_Click(object sender, EventArgs e)
        {
            StavkaEvidencijeNastave stavka = new StavkaEvidencijeNastave()
            {
                idStavkeEvidencije = globalnaStavka.idStavkeEvidencije,
                Prisustvo = chPrisustvo.Checked,
                UradjenDomaci = chDomaci.Checked,
                DatumOdrzavanja = dateDatum.Value,
                Komentar = txtKomentar.Text,
                RedniBrojCasa  = (int)cbRedniBrojCasa.SelectedItem
            };
            DialogResult res = MessageBox.Show("Da li ste sigurni da zelite da zapamtite promenu?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                try
                {
                    broker.promeniStavkuEvidencijeNastave(stavka);
                    MessageBox.Show("Promene su sacuvane");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("OK");
            }
        }
    }
}
