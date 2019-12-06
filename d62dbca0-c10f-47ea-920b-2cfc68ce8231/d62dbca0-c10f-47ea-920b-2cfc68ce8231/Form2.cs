using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace d62dbca0_c10f_47ea_920b_2cfc68ce8231
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Récupération de la fenête MDI parent
            MaMdiParent parent;
            parent = (MaMdiParent)this.MdiParent;

            parent.monMenu.Visible = false;


        }
    }
}
