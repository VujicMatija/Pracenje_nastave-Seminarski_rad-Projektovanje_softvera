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
    public partial class UCPrikazUcitelja : UserControl
    {
        Ucitelj ucitelj = new Ucitelj();
        Broker broker = new Broker();
        public UCPrikazUcitelja(Ucitelj u)
        {
            InitializeComponent();
            ucitelj = broker.pretraziUcitelja(u);
            txtIme.Text = ucitelj.ImeUcitelja;
            txtPrezime.Text = ucitelj.PrezimeUcitelja;
            txtTelefon.Text = ucitelj.Telefon;
            txtEmail.Text = ucitelj.Email;
            txtDatum.Text = ucitelj.DatumPocetkaRada.ToShortDateString();

            dgvLicence.DataSource = broker.vratiListuSertifikata(ucitelj);
            dgvLicence.Columns[0].Visible = false;
            dgvLicence.RowHeadersVisible = false;
               
            dgvGrupe.DataSource = broker.vratiGrupeUcenika(ucitelj);
            foreach(DataGridViewColumn col in dgvGrupe.Columns)
            {
                col.Visible = false;
            }
            dgvGrupe.Columns[1].Visible = true;
            dgvGrupe.RowHeadersVisible = false;
            dgvGrupe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLicence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            

        }
    }
}
