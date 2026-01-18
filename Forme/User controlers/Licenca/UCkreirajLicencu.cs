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
        
        Ucitelj globUcitelj = new Ucitelj();
        public UCkreirajLicencu(Ucitelj ucitelj)
        {
            InitializeComponent();
            txtUcitelj.Enabled = false;
            txtUcitelj.Text = ucitelj.ToString();
            BindingList<Sertifikat> sviSertifikati = Komunikacija.Instance.VratiListuSviSertifikati();
            BindingList<Sertifikat> uciteljeviSertifikati = Komunikacija.Instance.vratiListuSertifikata(ucitelj);
            cbSertifikati.DataSource = sviSertifikati.Except(uciteljeviSertifikati).ToList();
            globUcitelj = ucitelj;
        }

        public UCkreirajLicencu(Licenca licenca)
        {
            InitializeComponent();
            globUcitelj = licenca.ucitelj;
            txtUcitelj.Enabled = false;
            txtUcitelj.Text = licenca.ucitelj.ToString();
            cbSertifikati.DataSource = Komunikacija.Instance.VratiListuSviSertifikati();
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
                Komunikacija.Instance.KreirajLicencu(licenca);
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
                    Komunikacija.Instance.PromeniLicencu(licenca);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
