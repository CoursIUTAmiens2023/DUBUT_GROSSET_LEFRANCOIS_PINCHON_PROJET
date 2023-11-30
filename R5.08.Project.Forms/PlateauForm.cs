﻿using MySqlConnector;
using R5._08.Project.Forms;
using DB = R5._08.Project.Database.DatabaseConnection;

namespace ProjetForm
{
    public partial class PlateauForm : Form
    {
        private Puissance4 v_Puissance4;

        public PlateauForm(Puissance4 p_Puissance4)
        {
            InitializeComponent();
            this.v_Puissance4 = p_Puissance4;
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
            v_Puissance4.setOnBoard(v_PawnPosition.Y, v_PawnPosition.X, true);
            if (v_Puissance4.isRedPlayerToPlay())
            {
                v_Puissance4.setRedPawnOnBoard(v_PawnPosition.Y, v_PawnPosition.X, true);
                v_Puissance4.setRedPlayerToPlay(false);
            }
            else
            {
                v_Puissance4.setYellowPawnOnBoard(v_PawnPosition.Y, v_PawnPosition.X, true);
                v_Puissance4.setRedPlayerToPlay(true);
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
        private void EnableEndScreen(String p_PseudoPlayerWinner, bool draw)
        {
            // Affichage de la group Box pour montrer le gagnant
            groupBoxWinner.Visible = true;

            // Desactivation des boutons
            List<Button> v_BtnColList = new List<Button> { btnCol1, btnCol2, btnCol3, btnCol4, btnCol5, btnCol6, btnCol7 };

            v_BtnColList.ForEach((btn) => btn.Enabled = false);
            btnPlateauAbandon.Enabled = false;

            if(draw)
            {
                lblWinner.Text = "Égalité !";
            } else
            {
                lblWinner.Text = p_PseudoPlayerWinner + " a gagné !";
            }

            
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
            v_PlayerPawn = Puissance4Manager.CreatePawn(v_Puissance4);

            // Calcule des position dans le plateau
            v_PawnPosition = Puissance4Manager.GetPawnPosition(v_Puissance4, v_ColumnPlayed);

            if(v_PawnPosition.X != -1)
            {
                AddPawnOnBoard(v_PlayerPawn, v_PawnPosition);   
            }

            if (Puissance4Manager.CheckIfWin(v_Puissance4))
            {
                string v_PseudoPlayerWinner = v_Puissance4.isRedPlayerToPlay() ? v_Puissance4.getJoueur2() : v_Puissance4.getJoueur1();
                string v_PseudoPlayerLose = v_Puissance4.isRedPlayerToPlay() ? v_Puissance4.getJoueur1() : v_Puissance4.getJoueur2();
                int v_Timer = 100;
                AddPlayer(true, v_PseudoPlayerWinner, v_Timer);
                AddPlayer(false, v_PseudoPlayerLose, v_Timer);
                EnableEndScreen(v_PseudoPlayerWinner, false);
            }

            if (Puissance4Manager.CheckIfDraw(v_Puissance4.getBoard()))
            {
                EnableEndScreen("égalité", true);
            }

            lblPlayerToPlay.Text = v_Puissance4.isRedPlayerToPlay() ? v_Puissance4.getJoueur1() : v_Puissance4.getJoueur2();

            if(!v_Puissance4.isPlayerVSPlayerMode())
            {
                aiPlay();
            }
        }

        public void AddPlayer(bool p_Winner, string p_Name, int p_PartyTime)
        {
            try
            {
                Scoreboard v_Scoreboard = new();
                string v_Query = $"SELECT * FROM Scoreboard WHERE Name = '{p_Name}'";
                MySqlCommand v_Command = new(v_Query, DB.m_DBConnection);
                MySqlDataReader v_DataReader = v_Command.ExecuteReader();
                while (v_DataReader.Read())
                {
                    v_Scoreboard = new Scoreboard() { Id = v_DataReader.GetInt32(0), Name = v_DataReader.GetString(1), NumberOfGames = v_DataReader.GetInt32(2), NumberOfWins = v_DataReader.GetInt32(3), AverageTime = v_DataReader.GetInt32(4) };
                }
                v_DataReader.Close();
                v_Command.Dispose();

                if (v_Scoreboard.Name != null)
                {
                    v_Scoreboard.AverageTime = (v_Scoreboard.AverageTime * v_Scoreboard.NumberOfGames + p_PartyTime) / (v_Scoreboard.NumberOfGames + 1);
                    v_Scoreboard.NumberOfGames = v_Scoreboard.NumberOfGames + 1;
                }
                else
                {
                    v_Scoreboard = new() { Name = p_Name, NumberOfGames = 1, AverageTime = p_PartyTime };
                }

                if(p_Winner)
                {
                    v_Scoreboard.NumberOfWins = v_Scoreboard.NumberOfWins + 1;

                }
                else
                {
                    v_Scoreboard.NumberOfWins = v_Scoreboard.NumberOfWins;

                }

                if(v_Scoreboard.Id == 0)
                {
                    string v_InsertQuery = $"INSERT INTO Scoreboard (Name, NumberOfGames, NumberOfWins, AverageTime) VALUES ('{v_Scoreboard.Name}',{v_Scoreboard.NumberOfGames},{v_Scoreboard.NumberOfWins},{v_Scoreboard.AverageTime})";
                    MySqlCommand v_InsertCommand = new(v_InsertQuery, DB.m_DBConnection);
                    v_InsertCommand.ExecuteNonQuery();
                    v_DataReader.Close();
                    v_Command.Dispose();
                }
                else
                {
                    string v_UpdateQuery = $"UPDATE Scoreboard SET NumberOfGames = {v_Scoreboard.NumberOfGames}, NumberOfWins = {v_Scoreboard.NumberOfWins}, AverageTime = {v_Scoreboard.AverageTime} WHERE Id = {v_Scoreboard.Id}";
                    MySqlCommand v_UpdateCommand = new(v_UpdateQuery, DB.m_DBConnection);
                    v_UpdateCommand.ExecuteNonQuery();
                    v_DataReader.Close();
                    v_Command.Dispose();
                }
            }
            catch (Exception v_Ex)
            {
                Console.WriteLine(v_Ex.ToString());
            }
        }


        private void btnPlateauAbandon_Click(object p_Sender, EventArgs p_EventArgs)
        {
            String playerWinner = v_Puissance4.isRedPlayerToPlay() ? v_Puissance4.getJoueur2() : v_Puissance4.getJoueur1();
            EnableEndScreen(playerWinner, false);
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
            Puissance4 newPuissance4 = new Puissance4(v_Puissance4.getJoueur1(), v_Puissance4.getJoueur2(), v_Puissance4.isPlayerVSPlayerMode()); ;
            PlateauForm v_PlateauForm = new PlateauForm(newPuissance4);
            v_PlateauForm.ShowDialog();
        }
    }
}