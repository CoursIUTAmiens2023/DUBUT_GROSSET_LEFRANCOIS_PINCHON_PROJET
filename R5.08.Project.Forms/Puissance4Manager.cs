using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetForm
{
    public static class Puissance4Manager
    {
        public static int BOARD_NUMBER_LINE = 6;
        public static int BOARD_NUMBER_COLUMN = 7;

        /// <summary>
        /// Crée un pion
        /// </summary>
        /// <param name="puissance4"> La partie de puissance4</param>
        /// <returns>Le pion</returns>
        public static PictureBox CreatePawn(Puissance4 puissance4)
        {
            if (puissance4.isRedPlayerToPlay())
                return CreatePawn(puissance4, Color.Red);
            return CreatePawn(puissance4, Color.Yellow);
        }

        /// <summary>
        /// Crée un pion
        /// </summary>
        /// <param name="puissance4">La partie de puissance4</param>
        /// <param name="p_Color">La couleur du pion</param>
        /// <returns>Le pion</returns>
        private static PictureBox CreatePawn(Puissance4 puissance4, Color p_Color)
        {
            PictureBox v_PBBoxPawn = new PictureBox();

            // Création d'une bitmap
            Bitmap v_Bitmap = new Bitmap(32, 32);

            // Création d'un objet graphics pour dessiner dessus
            Graphics v_Graphics = Graphics.FromImage(v_Bitmap);
            ;
            // Ecriture sur l'objet
            LinearGradientBrush v_LinearGradientBrush = new LinearGradientBrush(new Rectangle(0, 0, 40, 30), p_Color, Color.White, -45, false);

            // Remplissage
            v_Graphics.FillEllipse(v_LinearGradientBrush, 0, 0, v_Bitmap.Size.Width, v_Bitmap.Size.Height);

            // Attribution
            v_PBBoxPawn.Image = v_Bitmap;
            v_PBBoxPawn.SizeMode = PictureBoxSizeMode.StretchImage;

            return v_PBBoxPawn;
        }

        /// <summary>
        /// Retour la position du pion
        /// </summary>
        /// <param name="puissance4">La partie de puissance4</param>
        /// <param name="p_pawnColmunPosition">La colonne choisi par le joueur</param>
        /// <returns>La position du pion (retourn (-1, -1) s'il n'y a pas d'emplacement libre)</returns>
        public static Point GetPawnPosition(Puissance4 puissance4, int p_pawnColmunPosition)
        {
            int v_pawnLinePosition = 5;
            bool v_pawnLinePositionFind = false;
            int v_pawnColmunPosition = p_pawnColmunPosition - 1;

            while (!v_pawnLinePositionFind && v_pawnLinePosition >= 0)
            {
                if (puissance4.getBoard()[v_pawnLinePosition, v_pawnColmunPosition])
                {
                    v_pawnLinePosition--;
                }
                else
                {
                    v_pawnLinePositionFind = true;
                }
            }

            if (v_pawnLinePositionFind)
                return new Point(v_pawnColmunPosition, v_pawnLinePosition);

            return new Point(-1, -1);
        }

        /// <summary>
        /// Retourne s'il y a eu un gagnant ou non.
        /// </summary>
        /// <param name="puissance4">La partie de puissance4</param>
        /// <returns>Vrai ou faux selon s'il y a un gagnant</returns>
        public static bool CheckIfWin(Puissance4 puissance4)
        {
            // Si c'est au rouge de jouer, c'est que le jaune vient de jouer, donc on vérifie s'il à gagné
            bool v_playerWin;
            if (puissance4.isRedPlayerToPlay())
                v_playerWin = CheckIfWin(puissance4.getYellowPawnOnBoard());
            else v_playerWin = CheckIfWin(puissance4.getRedPawnOnBoard());

            return v_playerWin;
        }

        /// <summary>
        /// Retourne vrai ou faux si le joueur a gagné ou non
        /// </summary>
        /// <param name="p_pawnOnBoard">Les pions posés par le joueur</param>
        /// <returns>Vrai ou faux si le joueur a gagné ou non</returns>
        private static bool CheckIfWin(bool[,] p_pawnOnBoard)
        {
            if (CheckIfWinLine(p_pawnOnBoard)) return true;
            if (CheckIfWinColumn(p_pawnOnBoard)) return true;
            if (CheckIfWinDiagonal(p_pawnOnBoard)) return true;

            return false;
        }

        /// <summary>
        /// Retourne vrai ou faux si le joueur a alligner 4 pions sur une ligne
        /// </summary>
        /// <param name="p_pawnOnBoard">Les pions posés par le joueur</param>
        /// <returns> Vrai ou faux si le joueur a alligner 4 pions sur une ligne </returns>
        private static bool CheckIfWinLine(bool[,] p_pawnOnBoard)
        {
            bool v_playerWin = false;

            for (int v_line = BOARD_NUMBER_LINE - 1; v_line >= 0 && !v_playerWin; v_line--)
            {
                int v_nbrOfPawnInARow = 0;

                for (int v_column = 0; v_column < BOARD_NUMBER_COLUMN && !v_playerWin; v_column++)
                {
                    if (p_pawnOnBoard[v_line, v_column])
                    {
                        v_nbrOfPawnInARow++;
                        if (v_nbrOfPawnInARow == 4)
                            v_playerWin = true;
                    }
                    else
                    {
                        v_nbrOfPawnInARow = 0;
                    }
                }
            }

            return v_playerWin;
        }

        /// <summary>
        /// Retourne vrai ou faux si le joueur a alligner 4 pions sur une colonne
        /// </summary>
        /// <param name="p_pawnOnBoard">Les pions posés par le joueur</param>
        /// <returns> Vrai ou faux si le joueur a alligner 4 pions sur une colonne </returns>
        private static bool CheckIfWinColumn(bool[,] p_pawnOnBoard)
        {
            bool v_playerWin = false;

            for (int v_column = 0; v_column < BOARD_NUMBER_COLUMN && !v_playerWin; v_column++)
            {
                int v_nbrOfPawnInARow = 0;

                for (int v_line = BOARD_NUMBER_LINE - 1; v_line >= 0 && !v_playerWin; v_line--)
                {
                    if (p_pawnOnBoard[v_line, v_column])
                    {
                        v_nbrOfPawnInARow++;
                        if (v_nbrOfPawnInARow == 4)
                            v_playerWin = true;
                    }
                    else
                    {
                        v_nbrOfPawnInARow = 0;
                    }
                }
            }

            return v_playerWin;
        }

        /// <summary>
        /// Retourne vrai ou faux si le joueur a alligner 4 pions sur une diagonale
        /// </summary>
        /// <param name="p_pawnOnBoard">Les pions posés par le joueur</param>
        /// <returns> Vrai ou faux si le joueur a alligner 4 pions sur une diagonale </returns>
        private static bool CheckIfWinDiagonal(bool[,] p_pawnOnBoard)
        {
            bool v_playerWin = false;

            for (int v_line = BOARD_NUMBER_LINE - 1; v_line >= 0 && !v_playerWin; v_line--)
            {

                for (int v_column = 0; v_column < BOARD_NUMBER_COLUMN && !v_playerWin; v_column++)
                {
                    v_playerWin = CheckIfWinDiagonalBotLeftToTopRight(p_pawnOnBoard, v_line, v_column);
                    if (!v_playerWin)
                        v_playerWin = CheckIfWinDiagonalBotRightToTopLeft(p_pawnOnBoard, v_line, v_column);
                }
            }

            return v_playerWin;
        }

        /// <summary>
        /// Retourne vrai ou faux si le joueur a alligner 4 pions sur une diagonale 
        /// (vérifie les diagonales qui commencent en bas à gauche et finissent en haut à droite)
        /// </summary>
        /// <param name="p_pawnOnBoard">Les pions posés par le joueur</param>
        /// <returns> Vrai ou faux si le joueur a alligner 4 pions sur une diagonale </returns>
        private static bool CheckIfWinDiagonalBotLeftToTopRight(bool[,] p_pawnOnBoard, int p_line, int p_column)
        {
            int v_nbrOfPawnInARow = 0;

            for (int v_diagonal = 0; v_diagonal < 4; v_diagonal++)
            {
                if (p_line - v_diagonal > -1 && p_column + v_diagonal < 7)
                {
                    if (p_pawnOnBoard[p_line - v_diagonal, p_column + v_diagonal])
                    {
                        v_nbrOfPawnInARow++;
                    }
                }
            }

            return v_nbrOfPawnInARow == 4;
        }

        /// <summary>
        /// Retourne vrai ou faux si le joueur a alligner 4 pions sur une diagonale 
        /// (vérifie les diagonales qui commencent en bas à droite et finissent en haut à gauche)
        /// </summary>
        /// <param name="p_pawnOnBoard">Les pions posés par le joueur</param>
        /// <returns> Vrai ou faux si le joueur a alligner 4 pions sur une diagonale </returns>
        private static bool CheckIfWinDiagonalBotRightToTopLeft(bool[,] p_pawnOnBoard, int p_line, int p_column)
        {
            int v_nbrOfPawnInARow = 0;

            for (int v_diagonal = 0; v_diagonal < 4; v_diagonal++)
            {
                if (p_line - v_diagonal > -1 && p_column - v_diagonal > -1)
                {
                    if (p_pawnOnBoard[p_line - v_diagonal, p_column - v_diagonal])
                    {
                        v_nbrOfPawnInARow++;
                    }
                }
            }

            return v_nbrOfPawnInARow == 4;
        }
    }
}
