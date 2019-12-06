using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace f8537c4d_61b8_41e3_8972_e945d7eb7028
{
    public partial class FormMDI : Form
    {
        public FormMDI()
        {
            InitializeComponent();

            Form1 f;
            f = new Form1();
            f.MdiParent = this;
            f.Show();
        }

        internal void MaMéthode()
        {
            
        }
    }
}
