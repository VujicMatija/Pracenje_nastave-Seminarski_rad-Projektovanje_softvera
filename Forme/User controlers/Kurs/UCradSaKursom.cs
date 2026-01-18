using Domeni;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme.User_controlers
{
    public partial class UCradSaKursom : UserControl
    {
        
        Kurs globalniKurs = new Kurs();
        public UCradSaKursom()
        {
            InitializeComponent();
            cbTezina.DataSource = Enum.GetValues<TezinaKursa>();
            cbUzrast.DataSource = Enum.GetValues<Uzrast>();
            dgvPodaci.DataSource = Komunikacija.Instance.VratiListuSviKursevi();
            foreach (DataGridViewColumn col in dgvPodaci.Columns)
            {
                col.Visible = false;
            }

            dgvPodaci.Columns[1].Visible = true;
            dgvPodaci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public UCradSaKursom(Kurs kurs)
        {
            InitializeComponent();
            globalniKurs = kurs;
            cbTezina.DataSource = Enum.GetValues<TezinaKursa>();
            cbUzrast.DataSource = Enum.GetValues<Uzrast>();
            try
            {
                dgvPodaci.DataSource = Komunikacija.Instance.VratiListuEvidencijaNastave(kurs);
                dgvPodaci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                foreach(DataGridViewColumn col in dgvPodaci.Columns)
                {
                    col.Visible = false;
                }
                dgvPodaci.Columns[4].Visible = true;
            }
            catch {  }
            InizijalizujFormu(kurs);


        }

      

        private void btnKreiraj_Click(object sender, EventArgs e)
        {

            try
            {

                if (ValidirajKurs())
                {
                    Kurs k = new Kurs()
                    {
                        NazivKursa = txtNaziv.Text,
                        TezinaKursa = (TezinaKursa)cbTezina.SelectedItem,
                        UzrastKursa = (Uzrast)cbUzrast.SelectedItem,
                        TrajanjeKursa = (int)numTrajanje.Value,
                        OznakaKursa = txtOznaka.Text
                    };
               
                    try
                    {
                        Komunikacija.Instance.KreirajKurs(k);
                        MessageBox.Show("Kurs je kreiran!");
                        dgvPodaci.DataSource = Komunikacija.Instance.VratiListuSviKursevi();
                        ResetujPolja();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

       
        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                dgvPodaci.DataSource = Komunikacija.Instance.VratiListuSviKursevi();
            }
            else
            {
                Kurs zaPretragu = new Kurs() { NazivKursa = txtNaziv.Text };
                dgvPodaci.DataSource = Komunikacija.Instance.VratiListuKurseva(zaPretragu);
                foreach (DataGridViewColumn col in dgvPodaci.Columns)
                {
                    col.Visible = false;
                }

                dgvPodaci.Columns[1].Visible = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvPodaci.CurrentRow != null)
                {
                    UCradSaKursom ucRadSaKursom = new UCradSaKursom((Kurs)dgvPodaci.CurrentRow.DataBoundItem);
                    PomocnaForma prikazKursaForma = new PomocnaForma(ucRadSaKursom);
                    prikazKursaForma.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Niste odabrali kurs!");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

      

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            try {
                if (ValidirajKurs())
                {
                    Kurs k = new Kurs()
                    {
                        IdKursa = globalniKurs.IdKursa,
                        NazivKursa = txtNaziv.Text,
                        TezinaKursa = (TezinaKursa)cbTezina.SelectedItem,
                        UzrastKursa = (Uzrast)cbUzrast.SelectedItem,
                        TrajanjeKursa = (int)numTrajanje.Value,
                        OznakaKursa = txtOznaka.Text
                    };
                    
                    DialogResult res = MessageBox.Show("Da li ste sigurni da zelite da promenite kurs?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {


                        try
                        {
                            Komunikacija.Instance.PromeniKurs(k);
                            MessageBox.Show("Kurs je promenjen!");

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

        private void btnOmoguciIzmene_Click(object sender, EventArgs e)
        {
            omoguciPolja(true);
            btnOmoguciIzmene.Visible = false;
            txtOznaka.Enabled = false;
            btnIzmeni.Visible = true;
        }

        public bool ValidirajKurs()
        {
            txtNaziv.BackColor = SystemColors.Window;
            numTrajanje.BackColor = SystemColors.Window;
            txtOznaka.BackColor = SystemColors.Window;
            Color boja = ColorTranslator.FromHtml("#d96f6f"); ;
            bool uspesno = true;
            string poruka = "";
            if (string.IsNullOrEmpty(txtNaziv.Text))
            {
                poruka = poruka + "Naziv kursa ne sme biti prazan\n";
                txtNaziv.BackColor = boja;
            }
            if (string.IsNullOrEmpty(txtOznaka.Text))
            {
                poruka = poruka + "Unesite oznaku kursa\n";
                txtOznaka.BackColor = boja;
            }
            if(numTrajanje.Value == 0)
            {
                poruka = poruka + "Kurs mora da traje makar jedan čas\n";
                numTrajanje.BackColor = boja;
            }
            if(string.IsNullOrEmpty(poruka) == false)
            {
                MessageBox.Show("Greska prilikom validacije\n" + poruka);
                uspesno = false;
            }
            return uspesno;
        }

      

        public void ResetujPolja()
        {
            txtNaziv.Text = "";
            txtOznaka.Text = "";
            cbTezina.SelectedIndex = 0;
            cbUzrast.SelectedIndex = 0;
            numTrajanje.Value = 0;
        }

        private void omoguciPolja(bool x)
        {
            numTrajanje.Enabled = x;
            cbTezina.Enabled = x;
            cbUzrast.Enabled = x;
            txtNaziv.Enabled = x;
            txtOznaka.Enabled = x;
        }

        public void InizijalizujFormu(Kurs kurs)
        {
            txtNaziv.Text = kurs.NazivKursa;
            txtOznaka.Text = kurs.OznakaKursa;
            numTrajanje.Value = kurs.TrajanjeKursa;
            cbTezina.SelectedItem = kurs.TezinaKursa;
            cbUzrast.SelectedItem = kurs.UzrastKursa;
            omoguciPolja(false);
            btnKreiraj.Visible = false;
            btnPretrazi.Visible = false;
            btnPrikazi.Visible = false;
            btnOmoguciIzmene.Visible = true;
        }

        private void UCradSaKursom_Load(object sender, EventArgs e)
        {

        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



    }


}
