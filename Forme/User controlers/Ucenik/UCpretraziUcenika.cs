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
    public partial class UCpretraziUcenika : UserControl
    {

        

        public UCpretraziUcenika()
        {
            InitializeComponent();
            dgvUcenici.DataSource = Komunikacija.Instance.VratiListuSviUcenici();
            foreach (DataGridViewColumn col in dgvUcenici.Columns)
            {
                col.Visible = false;
            }
            dgvUcenici.Columns[1].Visible = true;
            dgvUcenici.Columns[2].Visible = true;
            dgvUcenici.Columns[4].Visible = true;
            dgvUcenici.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            Ucenik ucenik = new Ucenik();
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

                    ucenik = new Ucenik
                    {
                        ImeUcenika = char.ToUpper(ime[0]) + ime.Substring(1),
                        PrezimeUcenika = prezime != "" ? char.ToUpper(prezime[0]) + prezime.Substring(1) : ""
                    };
                }
            }
            catch
            {
                ucenik = null;
            }

            if (ucenik == null)
            {
                MessageBox.Show("Greška");
            }
            else
            {
                dgvUcenici.DataSource = Komunikacija.Instance.PretraziUcenikaPoImenu(ucenik);
                foreach(DataGridViewColumn col in dgvUcenici.Columns)
                {
                    col.Visible = false;
                }
                dgvUcenici.Columns[1].Visible = true;
                dgvUcenici.Columns[2].Visible = true;
                dgvUcenici.Columns[4].Visible = true;
                dgvUcenici.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void butnPrikaz_Click(object sender, EventArgs e)
        {
            try
            {
                Ucenik ucenik = (Ucenik)dgvUcenici.CurrentRow.DataBoundItem;
                PomocnaForma frm = new PomocnaForma(new UCradSaUcenikom(ucenik));
                frm.ShowDialog();

            }
            catch
            {
                MessageBox.Show("Greska!");
            }
        }
    }
}
