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

        private void radioButtonGameMode1_CheckedChanged(object p_Sender, EventArgs p_EventArgs)
        {
            // Changement d'état des radioButtons
            radioButtonGameMode2.Checked = false;

            // Affichage (ou non) des groupBox en fonction des radioButtons
            groupBoxGameModeInput1.Visible = true;
            groupBoxGameModeInput2.Visible = false;
        }

        private void radioButtonGameMode2_CheckedChanged(object p_Sender, EventArgs p_EventArgs)
        {
            // Changement d'état des radioButtons
            radioButtonGameMode1.Checked = false;

            // Affichage (ou non) des groupBox en fonction des radioButtons
            groupBoxGameModeInput1.Visible = false;
            groupBoxGameModeInput2.Visible = true;
        }

        private void btnGameModeBack_Click(object p_Sender, EventArgs p_EventArgs)
        {
            // Ferme la page
            Close();

            // Réouvre la page Home
            HomeForm v_HomeForm = new HomeForm();
            v_HomeForm.ShowDialog();
        }

        private void inputJoueur1_Enter(object p_Sender, EventArgs p_EventArgs)
        {
            inputJoueur1.Clear();
        }

        private void inputJoueur2_Enter(object p_Sender, EventArgs p_EventArgs)
        {
            inputJoueur2.Clear();
        }

        private void btnJoueurInput_Enter(object p_Sender, EventArgs p_EventArgs)
        {
            inputJoueur.Clear();
        }

        private void radioButtonModeEasy_CheckedChanged(object p_Sender, EventArgs p_EventArgs)
        {
            // Changement d'état des radioButtons en fonction de celui sélectionné
            radioButtonModeNormal.Checked = false;
            radioButtonModeHard.Checked = false;
        }

        private void radioButtonModeNormal_CheckedChanged(object p_Sender, EventArgs p_EventArgs)
        {
            // Changement d'état des radioButtons en fonction de celui sélectionné
            radioButtonModeEasy.Checked = false;
            radioButtonModeHard.Checked = false;
        }

        private void radioButtonModeHard_CheckedChanged(object p_Sender, EventArgs p_EventArgs)
        {
            // Changement d'état des radioButtons en fonction de celui sélectionné
            radioButtonModeEasy.Checked = false;
            radioButtonModeNormal.Checked = false;
        }

        private void btnGameModePlay_Click(object p_Sender, EventArgs p_EventArgs)
        {
            // Fermeture de la page
            Close();

            // Ouverture du plateau de jeu
            PlateauForm v_PlateauForm = new PlateauForm();
            v_PlateauForm.ShowDialog();
        }
    }
}