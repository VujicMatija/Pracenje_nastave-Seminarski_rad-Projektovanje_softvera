using BrokerBazePodataka;
using Domeni;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme.User_controlers
{
    public partial class UCkreirajLicencu : UserControl
    {
        Broker broker = new Broker();
        Ucitelj globUcitelj = new Ucitelj();
        public UCkreirajLicencu(Ucitelj ucitelj)
        {
            InitializeComponent();
            txtUcitelj.Enabled = false;
            txtUcitelj.Text = ucitelj.ToString();
            cbSertifikati.DataSource = broker.vratiListuSviSertifikati();
            globUcitelj = ucitelj;
        }

        public UCkreirajLicencu(Licenca licenca)
        {
            InitializeComponent();
            globUcitelj = licenca.ucitelj;
            txtUcitelj.Enabled = false;
            txtUcitelj.Text = licenca.ucitelj.ToString();
            cbSertifikati.DataSource = broker.vratiListuSviSertifikati();
            cbSertifikati.SelectedItem = licenca.sertifikat;
            dateDobijanje.Value = licenca.DatumDobijanja;
            txtUcitelj.Enabled = false;
            cbSertifikati.Enabled = false;
            dateDobijanje.Enabled = false;
            btnOmoguciIzmenu.Visible = true;
        }

        private void btnDodajLicencu_Click(object sender, EventArgs e)
        {
            Licenca licenca = new Licenca()
            {
                ucitelj = new Ucitelj
                {
                    Id = globUcitelj.Id
                },
                sertifikat = new Sertifikat
                {
                    IdSertifikata = ((Sertifikat)cbSertifikati.SelectedItem).IdSertifikata
                },
                DatumDobijanja = dateDobijanje.Value

            };
            try
            {
                broker.kreirajLicencu(licenca);
                MessageBox.Show("Licenca je dodata!");
            }
            catch
            {
                MessageBox.Show("Greska prilikom rada sa bazom!");
            }
        }

        private void btnOmoguciIzmenu_Click(object sender, EventArgs e)
        {
            btnOmoguciIzmenu.Visible = false;
            btnIzmeni.Visible = true;
            dateDobijanje.Enabled = true;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            Licenca licenca = new Licenca
            {
                ucitelj = globUcitelj,
                sertifikat = (Sertifikat)cbSertifikati.SelectedItem,
                DatumDobijanja = dateDobijanje.Value
            };

            DialogResult res = MessageBox.Show("Da li ste sigurni da zelite da sacuvate promene?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                try
                {
                    broker.promeniLicencu(licenca);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
