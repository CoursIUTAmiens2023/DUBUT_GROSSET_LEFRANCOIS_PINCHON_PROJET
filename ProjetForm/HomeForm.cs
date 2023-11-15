﻿using System;
using System.Windows.Forms;

namespace ProjetForm
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnHomePlay_Click(object p_Sender, EventArgs p_EventArgs)
        {
            // Cache l'écran principal pour se rediriger vers les modes de jeu
            Hide();
            GameModeForm v_GameModeForm = new GameModeForm();
            v_GameModeForm.ShowDialog();
        }

        private void btnHomeQuit_Click(object p_Sender, EventArgs p_EventArgs)
        {
            // Fermeture de l'application
        }

        private void btnHomeScores_Click(object p_Sender, EventArgs p_EventArgs)
        {
            // On cache la page
            Hide();

            // Ouverture de la page de scores
            ScoresForm v_ScoresForm = new ScoresForm();
            v_ScoresForm.ShowDialog();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            //Connection à la base de données
            bool connexionOuverte = DatabaseConnection.InitConnexion();
            if (connexionOuverte)
            {
                MessageBox.Show("Connexion à la base réussi !");

            }
            else
            {
                MessageBox.Show("Echec de connexion à la base !");
                this.Close();
            }
        }
    }
}