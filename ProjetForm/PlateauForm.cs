using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProjetForm
{
    public partial class PlateauForm : Form
    {
        private Puissance4 puissance4;

        public PlateauForm(Puissance4 p_Puissance4)
        {
            InitializeComponent();
            this.puissance4 = p_Puissance4;
            lblPlayerToPlay.Text = p_Puissance4.isRedPlayerToPlay() ? p_Puissance4.getJoueur1() : p_Puissance4.getJoueur2();
        }

        /// <summary>
        /// Ajout un pion sur le plateau
        /// </summary>
        /// <param name="v_PlayerPawn">Le pion du joueur</param>
        /// <param name="v_PawnPosition">La position du pion</param>
        private void AddPawnOnBoard(PictureBox v_PlayerPawn, Point v_PawnPosition)
        {
            // Ajout du pion sur le plateau
            plateauJeu.Controls.Add(v_PlayerPawn, v_PawnPosition.X, v_PawnPosition.Y);
            puissance4.setOnBoard(v_PawnPosition.Y, v_PawnPosition.X, true);
            if (puissance4.isRedPlayerToPlay())
            {
                puissance4.setRedPawnOnBoard(v_PawnPosition.Y, v_PawnPosition.X, true);
                puissance4.setRedPlayerToPlay(false);
            }
            else
            {
                puissance4.setYellowPawnOnBoard(v_PawnPosition.Y, v_PawnPosition.X, true);
                puissance4.setRedPlayerToPlay(true);
            }
        }

        /// <summary>
        /// Fait jouer l'IA
        /// </summary>
        private void aiPlay()
        {
            // Faire jouer l'IA.
        }

        /// <summary>
        /// Active l'écran de fin
        /// </summary>
        /// <param name="p_PseudoPlayerWinner">Le pseudo du joueur qui a gagné</param>
        private void EnableEndScreen(String p_PseudoPlayerWinner)
        {
            // Affichage de la group Box pour montrer le gagnant
            groupBoxWinner.Visible = true;

            // Desactivation des boutons
            List<Button> v_BtnColList = new List<Button> { btnCol1, btnCol2, btnCol3, btnCol4, btnCol5, btnCol6, btnCol7 };

            v_BtnColList.ForEach((btn) => btn.Enabled = false);
            btnPlateauAbandon.Enabled = false;

            lblWinner.Text = p_PseudoPlayerWinner + " a gagné !";
        }

        private void buttonColonne_Click(object p_Sender, EventArgs p_EventArgs)
        {
            Point v_PawnPosition;  // Position du pion sur le palteau de jeu
            PictureBox v_PlayerPawn; // Pion a ajouter

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
            v_PlayerPawn = Puissance4Manager.CreatePawn(puissance4);

            // Calcule des position dans le plateau
            v_PawnPosition = Puissance4Manager.GetPawnPosition(puissance4, v_ColumnPlayed);

            if(v_PawnPosition.X != -1)
            {
                AddPawnOnBoard(v_PlayerPawn, v_PawnPosition);   
            }

            if(Puissance4Manager.CheckIfWin(puissance4))
            {
                String v_PseudoPlayerWinner = puissance4.isRedPlayerToPlay() ? puissance4.getJoueur2() : puissance4.getJoueur1();
                EnableEndScreen(v_PseudoPlayerWinner);
            }

            lblPlayerToPlay.Text = puissance4.isRedPlayerToPlay() ? puissance4.getJoueur1() : puissance4.getJoueur2();

            if(!puissance4.isPlayerVSPlayerMode())
            {
                aiPlay();
            }
        }

        private void btnPlateauAbandon_Click(object p_Sender, EventArgs p_EventArgs)
        {
            String playerWinner = puissance4.isRedPlayerToPlay() ? puissance4.getJoueur2() : puissance4.getJoueur1();
            EnableEndScreen(playerWinner);
        }

        private void btnWinnerHome_Click(object p_Sender, EventArgs p_EventArgs)
        {
            Hide();

            // Réouverture de la fenêtre du menu principal
            HomeForm v_HomeForm = new HomeForm();
            v_HomeForm.ShowDialog();
        }

        private void btnWinnerQuitter_Click(object p_Sender, EventArgs p_EventArgs)
        {
            // Fermeture de l'application
            Application.Exit();
        }

        private void btnWinnerPlay_Click(object sender, EventArgs e)
        {
            Hide();

            // Ouverture du plateau de jeu
            Puissance4 newPuissance4 = new Puissance4(puissance4.getJoueur1(), puissance4.getJoueur2(), puissance4.isPlayerVSPlayerMode()); ;
            PlateauForm v_PlateauForm = new PlateauForm(newPuissance4);
            v_PlateauForm.ShowDialog();
        }
    }
}