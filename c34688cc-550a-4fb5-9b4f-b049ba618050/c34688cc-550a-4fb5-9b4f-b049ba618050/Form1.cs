using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c34688cc_550a_4fb5_9b4f_b049ba618050
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f;
            f = new Form2();

            f.Show();
            f.SetBindingSourceOfCombo(this.bindingSource1.DataSource);
        }
    }
}
