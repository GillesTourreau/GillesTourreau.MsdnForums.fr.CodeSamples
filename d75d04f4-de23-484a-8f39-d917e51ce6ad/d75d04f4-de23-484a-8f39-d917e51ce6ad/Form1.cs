using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace d75d04f4_de23_484a_8f39_d917e51ce6ad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
{
    this.pictureBox1.Image = Image.FromFile(listBox1.SelectedItem.ToString());
}
    }
}
