using BrokerBazePodataka;
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
        Broker broker = new Broker();
        public UCPretraziEvidencijuNastave()
        {
            InitializeComponent();
            BindingList<Ucitelj> sviUcitelji = broker.vratiListuSviUcitelji();
            cbUcitelj.DataSource = sviUcitelji;
            cbUcitelj.SelectedItem = null;
            BindingList<GrupaUcenika> sveGrupeUcenika = broker.vratiListuSveGrupeUcenika();
            cbGrupa.DataSource = sveGrupeUcenika;
            cbGrupa.SelectedItem = null;
            BindingList<Ucenik> sviUcenici = broker.vratiListuSviUcenici();
            cbUcenik.DataSource = sviUcenici;
            cbUcenik.SelectedItem = null;
            dgvEvidencije.DataSource = broker.vratiListuSveEvidencijaNastave();
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
            dgvEvidencije.DataSource = broker.vratiListuEvidencijaNastave((GrupaUcenika)cbGrupa.SelectedItem, (Ucitelj)cbUcitelj.SelectedItem, (Ucenik)cbUcenik.SelectedItem, null);
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
    }
}
