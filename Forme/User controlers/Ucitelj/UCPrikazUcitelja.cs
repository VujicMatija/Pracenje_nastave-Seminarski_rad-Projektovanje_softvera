using Domeni;

namespace Forme.User_controlers
{
    public partial class UCPrikazUcitelja : UserControl
    {
        Ucitelj ucitelj = new Ucitelj();
        public UCPrikazUcitelja(Ucitelj u)
        {
            InitializeComponent();
            ucitelj = Komunikacija.Instance.pretraziUcitelja(u);
            PopuniPoljaSaPodacima(ucitelj);
            dateDatumPocetka.MaxDate = DateTime.Today;


            btnDodajLicencu.Visible = false;

            try
            {
                dgvLicence.DataSource = Komunikacija.Instance.VratiListuSertifikata(ucitelj: ucitelj, sertifikat:null);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            dgvLicence.Columns[0].Visible = false;
            dgvLicence.RowHeadersVisible = false;

            dgvGrupe.DataSource = Komunikacija.Instance.vratiListuGrupaUcenika(ucitelj, ucenik: null, kurs: null);
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


        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                RestartujTextBoxove();
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
                if (ValidirajUcitelja())
                {
                    try
                    {
                        DialogResult res = MessageBox.Show("Da li ste sigurni da želite da promenite učitelja?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (res == DialogResult.Yes)
                        {
                            Komunikacija.Instance.promeniUcitelja(novi);
                            MessageBox.Show("Promene su sacuvane!");
                            PopuniPoljaSaPodacima(novi);
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
            dgvLicence.DataSource = Komunikacija.Instance.VratiListuSertifikata(ucitelj:ucitelj, sertifikat: null);
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
                    Komunikacija.Instance.obrisiUcitelja(ucitelj);
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


        private void PopuniPoljaSaPodacima(Ucitelj ucitelj)
        {
            txtIme.Text = ucitelj.ImeUcitelja;
            txtPrezime.Text = ucitelj.PrezimeUcitelja;
            txtTelefon.Text = ucitelj.Telefon;
            txtEmail.Text = ucitelj.Email;
            dateDatumPocetka.Value = ucitelj.DatumPocetkaRada;
            btnDodajLicencu.Visible = false;
            btnIzmeni.Visible = false;
            enejbul(false);
        }

        private void enejbul(bool x)
        {
            txtIme.Enabled = x;
            txtPrezime.Enabled = x;
            txtEmail.Enabled = x;
            txtTelefon.Enabled = x;
            dateDatumPocetka.Enabled = x;
        }

        private bool ValidirajUcitelja()
        {
            Color boja = ColorTranslator.FromHtml("#d96f6f");
            bool uspesno = true;
            string poruka = "";
            if (txtIme.Text.Length < 3)
            {
                txtIme.BackColor = boja;
                poruka = poruka + "Ime mora imati vise od 2 slova!\n";
            }
            if (txtPrezime.Text.Length < 3)
            {
                txtPrezime.BackColor = boja;
                poruka = poruka + "Prezime mora imati vise od 2 slova!\n";
            }
            if (txtEmail.Text.Contains("@") == false || txtEmail.Text.Contains(".com") == false)
            {
                txtEmail.BackColor = boja;
                poruka = poruka + "Email mora da sadrzi @ i .com\n";
            }
            if (txtTelefon.Text.Length > 3 && txtTelefon.Text.Substring(0, 2) != "06")
            {
                poruka = poruka + "Broj telefona mora da pocinenje sa 06!\n";
                txtTelefon.BackColor = boja;
            }
            else if (txtTelefon.Text.Length < 3)
            {
                poruka = poruka + "Broj telefona mora da pocinenje sa 06!\n";
                txtTelefon.BackColor = boja;
            }
            
            if (string.IsNullOrEmpty(poruka) == false)
            {
                uspesno = false;
                MessageBox.Show("Neuspesna validacija podataka\n" + poruka);
            }
            return uspesno;
        }

        private void RestartujTextBoxove()
        {
            txtIme.BackColor = SystemColors.Window;
            txtPrezime.BackColor = SystemColors.Window;
            txtEmail.BackColor = SystemColors.Window;
            txtTelefon.BackColor = SystemColors.Window;
 
        }
    }
}
