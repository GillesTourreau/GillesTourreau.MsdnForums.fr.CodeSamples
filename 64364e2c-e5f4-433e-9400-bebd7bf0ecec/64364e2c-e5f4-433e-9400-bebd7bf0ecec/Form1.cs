using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _64364e2c_e5f4_433e_9400_bebd7bf0ecec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int v1 = Convert.ToInt32(this.textBox1.Text);
            int v2 = Convert.ToInt32(this.textBox2.Text);
            int v3 = Convert.ToInt32(this.textBox3.Text);

            Calculer(new[] { v1, v2, v3 }, 0, 0);
        }

        private class Calcul
        {
            private int[] valeurs;
            private int résultat;
            private int valeurEnCours;

            private bool[] combinaisonEnCours;

            public Calcul(int[] valeurs, int résultat)
            {
                this.valeurs = valeurs;
                this.résultat = résultat;
                this.valeurEnCours = 0;

                this.combinaisonEnCours = new bool[this.valeurs.Length];
            }

            public string Calculer(int rang)
            {
                int temp;
                
                // Tester l'addition
                temp = this.valeurs[rang] + this.valeurEnCours;
                if (temp == this.résultat)
                {
                    return this.ConstruireExpression();
                }

                // Tester la multiplication
                temp = this.valeurs[rang] * this.valeurEnCours;
                if (temp == this.résultat)
                {
                    return this.ConstruireExpression();
                }

                // Tester la soustraction
                temp = this.valeurs[rang] - this.valeurEnCours;
                if (temp == this.résultat)
                {
                    return this.ConstruireExpression();
                }


            }

            private string ConstruireExpression()
            {

            }
        }
    }
}
