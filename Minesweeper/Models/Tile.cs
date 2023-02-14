using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Minesweeper.Models
{
    public enum State
    { 
        Empty,
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Bomb,
        
    }
    public class Tile : Button
    {
        public int BombsAround;
        public bool isFlagged = false;
        public bool isRevealed=false;
        public void Reveal()
        {
            if(isRevealed) return;
            isRevealed= true;
            switch (state)
            {
                case State.Empty:
                    this.Content = new Image() { Source = ((ImageBrush)FindResource("EmptyImage")).ImageSource };
                    BombsAround = 0;
                    break;
                case State.One:
                    this.Content = new Image() { Source = ((ImageBrush)FindResource("OneImage")).ImageSource };
                    BombsAround = 1;
                    break;
                case State.Two:
                    this.Content = new Image() { Source = ((ImageBrush)FindResource("TwoImage")).ImageSource };
                    BombsAround = 2;
                    break;
                case State.Three:
                    this.Content = new Image() { Source = ((ImageBrush)FindResource("ThreeImage")).ImageSource };
                    BombsAround = 3;
                    break;
                case State.Four:
                    this.Content = new Image() { Source = ((ImageBrush)FindResource("FourImage")).ImageSource };
                    BombsAround = 4;
                    break;
                case State.Five:
                    this.Content = new Image() { Source = ((ImageBrush)FindResource("FiveImage")).ImageSource };
                    BombsAround = 5;
                    break;
                case State.Six:
                    this.Content = new Image() { Source = ((ImageBrush)FindResource("SixImage")).ImageSource };
                    BombsAround = 6;
                    break;
                case State.Seven:
                    this.Content = new Image() { Source = ((ImageBrush)FindResource("SevenImage")).ImageSource };
                    BombsAround = 7;
                    break;
                case State.Eight:
                    this.Content = new Image() { Source = ((ImageBrush)FindResource("EightImage")).ImageSource };
                    BombsAround = 8;
                    break;
                case State.Bomb:
                    this.Content = new Image() { Source = ((ImageBrush)FindResource("MineImage")).ImageSource };
                    MainWindow.gameOver = true;
                    break;
            }
            //this.Content = new Image() { Source = ((ImageBrush)FindResource("MineImage")).ImageSource };
        }

        public void Flag()
        {
            this.Content = new Image() { Source = ((ImageBrush)FindResource("FlagImage")).ImageSource };
            isFlagged = true;
        }
        public void unFlag()
        {
            this.Content = new Image() { Source = ((ImageBrush)FindResource("TileImage")).ImageSource };
            isFlagged = false;
        }
        public State state;
       
    }
}
