using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProjetForm
{
    public partial class PlateauForm : Form
    {
        public PlateauForm()
        {
            InitializeComponent();
        }

        private PictureBox creationPions(Color p_Color)
        {
            PictureBox v_PBBoxPawn = new PictureBox();

            // Création d'une bitmap
            Bitmap v_Bitmap = new Bitmap(32, 32);

            // Création d'un objet graphics pour dessiner dessus
            Graphics v_Graphics = Graphics.FromImage(v_Bitmap);
            ;
            // Ecriture sur l'objet
            LinearGradientBrush v_LinearGradientBrush = new LinearGradientBrush(new Rectangle(0, 0, 40, 30), p_Color, Color.White, -45, false);

            // Remplissage
            v_Graphics.FillEllipse(v_LinearGradientBrush, 0, 0, v_Bitmap.Size.Width, v_Bitmap.Size.Height);

            // Attribution
            v_PBBoxPawn.Image = v_Bitmap;
            v_PBBoxPawn.SizeMode = PictureBoxSizeMode.StretchImage;

            return v_PBBoxPawn;
        }

        private void buttonColonne_Click(object p_Sender, EventArgs p_EventArgs)
        {
            Point v_PawnPosition;  // Position du pion sur le palteau de jeu
            PictureBox v_PlayerPawn; // Pion a ajouté

            int v_ColumnPlayed;
            switch (((Button)p_Sender).Name.ToString())
            {
                case "btnCol1":
                    v_ColumnPlayed = 1;
                    break;

                case "btnCol2":
                    v_ColumnPlayed = 2;
                    break;

                case "btnCol3":
                    v_ColumnPlayed = 3;
                    break;

                case "btnCol4":
                    v_ColumnPlayed = 4;
                    break;

                case "btnCol5":
                    v_ColumnPlayed = 5;
                    break;

                case "btnCol6":
                    v_ColumnPlayed = 6;
                    break;

                case "btnCol7":
                    v_ColumnPlayed = 7;
                    break;

                default:
                    //TODO should resolv this error
                    throw new Exception("Bouton inexistant");
            }

            // Crée un nouveau pion à ajouter
            v_PlayerPawn = creationPions(Color.Red);

            // Calcule des position dans le plateau
            v_PawnPosition = new Point(v_ColumnPlayed - 1, 0);

            // Ajout du pion sur le plateau
            plateauJeu.Controls.Add(v_PlayerPawn, v_PawnPosition.X, v_PawnPosition.Y);
        }

        private void btnPlateauAbandon_Click(object p_Sender, EventArgs p_EventArgs)
        {
            // Affichage de la group Box pour montrer le gagnant
            groupBoxWinner.Visible = true;

            // Desactivation des boutons
            List<Button> v_BtnColList = new List<Button> { btnCol1, btnCol2, btnCol3, btnCol4, btnCol5, btnCol6, btnCol7 };

            v_BtnColList.ForEach((btn) => btn.Enabled = false);
            btnPlateauAbandon.Enabled = false;
        }

        private void btnWinnerHome_Click(object p_Sender, EventArgs p_EventArgs)
        {
            // Fermeture de la fenêtre
            Close();

            // Réouverture de la fenêtre du menu principal
            HomeForm v_HomeForm = new HomeForm();
            v_HomeForm.ShowDialog();
        }

        private void btnWinnerQuitter_Click(object p_Sender, EventArgs p_EventArgs)
        {
            // Fermeture de l'application
            Application.Exit();
        }
    }
}