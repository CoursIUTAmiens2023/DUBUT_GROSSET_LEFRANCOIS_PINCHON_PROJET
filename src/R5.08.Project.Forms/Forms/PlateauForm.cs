using Timer = System.Windows.Forms.Timer;
using R5._08.Project.Forms.Models;
using R5._08.Project.Database.Interface;
using R5._08.Project.Database.Entities;

namespace ProjetForm
{
    public partial class PlateauForm : Form
    {
        private IUnitOfWork m_UnitOfWork;
        private R5._08.Project.Forms.Models.Puissance4 m_Puissance4;
        private Timer m_Timer;
        private int m_ElapsedTime = 0;

        public PlateauForm(R5._08.Project.Forms.Models.Puissance4 p_Puissance4, IUnitOfWork p_UnitOfWork)
        {
            m_UnitOfWork = p_UnitOfWork;
            m_Timer = new Timer();
            m_Puissance4 = p_Puissance4;

            InitializeComponent();

            m_LblPlayerToPlay.Text = p_Puissance4.GetPlayerToPlay();

            if (p_Puissance4.m_IaStart)
            {
                AiPlay();
            }
        }

        /// <summary>
        /// Ajout un pion sur le plateau
        /// </summary>
        /// <param name="p_PlayerPawn">Le pion du joueur</param>
        /// <param name="v_PawnPosition">La position du pion</param>
        private void AddPawnOnBoard(PictureBox p_PlayerPawn, int p_ColumnPlayed, int p_RowPlayed)
        {
            // Ajout du pion sur le plateau
            m_PlateauJeu.Controls.Add(p_PlayerPawn, p_ColumnPlayed, Grid.NUMBER_OF_ROWS - p_RowPlayed - 1);
        }

        /// <summary>
        /// Fait jouer l'IA
        /// </summary>
        private void AiPlay()
        {
            int v_Col;
            if (m_Puissance4.m_difficulty == 0)
                v_Col = Bot.EasyModePlay(m_Puissance4);
            else if (m_Puissance4.m_difficulty == 1)
                v_Col = Bot.NormalModePlay(m_Puissance4);
            else
                v_Col = Bot.HardModePlay(m_Puissance4);

            PictureBox v_AiPawn = m_Puissance4.CreatePawn();

            int v_Row = m_Puissance4.PlacePawn(v_Col);
            AddPawnOnBoard(v_AiPawn, v_Col, v_Row);
        }

        /// <summary>
        /// Active l'écran de fin
        /// </summary>
        /// <param name="p_PseudoPlayerWinner">Le pseudo du joueur qui a gagné</param>
        private void EnableEndScreen(string p_PseudoPlayerWinner, bool p_Draw)
        {
            // Affichage de la group Box pour montrer le gagnant
            m_GroupBoxWinner.Visible = true;

            // Desactivation des boutons
            List<Button> v_BtnColList = new List<Button> { m_BtnCol1, m_BtnCol2, m_BtnCol3, m_BtnCol4, m_BtnCol5, m_BtnCol6, m_BtnCol7 };

            v_BtnColList.ForEach((btn) => btn.Visible = false);
            m_BtnPlateauAbandon.Visible = false;

            if (p_Draw)
            {
                m_LblWinner.Text = "Égalité !";
            }
            else
            {
                m_LblWinner.Text = p_PseudoPlayerWinner + " a gagné !";
            }
        }

