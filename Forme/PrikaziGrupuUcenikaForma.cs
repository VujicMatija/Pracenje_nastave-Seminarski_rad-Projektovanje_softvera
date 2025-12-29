using Forme.User_controlers;
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

namespace Forme
{
    public partial class PrikaziGrupuUcenikaForma : Form
    {
        public PrikaziGrupuUcenikaForma(UCKreirajGrupuUčenika ucPromeniGrupuUcenika)
        {
            InitializeComponent();
            panel.Controls.Clear();
           
            panel.Controls.Add(ucPromeniGrupuUcenika);
        }

        private void PrikaziGrupuUcenikaForma_Load(object sender, EventArgs e)
        {

        }
    }
}
