using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01d7cd67_0d7b_4edb_9cea_8778244b2550
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.listView1.Items.Add(new ListViewItem(new[] { "A", "B", "C" }));
            this.listView1.Items.Add(new ListViewItem(new[] { "A", "B", "C" }));
            this.listView1.Items.Add(new ListViewItem(new[] { "A", "B", "C" }));
            this.listView1.Items.Add(new ListViewItem(new[] { "A", "B", "C" }));
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
