using BrokerBazePodataka;
using Domeni;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme.User_controlers
{
    public partial class UCradSaUcenikom : UserControl
    {

        Ucenik globalniUcenik = new Ucenik();

        public UCradSaUcenikom()
        {
            InitializeComponent();
            cbPol.DataSource = Enum.GetValues<Pol>();
            btnOmoguciIzmene.Visible = false;
            btnObrisi.Visible = false;
            btnIzmeni.Visible = false;
        }

        public UCradSaUcenikom(Ucenik ucenik)
        {
            InitializeComponent();
            dgvEvidencijeNastave.Visible = true;
            globalniUcenik = ucenik;
            cbPol.DataSource = Enum.GetValues<Pol>();
            txtImeUcenika.Text = ucenik.ImeUcenika;
            txtPrezimeUcenika.Text = ucenik.PrezimeUcenika;
            txtImeRoditelja.Text = ucenik.ImeRoditelja;
            txtPrezimeRoditelja.Text = ucenik.PrezimeRoditelja;
            txtEmailUcenika.Text = ucenik.EmailUcenika;
            txtTelefonUcenika.Text = ucenik.TelefonUcenika;
            txtTelefonRoditelja.Text = ucenik.TelefonRoditelja;
            dateDatumRodjenja.Value = ucenik.DatumRodjenjaUcenika;
            cbPol.SelectedItem = ucenik.PolUcenika;
            btnKreiraj.Visible = false;
            dgvEvidencijeNastave.DataSource = broker.vratiListuEvidencijaNastave(ucenik);

            dgvEvidencijeNastave.Columns[0].Visible = false;
            dgvEvidencijeNastave.Columns[2].Visible = false;
            dgvEvidencijeNastave.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEvidencijeNastave.Enabled = false;
            btnOmoguciIzmene.Visible = true;
            omoguciPolja(false);
            btnObrisi.Visible = false;
            btnIzmeni.Visible = false;
        }

        private void omoguciPolja(bool x)
        {
            txtImeUcenika.Enabled = x;
            txtPrezimeUcenika.Enabled = x;
            txtImeRoditelja.Enabled = x;
            txtPrezimeRoditelja.Enabled = x;
            txtEmailUcenika.Enabled = x;
            txtTelefonUcenika.Enabled = x;
            txtTelefonRoditelja.Enabled = x;
            dateDatumRodjenja.Enabled = x;
            cbPol.Enabled = x;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        Broker broker = new Broker();

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtImeUcenika.Text) || string.IsNullOrEmpty(txtPrezimeUcenika.Text) || string.IsNullOrEmpty(txtImeRoditelja.Text) || string.IsNullOrEmpty(txtPrezimeRoditelja.Text)
                 || string.IsNullOrEmpty(txtTelefonRoditelja.Text) || string.IsNullOrEmpty(txtTelefonUcenika.Text) || string.IsNullOrEmpty(txtEmailUcenika.Text))
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
            }
            else
            {
                Ucenik ucenik = new Ucenik()
                {
                    ImeUcenika = txtImeUcenika.Text,
                    PrezimeUcenika = txtPrezimeUcenika.Text,
                    PolUcenika = (Pol)cbPol.SelectedItem,
                    ImeRoditelja = txtImeRoditelja.Text,
                    PrezimeRoditelja = txtPrezimeRoditelja.Text,
                    TelefonRoditelja = txtTelefonRoditelja.Text,
                    DatumRodjenjaUcenika = dateDatumRodjenja.Value,
                    TelefonUcenika = txtTelefonUcenika.Text,
                    EmailUcenika = txtEmailUcenika.Text
                };
                try
                {
                    broker.kreirajUcenika(ucenik);
                    MessageBox.Show("Ucenik je uspesno kreiran");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greska prilikom rada sa bazom", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnOmoguciIzmene_Click(object sender, EventArgs e)
        {
            btnOmoguciIzmene.Visible = false;
            omoguciPolja(true);
            btnObrisi.Visible = true;
            btnIzmeni.Visible = true;
            
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            Ucenik ucenik = new Ucenik()
            {
                IdUcenika = globalniUcenik.IdUcenika,
                ImeUcenika = txtImeUcenika.Text,
                PrezimeUcenika = txtPrezimeUcenika.Text,
                ImeRoditelja = txtImeRoditelja.Text,
                PrezimeRoditelja = txtPrezimeRoditelja.Text,
                TelefonRoditelja = txtTelefonRoditelja.Text,
                TelefonUcenika = txtTelefonUcenika.Text,
                EmailUcenika = txtEmailUcenika.Text,
                PolUcenika = (Pol)cbPol.SelectedItem,
                DatumRodjenjaUcenika = dateDatumRodjenja.Value
            };

            DialogResult res = MessageBox.Show("Da li ste sigurni da želite da izmenite učenika?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    broker.PromeniUcenika(ucenik);
                    MessageBox.Show("Promene su sačuvane!");
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

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Da li ste sigurni da želite da obrišete učenika?", "Potvrda", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                try
                {
                    broker.obrisiUcenika(globalniUcenik);
                    MessageBox.Show("Ucenik je obrisan!");
                }catch(Exception ex)
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
