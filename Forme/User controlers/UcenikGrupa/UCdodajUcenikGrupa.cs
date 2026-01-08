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
    public partial class UCdodajUcenikGrupa : UserControl
    {

        Broker broker = new Broker();
        GrupaUcenika globalnaGrupa = new GrupaUcenika();

        public UCdodajUcenikGrupa(GrupaUcenika grupa)
        {
            InitializeComponent();
            globalnaGrupa = grupa;
            lblGrupa.Text = $"Učenici grupe {grupa.OznakaGrupe}";

            dgvTrenutni.DataSource = broker.vratiListuUcenika(grupa);
            foreach(DataGridViewColumn col in dgvTrenutni.Columns)
            {
                col.Visible = false;
            }
            dgvTrenutni.Columns[1].Visible = true;
            dgvTrenutni.Columns[2].Visible = true;
            dgvTrenutni.Columns[4].Visible = true;
            dgvTrenutni.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvRaspolozivi.DataSource = broker.vratiListuSviUcenici();
            foreach (DataGridViewColumn col in dgvRaspolozivi.Columns)
            {
                col.Visible = false;
            }
            dgvRaspolozivi.Columns[1].Visible = true;
            dgvRaspolozivi.Columns[2].Visible = true;
            dgvRaspolozivi.Columns[4].Visible = true;
            dgvRaspolozivi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
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
                dgvRaspolozivi.DataSource = broker.pretraziUcenikaPoImenu(ucenik);
                foreach (DataGridViewColumn col in dgvRaspolozivi.Columns)
                {
                    col.Visible = false;
                }
                dgvRaspolozivi.Columns[1].Visible = true;
                dgvRaspolozivi.Columns[2].Visible = true;
                dgvRaspolozivi.Columns[4].Visible = true;
                dgvRaspolozivi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void UCdodajUcenikGrupa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show($"Da li ste sigruni da želite da ubacite učenika u grupu {globalnaGrupa.OznakaGrupe}?", "Potvrda", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(res== DialogResult.Yes)
                {
                    try
                    {
                        broker.kreirajUcenikGrupa((Ucenik)dgvRaspolozivi.CurrentRow.DataBoundItem, globalnaGrupa);
                        MessageBox.Show("Ucenik je dodat u grupu");
                        globalnaGrupa.BrojUcenika++;
                        broker.PromeniGrupuUcenika(globalnaGrupa);
                        dgvTrenutni.DataSource = broker.vratiListuUcenika(globalnaGrupa);
                        
                        foreach (DataGridViewColumn col in dgvTrenutni.Columns)
                        {
                            col.Visible = false;
                        }
                        dgvTrenutni.Columns[1].Visible = true;
                        dgvTrenutni.Columns[2].Visible = true;
                        dgvTrenutni.Columns[4].Visible = true;
                        dgvTrenutni.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("OK");
                }
                    
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
