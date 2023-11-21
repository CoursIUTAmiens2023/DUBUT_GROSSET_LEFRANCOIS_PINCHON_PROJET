using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetForm
{
    public class Puissance4
    {

        private String joueur1;
        private String joueur2;
        private bool redPlayerToPlay;
        private bool playerVSPlayerMode;
        bool[,] board;
        bool[,] redPawnOnBoard;
        bool[,] yellowPawnOnBoard;

        public Puissance4(string joueur1, string joueur2, bool playerVSPlayerMode)
        {
            this.joueur1 = joueur1;
            this.joueur2 = joueur2;
            this.redPlayerToPlay = true;
            this.playerVSPlayerMode = playerVSPlayerMode;
            this.board = new bool[Puissance4Manager.BOARD_NUMBER_LINE, Puissance4Manager.BOARD_NUMBER_COLUMN];
            this.redPawnOnBoard = new bool[Puissance4Manager.BOARD_NUMBER_LINE, Puissance4Manager.BOARD_NUMBER_COLUMN];
            this.yellowPawnOnBoard = new bool[Puissance4Manager.BOARD_NUMBER_LINE, Puissance4Manager.BOARD_NUMBER_COLUMN];
        }

        public void setJoueur1(String joueur1)
        {
            this.joueur1 = joueur1;
        }

        public String getJoueur1 ()
        {
            return this.joueur1;
        }

        public void setJoueur2(String joueur2) 
        { 
            this.joueur2 = joueur2;
        }

        public String getJoueur2 ()
        {
            return this.joueur2;
        }

        public void setRedPlayerToPlay(bool redPlayerToPlay)
        {
            this.redPlayerToPlay = redPlayerToPlay;
        }

        public bool isRedPlayerToPlay()
        {
            return this.redPlayerToPlay;
        }

        public void setPlayerVSPlayerMode(bool playerVSPlayerMode)
        {
            this.playerVSPlayerMode = playerVSPlayerMode;
        }

        public bool isPlayerVSPlayerMode()
        {
            return this.playerVSPlayerMode;
        }

        public void setOnBoard(int p_x, int p_y, bool isOnBoard)
        {
            this.board[p_x, p_y] = isOnBoard;
        }

        public bool[,] getBoard()
        {
            return this.board;
        }

        public void setRedPawnOnBoard(int p_x, int p_y, bool isOnBoard)
        {
            this.redPawnOnBoard[p_x, p_y] = isOnBoard;
        }

        public bool[,] getRedPawnOnBoard()
        {
            return this.redPawnOnBoard;
        }

        public void setYellowPawnOnBoard(int p_x, int p_y, bool isOnBoard)
        {
            this.yellowPawnOnBoard[p_x, p_y] = isOnBoard;
        }

        public bool[,] getYellowPawnOnBoard()
        {
            return this.yellowPawnOnBoard;
        }
    }
}
