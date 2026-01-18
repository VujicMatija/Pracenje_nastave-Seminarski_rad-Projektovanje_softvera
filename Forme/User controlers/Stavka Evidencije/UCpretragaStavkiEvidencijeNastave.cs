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
    public partial class UCpretragaStavkiEvidencijeNastave : UserControl
    {
        //Broker broker = new Broker();

        //public UCpretragaStavkiEvidencijeNastave()
        //{
        //    InitializeComponent();
        //    cbEvidencija.DataSource = Komunikacija.Instance.VratiListuSveEvidencijeNastave();
        //    dgvStavke.DataSource = broker.vratiListuSveStavkeEvidencijeNastave();
        //    dgvStavke.Columns[0].Visible = false;
        //    cbUcenik.SelectedItem = null;
        //    cbEvidencija.SelectedItem = null;
        //}

        //private void cbEvidencija_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //    if (cbEvidencija.SelectedItem != null)
        //    {
        //        EvidencijaNastave ev = (EvidencijaNastave)cbEvidencija.SelectedItem;
        //        cbUcenik.DataSource = broker.vratiListuUcenika(ev.Grupa);
        //        cbUcenik.SelectedItem = null;
        //    }


        //}

        //private void btnPretrazi_Click(object sender, EventArgs e)
        //{


        //    if (cbEvidencija.SelectedItem != null && cbUcenik.SelectedItem != null)
        //    {
               
        //        dgvStavke.DataSource = broker.vratiListuStavkiEvidencijeNastave(en:(EvidencijaNastave)cbEvidencija.SelectedItem, ucenik:(Ucenik)cbUcenik.SelectedItem);
        //        dgvStavke.Columns[0].Visible = false;

        //    }
        //    else if (cbEvidencija.SelectedItem == null && cbUcenik.SelectedItem == null)
        //    {
        //        dgvStavke.DataSource = broker.vratiListuSveStavkeEvidencijeNastave();
        //        dgvStavke.Columns[0].Visible = false;
        //    }
        //    else if (cbEvidencija.SelectedItem == null)
        //    {
        //        dgvStavke.DataSource = broker.vratiListuStavkiEvidencijeNastave((Ucenik)cbUcenik.SelectedItem);
        //        dgvStavke.Columns[0].Visible = false;
        //    }
        //    else if (cbUcenik.SelectedItem == null)
        //    {
                
        //        dgvStavke.DataSource = broker.vratiListuStavkiEvidencijeNastave((EvidencijaNastave)cbEvidencija.SelectedItem);
        //        dgvStavke.Columns[0].Visible = false;
        //    }
        //}

        //private void btnResetuj_Click(object sender, EventArgs e)
        //{
        //    cbEvidencija.SelectedItem = null;
        //    cbUcenik.SelectedItem = null;
        //}

        //private void btnPromeni_Click(object sender, EventArgs e)
        //{
        //    UCradSaStavkomEvidencijeNastave uCradSaStavkomEvidencijeNastave = new UCradSaStavkomEvidencijeNastave((StavkaEvidencijeNastave)dgvStavke.CurrentRow.DataBoundItem); 
        //    PomocnaForma stavkaEvidencijeForma = new PomocnaForma(uCradSaStavkomEvidencijeNastave);
        //    stavkaEvidencijeForma.ShowDialog();
        //}
    }
}
