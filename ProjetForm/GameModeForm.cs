using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetForm
{
    public partial class GameModeForm : Form
    {
        public GameModeForm()
        {
            InitializeComponent();
        }

        private void radioButtonGameMode1_CheckedChanged(object sender, EventArgs e)
        {
            // Changement d'état des radioButtons
            radioButtonGameMode2.Checked = false;

            // Affichage (ou non) des groupBox en fonction des radioButtons
            groupBoxGameModeInput1.Visible = true;
            groupBoxGameModeInput2.Visible = false;
        }

        private void radioButtonGameMode2_CheckedChanged(object sender, EventArgs e)
        {
            // Changement d'état des radioButtons
            radioButtonGameMode1.Checked = false;

            // Affichage (ou non) des groupBox en fonction des radioButtons
            groupBoxGameModeInput1.Visible = false;
            groupBoxGameModeInput2.Visible = true;
        }

        private void btnGameModeBack_Click(object sender, EventArgs e)
        {
            // Ferme la page
            Close();

            // Réouvre la page Home
            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
        }

        private void inputJoueur1_Enter(object sender, EventArgs e)
        {
            inputJoueur1.Clear();
        }

        private void inputJoueur2_Enter(object sender, EventArgs e)
        {
            inputJoueur2.Clear();
        }

        private void btnJoueurInput_Enter(object sender, EventArgs e)
        {
            inputJoueur.Clear();
        }

        private void radioButtonModeEasy_CheckedChanged(object sender, EventArgs e)
        {
            // Changement d'état des radioButtons en fonction de celui sélectionné
            radioButtonModeNormal.Checked = false;
            radioButtonModeHard.Checked = false;
        }

        private void radioButtonModeNormal_CheckedChanged(object sender, EventArgs e)
        {
            // Changement d'état des radioButtons en fonction de celui sélectionné
            radioButtonModeEasy.Checked = false;
            radioButtonModeHard.Checked = false;
        }

        private void radioButtonModeHard_CheckedChanged(object sender, EventArgs e)
        {
            // Changement d'état des radioButtons en fonction de celui sélectionné
            radioButtonModeEasy.Checked = false;
            radioButtonModeNormal.Checked = false;
        }

        private void btnGameModePlay_Click(object sender, EventArgs e)
        {
            // Fermeture de la page
            Close();

            // Ouverture du plateau de jeu
            PlateauForm plateauForm = new PlateauForm();
            plateauForm.ShowDialog();
        }
    }
}
