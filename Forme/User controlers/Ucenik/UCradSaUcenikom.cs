using Domeni;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme.User_controlers
{
    public partial class UCradSaUcenikom : UserControl
    {

        Ucenik globalniUcenik = new Ucenik();
        
        public UCradSaUcenikom()
        {
            InitializeComponent();
            cbPol.DataSource = Enum.GetValues<Pol>();
            btnOmoguciIzmene.Visible = false;
            btnObrisi.Visible = false;
            btnIzmeni.Visible = false;
        }

        public UCradSaUcenikom(Ucenik ucenik)
        {
            InitializeComponent();
            dgvGrupe.Visible = true;
            globalniUcenik = ucenik;
            cbPol.DataSource = Enum.GetValues<Pol>();


            txtImeUcenika.Text = ucenik.ImeUcenika;
            txtPrezimeUcenika.Text = ucenik.PrezimeUcenika;
            txtImeRoditelja.Text = ucenik.ImeRoditelja;
            txtPrezimeRoditelja.Text = ucenik.PrezimeRoditelja;
            txtEmailUcenika.Text = ucenik.EmailUcenika;
            txtTelefonUcenika.Text = ucenik.TelefonUcenika;
            txtTelefonRoditelja.Text = ucenik.TelefonRoditelja;
            dateDatumRodjenja.Value = ucenik.DatumRodjenjaUcenika;
            cbPol.SelectedItem = ucenik.PolUcenika;


            btnKreiraj.Visible = false;
            dgvGrupe.DataSource = Komunikacija.Instance.vratiListuGrupaUcenika(ucenik: ucenik, ucitelj: null, kurs: null);
            foreach(DataGridViewColumn col in dgvGrupe.Columns)
            {
                col.Visible = false;
            }
            dgvGrupe.Columns[1].Visible = true;
            dgvGrupe.Columns[3].Visible = true;
            dgvGrupe.Columns[4].Visible = true;
            dgvGrupe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGrupe.Enabled = false;
            btnOmoguciIzmene.Visible = true;
            omoguciPolja(false);
            btnObrisi.Visible = false;
            btnIzmeni.Visible = false;
        }

       

       
        

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidirajUcenika())
                {
                    Ucenik ucenik = new Ucenik()
                    {
                        ImeUcenika = txtImeUcenika.Text,
                        PrezimeUcenika = txtPrezimeUcenika.Text,
                        PolUcenika = (Pol)cbPol.SelectedItem,
                        ImeRoditelja = txtImeRoditelja.Text,
                        PrezimeRoditelja = txtPrezimeRoditelja.Text,
                        TelefonRoditelja = txtTelefonRoditelja.Text,
                        DatumRodjenjaUcenika = dateDatumRodjenja.Value,
                        TelefonUcenika = txtTelefonUcenika.Text,
                        EmailUcenika = txtEmailUcenika.Text
                    };
                    try
                    {
                        Komunikacija.Instance.KreirajUcenika(ucenik);
                        MessageBox.Show("Ucenik je uspesno kreiran");
                        ocistiPolja();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Greska prilikom rada sa bazom", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }

        

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            

            try
            {
                if (ValidirajUcenika())
                {
                    Ucenik ucenik = new Ucenik()
                    {
                        IdUcenika = globalniUcenik.IdUcenika,
                        ImeUcenika = txtImeUcenika.Text,
                        PrezimeUcenika = txtPrezimeUcenika.Text,
                        ImeRoditelja = txtImeRoditelja.Text,
                        PrezimeRoditelja = txtPrezimeRoditelja.Text,
                        TelefonRoditelja = txtTelefonRoditelja.Text,
                        TelefonUcenika = txtTelefonUcenika.Text,
                        EmailUcenika = txtEmailUcenika.Text,
                        PolUcenika = (Pol)cbPol.SelectedItem,
                        DatumRodjenjaUcenika = dateDatumRodjenja.Value
                    };
                    DialogResult res = MessageBox.Show("Da li ste sigurni da želite da izmenite učenika?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        try
                        {
                            Komunikacija.Instance.PromeniUcenika(ucenik);
                            MessageBox.Show("Promene su sačuvane!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("OK");
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Da li ste sigurni da želite da obrišete učenika?", "Potvrda", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                try
                {
                    Komunikacija.Instance.ObrisiUcenika(globalniUcenik);
                    MessageBox.Show("Ucenik je obrisan!");
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("OK");
            }
        }

        private void omoguciPolja(bool x)
        {
            txtImeUcenika.Enabled = x;
            txtPrezimeUcenika.Enabled = x;
            txtImeRoditelja.Enabled = x;
            txtPrezimeRoditelja.Enabled = x;
            txtEmailUcenika.Enabled = x;
            txtTelefonUcenika.Enabled = x;
            txtTelefonRoditelja.Enabled = x;
            dateDatumRodjenja.Enabled = x;
            cbPol.Enabled = x;
        }

        private void btnOmoguciIzmene_Click(object sender, EventArgs e)
        {
            btnOmoguciIzmene.Visible = false;
            omoguciPolja(true);
            btnObrisi.Visible = true;
            btnIzmeni.Visible = true;

        }

        private void ocistiPolja()
        {
            txtImeUcenika.Text = "";
            txtPrezimeUcenika.Text = "";
            txtImeRoditelja.Text = "";
            txtPrezimeRoditelja.Text = "";
            txtTelefonRoditelja.Text = "";
            txtTelefonUcenika.Text = "";
            txtEmailUcenika.Text = "";

        }

        private bool ValidirajUcenika()
        {
            txtImeUcenika.BackColor = SystemColors.Window;
            txtPrezimeUcenika.BackColor = SystemColors.Window;
            txtImeRoditelja.BackColor = SystemColors.Window;
            txtPrezimeRoditelja.BackColor = SystemColors.Window;
            txtTelefonRoditelja.BackColor = SystemColors.Window;
            txtTelefonUcenika.BackColor = SystemColors.Window;
            txtEmailUcenika.BackColor = SystemColors.Window;
            txtImeUcenika.BackColor = SystemColors.Window;
            
            string poruka = "";
            Color boja = ColorTranslator.FromHtml("#d96f6f");
            bool uspesno = true;
            if (txtImeUcenika.Text.Length < 3)
            {
                poruka = poruka + "Ime ucenika mora biti duze od dva karaktera";
                txtImeUcenika.BackColor = boja;
            }
            if (txtPrezimeUcenika.Text.Length < 3)
            {
                poruka = poruka + "Prezime ucenika mora biti duze od dva karaktera";
                txtPrezimeUcenika.BackColor = boja;
            }
            
            if (txtEmailUcenika.Text.Contains("@") == false || txtEmailUcenika.Text.Contains(".com") == false)
            {
                poruka = poruka + "Email mora da sadrzi @ i .com";
                txtEmailUcenika.BackColor = boja;
            }

            if (txtImeRoditelja.Text.Length < 3)
            {
                poruka = poruka + "Ime roditelja mora biti duze od dva karaktera";
                txtImeRoditelja.BackColor = boja;
            }
            if (txtPrezimeRoditelja.Text.Length < 3)
            {
                poruka = poruka + "Prezime roditelja mora biti duze od dva karaktera";
                txtPrezimeRoditelja.BackColor = boja;
            }
            if (txtTelefonRoditelja.Text == txtTelefonUcenika.Text)
            {
                poruka= poruka + "Telefon roditelja i ucenika mora da se razlikuje!";
                txtTelefonRoditelja.BackColor = boja;
                txtTelefonUcenika.BackColor = boja;
            }

            if (string.IsNullOrEmpty(poruka) == false)
            {
                MessageBox.Show("Neuspesna validacija ucenika\n" + poruka);
                uspesno = false;
            }

            return uspesno;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}
