using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetForm
{
    public partial class PlateauForm : Form
    {
        public PlateauForm()
        {
            InitializeComponent();
        }

        private PictureBox creationPions(Color couleur)
        {
            PictureBox PBPion = new PictureBox();

            // Création d'une bitmap
            Bitmap bm = new Bitmap(32, 32);

            // Création d'un objet graphics pour dessiner dessus
            Graphics g = Graphics.FromImage(bm);
;
            // Ecriture sur l'objet
            LinearGradientBrush b = new LinearGradientBrush(new Rectangle(0, 0, 40, 30), couleur, Color.White, -45, false);

            // Remplissage
            g.FillEllipse(b, 0, 0, bm.Size.Width, bm.Size.Height);

            // Attribution
            PBPion.Image = bm;
            PBPion.SizeMode = PictureBoxSizeMode.StretchImage;

            return PBPion;
        }

        private void buttonColonne_Click(object sender, EventArgs e)
        {
            Point positionPionPlateau;  // Position du pion sur le palteau de jeu
            PictureBox pionJoueur; // Pion a ajouté

            int ColonneJouee;

            switch (((Button)sender).Name.ToString())
            {
                case "btnCol1":
                    ColonneJouee = 1;
                    break;
                case "btnCol2":
                    ColonneJouee = 2;
                    break;
                case "btnCol3":
                    ColonneJouee = 3;
                    break;
                case "btnCol4":
                    ColonneJouee = 4;
                    break;
                case "btnCol5":
                    ColonneJouee = 5;
                    break;
                case "btnCol6":
                    ColonneJouee = 6;
                    break;
                case "btnCol7":
                    ColonneJouee = 7;
                    break;
                default:
                    throw new Exception("Bouton inexistant");
            }

            // Crée un nouveau pion à ajouter
            pionJoueur = creationPions(Color.Red);

            // Calcule des position dans le plateau
            positionPionPlateau = new Point(ColonneJouee - 1, 0);

            // Ajout du pion sur le plateau
            plateauJeu.Controls.Add(pionJoueur, positionPionPlateau.X, positionPionPlateau.Y);
        }

        private void btnPlateauAbandon_Click(object sender, EventArgs e)
        {
            // Affichage de la group Box pour montrer le gagnant
            groupBoxWinner.Visible = true;

            // Desactivation des boutons
            List<Button> btnColList = new List<Button> {btnCol1, btnCol2 , btnCol3 , btnCol4 , btnCol5 , btnCol6 , btnCol7};

            btnColList.ForEach((btn) => btn.Enabled = false);
            btnPlateauAbandon.Enabled = false;
        }

        private void btnWinnerHome_Click(object sender, EventArgs e)
        {
            // Fermeture de la fenêtre
            Close();

            // Réouverture de la fenêtre du menu principal
            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
        }

        private void btnWinnerQuitter_Click(object sender, EventArgs e)
        {
            // Fermeture de l'application
            Application.Exit();
        }
    }
}
