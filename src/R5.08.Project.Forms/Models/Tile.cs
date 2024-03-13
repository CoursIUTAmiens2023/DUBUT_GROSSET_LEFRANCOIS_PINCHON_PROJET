namespace R5._08.Project.Forms.Models
{
    public class Tile : ICloneable
    {
        public List<Vecteur> m_Vectors = new();
        public List<Vecteur> m_WinVectors = new();

        public int m_Player; // 0 -> J1 | 1 -> J2 | -1 -> personne
        public int m_X;
        public int m_Y;
        public int m_GridId;

        // Déplacements dans les axes x et y inclus dans les tableaux (Voisinage)
        int[] v_Dx = { -1, 0, 1, -1, 1, -1, 0, 1 };
        int[] v_Dy = { -1, -1, -1, 0, 0, 1, 1, 1 };

        public Tile(int p_Player, int p_X, int p_Y, int p_GridId)
        {
            m_Player = p_Player;
            m_X = p_X;
            m_Y = p_Y;

            m_GridId = p_GridId;
        }

        public string GetDirection(Tile p_Tile)
        {
            int v_XDirection = p_Tile.m_X - m_X; // -1: à gauche  | 0: même niveau | 1: à droite
            int v_YDirection = p_Tile.m_Y - m_Y; // -1: au dessus | 0: même niveau | 1: en dessous

            string v_Direction = string.Empty;

            // { "Vertical", "Horizontale", "Diagonale-Gauche", "Diagonale-Droite" }
            if (v_XDirection == -1 && v_YDirection == -1 || v_XDirection == 1 && v_YDirection == 1)
            {
                v_Direction = "Diagonale-Gauche";
            }
            else if (v_XDirection == -1 && v_YDirection == 0 || v_XDirection == 1 && v_YDirection == 0)
            {
                v_Direction = "Horizontale";
            }
            else if (v_XDirection == -1 && v_YDirection == 1 || v_XDirection == 1 && v_YDirection == -1)
            {
                v_Direction = "Diagonale-Droite";
            }
            else if (v_XDirection == 0 && v_YDirection == -1 || v_XDirection == 0 && v_YDirection == 1)
            {
                v_Direction = "Verticale";
            }
            else { throw (new Exception("Direction invalide")); }

            return v_Direction;
        }

        /** Permet de mettre à jour un les vecteurs de la tailles selon ses voisins; on passe en paramètre la nouvelle tile **/

        public void UpdateVector(Tile p_Tile)
        {
            if (p_Tile.m_Player != m_Player || p_Tile.m_Player == -1 || m_Player == -1)
                return;

            string v_Direction = GetDirection(p_Tile);

            // Metre à jour les vecteurs existants
            foreach (Vecteur v_Vector in m_Vectors)
            {
                if (v_Vector.m_Direction == v_Direction)
                {
                    v_Vector.AddCoo(p_Tile.m_X, p_Tile.m_Y);
                    p_Tile.m_Vectors.Add(v_Vector);

                    if (v_Vector.m_Lenght >= 4)
                    {
                        p_Tile.m_WinVectors.Add(v_Vector);
                    }
                }
            }

            Vecteur v_NewVector = new(2, v_Direction);
            v_NewVector.m_Coo = new List<int[]>();
            v_NewVector.AddCoo(m_X, m_Y);
            v_NewVector.AddCoo(p_Tile.m_X, p_Tile.m_Y);

            Console.WriteLine("---------------------------------------------------");

            p_Tile.m_Vectors.Add(v_NewVector);
            m_Vectors.Add(v_NewVector);
        }

        public void UpdateTilePlayer(int p_Player)
        {
            m_Player = p_Player;
            List<Tile> v_Neighbors = GetNeighbors();
            Console.WriteLine(v_Neighbors.Count);// TODO ICI
            foreach (Tile v_Neighbor in v_Neighbors)
            {
                v_Neighbor.UpdateVector(this);
                v_Neighbor.FusionVectors();
            }
            FusionVectors();
            Print();
        }

        /** Mettre à jour la taille des vecteurs de la Tile **/

        public void FusionVectors()
        {
            // { "Vertical", "Horizontale", "Diagonale-Gauche", "Diagonale-Droite" }

            List<Vecteur> v_Vertical = new();
            List<Vecteur> v_Horizontal = new();
            List<Vecteur> v_DiagonaleGauche = new();
            List<Vecteur> v_DiagonaleDroite = new();

            foreach (Vecteur v_Vector in m_Vectors)
            {
                switch (v_Vector.m_Direction)
                {
                    case "Verticale":
                        v_Vertical.Add(v_Vector);
                        break;

                    case "Horizontale":
                        v_Horizontal.Add(v_Vector);
                        break;

                    case "Diagonale-Gauche":
                        v_DiagonaleGauche.Add(v_Vector);
                        break;

                    case "Diagonale-Droite":
                        v_DiagonaleDroite.Add(v_Vector);
                        break;

                    default:
                        throw new Exception("Direction invalide");
                }
            }

            List<List<Vecteur>> v_AllVectors = new()
            {
                v_Vertical,
                v_Horizontal,
                v_DiagonaleDroite,
                v_DiagonaleGauche
            };
            Grid v_CurrentGrid = Grid.m_AllGrids[m_GridId];

            foreach (List<Vecteur> v_VectorList in v_AllVectors)
            {
                Vecteur v_RootVector = new(0, "---");
                foreach (Vecteur v_Vecteur in v_VectorList)
                {
                    if (v_RootVector.m_Lenght == 0)
                    {
                        v_RootVector.m_Lenght = v_Vecteur.m_Lenght;
                        v_RootVector.MergeCoo(v_Vecteur.m_Coo);
                        v_RootVector.m_Direction = v_Vecteur.m_Direction;
                    }
                    else
                    {
                        v_RootVector.MergeCoo(v_Vecteur.m_Coo);
                        v_RootVector.m_Lenght = v_RootVector.m_Coo.Count;
                    }

                    foreach (int[] v_Coo in v_Vecteur.m_Coo)
                    {
                        Tile v_OtherTile = v_CurrentGrid.m_GridTiles[(v_Coo[0], v_Coo[1])];
                        v_OtherTile.m_Vectors.Remove(v_Vecteur);
                    }
                }

                if (v_RootVector.m_Direction != "---")
                {
                    if (v_RootVector.m_Lenght >= 4)
                    {
                        m_WinVectors.Add(v_RootVector);
                    }

                    foreach (int[] v_Coo in v_RootVector.m_Coo)
                    {
                        Tile v_OtherTile = v_CurrentGrid.m_GridTiles[(v_Coo[0], v_Coo[1])];
                        v_OtherTile.m_Vectors.Add(v_RootVector);
                    }
                }
            }
        }

        /** Récupérer les voisins de la Tile **/

        public List<Tile> GetNeighbors()
        {
            List<Tile> v_Neighbors = new();

            // Vérifiez chaque voisin potentiel
            for (int v_Index = 0; v_Index < 8; v_Index++)
            {
                int v_NeighborX = m_X + v_Dx[v_Index];
                int v_NeighborY = m_Y + v_Dy[v_Index];

                if (Grid.m_AllGrids[m_GridId].m_GridTiles.TryGetValue((v_NeighborX, v_NeighborY), out var v_NeighborTile))
                {
                    v_Neighbors.Add(v_NeighborTile);
                }
            }

            return v_Neighbors;
        }

        public void Print()
        {
            Console.WriteLine("+-------- Tile: " + m_X + ", " + m_Y + " --------+");
            foreach (Vecteur v_Vecteur in m_Vectors)
            {
                Console.WriteLine("| > V(" + v_Vecteur.m_Coo[0][0] + ", " + v_Vecteur.m_Coo[0][0] + ") --" + v_Vecteur.m_Lenght + "--> " + v_Vecteur.m_Direction);
                foreach (int[] Coo in v_Vecteur.m_Coo)
                {
                    Console.WriteLine("| | > " + Coo[0] + ", " + Coo[1]);
                }
            }
            Console.WriteLine("+-------------------------------+");
        }

        public object Clone()
        {
            Tile v_Tile = (Tile)MemberwiseClone();
            v_Tile.m_WinVectors = new List<Vecteur>();
            v_Tile.m_GridId = -1;
            foreach (Vecteur v_Vector in m_WinVectors)
            {
                v_Tile.m_WinVectors.Add((Vecteur)v_Vector.Clone());
            }

            v_Tile.m_Vectors = new List<Vecteur>();
            foreach (Vecteur v_Vector in m_Vectors)
            {
                v_Tile.m_Vectors.Add((Vecteur)v_Vector.Clone());
            }
            return v_Tile;
        }
    }
}