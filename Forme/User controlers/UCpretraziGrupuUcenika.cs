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
    public partial class UCpretraziGrupuUcenika : UserControl
    {
        Broker broker = new Broker();

        public UCpretraziGrupuUcenika()
        {
            InitializeComponent();
            cbKursevi.DataSource = broker.vratiListuSviKursevi();
            cbKursevi.SelectedItem = null;

        }

        private void UCpretraziGrupuUcenika_Load(object sender, EventArgs e)
        {

        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            if(cbKursevi.SelectedItem == null)
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
    }
}
