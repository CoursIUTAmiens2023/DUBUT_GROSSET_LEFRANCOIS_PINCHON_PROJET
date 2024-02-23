using MySqlConnector;
using R5._08.Project.Forms;
using DB = R5._08.Project.Database.DatabaseConnection;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
using R5._08.Project.Forms.Models;

namespace ProjetForm
{
    public partial class PlateauForm : Form
    {
        private puissance4 v_Puissance4;
        private Timer m_Timer;
        private int m_ElapsedTime = 0;

        public PlateauForm(puissance4 p_Puissance4)
        {
            InitializeComponent();
            this.v_Puissance4 = p_Puissance4;
            lblPlayerToPlay.Text = p_Puissance4.GetPlayerToPlay();
        }

        /// <summary>
        /// Ajout un pion sur le plateau
        /// </summary>
        /// <param name="v_PlayerPawn">Le pion du joueur</param>
        /// <param name="v_PawnPosition">La position du pion</param>
        private void AddPawnOnBoard(PictureBox v_PlayerPawn, int v_ColumnPlayed, int v_RowPlayed)
        {
            // Ajout du pion sur le plateau
            plateauJeu.Controls.Add(v_PlayerPawn, v_ColumnPlayed, Grid.NUMBER_OF_ROWS - v_RowPlayed - 1);
        }

        /// <summary>
        /// Fait jouer l'IA
        /// </summary>
        private void aiPlay()
        {
            if (v_Puissance4.v_difficulty == 0)
            {
                int v_Col = Bot.EasyModePlay(v_Puissance4);
                PictureBox v_AiPawn = Puissance4Manager.CreatePawn(v_Puissance4);

                try
                {
                    int v_Row = v_Puissance4.PlacePawn(v_Col);
                    AddPawnOnBoard(v_AiPawn, v_Col, v_Row);
                } catch (Exception e) { }
                
            } else
            {

            }
        }

        /// <summary>
        /// Active l'écran de fin
        /// </summary>
        /// <param name="p_PseudoPlayerWinner">Le pseudo du joueur qui a gagné</param>
        private void EnableEndScreen(String p_PseudoPlayerWinner, bool p_Draw)
        {
            // Affichage de la group Box pour montrer le gagnant
            groupBoxWinner.Visible = true;

            // Desactivation des boutons
            List<Button> v_BtnColList = new List<Button> { btnCol1, btnCol2, btnCol3, btnCol4, btnCol5, btnCol6, btnCol7 };

            v_BtnColList.ForEach((btn) => btn.Enabled = false);
            btnPlateauAbandon.Enabled = false;

            if(p_Draw)
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
                    throw new Exception("Bouton inexistant");
            }
            v_ColumnPlayed -= 1;

            // Crée un nouveau pion à ajouter
            v_PlayerPawn = Puissance4Manager.CreatePawn(v_Puissance4);


            try {
                int v_RowPlayed = v_Puissance4.PlacePawn(v_ColumnPlayed);
                AddPawnOnBoard(v_PlayerPawn, v_ColumnPlayed, v_RowPlayed);

                if (v_Puissance4.v_Winner != -1)
                {
                    m_Timer.Stop();
                    string v_PseudoPlayerWinner = v_Puissance4.v_Winner == 1 ? v_Puissance4.v_Joueur2 : v_Puissance4.v_Joueur1;
                    string v_PseudoPlayerLose = v_Puissance4.v_Winner == 1 ? v_Puissance4.v_Joueur1 : v_Puissance4.v_Joueur2;
                    AddPlayer(true, v_PseudoPlayerWinner);
                    AddPlayer(false, v_PseudoPlayerLose);
                    EnableEndScreen(v_PseudoPlayerWinner, false);
                }

                if (v_Puissance4.CheckIfDraw())
                {
                    m_Timer.Stop();
                    AddPlayer(false, v_Puissance4.v_Joueur2);
                    AddPlayer(false, v_Puissance4.v_Joueur1);
                    EnableEndScreen("égalité", true);
                }

                lblPlayerToPlay.Text = v_Puissance4.GetPlayerToPlay();

                if (v_Puissance4.v_difficulty >= 0)
                {
                    aiPlay();

                    if (v_Puissance4.v_Winner != -1)
                    {
                        m_Timer.Stop();
                        string v_PseudoPlayerWinner = v_Puissance4.v_Winner == 1 ? v_Puissance4.v_Joueur2 : v_Puissance4.v_Joueur1;
                        string v_PseudoPlayerLose = v_Puissance4.v_Winner == 1 ? v_Puissance4.v_Joueur1 : v_Puissance4.v_Joueur2;
                        AddPlayer(true, v_PseudoPlayerWinner);
                        AddPlayer(false, v_PseudoPlayerLose);
                        EnableEndScreen(v_PseudoPlayerWinner, false);
                    }

                    if (v_Puissance4.CheckIfDraw())
                    {
                        m_Timer.Stop();
                        AddPlayer(false, v_Puissance4.v_Joueur2);
                        AddPlayer(false, v_Puissance4.v_Joueur1);
                        EnableEndScreen("égalité", true);
                    }

                    lblPlayerToPlay.Text = v_Puissance4.GetPlayerToPlay();

                }
            } catch (Exception e) { }

        }

