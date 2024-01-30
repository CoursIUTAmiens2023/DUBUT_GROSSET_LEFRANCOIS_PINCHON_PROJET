﻿using R5._08.Project.Forms.Models;
using System;
using System.Windows.Forms;

namespace ProjetForm
{
    public partial class GameModeForm : Form
    {
        public GameModeForm()
        {
            InitializeComponent();
        }

        private void radioButtonPlayerVsPlayer_CheckedChanged(object p_Sender, EventArgs p_EventArgs)
        {
            // Affichage (ou non) des groupBox en fonction des radioButtons
            groupBoxGameModePlayerVSPlayerInput1.Visible = true;
            groupBoxGameModePlayerVSPlayerInput2.Visible = false;
        }

        private void radioButtonPlayerVsIA_CheckedChanged(object p_Sender, EventArgs p_EventArgs)
        {
            // Affichage (ou non) des groupBox en fonction des radioButtons
            groupBoxGameModePlayerVSPlayerInput1.Visible = false;
            groupBoxGameModePlayerVSPlayerInput2.Visible = true;
        }

        private void btnGameModeBack_Click(object p_Sender, EventArgs p_EventArgs)
        {
            
            Hide();

            // Réouvre la page Home
            HomeForm v_HomeForm = new HomeForm();
            v_HomeForm.ShowDialog();
        }

        private void inputPseudoPlayer1_Enter(object p_Sender, EventArgs p_EventArgs)
        {
            if(inputPseudoPlayer1.Text.Equals("Joueur 1"))
            {
                inputPseudoPlayer1.Clear();
            }
        }

        private void inputPseudoPlayer2_Enter(object p_Sender, EventArgs p_EventArgs)
        {
            if (inputPseudoPlayer2.Text.Equals("Joueur 2"))
            {
                inputPseudoPlayer2.Clear();
            }
        }

        private void inputPseudoPlayer_Enter(object p_Sender, EventArgs p_EventArgs)
        {
            if (inputPseudoPlayer.Text.Equals("Pseudo"))
            {
                inputPseudoPlayer.Clear();
            }
        }

        private void btnGameModePlay_Click(object p_Sender, EventArgs p_EventArgs)
        {

            if (radioButtonPlayerVSPlayer.Checked)
            {
                bool v_PseudoAreCorrect = CheckPseudoPlayerVSPlayer();
                if (v_PseudoAreCorrect)
                {
                    StartGame();
                }
            }
            else if (radioButtonPlayerVSAi.Checked)
            {
                bool v_PseudoAreCorrect = CheckPseudoPlayerVSAi();
                if (v_PseudoAreCorrect)
                {
                    StartGame();
                }
            } 
        }

        private bool CheckPseudoPlayerVSPlayer()
        {
            bool v_PseudoAreCorrect = true;

            if (inputPseudoPlayer1.Text.Length <= 0)
            {
                errorProviderInputPseudoPlayer1.SetError(inputPseudoPlayer1, "Le pseudo ne peut pas être vide !");
                v_PseudoAreCorrect = false;
            }
            else if (inputPseudoPlayer1.Text.Length > 10)
            {
                errorProviderInputPseudoPlayer1.SetError(inputPseudoPlayer1, "Le pseudo ne peut pas excéder 10 caractères !");
                v_PseudoAreCorrect = false;
            } else
            {
                errorProviderInputPseudoPlayer1.SetError(inputPseudoPlayer1, "");
            }
            
            if (inputPseudoPlayer2.Text.Length <= 0)
            {
                errorProviderInputPseudoPlayer2.SetError(inputPseudoPlayer2, "Le pseudo ne peut pas être vide !");
                v_PseudoAreCorrect = false;
            }
            else if (inputPseudoPlayer2.Text.Length > 10)
            {
                errorProviderInputPseudoPlayer2.SetError(inputPseudoPlayer2, "Le pseudo ne peut pas excéder 10 caractères !");
                v_PseudoAreCorrect = false;
            } else
            {
                errorProviderInputPseudoPlayer2.SetError(inputPseudoPlayer2, "");
            }

            return v_PseudoAreCorrect;
        }

        private bool CheckPseudoPlayerVSAi()
        {
            bool v_PseudoAreCorrect = true;

            if (inputPseudoPlayer.Text.Length <= 0)
            {
                errorProviderInputPseudoPlayer.SetError(inputPseudoPlayer, "Le pseudo ne peut pas être vide !");
                v_PseudoAreCorrect = false;
            }
            else if (inputPseudoPlayer.Text.Length > 10)
            {
                errorProviderInputPseudoPlayer.SetError(inputPseudoPlayer, "Le pseudo ne peut pas excéder 10 caractères !");
                v_PseudoAreCorrect = false;
            }
            else
            {
                errorProviderInputPseudoPlayer.SetError(inputPseudoPlayer, "");
            }

            return v_PseudoAreCorrect;
        }

        private void StartGame()
        {
            Hide();

            puissance4 v_Puissance4 = new puissance4();
            if (radioButtonPlayerVSPlayer.Checked)
            {
                v_Puissance4.v_Joueur1 = inputPseudoPlayer1.Text;
                v_Puissance4.v_Joueur2 = inputPseudoPlayer2.Text;
            } else
            {
                // Récupérer le niveau de difficulté de l'IA, 0 -> Easy, 1 -> Normal, 2 -> Hard
                int v_NiveauIa = radioButtonModeEasy.Checked ? 0 : (radioButtonModeNormal.Checked ? 1 : 2);
                v_Puissance4.v_Joueur1 = inputPseudoPlayer1.Text;
                v_Puissance4.v_Joueur2 = "Le Bot";
                v_Puissance4.v_difficulty = v_NiveauIa;
            }

            // Ouverture du plateau de jeu
            PlateauForm v_PlateauForm = new PlateauForm(v_Puissance4);
            v_PlateauForm.ShowDialog();
        }
    }
}