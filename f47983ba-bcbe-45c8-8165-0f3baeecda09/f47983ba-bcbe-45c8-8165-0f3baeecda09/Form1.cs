using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace f47983ba_bcbe_45c8_8165_0f3baeecda09
{
    public partial class Form1 : Form
    {
        private PictureBox[,] plateauJeu;

        private Dictionary<PictureBox, Point> coordonnées;

        private const int largeurCase = 40;

        private const int espaceCase = 10;

        public Form1()
        {
            InitializeComponent();

            this.InitializerPlateau();   
        }

        private void InitializerPlateau()
        {
            // Créer un plateau de jeux
            this.plateauJeu = new PictureBox[7, 6];
            this.coordonnées = new Dictionary<PictureBox, Point>();

            for (int x = 0; x < this.plateauJeu.GetLength(0); x++)
            {
                for (int y = 0; y < this.plateauJeu.GetLength(1); y++)
                {
                    // Créer une picture box vide
                    PictureBox caseVide;
                    caseVide = new PictureBox();
                    caseVide.BackColor = Color.White;

                    // Lui donner son abscisse et sa largeur
                    caseVide.Left = (largeurCase + espaceCase) * x;
                    caseVide.Width = largeurCase;

                    // Lui donner son ordonnée et sa hauteur
                    caseVide.Top = (largeurCase + espaceCase) * y;
                    caseVide.Height = largeurCase;

                    // L'affecter dans le tableau de plateau de jeu
                    this.plateauJeu[x, y] = caseVide;

                    // Ajouter la case dans un dictionnaire pour retrouver ses coordonnées si nécessaire
                    this.coordonnées.Add(caseVide, new Point(x, y));

                    this.Controls.Add(caseVide);
                }
            }

            // Initialiser l'événement clic pour les cases du haut
            for (int x = 0; x < this.plateauJeu.GetLength(0); x++)
            {
                this.plateauJeu[x, 0].MouseClick += OnPictureBoxDuDébutClick;
            }
        }

        private void OnPictureBoxDuDébutClick(object sender, MouseEventArgs e)
        {
            // Récupérer les "coordonées" de la picture box
            Point p;
            p = this.coordonnées[(PictureBox)sender];

            // Faire tomber le jeton
            for (int y = this.plateauJeu.GetLength(1) - 1; y >= 0; y--)
            {
                if (this.plateauJeu[p.X, y].BackColor == Color.White)
                {
                    this.plateauJeu[p.X, y].BackColor = Color.Red;
                    break;
                }
            }
        }
    }
}
