using BrokerBazePodataka;
using Domeni;
using Microsoft.IdentityModel.Tokens;
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
    public partial class UCRadSaEvidencijomNastave : UserControl
    {

        Broker broker = new Broker();

        public UCRadSaEvidencijomNastave()
        {
            InitializeComponent();
            BindingList<Ucitelj> sviUcitelji = broker.vratiListuSviUcitelji();
            cbUcitelj.DataSource = sviUcitelji;
            cbUcitelj.SelectedItem = null;
            BindingList<GrupaUcenika> dostupneGrupeUcenika = broker.vratiListuSlobodneGrupe();
            cbGrupa.DataSource = dostupneGrupeUcenika;
            if (dostupneGrupeUcenika.IsNullOrEmpty())
            {
                MessageBox.Show("Nema slobodnih grupa!");
            }
            cbGrupa.SelectedItem = null;
        }

        private void UCRadSaEvidencijomNastave_Load(object sender, EventArgs e)
        {

        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            if (cbGrupa.SelectedItem == null || cbUcitelj.SelectedItem == null)
            {
                MessageBox.Show("Morate popuniti sva polja!", "Greska!",MessageBoxButtons.OK,MessageBoxIcon.Error);
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

                
                try
                {
                    broker.KreirajEvidencijuNastave(unos);
                    MessageBox.Show("Uspesan unos");
                    BindingList<GrupaUcenika> dostupneGrupeUcenika = broker.vratiListuSlobodneGrupe();
                    cbGrupa.DataSource = dostupneGrupeUcenika;
                    if (dostupneGrupeUcenika.IsNullOrEmpty())
                    {
                        MessageBox.Show("Nema slobodnih grupa!");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
