using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _46f604a0_1458_4786_aa61_8ebfaacb8d28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {          
            DataRow dataRowDansDataTable;
            dataRowDansDataTable = ((DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row;
        }
    }
}
