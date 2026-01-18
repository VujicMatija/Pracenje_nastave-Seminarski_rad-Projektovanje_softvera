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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Forme.User_controlers
{
    public partial class UCradSaUciteljem : UserControl
    {

        

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
            Ucitelj u = new Ucitelj();
            RestartujTextBoxove();
            try
            {
               
                u = new Ucitelj
                {
                    ImeUcitelja = txtIme.Text,
                    PrezimeUcitelja = txtPrezime.Text,
                    Email = txtEmail.Text,
                    Telefon = txtTelefon.Text,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Lozinka = txtLozinka.Text,
                    DatumPocetkaRada = datePocetakRada.Value
                };
                if (ValidirajUcitelja())
                {
                    try
                    {
                        Komunikacija.Instance.KreirajUcitelja(u);
                        MessageBox.Show("Učitelj je kreiran!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Greška prilikom rada sa bazom!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
     
                
               
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

               

            }

            
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
            }else if(txtTelefon.Text.Length < 3){
                poruka = poruka + "Broj telefona mora da pocinenje sa 06!\n";
                txtTelefon.BackColor = boja;
            }
            if (txtKorisnickoIme.Text.Length < 8)
            {
                poruka = poruka + "Korisnicko ime mora biti duze od 7 karaktera\n";
                txtKorisnickoIme.BackColor = boja;
            }
            if (txtLozinka.Text.Length < 10)
            {
                poruka = poruka + "Lozinka mora imati minimum 10 karaktera\n";
                txtLozinka.BackColor = boja;
            }
            if (txtKorisnickoIme.Text == txtLozinka.Text)
            {
                txtLozinka.BackColor = boja;
                txtKorisnickoIme.BackColor = boja;
                poruka = poruka + "Lozinka i korisnicko ime moraju  da se razlikuju\n";
            }
            if(string.IsNullOrEmpty(poruka) == false)
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
            txtLozinka.BackColor = SystemColors.Window;
            txtKorisnickoIme.BackColor = SystemColors.Window;
        }
    }
}