        public void AddPlayer(bool p_IsWinner, string p_Name)
        {
            try
            {
                //Create object to store data
                Scoreboard v_Scoreboard = new();
                
                //Check if the player already exists in the database
                string v_Query = $"SELECT * FROM Scoreboard WHERE Name = '{p_Name}'";
                MySqlCommand v_Command = new(v_Query, DB.m_DBConnection);
                MySqlDataReader v_DataReader = v_Command.ExecuteReader();
                while (v_DataReader.Read())
                {
                    v_Scoreboard = new Scoreboard() { Id = v_DataReader.GetInt32(0), Name = v_DataReader.GetString(1), NumberOfGames = v_DataReader.GetInt32(2), NumberOfWins = v_DataReader.GetInt32(3), AverageTime = v_DataReader.GetInt32(4) };
                }
                v_DataReader.Close();
                v_Command.Dispose();

                //If exist update data
                if (v_Scoreboard.Name != null)
                {
                    v_Scoreboard.AverageTime = (v_Scoreboard.AverageTime * v_Scoreboard.NumberOfGames + m_ElapsedTime) / (v_Scoreboard.NumberOfGames + 1);
                    v_Scoreboard.NumberOfGames = v_Scoreboard.NumberOfGames + 1;
                }
                else //Create the data
                {
                    v_Scoreboard = new() { Name = p_Name, NumberOfGames = 1, AverageTime = m_ElapsedTime };
                }

                //Check if the player is the winner
                if (p_IsWinner)
                {
                    v_Scoreboard.NumberOfWins = v_Scoreboard.NumberOfWins + 1;

                }
                else
                {
                    v_Scoreboard.NumberOfWins = v_Scoreboard.NumberOfWins;

                }

                string v_UpsertQuery;
                if(v_Scoreboard.Id == 0)
                {
                    v_UpsertQuery = $"INSERT INTO Scoreboard (Name, NumberOfGames, NumberOfWins, AverageTime) VALUES ('{v_Scoreboard.Name}',{v_Scoreboard.NumberOfGames},{v_Scoreboard.NumberOfWins},{v_Scoreboard.AverageTime})";

                }
                else
                {
                    v_UpsertQuery = $"UPDATE Scoreboard SET NumberOfGames = {v_Scoreboard.NumberOfGames}, NumberOfWins = {v_Scoreboard.NumberOfWins}, AverageTime = {v_Scoreboard.AverageTime} WHERE Id = {v_Scoreboard.Id}";
                }
                MySqlCommand v_InsertCommand = new(v_UpsertQuery, DB.m_DBConnection);
                v_InsertCommand.ExecuteNonQuery();
                v_DataReader.Close();
                v_Command.Dispose();
            }
            catch (Exception v_Ex)
            {
                Console.WriteLine(v_Ex.ToString());
            }
        }


        private void btnPlateauAbandon_Click(object p_Sender, EventArgs p_EventArgs)
        {
            String playerWinner = v_Puissance4.GetPlayerToPlay();
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

        private void btnWinnerPlay_Click(object p_Sender, EventArgs p_EventArgs)
        {
            Hide();

            // Ouverture du plateau de jeu
            puissance4 newPuissance4 = new puissance4();
            newPuissance4.v_Joueur1 = v_Puissance4.v_Joueur1;
            newPuissance4.v_Joueur2 = v_Puissance4.v_Joueur2;
            newPuissance4.v_difficulty = v_Puissance4.v_difficulty;

            PlateauForm v_PlateauForm = new PlateauForm(newPuissance4);
            v_PlateauForm.ShowDialog();
        }

        private void PlateauForm_Load(object p_Sender, EventArgs p_EventArgs)
        {
            m_Timer = new();
            m_Timer.Interval = 1000;
            m_Timer.Tick += TimerTick;
            m_Timer.Start();
        }

        private void TimerTick(object? p_Sender, EventArgs? p_EventArgs)
        {
            m_ElapsedTime++;
            //lblPlateauTimer.Text = $"Temps écoulé : {m_ElapsedTime} secondes";
        }
    }
}