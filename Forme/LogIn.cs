using Domeni;
using Microsoft.IdentityModel.Tokens.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    public partial class LogIn : Form
    {
        

        public LogIn()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKorisnickoIme.Text) || string.IsNullOrEmpty(txtLozinka.Text))
            {
                MessageBox.Show("Sva polja moraju biti popunjena!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Ucitelj u = new Ucitelj
                {
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Lozinka = txtLozinka.Text
                };

                Ucitelj logovani = new Ucitelj();
                try
                {
                    logovani = Komunikacija.instance.PrijaviUcitelja(u);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (logovani == null)
                {
                    MessageBox.Show("Ne postoji učitelj sa unetim kredencijalima!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Dobrodošli!", "Uspešna prijava", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Glavna frm = new Glavna(logovani);
                    frm.ShowDialog();
                    this.Close();
                }
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            try
            {
                Komunikacija.Instance.PoveziSe();
            }catch(Exception ex)
            {
                MessageBox.Show("Neuspesno povezivanje");
                this.Close();
            }
        }
    }
}
