using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _537b7895_4ed6_4998_b0c1_6193a3b2dcb1
{
public partial class Form1 : Form
{
    private UserControl userControlCourant;

    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        // Supprimer le UserControl courant de la fenêtre si existant
        if (this.userControlCourant != null)
        {
            this.Controls.Remove(this.userControlCourant);
        }

        // Créer le nouveau UserControl (ici vous devez appliquer vos conditions pour créer
        // le bon UserControl).
        this.userControlCourant = new MyUserControl();

        // Positionner le UserControl
        this.userControlCourant.Left = 16;
        this.userControlCourant.Top = 64;
            
        // Dimensionner le UserControl
        this.userControlCourant.Width = 100;
        this.userControlCourant.Height = 200;

        // Ajouter le UserControl dans la fenêtre
        this.Controls.Add(this.userControlCourant);
    }
}
}
