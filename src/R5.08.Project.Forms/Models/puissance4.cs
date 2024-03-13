using System.Drawing.Drawing2D;

namespace R5._08.Project.Forms.Models
{
    public class Puissance4 : ICloneable
    {
        public Grid m_Grid;

        public List<int> m_NbPawnByCol = new();

        public int m_CurrentPlayer = 0;

        public int m_Winner = -1;

        public string m_Joueur1 = "";
        public string m_Joueur2 = "";

        public int m_NbPawn = 0;
        public int m_difficulty = -1;

        public bool m_IaStart = false;

        private List<Tile> v_AllReadyCounted = new();
        private Tile v_XRaySource = null;

        private Random rd = new Random();

        public Puissance4()
        {
            m_Grid = new Grid();
            // Initialiser les colonnes
            for (int v_ColIndex = 0; v_ColIndex < Grid.NUMBER_OF_COLS; v_ColIndex++)
            {
                m_NbPawnByCol.Add(0);
            }
        }

        public object Clone()
        {
            Puissance4 v_Puissance4 = new()
            {
                m_Joueur1 = m_Joueur1,
                m_Joueur2 = m_Joueur2,
                m_difficulty = m_difficulty,
                m_Winner = m_Winner,
                m_CurrentPlayer = m_CurrentPlayer,
                m_NbPawn = m_NbPawn,
                m_Grid = (Grid)m_Grid.Clone(),
                m_NbPawnByCol = new List<int>(m_NbPawnByCol)
            };

            return v_Puissance4;
        }

        public string GetPlayerToPlay(bool p_Reversed = false)
        {
            return m_CurrentPlayer == 0 + Convert.ToInt32(p_Reversed) ? m_Joueur1 : m_Joueur2;
        }

        public string GetWinnerName()
        {
            if (m_Winner == -1) { throw new Exception("Impossible de récupérer le nom du gagnant car il n'y a pas de gagnant"); }
            return m_Winner == 0 ? m_Joueur1 : m_Joueur2;
        }

        public List<int> GetAvailableCols()
        {
            List<int> v_Cols = new List<int>();
            for (int v_ColIndex = 0; v_ColIndex < Grid.NUMBER_OF_COLS; v_ColIndex++)
            {
                if (m_NbPawnByCol[v_ColIndex] < Grid.NUMBER_OF_ROWS)
                {
                    v_Cols.Add(v_ColIndex);
                }
            }
            return v_Cols;
        }

        public int PlacePawn(int p_ColIndex)
        {
            if (p_ColIndex < 0 || p_ColIndex >= Grid.NUMBER_OF_COLS)
            {
                throw new ArgumentException("Index de colonne invalide");
            }

            if (m_NbPawnByCol[p_ColIndex] - 1 >= Grid.NUMBER_OF_ROWS)
            {
                throw new ArgumentException("Plus de place dans la colonne choisie");
            }

            m_Grid.Play(p_ColIndex, m_NbPawnByCol[p_ColIndex], m_CurrentPlayer);
            m_NbPawnByCol[p_ColIndex]++;

            m_NbPawn++;

            // Vérifier s'il y a un gagnant
            if (m_Grid.m_WinVectors.Count > 0 && m_Winner == -1)
            {
                m_Winner = m_CurrentPlayer;
            }
            m_CurrentPlayer = (m_CurrentPlayer + 1) % 2;

            return m_NbPawnByCol[p_ColIndex] - 1;
        }

