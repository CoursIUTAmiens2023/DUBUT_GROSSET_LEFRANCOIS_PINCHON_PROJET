using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace R5._08.Project.Forms.Models
{
    public class Tile: ICloneable
    {
        public List<Vecteur> v_Vectors = new List<Vecteur>();
        public List<Vecteur> v_WinVectors = new List<Vecteur>();

        public int v_Player; // 0 -> J1 | 1 -> J2 | -1 -> personne
        public int x;
        public int y;
        public int v_GridId;

        public Tile(int p_Player, int x, int y, int v_GridId)
        {
            this.v_Player = p_Player;
            this.x = x;
            this.y = y;

            this.v_GridId = v_GridId;
        }

        /** Permet de mettre à jour un les vecteurs de la tailles selon ses voisins; on passe en paramètre la nouvelle tile **/
        public void UpdateVector(Tile p_tile)
        {   
            if (p_tile.v_Player != v_Player || p_tile.v_Player == -1 || v_Player == -1) { return; }
            int v_XDirection = p_tile.x - this.x; // -1: à gauche  | 0: même niveau | 1: à droite
            int v_YDirection = p_tile.y - this.y; // -1: au dessus | 0: même niveau | 1: en dessous
            Console.WriteLine("update: " + this.x + ", " + this.y + " to " + p_tile.x + ", " + p_tile.y);
            string v_Direction;

            // { "Vertical", "Horizontale", "Diagonale-Gauche", "Diagonale-Droite" }
            if (v_XDirection == -1 && v_YDirection == -1 || v_XDirection == 1 && v_YDirection == 1)
            {
                v_Direction = "Diagonale-Gauche";

            } else if (v_XDirection == -1 && v_YDirection == 0 || v_XDirection == 1 && v_YDirection == 0)
            {
                v_Direction = "Horizontale";

            } else if (v_XDirection == -1 && v_YDirection == 1 || v_XDirection == 1 && v_YDirection == -1)
            {
                v_Direction = "Diagonale-Droite";

            } else if (v_XDirection == 0 && v_YDirection == -1 || v_XDirection == 0 && v_YDirection == 1)
            {
                v_Direction = "Verticale";

            } else { return; }
            Console.WriteLine(v_Direction + ": " + v_XDirection + ", " + v_YDirection);
            Console.WriteLine("Update direction " +  v_Direction);

            // Metre à jour les vecteurs existants
            foreach (Vecteur vector in this.v_Vectors)
            {
                if (vector.v_Direction == v_Direction)
                {
                    vector.AddCoo(p_tile.x, p_tile.y);
                    p_tile.v_Vectors.Add(vector);

                    if (vector.v_Lenght >= 4)
                    {
                        p_tile.v_WinVectors.Add(vector);
                    }
                }
            }

            Vecteur v_NewVector = new(2, v_Direction);
            v_NewVector.v_Coo = new List<int[]>();
            v_NewVector.AddCoo(this.x, this.y);
            v_NewVector.AddCoo(p_tile.x, p_tile.y);

            Console.WriteLine("---------------------------------------------------");

            p_tile.v_Vectors.Add(v_NewVector);
            this.v_Vectors.Add(v_NewVector);
        }

        public void UpdateTilePlayer(int player)
        {
            this.v_Player = player;
            List<Tile> neighbors = GetNeighbors();
            Console.WriteLine(neighbors.Count);// TODO ICI
            foreach (Tile neighbor in neighbors) 
            {
                neighbor.UpdateVector(this);
                neighbor.FusionVectors();
            }
            FusionVectors();
            this.print();
        }

        /** Mettre à jour la taille des vecteurs de la Tile **/
        public void FusionVectors()
        {
            // { "Vertical", "Horizontale", "Diagonale-Gauche", "Diagonale-Droite" }

            List<Vecteur> v_Vertical = new List<Vecteur>();
            List<Vecteur> v_Horizontal = new List<Vecteur>();
            List<Vecteur> v_DiagonaleGauche = new List<Vecteur>();
            List<Vecteur> v_DiagonaleDroite = new List<Vecteur>();

            foreach (Vecteur v_Vector in this.v_Vectors)
            {
                if (v_Vector.v_Direction == "Verticale") { v_Vertical.Add(v_Vector); }
                else if (v_Vector.v_Direction == "Horizontale") { v_Horizontal.Add(v_Vector); }
                else if (v_Vector.v_Direction == "Diagonale-Gauche") { v_DiagonaleGauche.Add(v_Vector); }
                else if (v_Vector.v_Direction == "Diagonale-Droite") { v_DiagonaleDroite.Add(v_Vector); }
                else { throw new Exception("Direction invalide"); }
            }

            List<List<Vecteur>> v_AllVectors = new List<List<Vecteur>>();
            v_AllVectors.Add(v_Vertical);
            v_AllVectors.Add(v_Horizontal);
            v_AllVectors.Add(v_DiagonaleDroite);
            v_AllVectors.Add(v_DiagonaleGauche);
            Grid CurrentGrid = Grid.ALL_GRIDS[v_GridId];

            foreach (List<Vecteur> VectorList in v_AllVectors)
            {
                Vecteur v_RootVector = new Vecteur(0, "---");
                foreach (Vecteur v_Vecteur in VectorList)
                {
                    if (v_RootVector.v_Lenght == 0)
                    {
                        v_RootVector.v_Lenght = v_Vecteur.v_Lenght;
                        v_RootVector.MergeCoo(v_Vecteur.v_Coo);
                        v_RootVector.v_Direction = v_Vecteur.v_Direction;
                    } else
                    {
                        v_RootVector.MergeCoo(v_Vecteur.v_Coo);
                        v_RootVector.v_Lenght = v_RootVector.v_Coo.Count;
                    }

                    foreach (int[] Coo in v_Vecteur.v_Coo)
                    {
                        Tile OtherTile = CurrentGrid.v_GridTiles[(Coo[0], Coo[1])];
                        OtherTile.v_Vectors.Remove(v_Vecteur);
                    }
                }

                if (v_RootVector.v_Direction != "---")
                {
                    if (v_RootVector.v_Lenght >= 4)
                    {
                        this.v_WinVectors.Add(v_RootVector);
                    }

                    foreach (int[] Coo in v_RootVector.v_Coo)
                    {
                        Tile OtherTile = CurrentGrid.v_GridTiles[(Coo[0], Coo[1])];
                        OtherTile.v_Vectors.Add(v_RootVector);
                    }
                }
            }
        }

        /** Récupérer les voisins de la Tile **/
        public List<Tile> GetNeighbors()
        {
            List<Tile> v_Neighbors = new List<Tile>();

            // Déplacements dans les axes x et y inclus dans les tableaux
            int[] dx = { -1, 0, 1, -1, 1, -1, 0, 1 };
            int[] dy = { -1, -1, -1, 0, 0, 1, 1, 1 };

            // Vérifiez chaque voisin potentiel
            for (int i = 0; i < 8; i++)
            {
                int v_NeighborX = this.x + dx[i];
                int v_NeighborY = this.y + dy[i];

                if (Grid.ALL_GRIDS[v_GridId].v_GridTiles.TryGetValue((v_NeighborX, v_NeighborY), out var v_NeighborTile))
                {
                    v_Neighbors.Add(v_NeighborTile);
                }
            }

            return v_Neighbors;
        }

        public void print()
        {
            Console.WriteLine("+-------- Tile: " + this.x + ", " + this.y + " --------+");
            foreach (Vecteur vecteur in this.v_Vectors)
            {
                Console.WriteLine("| > V(" + vecteur.v_Coo[0][0] + ", " + vecteur.v_Coo[0][0] + ") --" + vecteur.v_Lenght + "--> " + vecteur.v_Direction);
                foreach (int[] Coo in vecteur.v_Coo)
                {
                    Console.WriteLine("| | > " + Coo[0] + ", " + Coo[1]);
                }
            }
            Console.WriteLine("+-------------------------------+");
        }

        public object Clone()
        {
            Tile tile = (Tile)MemberwiseClone();
            tile.v_WinVectors = new List<Vecteur>();
            tile.v_GridId = -1;
            foreach (Vecteur v_Vector in this.v_WinVectors)
            {
                tile.v_WinVectors.Add((Vecteur)v_Vector.Clone());
            }

            tile.v_Vectors = new List<Vecteur>();
            foreach (Vecteur v_Vector in this.v_Vectors)
            {
                tile.v_Vectors.Add((Vecteur)v_Vector.Clone());
            }
            return tile;
        }
    }
}
