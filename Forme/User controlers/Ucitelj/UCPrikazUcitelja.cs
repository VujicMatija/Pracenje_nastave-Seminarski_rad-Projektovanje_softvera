using BrokerBazePodataka;
using Domeni;

namespace Forme.User_controlers
{
    public partial class UCPrikazUcitelja : UserControl
    {
        Ucitelj ucitelj = new Ucitelj();
        Broker broker = new Broker();
        public UCPrikazUcitelja(Ucitelj u)
        {
            InitializeComponent();
            ucitelj = broker.pretraziUcitelja(u);
            txtIme.Text = ucitelj.ImeUcitelja;
            txtPrezime.Text = ucitelj.PrezimeUcitelja;
            txtTelefon.Text = ucitelj.Telefon;
            txtEmail.Text = ucitelj.Email;
            dateDatumPocetka.Value = ucitelj.DatumPocetkaRada;
            btnDodajLicencu.Visible = false;

            dgvLicence.DataSource = broker.vratiListuSertifikata(ucitelj);
            dgvLicence.Columns[0].Visible = false;
            dgvLicence.RowHeadersVisible = false;

            dgvGrupe.DataSource = broker.vratiGrupeUcenika(ucitelj);
            foreach (DataGridViewColumn col in dgvGrupe.Columns)
            {
                col.Visible = false;
            }
            dgvGrupe.Columns[1].Visible = true;
            dgvGrupe.RowHeadersVisible = false;
            dgvGrupe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLicence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            btnObrisi.Visible = false;


        }

        private void btnOmoguciIzmenu_Click(object sender, EventArgs e)
        {
            btnIzmeni.Visible = true;
            btnOmoguciIzmenu.Visible = false;
            btnDodajLicencu.Visible = true;
            btnObrisi.Visible = true;
            enejbul(true);
        }

        private void enejbul(bool x)
        {
            txtIme.Enabled = x;
            txtPrezime.Enabled = x;
            txtEmail.Enabled = x;
            txtTelefon.Enabled = x;
            dateDatumPocetka.Enabled = x;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                Ucitelj novi = new Ucitelj()
                {
                    Id = ucitelj.Id,
                    ImeUcitelja = txtIme.Text,
                    PrezimeUcitelja = txtPrezime.Text,
                    Email = txtEmail.Text,
                    DatumPocetkaRada = dateDatumPocetka.Value,
                    Telefon = txtTelefon.Text,
                    Lozinka = ucitelj.Lozinka,
                    KorisnickoIme = ucitelj.KorisnickoIme
                    
                };
                novi.validiraj();
                try
                {
                    DialogResult res = MessageBox.Show("Da li ste sigurni da želite da promenite učitelja?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        broker.promeniUcitelja(novi);
                        MessageBox.Show("Promene su sacuvane!");
                    }
                    else
                    {
                        MessageBox.Show("OK");
                    }
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

        private void btnDodajLicencu_Click(object sender, EventArgs e)
        {
            DodajLicencuForma dodajLicencuForma = new DodajLicencuForma(ucitelj);
            dodajLicencuForma.ShowDialog();
            dgvLicence.DataSource = broker.vratiListuSertifikata(ucitelj);
            dgvLicence.Columns[0].Visible = false;
            dgvLicence.RowHeadersVisible = false;
            dgvLicence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Da li ste sigurni da želite da obrišete učitelja?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(res == DialogResult.Yes)
                {
                    broker.obrisiUcitelja(ucitelj);
                    MessageBox.Show("Obrisano!");
                }
                else
                {
                    MessageBox.Show("OK");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Greška prilikom brisanja! Verovatno postoje licence sa ovim učiteljem!");
            }
        }
    }
}
