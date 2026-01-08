using BrokerBazePodataka;
using Domeni;
using Microsoft.IdentityModel.Tokens;
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
    public partial class UCradSaUciteljem : UserControl
    {

        Broker broker = new Broker();

        public UCradSaUciteljem()
        {
            InitializeComponent();
            datePocetakRada.MaxDate = DateTime.Today;
        }

        private void UCradSaUciteljem_Load(object sender, EventArgs e)
        {

        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtIme.Text) || string.IsNullOrEmpty(txtPrezime.Text) || string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtTelefon.Text) || string.IsNullOrEmpty(txtKorisnickoIme.Text) || string.IsNullOrEmpty(txtLozinka.Text))
            {
                MessageBox.Show("Sva polja moraju biti uneta!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if(txtIme.Text == txtKorisnickoIme.Text)
            {
                MessageBox.Show("Korisničko ime i ime učitelja moraju da se razlikuju!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtLozinka.Text == txtKorisnickoIme.Text)
            {
                MessageBox.Show("Korisničko ime i lozinka moraju da se razlikuju!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Ucitelj u = new Ucitelj
                {
                    ImeUcitelja = txtIme.Text,
                    PrezimeUcitelja = txtPrezime.Text,
                    Email = txtEmail.Text,
                    Telefon = txtTelefon.Text,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Lozinka = txtLozinka.Text,
                    DatumPocetkaRada = datePocetakRada.Value
                };
                
                try
                {
                    broker.kreirajUcitelja(u);
                    MessageBox.Show("Učitelj je kreiran!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Greška prilikom rada sa bazom!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }
    }
}
