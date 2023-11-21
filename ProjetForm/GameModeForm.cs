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
                bool pseudoAreCorrect = CheckPseudoPlayerVSPlayer();
                if (pseudoAreCorrect)
                {
                    StartGame();
                }
            }
            else if (radioButtonPlayerVSAi.Checked)
            {
                bool pseudoAreCorrect = CheckPseudoPlayerVSAi();
                if (pseudoAreCorrect)
                {
                    StartGame();
                }
            } 
        }

        private bool CheckPseudoPlayerVSPlayer()
        {
            bool pseudoAreCorrect = true;

            if (inputPseudoPlayer1.Text.Length <= 0)
            {
                errorProviderInputPseudoPlayer1.SetError(inputPseudoPlayer1, "Le pseudo ne peut pas être vide !");
                pseudoAreCorrect = false;
            }
            else if (inputPseudoPlayer1.Text.Length > 10)
            {
                errorProviderInputPseudoPlayer1.SetError(inputPseudoPlayer1, "Le pseudo ne peut pas excéder 10 caractères !");
                pseudoAreCorrect = false;
            } else
            {
                errorProviderInputPseudoPlayer1.SetError(inputPseudoPlayer1, "");
            }
            
            if (inputPseudoPlayer2.Text.Length <= 0)
            {
                errorProviderInputPseudoPlayer2.SetError(inputPseudoPlayer2, "Le pseudo ne peut pas être vide !");
                pseudoAreCorrect = false;
            }
            else if (inputPseudoPlayer2.Text.Length > 10)
            {
                errorProviderInputPseudoPlayer2.SetError(inputPseudoPlayer2, "Le pseudo ne peut pas excéder 10 caractères !");
                pseudoAreCorrect = false;
            } else
            {
                errorProviderInputPseudoPlayer2.SetError(inputPseudoPlayer2, "");
            }

            return pseudoAreCorrect;
        }

        private bool CheckPseudoPlayerVSAi()
        {
            bool pseudoAreCorrect = true;

            if (inputPseudoPlayer.Text.Length <= 0)
            {
                errorProviderInputPseudoPlayer.SetError(inputPseudoPlayer, "Le pseudo ne peut pas être vide !");
                pseudoAreCorrect = false;
            }
            else if (inputPseudoPlayer.Text.Length > 10)
            {
                errorProviderInputPseudoPlayer.SetError(inputPseudoPlayer, "Le pseudo ne peut pas excéder 10 caractères !");
                pseudoAreCorrect = false;
            }
            else
            {
                errorProviderInputPseudoPlayer.SetError(inputPseudoPlayer, "");
            }

            return pseudoAreCorrect;
        }

        private void StartGame()
        {
            Hide();

            Puissance4 puissance4;
            if (radioButtonPlayerVSPlayer.Checked)
            {
                puissance4 = new Puissance4(inputPseudoPlayer1.Text, inputPseudoPlayer2.Text, true);
            } else
            {
                puissance4 = new Puissance4(inputPseudoPlayer.Text, "", false);
            }

            // Ouverture du plateau de jeu
            PlateauForm v_PlateauForm = new PlateauForm(puissance4);
            v_PlateauForm.ShowDialog();
        }
    }
}