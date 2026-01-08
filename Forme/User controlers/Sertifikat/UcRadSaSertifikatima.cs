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
    public partial class UcRadSaSertifikatima : UserControl
    {

        Broker broker = new Broker();
        Sertifikat globalniSertifikat = new Sertifikat();
        public UcRadSaSertifikatima()
        {
            InitializeComponent();
            dgvPodaci.DataSource = broker.vratiListuSviSertifikati();
            dgvPodaci.Columns[0].Visible = false;
            dgvPodaci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public UcRadSaSertifikatima(Sertifikat sertifikat)
        {
            InitializeComponent();
            globalniSertifikat = sertifikat;
            btnIzmeni.Visible = false;
            btnOmoguciIzmene.Visible = true;

            txtNazivSertifikata.Text = sertifikat.NazivSertifikata;
            txtNazivSertifikata.Enabled = false;
            btnPrikazi.Visible = false;
            btnUbaciSertifikat.Visible = false;
            dgvPodaci.DataSource = broker.vratiListuUcitelja(sertifikat);
            foreach (DataGridViewColumn col in dgvPodaci.Columns)
            {
                col.Visible = false;
            }
            dgvPodaci.Columns[1].Visible = true;
            dgvPodaci.Columns[2].Visible = true;
            dgvPodaci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txtNazivSertifikata.Text))
                {
                    MessageBox.Show("Morate uneti naziv sertifikata!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Sertifikat s = new Sertifikat() { NazivSertifikata = txtNazivSertifikata.Text };
                    broker.ubaciSertifikat(s);
                    MessageBox.Show("Sertifikat ubacen!");
                    dgvPodaci.DataSource = broker.vratiListuSviSertifikati();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
                UcRadSaSertifikatima ucRadSaSertifikatima = new UcRadSaSertifikatima((Sertifikat)dgvPodaci.CurrentRow.DataBoundItem);
                PomocnaForma prikazSertifikataForma = new PomocnaForma(ucRadSaSertifikatima);
                prikazSertifikataForma.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Morate odabrati sertifikat!");
            }
        }

        private void btnOmoguciIzmene_Click(object sender, EventArgs e)
        {
            btnOmoguciIzmene.Visible = false;
            btnObrisi.Visible = true;
            btnIzmeni.Visible = true;
            txtNazivSertifikata.Enabled = true;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            Sertifikat s = new Sertifikat() { IdSertifikata = globalniSertifikat.IdSertifikata, NazivSertifikata = txtNazivSertifikata.Text };
            DialogResult res = MessageBox.Show("Da li zelite da sacuvate promene?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    broker.promeniSertifikat(s);
                    MessageBox.Show("Promena sacuvana!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("OK!");
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Da li ste sigurni da zelite da obrisete sertifikat?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    broker.obrisiSertikat(globalniSertifikat);
                    MessageBox.Show("Sertifikat obrisan!");

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

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNazivSertifikata.Text))
            {
                dgvPodaci.DataSource = broker.vratiListuSviSertifikati();
            }
            else
            {
                Sertifikat sertifikatZaPretragu = new Sertifikat() { NazivSertifikata = txtNazivSertifikata.Text };
                dgvPodaci.DataSource = broker.vratiListuSertifikata(sertifikatZaPretragu);
            }
        }
    }
}
