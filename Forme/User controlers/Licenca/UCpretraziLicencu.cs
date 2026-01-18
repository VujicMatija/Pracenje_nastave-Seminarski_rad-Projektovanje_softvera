using Domeni;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme.User_controlers
{
    public partial class UCpretraziLicencu : UserControl
    {
        

        public UCpretraziLicencu()
        {
            InitializeComponent();
            cbUcitelj.DataSource = Komunikacija.Instance.VratiListuSviUcitelji();
            cbSertifikat.DataSource = Komunikacija.Instance.VratiListuSviSertifikati();
            dgvLicence.DataSource = Komunikacija.Instance.VratiListuSveLicence();
            dgvLicence.Columns[2].Visible = false;
            dgvLicence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbSertifikat.SelectedItem != null && cbUcitelj.SelectedItem != null)
            {

                dgvLicence.DataSource = Komunikacija.Instance.vratiListuLicence((Ucitelj)cbUcitelj.SelectedItem, (Sertifikat)cbSertifikat.SelectedItem);
                dgvLicence.Columns[2].Visible = false;
                dgvLicence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if (cbSertifikat.SelectedItem != null)
            {
                dgvLicence.DataSource = Komunikacija.Instance.vratiListuLicence((Sertifikat)cbSertifikat.SelectedItem);
                dgvLicence.Columns[2].Visible = false;
                dgvLicence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if (cbUcitelj.SelectedItem != null)
            {
                dgvLicence.DataSource = Komunikacija.Instance.vratiListuLicence((Ucitelj)cbUcitelj.SelectedItem);
                dgvLicence.Columns[2].Visible = false;
                dgvLicence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                dgvLicence.DataSource = Komunikacija.Instance.VratiListuSveLicence();
            }
        }

        private void btnResetuj_Click(object sender, EventArgs e)
        {
            cbUcitelj.SelectedItem = null;
            cbSertifikat.SelectedItem = null;
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            try
            { 
                DodajLicencuForma licencaFrm = new DodajLicencuForma((Licenca)dgvLicence.CurrentRow.DataBoundItem);
                licencaFrm.ShowDialog();

            }catch(Exception ex)
            {
                MessageBox.Show("Morate izabrati licencu!");
            }
        }
    }
}
