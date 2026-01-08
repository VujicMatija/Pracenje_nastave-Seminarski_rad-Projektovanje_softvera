using BrokerBazePodataka;
using Domeni;
using Forme.Utils;
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
    public partial class UCPrikazEvidencijeNastave : UserControl
    {

        Broker broker = new Broker();
        EvidencijaNastave globalna = new EvidencijaNastave();
        public UCPrikazEvidencijeNastave(EvidencijaNastave evidencija, WorkMode mode = WorkMode.READ)
        {
            InitializeComponent();
            globalna = evidencija;
            cbGrupa.DataSource = broker.vratiListuSveGrupeUcenika();
            cbGrupa.SelectedItem = evidencija.Grupa;
            cbUcitelj.DataSource = broker.vratiListuSviUcitelji();
            cbUcitelj.SelectedItem = evidencija.Ucitelj;
            dgvUcenici.DataSource = broker.vratiListuUcenika(evidencija.Grupa);
            foreach (DataGridViewColumn col in dgvUcenici.Columns)
            {
                col.Visible = false;
            }
            dgvUcenici.Columns[1].Visible = true;
            dgvUcenici.Columns[2].Visible = true;
            dgvUcenici.Columns[1].HeaderText = "Ime";
            dgvUcenici.Columns[2].HeaderText = "Prezime";
            dgvUcenici.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStavke.DataSource = broker.vratiListuStavkiEvidencijeNastave(evidencija);
            dgvStavke.Columns[0].Visible = false;
            dgvStavke.Columns[dgvStavke.Columns.Count - 1].Visible = false;
            datePocetak.Value = evidencija.DatumPocetkaRada;
            chAktivna.Checked = evidencija.StatusAktivnosti;

            if (mode == WorkMode.READ)
            {
                chAktivna.Enabled = false;
                datePocetak.Enabled = false;
                cbUcitelj.Enabled = false;
                cbGrupa.Enabled = false;
                btnPromeni.Visible = false;
            }
            else if (mode == WorkMode.UPDATE)
            {
                chAktivna.Enabled = true;
                datePocetak.Enabled = true;
                cbUcitelj.Enabled = true;
                cbGrupa.Enabled = false;
                btnPromeni.Enabled = true;
                btnPromeni.Visible = true;
            }

            
        }

        private void btnPromeni_Click(object sender, EventArgs e)
        {
            EvidencijaNastave novaEvidencija = globalna;
            novaEvidencija.StatusAktivnosti = chAktivna.Checked;
            novaEvidencija.DatumPocetkaRada = datePocetak.Value;
            novaEvidencija.Ucitelj.Id = ((Ucitelj)cbUcitelj.SelectedItem).Id;
            try
            {
                broker.PromeniEvidencijuNastave(novaEvidencija);
                MessageBox.Show("Evidencija uspesno izmenjena");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            UCradSaStavkomEvidencijeNastave ucStavka = new UCradSaStavkomEvidencijeNastave(globalna);
            PomocnaForma stavkaEvidencijeForma = new PomocnaForma(ucStavka);
            stavkaEvidencijeForma.ShowDialog();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
