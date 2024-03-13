namespace R5._08.Project.Forms.Models
{
    internal class Bot
    {
        public static int EasyModePlay(Puissance4 v_Puissance4)
        {
            List<int> v_AvailablesColumns = v_Puissance4.GetAvailableCols();
            double v_BestScore = -1;
            int v_BestCol = -1;
            List<double> v_AllScore = new List<double>();
            Random rd = new Random();

            int v_ErrorFactor = 10;

            foreach (int v_Col in v_AvailablesColumns)
            {
                double v_ScoreCol = v_Puissance4.GetScoreCol(v_Col) + rd.Next(v_ErrorFactor) / 2.0;
                v_AllScore.Add(v_ScoreCol);
                if (v_ScoreCol > v_BestScore)
                {
                    v_BestCol = v_Col;
                    v_BestScore = v_ScoreCol;
                }
            }

            return v_BestCol;
        }

        public static int NormalModePlay(Puissance4 v_Puissance4)
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
                    Puissance4 tmp_grid = (Puissance4)v_Puissance4.Clone();
                    tmp_grid.PlacePawn(MainColToTry);
                    List<int> v_AvailablesColumnsTmpGrid = tmp_grid.GetAvailableCols();

                    while (v_AvailablesColumnsTmpGrid.Count > 0 && tmp_grid.m_Winner == -1)
                    {
                        int v_ColIndex = rd.Next(v_AvailablesColumnsTmpGrid.Count);
                        int v_Col = v_AvailablesColumnsTmpGrid[v_ColIndex];

                        tmp_grid.PlacePawn(v_Col);

                        // Mettre à jour la liste des colonnes disponibles
                        v_AvailablesColumnsTmpGrid = tmp_grid.GetAvailableCols();
                    }

                    if (tmp_grid.m_Winner != -1)
                    {
                        string v_PseudoPlayerWinner = tmp_grid.GetWinnerName();
                        if (v_PseudoPlayerWinner == "IA Normale")
                        {
                            if (tmp_grid.m_NbPawn - v_Puissance4.m_NbPawn == 1)
                            {
                                v_WinrateForAi.Add(10000);
                            }
                            else
                            {
                                v_WinrateForAi.Add(200 / tmp_grid.m_NbPawn);
                            }
                        }
                        else
                        {
                            if (tmp_grid.m_NbPawn - v_Puissance4.m_NbPawn == 2)
                            {
                                v_WinrateForAi.Add(-8000);
                            }
                            else
                            {
                                v_WinrateForAi.Add(-50 + tmp_grid.m_NbPawn);
                            }
                        }
                    }
                    else
                    {
                        // Égalitée
                        v_WinrateForAi.Add(20);
                    }
                    string grids = tmp_grid.m_Grid.PrintString();

                    Grid.m_AllGrids.Remove(tmp_grid.m_Grid.m_GridId);
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

        public static int HardModePlay(Puissance4 v_Puissance4)
        {
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
                    Puissance4 tmp_grid = (Puissance4)v_Puissance4.Clone();
                    tmp_grid.PlacePawn(MainColToTry);
                    List<int> v_AvailablesColumnsTmpGrid = tmp_grid.GetAvailableCols();

                    while (v_AvailablesColumnsTmpGrid.Count > 0 && tmp_grid.m_Winner == -1)
                    {
                        double v_TotalScore = 0;
                        double v_MinScore = double.PositiveInfinity;
                        List<double> v_AllScore = new List<double>();
                        foreach (int v_ColToPlay in v_AvailablesColumnsTmpGrid)
                        {
                            double v_Score = tmp_grid.GetScoreCol(v_ColToPlay, true);
                            v_AllScore.Add(v_Score);

                            if (v_Score < v_MinScore) { v_MinScore = v_Score;}
                        }

                        for (int v_IndexScore = 0; v_IndexScore < v_AllScore.Count; v_IndexScore++)
                        {
                            v_AllScore[v_IndexScore] += Math.Abs(v_MinScore);
                            v_TotalScore += v_AllScore[v_IndexScore];
                        }


                        double v_ChoosenScore = rd.Next(Convert.ToInt32(v_TotalScore * 2)) / 2.0;

                        double v_LastScore = 0;
                        int v_ColIndex = 0;
                        foreach (double v_ColScore in v_AllScore)
                        {
                            if (v_ChoosenScore >= v_LastScore && v_ChoosenScore < v_LastScore + v_ColScore) { break; }
                            v_ColIndex++;
                            v_LastScore += v_ColScore;
                        }

                        if (v_ColIndex >= v_AvailablesColumnsTmpGrid.Count) { v_ColIndex--; }
                        int v_Col = v_AvailablesColumnsTmpGrid[v_ColIndex];

                        tmp_grid.PlacePawn(v_Col);

                        // Mettre à jour la liste des colonnes disponibles
                        v_AvailablesColumnsTmpGrid = tmp_grid.GetAvailableCols();
                    }

                    if (tmp_grid.m_Winner != -1)
                    {
                        string v_PseudoPlayerWinner = tmp_grid.GetWinnerName();
                        string tmp = tmp_grid.m_Grid.PrintString();
                        if (v_PseudoPlayerWinner == "IA Difficile")
                        {
                            if (tmp_grid.m_NbPawn - v_Puissance4.m_NbPawn == 1)
                            {
                                v_WinrateForAi.Add(10000);
                            }
                            else
                            {
                                v_WinrateForAi.Add(250 / (tmp_grid.m_NbPawn - v_Puissance4.m_NbPawn));
                            }
                        }
                        else
                        {
                            if (tmp_grid.m_NbPawn - v_Puissance4.m_NbPawn == 2)
                            {
                                v_WinrateForAi.Add(-9000);
                            }
                            else
                            {
                                v_WinrateForAi.Add(-150 + (tmp_grid.m_NbPawn - v_Puissance4.m_NbPawn));
                            }
                        }
                    }
                    else
                    {
                        // Égalitée
                        v_WinrateForAi.Add(-20);
                    }

                    Grid.m_AllGrids.Remove(tmp_grid.m_Grid.m_GridId);
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