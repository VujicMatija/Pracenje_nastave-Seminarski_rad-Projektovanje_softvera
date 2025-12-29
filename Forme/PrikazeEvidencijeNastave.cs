using Forme.User_controlers;
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
    public partial class PrikazeEvidencijeNastave : Form
    {
        public PrikazeEvidencijeNastave(UCPrikazEvidencijeNastave uc)
        {
            InitializeComponent();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }
    }
}
