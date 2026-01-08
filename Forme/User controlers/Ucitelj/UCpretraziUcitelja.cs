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
    public partial class UCpretraziUcitelja : UserControl
    {
        Broker broker = new Broker();
        public UCpretraziUcitelja()
        {
            InitializeComponent();

            cbSertifikati.DataSource = broker.vratiListuSviSertifikati();
            cbSertifikati.SelectedItem = null;
            dgvUcitelji.DataSource = broker.vratiListuSviUcitelji();
            foreach (DataGridViewColumn col in dgvUcitelji.Columns)
            {
                col.Visible = false;
            }
            dgvUcitelji.Columns[1].Visible = true;
            dgvUcitelji.Columns[2].Visible = true;
            dgvUcitelji.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ucitelj u = new Ucitelj()
            //{
            //    ImeUcitelja = "",
            //    PrezimeUcitelja = ""
            //};
            //Sertifikat s = new Sertifikat
            //{
            //    IdSertifikata = 1
            //};
            //dgvUcitelji.DataSource = broker.vratiListuUcitelja(u);
            Ucitelj u = new Ucitelj();
            Sertifikat s = (Sertifikat)cbSertifikati.SelectedItem;

            try
            {
                if (string.IsNullOrEmpty(txtImePrezime.Text) == false)
                {

                    string[] uc = txtImePrezime.Text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string ime = uc[0] != null ? uc[0] : "";
                    string prezime = "";
                    try
                    {
                        prezime = uc[1] != null ? uc[1] : "";
                    }
                    catch
                    {
                        prezime = "";
                    }

                    u = new Ucitelj
                    {
                        ImeUcitelja = ime,
                        PrezimeUcitelja = prezime
                    };
                }
            }
            catch
            {
                u = null;
            }



            if (s == null && u != null)
            {
                dgvUcitelji.DataSource = broker.vratiListuUcitelja(u);
            }
            else if (u == null && s != null)
            {
                dgvUcitelji.DataSource = broker.vratiListuUcitelja(s);
            }
            else
            {
                dgvUcitelji.DataSource = broker.vratiListuUcitelja(u, s);
            }
            foreach (DataGridViewColumn col in dgvUcitelji.Columns)
            {
                col.Visible = false;
            }
            dgvUcitelji.Columns[1].Visible = true;
            dgvUcitelji.Columns[2].Visible = true;
            dgvUcitelji.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnResetuj_Click(object sender, EventArgs e)
        {

            cbSertifikati.SelectedItem = null;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                UCPrikazUcitelja uCPrikazUcitelja = new UCPrikazUcitelja((Ucitelj)dgvUcitelji.CurrentRow.DataBoundItem);
                PomocnaForma frm = new PomocnaForma(uCPrikazUcitelja);
                frm.Show();
                

            }
            catch(Exception ex)
            {
                MessageBox.Show("Odaberite ucitelja za prikaz!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void UCpretraziUcitelja_Load(object sender, EventArgs e)
        {

        }
    }
}
