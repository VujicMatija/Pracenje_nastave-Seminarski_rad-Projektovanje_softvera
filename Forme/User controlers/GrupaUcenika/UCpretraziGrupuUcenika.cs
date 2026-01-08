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
    public partial class UCpretraziGrupuUcenika : UserControl
    {
        Broker broker = new Broker();

        public UCpretraziGrupuUcenika()
        {
            InitializeComponent();
            cbKursevi.DataSource = broker.vratiListuSviKursevi();
            cbKursevi.SelectedItem = null;
            dgvGrupeUcenika.DataSource = broker.vratiListuSveGrupeUcenika();
            dgvGrupeUcenika.Columns[0].Visible = false;

        }

        private void UCpretraziGrupuUcenika_Load(object sender, EventArgs e)
        {

        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            if (cbKursevi.SelectedItem == null)
            {
                dgvGrupeUcenika.DataSource = broker.vratiListuSveGrupeUcenika();
                dgvGrupeUcenika.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvGrupeUcenika.Columns[0].Visible = false;
            }
            else
            {
                dgvGrupeUcenika.DataSource = broker.vratiListuGrupaUcenika((Kurs)cbKursevi.SelectedItem);
                dgvGrupeUcenika.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvGrupeUcenika.Columns[0].Visible = false;

            }
        }

        private void dgvGrupeUcenika_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPrikaziGrupu_Click(object sender, EventArgs e)
        {
            if(dgvGrupeUcenika.SelectedRows != null)
            {
               
                UCKreirajGrupuUčenika ucPromeniGrupuUcenika = new UCKreirajGrupuUčenika(WorkMode.READ, (GrupaUcenika)dgvGrupeUcenika.CurrentRow.DataBoundItem);
                PomocnaForma frm = new PomocnaForma(ucPromeniGrupuUcenika);
                frm.ShowDialog();
               
            }
            else
            {
                MessageBox.Show("Morate odabrati grupu učenika", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
