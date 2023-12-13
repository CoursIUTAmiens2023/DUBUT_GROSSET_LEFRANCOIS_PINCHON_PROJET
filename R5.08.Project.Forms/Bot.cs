using ProjetForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R5._08.Project.Forms
{
    internal class Bot
    {
        private static void AddPawnOnCustomBoard(PictureBox p_PlayerPawn, Point p_PawnPosition, Puissance4 p_Board)
        {
            p_Board.setOnBoard(p_PawnPosition.Y, p_PawnPosition.X, true);
            if (p_Board.isRedPlayerToPlay())
            {
                p_Board.setRedPawnOnBoard(p_PawnPosition.Y, p_PawnPosition.X, true);
                p_Board.setRedPlayerToPlay(false);
            }
            else
            {
                p_Board.setYellowPawnOnBoard(p_PawnPosition.Y, p_PawnPosition.X, true);
                p_Board.setRedPlayerToPlay(true);
            }
        }

        public static Point EasyModePlay(Puissance4 v_Puissance4)
        {
            // Faire jouer l'IA.
            int[] v_AvailablesColumns = Puissance4Manager.GetAvailablesColumnsId(v_Puissance4);

            Random rd = new Random();
            List<float> v_WinrateForAi;

            int v_BestColumnForAi = 0;
            float v_BestScoreForAi = float.NaN;

            // Obtenir des Winrates pour des coups aléatoires
            foreach (int MainColToTry in v_AvailablesColumns)
            {
                v_WinrateForAi = new List<float>();

                // Générer des grids aléatoires pour récupérer le coups avec la meillieur proba de win
                for (int grid_number = 0; grid_number <= 100; grid_number++)
                {
                    Puissance4 tmp_grid = new Puissance4("Joueur", "Bot", false);
                    tmp_grid.Copy(v_Puissance4);

                    int[] v_AvailablesColumnsTmpGrid = Puissance4Manager.GetAvailablesColumnsId(v_Puissance4);
                    while (v_AvailablesColumnsTmpGrid.Length > 0 && !Puissance4Manager.CheckIfWin(tmp_grid))
                    {
                        PictureBox v_Pawn = Puissance4Manager.CreatePawn(v_Puissance4);

                        int v_ColIndex = rd.Next(v_AvailablesColumnsTmpGrid.Length);
                        int v_Col = v_AvailablesColumnsTmpGrid[v_ColIndex];

                        Point v_Pos = Puissance4Manager.GetPawnPosition(tmp_grid, v_Col);
                        Bot.AddPawnOnCustomBoard(v_Pawn, v_Pos, tmp_grid);

                        // Mettre à jour la liste des colonnes disponibles
                        v_AvailablesColumnsTmpGrid = Puissance4Manager.GetAvailablesColumnsId(tmp_grid);

                    }

                    if (Puissance4Manager.CheckIfWin(tmp_grid))
                    {
                        string v_PseudoPlayerWinner = tmp_grid.isRedPlayerToPlay() ? tmp_grid.getJoueur2() : tmp_grid.getJoueur1();
                        if (v_PseudoPlayerWinner == "Bot")
                        {
                            v_WinrateForAi.Add(120);
                        }
                        else
                        {
                            v_WinrateForAi.Add(0);
                        }
                    }
                    else
                    {
                        // Égalitée
                        v_WinrateForAi.Add(40);
                    }

                }

                // Regarder si jouer ce coup est mieux que le meilleur coup déjà trouvé
                float v_AvgWinrate = v_WinrateForAi.Average();
                if (v_BestColumnForAi == 0 || v_BestScoreForAi == float.NaN || v_AvgWinrate > v_BestScoreForAi)
                {
                    v_BestColumnForAi = MainColToTry;
                    v_BestScoreForAi = v_AvgWinrate;
                }
            }

            Point v_PawnPosition = Puissance4Manager.GetPawnPosition(v_Puissance4, v_BestColumnForAi);
            return v_PawnPosition;
        }

    }
}