        public double GetScoreCol(int p_Col, bool p_Smart = false, int p_Player = -1, string v_XRayDirection = null, int v_Y=-1)
        {
            p_Player = p_Player == -1 ? m_CurrentPlayer : p_Player;

            double v_OwnVector1Score = 0.8;
            double v_OwnVector2Score = (v_OwnVector1Score + (p_Smart ? 2 : 0)) * 8;
            double v_OwnVector3Score = v_OwnVector2Score * 6 + 2;

            double v_EnemyVector1Score = m_NbPawn > 0 && p_Smart ? 0.5 : rd.NextDouble() / 2;
            double v_EnemyVector2Score = v_EnemyVector1Score + 2;
            double v_EnemyVector3Score = v_OwnVector2Score * 8 + 1;

            double v_BonusPossibleFuturWin = v_OwnVector2Score * (m_NbPawn <= 3 ? 5 : 2);
            double v_EmptyTileScore = v_OwnVector1Score * 4;

            // Récupérer la Tile actuelle
            Tile v_Tile;
            if (v_Y == -1)
            {
                int v_Row = m_NbPawnByCol[p_Col];
                if (v_Row > 5) { return -1.123; }

                v_Tile = m_Grid.Get(p_Col, v_Row);
                v_XRaySource = v_Tile;
                v_AllReadyCounted = new();
            } else
            {
                v_Tile = m_Grid.Get(p_Col, v_Y);
            }

            List<Tile> v_Neighbours = v_Tile.GetNeighbors();

            int v_DistanceFromSource = Convert.ToInt32(Math.Sqrt(Math.Pow(v_XRaySource.m_X - v_Tile.m_X, 2) + Math.Pow(v_XRaySource.m_Y - v_Tile.m_Y, 2)));

            double v_Score = 0;

            if (v_Tile.m_Player == -1 && v_Tile != v_XRaySource)
            {
                v_Score += v_EmptyTileScore;

                if (v_DistanceFromSource == 3)
                {
                    v_Score += v_BonusPossibleFuturWin;
                }
            } else {
                foreach(Tile v_Neighbour in v_Neighbours)
                {
                    if (v_Neighbour.m_Player == -1) { continue; }
                    string v_Direction = v_Tile.GetDirection(v_Neighbour);

                    foreach(Vecteur v_Vector in v_Neighbour.m_Vectors)
                    {
                        if(v_Vector.m_Direction == v_Direction)
                        {
                            if (v_Neighbour.m_Player == p_Player)
                            {
                                if (v_Vector == null) { v_Score += v_OwnVector1Score; }
                                else if (v_Vector.m_Lenght == 2) { v_Score += v_OwnVector2Score; }
                                else if (v_Vector.m_Lenght == 3) { v_Score += v_OwnVector3Score; }
                            } else
                            {
                                if (v_Vector == null) { v_Score += v_EnemyVector1Score; }
                                else if (v_Vector.m_Lenght == 2) { v_Score += v_EnemyVector2Score; }
                                else if (v_Vector.m_Lenght == 3) { v_Score += v_EnemyVector3Score; }
                            }
                        }
                    }
                }
            }

            if (!p_Smart) { return v_Score; }

            // Regarder si le coup debloquer des coups dangereux
            foreach (Tile v_Neighbour in v_Neighbours)
            {
                string v_Direction = v_Tile.GetDirection(v_Neighbour);
                if (v_Neighbour.m_Player == -1 && !v_AllReadyCounted.Contains(v_Neighbour) && (v_Direction == v_XRayDirection || v_XRayDirection == null))
                {
                    v_AllReadyCounted.Add(v_Neighbour);
                    v_Score += GetScoreCol(v_Neighbour.m_X, true, p_Player, v_Direction, v_Neighbour.m_Y);
                } else if (v_Neighbour.m_Player == p_Player)
                {
                    v_Score += v_EmptyTileScore;

                    if (v_DistanceFromSource == 3) { v_Score += v_BonusPossibleFuturWin; }
                }
            }

            return v_Score;
        }

        public bool CheckIfDraw()
        {
            int v_TotalPawn = m_NbPawnByCol.Count;
            return v_TotalPawn >= Grid.NUMBER_OF_COLS * Grid.NUMBER_OF_ROWS;
        }


        /// <summary>
        /// Crée un pion
        /// </summary>
        /// <param name="p_Puissance4"> La partie de puissance4</param>
        /// <returns>Le pion</returns>
        public PictureBox CreatePawn()
        {
            if (m_CurrentPlayer == 0)
                return CreatePawn(ColorTranslator.FromHtml("#EE6677"));
            return CreatePawn(ColorTranslator.FromHtml("#18BC9C"));
        }

        /// <summary>
        /// Crée un pion
        /// </summary>
        /// <param name="p_Color">La couleur du pion</param>
        /// <returns>Le pion</returns>
        private static PictureBox CreatePawn(Color p_Color)
        {
            PictureBox v_PBBoxPawn = new();

            // Création d'une bitmap
            Bitmap v_Bitmap = new(32, 32);

            // Création d'un objet graphics pour dessiner dessus
            Graphics v_Graphics = Graphics.FromImage(v_Bitmap);

            // Ecriture sur l'objet
            LinearGradientBrush v_LinearGradientBrush = new(new Rectangle(0, 0, 40, 30), p_Color, Color.White, -45, false);

            // Remplissage
            v_Graphics.FillEllipse(v_LinearGradientBrush, 0, 0, v_Bitmap.Size.Width, v_Bitmap.Size.Height);

            // Attribution
            v_PBBoxPawn.Image = v_Bitmap;
            v_PBBoxPawn.SizeMode = PictureBoxSizeMode.StretchImage;

            return v_PBBoxPawn;
        }
    }
}