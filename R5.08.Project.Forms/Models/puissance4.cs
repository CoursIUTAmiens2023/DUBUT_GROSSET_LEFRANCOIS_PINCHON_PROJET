using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R5._08.Project.Forms.Models
{
    public class puissance4: ICloneable
    {
        public Grid grid;// = new Grid();

        public List<int> v_NbPawnByCol = new List<int>();
        
        public int v_CurrentPlayer = 0;

        public int v_Winner = -1;

        public string v_Joueur1 = "";
        public string v_Joueur2 = "";

        public int v_NbPawn = 0;
        public int v_difficulty = -1;

        public puissance4()
        {
            grid = new Grid();
            // Initialiser les colonnes
            for (int col_index = 0; col_index < Grid.NUMBER_OF_COLS; col_index++)
            {
                v_NbPawnByCol.Add(0);
            }
        }

        private puissance4(int _)
        {
            // Initialiser les colonnes
            for (int col_index = 0; col_index < Grid.NUMBER_OF_COLS; col_index++)
            {
                v_NbPawnByCol.Add(0);
            }
        }

        public object Clone()
        {
            //puissance4 v_Puissance4 = (puissance4)MemberwiseClone();
            puissance4 v_Puissance4 = new puissance4(0);

            v_Puissance4.v_Joueur1 = v_Joueur1;
            v_Puissance4.v_Joueur2 = v_Joueur2;
            v_Puissance4.v_difficulty = v_difficulty;
            v_Puissance4.v_Winner = v_Winner;
            v_Puissance4.v_CurrentPlayer = v_CurrentPlayer;
            v_Puissance4.v_NbPawn = v_NbPawn;
            v_Puissance4.grid = (Grid)grid.Clone();
            v_Puissance4.v_NbPawnByCol = new List<int>(v_NbPawnByCol);

            return v_Puissance4;
        }

        public string GetPlayerToPlay()
        {
            return v_CurrentPlayer == 0 ? v_Joueur1 : v_Joueur2;
        }

        public string GetWinnerName()
        {
            if (v_Winner == -1) { throw new Exception("Impossible de récupérer le nom du gagnant car il n'y a pas de gagnant"); }
            return v_Winner == 0 ? v_Joueur1 : v_Joueur2;
        }

        public List<int> GetAvailableCols()
        {
            List<int> cols = new List<int>();
            for (int col_index = 0; col_index < Grid.NUMBER_OF_COLS; col_index ++)
            {
                if (v_NbPawnByCol[col_index] < Grid.NUMBER_OF_ROWS)
                {
                    cols.Add(col_index);
                }
            }
            return cols;
        }

        public int PlacePawn(int col_index)
        {
            if (col_index < 0 || col_index >= Grid.NUMBER_OF_COLS)
            {
                throw new ArgumentException("Index de colonne invalide");
            }

            if (v_NbPawnByCol[col_index] - 1 >= Grid.NUMBER_OF_ROWS)
            {
                throw new ArgumentException("Plus de place dans la colonne choisie");
            }

            this.grid.Play(col_index, v_NbPawnByCol[col_index], this.v_CurrentPlayer);
            v_NbPawnByCol[col_index]++;

            v_NbPawn++;

            // Vérifier s'il y a un gagnant
            if (grid.v_WinVectors.Count > 0 && v_Winner == -1)
            {
                this.v_Winner = v_CurrentPlayer;
            }
            this.v_CurrentPlayer = (this.v_CurrentPlayer + 1) % 2;

            return v_NbPawnByCol[col_index] - 1;
        }

        public bool CheckIfDraw()
        {
            int v_TotalPawn = v_NbPawnByCol.Sum(x => x);
            return v_TotalPawn >= Grid.NUMBER_OF_COLS * Grid.NUMBER_OF_ROWS;
        }
    }
}
