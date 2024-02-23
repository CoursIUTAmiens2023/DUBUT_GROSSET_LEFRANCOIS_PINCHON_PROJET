using ProjetForm;
using R5._08.Project.Forms.Models;
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

        public static int EasyModePlay(puissance4 v_Puissance4)
        {
            // Faire jouer l'IA.
            List<int> v_AvailablesColumns = v_Puissance4.GetAvailableCols();

            Random rd = new Random();
            List<float> v_WinrateForAi;

            int v_BestColumnForAi = -1;
            float v_BestScoreForAi = float.NaN;

            // Obtenir des Winrates pour des coups aléatoires
            foreach (int MainColToTry in v_AvailablesColumns)
            {
                v_WinrateForAi = new List<float>();

                // Générer des grids aléatoires pour récupérer le coups avec la meillieur proba de win
                for (int grid_number = 0; grid_number < 80; grid_number++)
                {
                    puissance4 tmp_grid = (puissance4)v_Puissance4.Clone();
                    tmp_grid.PlacePawn(MainColToTry);
                    List<int> v_AvailablesColumnsTmpGrid = tmp_grid.GetAvailableCols();

                    while (v_AvailablesColumnsTmpGrid.Count > 0 && tmp_grid.v_Winner == -1 )
                    {
                        int v_ColIndex = rd.Next(v_AvailablesColumnsTmpGrid.Count);
                        int v_Col = v_AvailablesColumnsTmpGrid[v_ColIndex];

                        tmp_grid.PlacePawn(v_Col);

                        // Mettre à jour la liste des colonnes disponibles
                        v_AvailablesColumnsTmpGrid = tmp_grid.GetAvailableCols();
                    }

                    if (tmp_grid.v_Winner != -1)
                    {
                        string v_PseudoPlayerWinner = tmp_grid.GetWinnerName();
                        if (v_PseudoPlayerWinner == "Le Bot")
                        {
                            if (tmp_grid.v_NbPawn - v_Puissance4.v_NbPawn == 1)
                            {
                                v_WinrateForAi.Add(10000);
                            } else {
                                v_WinrateForAi.Add(200 / tmp_grid.v_NbPawn); 
                            }
                        }
                        else
                        {
                            if (tmp_grid.v_NbPawn - v_Puissance4.v_NbPawn == 2)
                            {
                                v_WinrateForAi.Add(-8000);
                            }
                            else
                            {
                                v_WinrateForAi.Add(-50 + tmp_grid.v_NbPawn);
                            }
                        }
                    }
                    else
                    {
                        // Égalitée
                        v_WinrateForAi.Add(20);
                    }
                    string grids = tmp_grid.grid.printstring();

                    Grid.ALL_GRIDS.Remove(tmp_grid.grid.c_GridId);
                }

                // Regarder si jouer ce coup est mieux que le meilleur coup déjà trouvé
                float v_AvgWinrate = v_WinrateForAi.Average();
                if (v_BestColumnForAi == -1 || v_BestScoreForAi == float.NaN || v_AvgWinrate > v_BestScoreForAi)
                {
                    v_BestColumnForAi = MainColToTry;
                    v_BestScoreForAi = v_AvgWinrate;
                }
            }

            return v_BestColumnForAi;
        }

    }
}
