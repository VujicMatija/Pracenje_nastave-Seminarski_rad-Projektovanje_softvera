using Domeni;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forme.User_controlers
{
    public partial class UCRadSaEvidencijomNastave : UserControl
    {

        
        BindingList<StavkaEvidencijeNastave> stavke = new BindingList<StavkaEvidencijeNastave>();

        public UCRadSaEvidencijomNastave()
        {
            InitializeComponent();

            dateDatumStavke.MaxDate = DateTime.Today;
            datePocetakRada.MaxDate = DateTime.Today;

            cbGrupa.MouseWheel += (s, e) =>
            {
                ((HandledMouseEventArgs)e).Handled = true;
            };

            cbRBCasa.MouseWheel += (s, e) =>
            {
                ((HandledMouseEventArgs)e).Handled = true;
            };

            cbUcenici.MouseWheel += (s, e) =>
            {
                ((HandledMouseEventArgs)e).Handled = true;
            };

            cbUcitelj.MouseWheel += (s, e) =>
            {
                ((HandledMouseEventArgs)e).Handled = true;
            };




            BindingList<Ucitelj> sviUcitelji = Komunikacija.Instance.VratiListuSviUcitelji();
            cbUcitelj.DataSource = sviUcitelji;
            cbUcitelj.SelectedItem = null;
            BindingList<GrupaUcenika> dostupneGrupeUcenika = Komunikacija.Instance.vratiListuSlobodneGrupe();
            cbGrupa.DataSource = dostupneGrupeUcenika;
            if (dostupneGrupeUcenika.IsNullOrEmpty())
            {
                MessageBox.Show("Nema slobodnih grupa!");
            }
            cbGrupa.SelectedItem = null;
            cbUcenici.DataSource = null;
            cbRBCasa.DataSource = null;
            dgvStavke.DataSource = stavke;
            dgvStavke.Columns[0].Visible = false;
            dgvStavke.Columns[1].Visible = false;
            dgvStavke.Columns[7].Visible = false;
            dgvStavke.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void UCRadSaEvidencijomNastave_Load(object sender, EventArgs e)
        {

        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            if (cbGrupa.SelectedItem == null || cbUcitelj.SelectedItem == null)
            {
                MessageBox.Show("Morate popuniti sva polja!", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EvidencijaNastave unos = new EvidencijaNastave
                {
                    StatusAktivnosti = chAktivna.Checked,
                    Ucitelj = (Ucitelj)cbUcitelj.SelectedItem,
                    Grupa = (GrupaUcenika)cbGrupa.SelectedItem,
                    DatumPocetkaRada = datePocetakRada.Value

                };

                DialogResult res = MessageBox.Show("Da li ste sigurni da zelite da kreirate evidenciju nastave?", "Potvrda", MessageBoxButtons.YesNo);
                if(res == DialogResult.Yes)
                {
                    try
                    {
                        Komunikacija.Instance.KreirajEvidencijuNastave(unos, stavke);
                        MessageBox.Show("Uspesan unos");
                        resetujFormu();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("OK!");
                }
               
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void cbGrupa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            

            if (stavke.IsNullOrEmpty() == false)
            {
                DialogResult res = MessageBox.Show("Da li ste sigurni da zelite da promenite grupu? Trenutno unete stavke ce biti ponistene!", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                {
                    try
                    {
                        cbGrupa.SelectedIndex = trenutniIndex;
                        cbUcenici.DataSource = Komunikacija.Instance.VratiListuUcenika(trenutnaGrupa);
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                }
                else
                {
                    stavke.Clear();
                }
            }

        }

        private void cbGrupa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGrupa.SelectedItem != null)
            {

                if (stavke.Count == 0)
                {
                    GrupaUcenika novaGrupa = (GrupaUcenika)cbGrupa.SelectedItem;
                    cbUcenici.DataSource = Komunikacija.instance.VratiListuUcenika(novaGrupa);
                    Kurs k = Komunikacija.Instance.PretraziKurs(new Kurs() { IdKursa = novaGrupa.Kurs.IdKursa });
                    cbRBCasa.DataSource = Enumerable.Range(1, Komunikacija.Instance.PretraziKurs(k).TrajanjeKursa).ToList();
                }
                else
                {
                    if(trenutniIndex >= 0)
                    {
                        cbGrupa.SelectedIndex = trenutniIndex;
                        cbGrupa.SelectedItem = trenutnaGrupa;
                        cbUcenici.DataSource = Komunikacija.instance.VratiListuUcenika(trenutnaGrupa);
                        Kurs k = Komunikacija.instance.PretraziKurs(new Kurs() { IdKursa = trenutnaGrupa.Kurs.IdKursa });
                        cbRBCasa.DataSource = Enumerable.Range(1, Komunikacija.Instance.PretraziKurs(k).TrajanjeKursa).ToList();
                    }
                    

                }

            }

        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            txtKomentar.BackColor = SystemColors.Window;
            try
            {
                if(txtKomentar.Text.Length < 11)
                {
                    MessageBox.Show("Komentar mora biti duzi od 10 karaktera");
                    txtKomentar.BackColor = ColorTranslator.FromHtml("#d96f6f");
                }
                else
                {
                    StavkaEvidencijeNastave stavka = new StavkaEvidencijeNastave()
                    {
                        Prisustvo = chPrisustvo.Checked,
                        Komentar = txtKomentar.Text,
                        DatumOdrzavanja = dateDatumStavke.Value,
                        UradjenDomaci = chDomaci.Checked,
                        RedniBrojCasa = (int)cbRBCasa.SelectedItem,
                        Ucenik = (Ucenik)cbUcenici.SelectedItem
                    };
                    stavke.Add(stavka);
                    resetujStavku();
                }
                    
            }catch(Exception ex)
            {
                MessageBox.Show("Unos stavke neuspesan, probajte ponovo!");
            }
           

        }


        int trenutniIndex = 0;
        GrupaUcenika trenutnaGrupa;
        private void cbGrupa_DropDown(object sender, EventArgs e)
        {
            trenutniIndex = cbGrupa.SelectedIndex;
            trenutnaGrupa = (GrupaUcenika)cbGrupa.SelectedItem;
        }

        private void resetujStavku()
        {
            txtKomentar.Text = "";
            cbUcenici.SelectedIndex = -1;
            cbRBCasa.SelectedIndex = -1;
            chPrisustvo.Checked = false;
            chDomaci.Checked = false;
            dateDatumStavke.Value = DateTime.Today;
        }

        private void resetujFormu()
        {
            BindingList<GrupaUcenika> dostupneGrupeUcenika = Komunikacija.Instance.vratiListuSlobodneGrupe();
            cbGrupa.DataSource = dostupneGrupeUcenika;
            cbGrupa.SelectedIndex = -1;
            cbUcenici.DataSource = Komunikacija.Instance.VratiListuUcenika((GrupaUcenika)cbGrupa.SelectedItem);
            cbUcitelj.SelectedIndex = -1;
            chAktivna.Checked = false;
            datePocetakRada.Value = DateTime.Today;
            dateDatumStavke.Value = DateTime.Today;
            txtKomentar.Text = "";
            cbUcenici.SelectedIndex = -1;
            cbRBCasa.SelectedIndex = -1;
            chPrisustvo.Checked = false;
            chDomaci.Checked = false;
            dateDatumStavke.Value = DateTime.Today;
            stavke.Clear();
        }
    }
}
