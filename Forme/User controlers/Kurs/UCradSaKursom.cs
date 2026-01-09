using BrokerBazePodataka;
using Domeni;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme.User_controlers
{
    public partial class UCradSaKursom : UserControl
    {
        Broker broker = new Broker();
        Kurs globalniKurs = new Kurs();
        public UCradSaKursom()
        {
            InitializeComponent();
            cbTezina.DataSource = Enum.GetValues<TezinaKursa>();
            cbUzrast.DataSource = Enum.GetValues<Uzrast>();
            dgvPodaci.DataSource = broker.vratiListuSviKursevi();
            foreach (DataGridViewColumn col in dgvPodaci.Columns)
            {
                col.Visible = false;
            }

            dgvPodaci.Columns[1].Visible = true;
            dgvPodaci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public UCradSaKursom(Kurs kurs)
        {
            InitializeComponent();
            globalniKurs = kurs;
            cbTezina.DataSource = Enum.GetValues<TezinaKursa>();
            cbUzrast.DataSource = Enum.GetValues<Uzrast>();
            try
            {
                dgvPodaci.DataSource = broker.vratiListuEvidencijaNastave(null, null, null, null, kurs);
                dgvPodaci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                foreach(DataGridViewColumn col in dgvPodaci.Columns)
                {
                    col.Visible = false;
                }
                dgvPodaci.Columns[4].Visible = true;
            }
            catch {  }
            txtNaziv.Text = kurs.NazivKursa;
            txtOznaka.Text = kurs.OznakaKursa;
            numTrajanje.Value = kurs.TrajanjeKursa;
            cbTezina.SelectedItem = kurs.TezinaKursa;
            cbUzrast.SelectedItem = kurs.UzrastKursa;
            omoguciPolja(false);
            btnKreiraj.Visible = false;
            btnPretrazi.Visible = false;
            btnPrikazi.Visible = false;
            btnOmoguciIzmene.Visible = true;


        }

        private void omoguciPolja(bool x)
        {
            numTrajanje.Enabled = x;
            cbTezina.Enabled = x;
            cbUzrast.Enabled = x;
            txtNaziv.Enabled = x;
            txtOznaka.Enabled = x;
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {

            try
            {

                Kurs k = new Kurs()
                {
                    NazivKursa = txtNaziv.Text,
                    TezinaKursa = (TezinaKursa)cbTezina.SelectedItem,
                    UzrastKursa = (Uzrast)cbUzrast.SelectedItem,
                    TrajanjeKursa = (int)numTrajanje.Value,
                    OznakaKursa = txtOznaka.Text
                };
                k.validiraj();
                try
                {
                    broker.kreirajKurs(k);
                    MessageBox.Show("Kurs je kreiran!");
                    dgvPodaci.DataSource = broker.vratiListuSviKursevi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void UCradSaKursom_Load(object sender, EventArgs e)
        {

        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                dgvPodaci.DataSource = broker.vratiListuSviKursevi();
            }
            else
            {
                Kurs zaPretragu = new Kurs() { NazivKursa = txtNaziv.Text };
                dgvPodaci.DataSource = broker.vratiListuKurseva(zaPretragu);
                foreach (DataGridViewColumn col in dgvPodaci.Columns)
                {
                    col.Visible = false;
                }

                dgvPodaci.Columns[1].Visible = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UCradSaKursom ucRadSaKursom = new UCradSaKursom((Kurs)dgvPodaci.CurrentRow.DataBoundItem);
            PomocnaForma prikazKursaForma = new PomocnaForma(ucRadSaKursom);
            prikazKursaForma.ShowDialog();
            
        }

        private void btnOmoguciIzmene_Click(object sender, EventArgs e)
        {
            omoguciPolja(true);
            btnOmoguciIzmene.Visible = false;
            txtOznaka.Enabled = false; 
            btnIzmeni.Visible = true;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            try { 
            
                 Kurs k = new Kurs()
                 {
                     IdKursa = globalniKurs.IdKursa,
                     NazivKursa = txtNaziv.Text,
                     TezinaKursa = (TezinaKursa)cbTezina.SelectedItem,
                     UzrastKursa = (Uzrast)cbUzrast.SelectedItem,
                     TrajanjeKursa = (int)numTrajanje.Value,
                     OznakaKursa = txtOznaka.Text
                 };
                k.validiraj();
                DialogResult res = MessageBox.Show("Da li ste sigurni da zelite da promenite kurs?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                   

                    try
                    {
                        broker.promeniKurs(k);
                        MessageBox.Show("Kurs je promenjen!");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("OK");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
