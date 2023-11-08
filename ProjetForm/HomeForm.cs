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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnHomePlay_Click(object sender, EventArgs e)
        {
            // Cache l'écran principal pour se rediriger vers les modes de jeu
            Hide();
            GameModeForm gameModeForm = new GameModeForm();
            gameModeForm.ShowDialog();
        }

        private void btnHomeQuit_Click(object sender, EventArgs e)
        {
            // Fermeture de l'application
            Application.Exit();
        }

        private void btnHomeScores_Click(object sender, EventArgs e)
        {
            // On cache la page
            Hide();

            // Ouverture de la page de scores
            ScoresForm scoresForm = new ScoresForm();
            scoresForm.ShowDialog();
        }
    }
}
