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
    public partial class UCKreirajGrupuUčenika : UserControl
    {
        List<string> sati = new List<string>() { "10:00h", "12:00h", "14:00h", "16:00h", "18:00h", "20:00h" };
        GrupaUcenika globalnaGrupa = new GrupaUcenika();
        List<string> zauzetiTermini = new List<string>();
        

        public UCKreirajGrupuUčenika(WorkMode mode = WorkMode.CREATE, GrupaUcenika grupa = null)
        {
            InitializeComponent();
            zauzetiTermini = Komunikacija.Instance.VratiZauzeteTermine();
            cbKursevi.DataSource = Komunikacija.Instance.VratiListuSviKursevi();
            cbDani.DataSource = Enum.GetNames(typeof(Dani));
            cbSati.DataSource = sati;
            txtTermin.Visible = false;
            btnObrisi.Visible = false;
            if (mode == WorkMode.CREATE)
            {
                btnKreiraj.Visible = true;
                btnIzmeni.Visible = false;
                txtTermin.Visible = false;
                numBrojUcenika.Visible = false;
                lblBrojUcenika.Visible = false;
                dgvUcenici.Visible = false;
                lblUcenici.Visible = false;
                btnDodajUcenika.Visible = false;
                slika.Visible = true;
            }
            else if (mode == WorkMode.UPDATE)
            {
                slika.Visible = false;
                btnKreiraj.Visible = false;
                btnOmoguciIzmene.Visible = false;
                btnIzmeni.Visible = true;
                txtTermin.Visible = false;
                cbDani.Enabled = true;
                cbSati.Enabled = true;
                numBrojUcenika.Visible = true;
                numBrojUcenika.Enabled = false;
                lblBrojUcenika.Visible = true;
                btnObrisi.Visible = true;
                btnDodajUcenika.Visible = true;
                dgvUcenici.DataSource = Komunikacija.Instance.VratiListuUcenika(grupa);
                foreach (DataGridViewColumn col in dgvUcenici.Columns)
                {
                    col.Visible = false;
                }
                dgvUcenici.Columns[1].Visible = true;
                dgvUcenici.Columns[2].Visible = true;
                dgvUcenici.Columns[4].Visible = true;
                dgvUcenici.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            }
            else if (mode == WorkMode.READ)
            {
                slika.Visible = false;
                globalnaGrupa = grupa;
                cbKursevi.SelectedItem = grupa.Kurs;
                numBrojUcenika.Value = grupa.BrojUcenika;
                txtTermin.Text = grupa.Termin;
                txtOznaka.Text = grupa.OznakaGrupe;
                cbKursevi.Enabled = false;
                numBrojUcenika.Enabled = false;
                cbDani.Visible = false;
                cbSati.Visible = false;
                txtOznaka.Enabled = false;
                btnHint.Visible = false;
                btnIzmeni.Visible = false;
                btnKreiraj.Visible = false;
                btnOmoguciIzmene.Visible = true;
                txtTermin.Visible = true;
                txtTermin.Enabled = false;
                btnObrisi.Visible = false;
                numBrojUcenika.Visible = true;
                lblBrojUcenika.Visible = true;
                btnDodajUcenika.Visible = false;
                dgvUcenici.DataSource = Komunikacija.Instance.VratiListuUcenika(grupa);
                foreach (DataGridViewColumn col in dgvUcenici.Columns)
                {
                    col.Visible = false;
                }
                dgvUcenici.Columns[1].Visible = true;
                dgvUcenici.Columns[2].Visible = true;
                dgvUcenici.Columns[4].Visible = true;
                dgvUcenici.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOznaka.Text = formirajOznakuGrupe();
        }

        private string formirajOznakuGrupe()
        {
            if (cbKursevi.SelectedItem != null && cbDani.SelectedItem != null && cbSati.SelectedItem != null)
            {
                return $"{((Kurs)(cbKursevi.SelectedItem)).OznakaKursa}_{(cbDani.SelectedItem).ToString().Substring(0, 3)}_{cbSati.SelectedItem.ToString().Substring(0, 2)}";
            }
            else
            {
                return string.Empty;
            }


        }

        private void cbKursevi_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOznaka.Text = formirajOznakuGrupe();
        }

        private void cbDani_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOznaka.Text = formirajOznakuGrupe();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            GrupaUcenika grupa = new GrupaUcenika()
            {
                BrojUcenika = (int)numBrojUcenika.Value,
                Kurs = new Kurs
                {
                    IdKursa = ((Kurs)cbKursevi.SelectedItem).IdKursa
                },
                Termin = cbDani.SelectedItem + " " + cbSati.SelectedItem,
                OznakaGrupe = txtOznaka.Text
            };
            if (zauzetiTermini.Contains(grupa.Termin))
            {
                MessageBox.Show("Ovaj termin je vec zauzet, nije moguce kreirati grupu ucenika u tom terminu!");
                return;
            }

            try
            {
                DialogResult res = MessageBox.Show("Da li želite da kreirate grupu učenika?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    Komunikacija.Instance.KreirajGrupuUcenika(grupa);
                    zauzetiTermini = Komunikacija.Instance.VratiZauzeteTermine();
                    MessageBox.Show("Grupa učenika je uspešno kreirana!");
                }
                else
                {
                    MessageBox.Show("OK");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

  

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            slika.Visible = false;
            GrupaUcenika grupa = new GrupaUcenika()
            {
                BrojUcenika = (int)numBrojUcenika.Value,
                Kurs = new Kurs
                {
                    IdKursa = ((Kurs)cbKursevi.SelectedItem).IdKursa
                },
                Termin = cbDani.SelectedItem + " " + cbSati.SelectedItem,
                OznakaGrupe = txtOznaka.Text,
                IdGrupe = globalnaGrupa.IdGrupe
            };
            if (zauzetiTermini.Contains(grupa.Termin))
            {
                MessageBox.Show("Ovaj termin je vec zauzet, nije moguce kreirati grupu ucenika u tom terminu!");
                return;
            }
            try
            {
                Komunikacija.Instance.PromeniGrupuUcenika(grupa);
                MessageBox.Show("Promene su sačuvane!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnOmoguciIzmene_Click(object sender, EventArgs e)
        {
            btnOmoguciIzmene.Visible = false;
            slika.Visible = false;
            btnKreiraj.Visible = false;
            btnIzmeni.Visible = true;
            cbDani.Enabled = true;
            cbSati.Enabled = true;
            cbKursevi.Enabled = true;
            numBrojUcenika.Enabled = true;
            txtOznaka.Enabled = false;
            btnHint.Visible = true;
            btnIzmeni.Visible = true;
            btnKreiraj.Visible = false;
            cbDani.Visible = true;
            cbSati.Visible = true;
            btnObrisi.Visible = false;
            txtTermin.Visible = false;
            btnObrisi.Visible = true;
            btnDodajUcenika.Visible = true;
            numBrojUcenika.Enabled = false;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Da li ste sigurni da želite da obrišete grupu učenika?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Komunikacija.Instance.ObrisiGrupuUcenika(globalnaGrupa);
                MessageBox.Show("Grupa je obrisana");
            }
            else
            {
                MessageBox.Show("Grupa nije obrisana");
            }
        }

        private void UCKreirajGrupuUčenika_Load(object sender, EventArgs e)
        {

        }

        private void btnDodajUcenika_Click(object sender, EventArgs e)
        {
            UCdodajUcenikGrupa ucDodajUcenikGrupa = new UCdodajUcenikGrupa(globalnaGrupa);
            PomocnaForma frm = new PomocnaForma(ucDodajUcenikGrupa);
            frm.ShowDialog();
        }

        public string ispisZauzetihTermina()
        {
            List<string> dani = Enum.GetNames<Dani>().ToList();
            List<string> sveKombinacije = dani.SelectMany(dan => sati, (dan, sati) => $"{dan} {sati}").ToList();
            List<string> slobodni = sveKombinacije.Except(zauzetiTermini).ToList();
            string ispis = "\n";
            foreach(string s in slobodni)
            {
                ispis = ispis + s + "\n";
                //ispis.Concat(s + "\n");
            }
            return ispis;
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            zauzetiTermini = Komunikacija.Instance.VratiZauzeteTermine();
            MessageBox.Show($"Slobodni termini su {ispisZauzetihTermina()}");
        }
    }
}
