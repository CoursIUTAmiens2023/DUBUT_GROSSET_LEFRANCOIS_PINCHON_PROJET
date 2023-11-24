using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetForm
{
    public class Puissance4
    {

        private String v_Joueur1;
        private String v_Joueur2;
        private bool v_RedPlayerToPlay;
        private bool v_PlayerVSPlayerMode;
        bool[,] v_Board;
        bool[,] v_RedPawnOnBoard;
        bool[,] v_YellowPawnOnBoard;

        public Puissance4(string p_Joueur1, string p_Joueur2, bool p_PlayerVSPlayerMode)
        {
            this.v_Joueur1 = p_Joueur1;
            this.v_Joueur2 = p_Joueur2;
            this.v_RedPlayerToPlay = true;
            this.v_PlayerVSPlayerMode = p_PlayerVSPlayerMode;
            this.v_Board = new bool[Puissance4Manager.BOARD_NUMBER_LINE, Puissance4Manager.BOARD_NUMBER_COLUMN];
            this.v_RedPawnOnBoard = new bool[Puissance4Manager.BOARD_NUMBER_LINE, Puissance4Manager.BOARD_NUMBER_COLUMN];
            this.v_YellowPawnOnBoard = new bool[Puissance4Manager.BOARD_NUMBER_LINE, Puissance4Manager.BOARD_NUMBER_COLUMN];
        }

        public void setJoueur1(String p_Joueur1)
        {
            this.v_Joueur1 = p_Joueur1;
        }

        public String getJoueur1 ()
        {
            return this.v_Joueur1;
        }

        public void setJoueur2(String p_Joueur2) 
        { 
            this.v_Joueur2 = p_Joueur2;
        }

        public String getJoueur2 ()
        {
            return this.v_Joueur2;
        }

        public void setRedPlayerToPlay(bool p_RedPlayerToPlay)
        {
            this.v_RedPlayerToPlay = p_RedPlayerToPlay;
        }

        public bool isRedPlayerToPlay()
        {
            return this.v_RedPlayerToPlay;
        }

        public void setPlayerVSPlayerMode(bool p_PlayerVSPlayerMode)
        {
            this.v_PlayerVSPlayerMode = p_PlayerVSPlayerMode;
        }

        public bool isPlayerVSPlayerMode()
        {
            return this.v_PlayerVSPlayerMode;
        }

        public void setOnBoard(int p_x, int p_y, bool p_IsOnBoard)
        {
            this.v_Board[p_x, p_y] = p_IsOnBoard;
        }

        public bool[,] getBoard()
        {
            return this.v_Board;
        }

        public void setRedPawnOnBoard(int p_x, int p_y, bool p_IsOnBoard)
        {
            this.v_RedPawnOnBoard[p_x, p_y] = p_IsOnBoard;
        }

        public bool[,] getRedPawnOnBoard()
        {
            return this.v_RedPawnOnBoard;
        }

        public void setYellowPawnOnBoard(int p_x, int p_y, bool p_IsOnBoard)
        {
            this.v_YellowPawnOnBoard[p_x, p_y] = p_IsOnBoard;
        }

        public bool[,] getYellowPawnOnBoard()
        {
            return this.v_YellowPawnOnBoard;
        }
    }
}