        private async void buttonColonne_Click(object p_Sender, EventArgs p_EventArgs)
        {
            PictureBox v_PlayerPawn; // Pion a ajouter

            int v_ColumnPlayed;
            switch (((Button)p_Sender).Name.ToString())
            {
                case "m_BtnCol1":
                    v_ColumnPlayed = 1;
                    break;

                case "m_BtnCol2":
                    v_ColumnPlayed = 2;
                    break;

                case "m_BtnCol3":
                    v_ColumnPlayed = 3;
                    break;

                case "m_BtnCol4":
                    v_ColumnPlayed = 4;
                    break;

                case "m_BtnCol5":
                    v_ColumnPlayed = 5;
                    break;

                case "m_BtnCol6":
                    v_ColumnPlayed = 6;
                    break;

                case "m_BtnCol7":
                    v_ColumnPlayed = 7;
                    break;

                default:
                    throw new Exception("Bouton inexistant");
            }
            v_ColumnPlayed -= 1;

            // Crée un nouveau pion à ajouter
            v_PlayerPawn = m_Puissance4.CreatePawn();


            try
            {
                int v_RowPlayed = m_Puissance4.PlacePawn(v_ColumnPlayed);
                AddPawnOnBoard(v_PlayerPawn, v_ColumnPlayed, v_RowPlayed);

                if (m_Puissance4.m_Winner != -1)
                {
                    m_Timer.Stop();
                    string v_PseudoPlayerWinner = m_Puissance4.m_Winner == 1 ? m_Puissance4.m_Joueur2 : m_Puissance4.m_Joueur1;
                    string v_PseudoPlayerLose = m_Puissance4.m_Winner == 1 ? m_Puissance4.m_Joueur1 : m_Puissance4.m_Joueur2;
                    await AddPlayer(true, v_PseudoPlayerWinner);
                    await AddPlayer(false, v_PseudoPlayerLose);
                    EnableEndScreen(v_PseudoPlayerWinner, false);
                }

                if (m_Puissance4.CheckIfDraw())
                {
                    m_Timer.Stop();
                    await AddPlayer(false, m_Puissance4.m_Joueur2);
                    await AddPlayer(false, m_Puissance4.m_Joueur1);
                    EnableEndScreen("égalité", true);
                }

                m_LblPlayerToPlay.Text = m_Puissance4.GetPlayerToPlay();

                if (m_Puissance4.m_difficulty >= 0)
                {
                    AiPlay();

                    if (m_Puissance4.m_Winner != -1)
                    {
                        m_Timer.Stop();
                        string v_PseudoPlayerWinner = m_Puissance4.m_Winner == 1 ? m_Puissance4.m_Joueur2 : m_Puissance4.m_Joueur1;
                        string v_PseudoPlayerLose = m_Puissance4.m_Winner == 1 ? m_Puissance4.m_Joueur1 : m_Puissance4.m_Joueur2;
                        await AddPlayer(true, v_PseudoPlayerWinner);
                        await AddPlayer(false, v_PseudoPlayerLose);
                        EnableEndScreen(v_PseudoPlayerWinner, false);
                    }

                    if (m_Puissance4.CheckIfDraw())
                    {
                        m_Timer.Stop();
                        await AddPlayer(false, m_Puissance4.m_Joueur2);
                        await AddPlayer(false, m_Puissance4.m_Joueur1);
                        EnableEndScreen("égalité", true);
                    }

                    m_LblPlayerToPlay.Text = m_Puissance4.GetPlayerToPlay();

                }
            }
            catch (Exception e) { }

        }

        public async Task AddPlayer(bool p_IsWinner, string p_Name)
        {
            try
            {
                // Check if the player already exists in the database
                Scoreboard? v_Scoreboard = await m_UnitOfWork.ScoreboardRepository.GetScoreboardByName(p_Name);

                if (v_Scoreboard != null)
                {
                    // If exist update player data
                    v_Scoreboard.AverageTime =
                        (v_Scoreboard.AverageTime * v_Scoreboard.NumberOfGames + m_ElapsedTime) / (v_Scoreboard.NumberOfGames + 1);

                    v_Scoreboard.NumberOfGames++;
                }
                else
                {
                    // Create new player data
                    v_Scoreboard = new()
                    {
                        Name = p_Name,
                        NumberOfGames = 1,
                        AverageTime = m_ElapsedTime,
                        NumberOfWins = 0
                    };
                }

                // Check if the player is the winner
                if (p_IsWinner)
                {
                    v_Scoreboard.NumberOfWins += 1;

                }
                if (v_Scoreboard.Id == default)
                {
                    await m_UnitOfWork.ScoreboardRepository.AddScoreboards(v_Scoreboard);
                }
                else
                {
                    await m_UnitOfWork.ScoreboardRepository.UpdateScoreboards(v_Scoreboard);
                }
                _ = m_UnitOfWork.Save();
            }
            catch (Exception v_Ex)
            {
                Console.WriteLine(v_Ex.ToString());
            }
        }


        private void btnPlateauAbandon_Click(object p_Sender, EventArgs p_EventArgs)
        {
            string playerWinner = m_Puissance4.GetPlayerToPlay(true);
            EnableEndScreen(playerWinner, false);
        }

        private void btnWinnerHome_Click(object p_Sender, EventArgs p_EventArgs)
        {
            Hide();

            // Réouverture de la fenêtre du menu principal
            HomeForm v_HomeForm = new HomeForm(m_UnitOfWork);
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
            R5._08.Project.Forms.Models.Puissance4 newPuissance4 = new R5._08.Project.Forms.Models.Puissance4();
            newPuissance4.m_Joueur1 = m_Puissance4.m_Joueur1;
            newPuissance4.m_Joueur2 = m_Puissance4.m_Joueur2;
            newPuissance4.m_difficulty = m_Puissance4.m_difficulty;

            PlateauForm v_PlateauForm = new PlateauForm(newPuissance4, m_UnitOfWork);
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
            m_LblPlateauTimer.Text = $"Temps écoulé : {m_ElapsedTime} secondes";
        }
    }
}