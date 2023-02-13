using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;

namespace Minesweeper.Models
{
    public class Board
    {
        public int rows { get; set; }
        public int cols { get; set; }

        public Tile[,] board;

        public Board(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
           board = new Tile[rows, cols];
            
        }

        public void Initialize()
        {
            int pool;
           // if (rows == 8 || cols == 8)
           // {
                pool = 10;
           // }
          //  else
           // {
              pool = 10;
           // }

            for (pool=10; pool > 0;)
            {
                Random r = new Random();
                int x = r.Next(0, rows);
                int y = r.Next(0, cols);
                if (board[x,y].state != State.Bomb)
                {
                    board[x,y].state = State.Bomb;
                    pool--;
                }
            }
            int counter = 0;
            for (int i = 0; i < rows; i++)
            {

                for (int j = 0; j < cols; j++)
                {

                    if (board[i, j].state != State.Bomb)
                    {
                        if (i != 0 && j != 0)
                        {
                            if (board[i - 1, j - 1].state == State.Bomb)
                            {
                                counter++;
                            }
                        }
                        if (i != 0)
                        {
                            if (board[i - 1, j].state == State.Bomb)
                            {
                                counter++;
                            }
                        }
                        if (i != 0 && j != cols-1)
                        {
                            if (board[i - 1, j + 1].state == State.Bomb)
                            {
                                counter++;
                            }
                        }
                        if (j != 0)
                        {
                            if (board[i, j - 1].state == State.Bomb)
                            {
                                counter++;
                            }
                        }
                        if (j != cols-1)
                        {
                            if (board[i, j + 1].state == State.Bomb)
                            {
                                counter++;
                            }
                        }
                        if (i!=rows-1 && j != 0)
                        {
                            if (board[i+ 1, j - 1].state == State.Bomb)
                            {
                                counter++;
                            }
                        }
                        if (i!=rows - 1)
                        {
                            if (board[i+1, j].state == State.Bomb)
                            {
                                counter++;
                            }
                        }
                        if (i!=rows-1 && j != cols - 1)
                        {
                            if (board[i+1, j + 1].state == State.Bomb)
                            {
                                counter++;
                            }
                        }
                        switch (counter)
                        {
                            case 0:
                                board[i,j].state = State.Empty;
                                break;
                            case 1:
                                board[i, j].state = State.One;
                                break;
                            case 2:
                                board[i, j].state = State.Two;
                                break;
                            case 3:
                                board[i, j].state = State.Three;
                                break;
                            case 4:
                                board[i, j].state = State.Four;
                                break;
                            case 5:
                                board[i, j].state = State.Five;
                                break;
                            case 6:
                                board[i, j].state = State.Six;
                                break;
                            case 7:
                                board[i, j].state = State.Seven;
                                break;
                            case 8:
                                board[i, j].state = State.Eight;
                                break;
                            
                        }
                        counter = 0;
                    }

                }
            }
        }

        internal void Reveal(Tile b)
        {
            
            int x = getX(b);
            int y = getY(b);
            if (board[x, y].isFlagged)
            {
                return;
            }
            board[x, y].Reveal();
            if (b.state == State.Bomb)
            {
                MainWindow.gameOver= true;
                return;
            }
            if (b.state == State.Empty)
            {
                if (x != 0 && y != 0)
                {
                    if(!board[x - 1, y - 1].isRevealed)
                   Reveal(board[x - 1, y - 1]);
                }
                if (y != 0)
                {
                    if (!board[x, y - 1].isRevealed)
                        Reveal(board[x, y - 1]);
                }
                if (x != rows-1 && y != 0)
                {
                    if (!board[x + 1, y - 1].isRevealed)
                      Reveal(board[x + 1, y - 1]);
                }
                if (x != 0)
                {
                    if (!board[x - 1, y].isRevealed)
                       Reveal(board[x - 1, y]);
                }
                if (x != rows-1 )
                {
                    if (!board[x + 1, y].isRevealed)
                      Reveal(board[x + 1, y]);
                }
                if (x !=0 && y != cols-1)
                {
                    if (!board[x - 1, y + 1].isRevealed)
                       Reveal(board[x - 1, y + 1]);
                }
                if (y != cols-1)
                {
                    if (!board[x, y + 1].isRevealed)
                        Reveal(board[x, y + 1]);
                }
                if (x != rows - 1 && y != cols-1)
                {
                    if (!board[x + 1, y + 1].isRevealed)
                       Reveal(board[x + 1, y + 1]);
                }

            }
            

        }


        public int getX(Tile b)
        {
           
            string[] xiy = b.Name.Split('a');
            return int.Parse(xiy[0].Where(Char.IsDigit).ToArray());

        }
        public int getY(Tile b)
        {

            string[] xiy = b.Name.Split('a');
            return int.Parse(xiy[1].Where(Char.IsDigit).ToArray());

        }

        public void Flag(Tile b)
        {
            if (b.isRevealed)
                return;
            // MessageBox.Show("Goowno");
           b.isFlagged=true;
            b.Flag();
        }
        public void unFlag(Tile b)
        {
            if (b.isRevealed)
                return;
            // MessageBox.Show("Goowno");
            b.isFlagged = false;
            b.unFlag();
        }
    }
}
