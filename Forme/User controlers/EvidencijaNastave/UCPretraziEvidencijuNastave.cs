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
    public partial class UCPretraziEvidencijuNastave : UserControl
    {
        
        public UCPretraziEvidencijuNastave()
        {
            InitializeComponent();
            BindingList<Ucitelj> sviUcitelji = Komunikacija.Instance.VratiListuSviUcitelji();
            cbUcitelj.DataSource = sviUcitelji;
            cbUcitelj.SelectedItem = null;
            BindingList<GrupaUcenika> sveGrupeUcenika = Komunikacija.Instance.VratiListuSveGrupeUcenika();
            cbGrupa.DataSource = sveGrupeUcenika;
            cbGrupa.SelectedItem = null;
            BindingList<Ucenik> sviUcenici = Komunikacija.Instance.VratiListuSviUcenici();
            cbUcenik.DataSource = sviUcenici;
            cbUcenik.SelectedItem = null;
            dgvEvidencije.DataSource = Komunikacija.Instance.VratiListuSveEvidencijeNastave();
            dgvEvidencije.Columns[0].Visible = false;
            dgvEvidencije.Columns[1].Visible = false;
            dgvEvidencije.Columns[2].Visible = false;
            dgvEvidencije.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void UCPretraziEvidencijuNastave_Load(object sender, EventArgs e)
        {

        }

        private void btnPretraziEvidencije_Click(object sender, EventArgs e)
        {
            dgvEvidencije.DataSource = null;
            dgvEvidencije.DataSource = Komunikacija.Instance.VratiListuEvidencijaNastave((GrupaUcenika)cbGrupa.SelectedItem, (Ucitelj)cbUcitelj.SelectedItem, (Ucenik)cbUcenik.SelectedItem);
            // dgvEvidencije.DataSource = broker.vratiListuEvidencijaNastave((Ucitelj)cbUcitelj.SelectedItem);
            dgvEvidencije.Columns[0].Visible = false;
            dgvEvidencije.Columns[1].Visible = false;
            dgvEvidencije.Columns[2].Visible = false;
            dgvEvidencije.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            EvidencijaNastave ev = new EvidencijaNastave();
            if (dgvEvidencije.CurrentRow == null)
            {
                MessageBox.Show("Niste izabrali evidenciju za prikaz!");
            }
            else
            {
                ev = (EvidencijaNastave)dgvEvidencije.CurrentRow.DataBoundItem;
                UCPrikazEvidencijeNastave uCPrikazEvidencijeNastave = new UCPrikazEvidencijeNastave(ev);
               
                PomocnaForma pomFrm = new PomocnaForma(uCPrikazEvidencijeNastave);

                pomFrm.Show();
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            EvidencijaNastave ev = new EvidencijaNastave();
            if (dgvEvidencije.CurrentRow == null)
            {
                MessageBox.Show("Niste izabrali evidenciju za prikaz!");
            }
            else
            {

                ev = (EvidencijaNastave)dgvEvidencije.CurrentRow.DataBoundItem;
                UCPrikazEvidencijeNastave uCPrikazEvidencijeNastave = new UCPrikazEvidencijeNastave(ev, Utils.WorkMode.UPDATE);
                PomocnaForma pomFrm = new PomocnaForma(uCPrikazEvidencijeNastave);
                pomFrm.Show();
            }
        }

        private void btnRestart1_Click(object sender, EventArgs e)
        {
            cbUcitelj.SelectedItem = null;
        }

        private void btnRestart2_Click(object sender, EventArgs e)
        {
            cbUcenik.SelectedItem = null;
        }

        private void btnRestart3_Click(object sender, EventArgs e)
        {
            cbGrupa.SelectedItem = null;
        }

        private void btnOcistiFiltere_Click(object sender, EventArgs e)
        {
            cbUcitelj.SelectedItem = null;
            cbUcenik.SelectedItem = null;
            cbGrupa.SelectedItem = null;
            dgvEvidencije.DataSource = Komunikacija.Instance.VratiListuSveEvidencijeNastave();
            dgvEvidencije.Columns[0].Visible = false;
            dgvEvidencije.Columns[1].Visible = false;
            dgvEvidencije.Columns[2].Visible = false;
            dgvEvidencije.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
    }
}
