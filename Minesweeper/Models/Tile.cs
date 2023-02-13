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
                    break;
                case State.One:
                    this.Content = new Image() { Source = ((ImageBrush)FindResource("OneImage")).ImageSource };
                    break;
                case State.Two:
                    this.Content = new Image() { Source = ((ImageBrush)FindResource("TwoImage")).ImageSource };
                    break;
                case State.Three:
                    this.Content = new Image() { Source = ((ImageBrush)FindResource("ThreeImage")).ImageSource };
                    break;
                case State.Four:
                    this.Content = new Image() { Source = ((ImageBrush)FindResource("FourImage")).ImageSource };
                    break;
                case State.Five:
                    this.Content = new Image() { Source = ((ImageBrush)FindResource("FiveImage")).ImageSource };
                    break;
                case State.Six:
                    this.Content = new Image() { Source = ((ImageBrush)FindResource("SixImage")).ImageSource };
                    break;
                case State.Seven:
                    this.Content = new Image() { Source = ((ImageBrush)FindResource("SevenImage")).ImageSource };
                    break;
                case State.Eight:
                    this.Content = new Image() { Source = ((ImageBrush)FindResource("EightImage")).ImageSource };
                    break;
                default:
                    this.Content = new Image() { Source = ((ImageBrush)FindResource("MineImage")).ImageSource };
                    break;
            }
            //this.Content = new Image() { Source = ((ImageBrush)FindResource("MineImage")).ImageSource };
        }

        public void Flag()
        {
            this.Content = new Image() { Source = ((ImageBrush)FindResource("FlagImage")).ImageSource };
        }
        public void unFlag()
        {
            this.Content = new Image() { Source = ((ImageBrush)FindResource("TileImage")).ImageSource };
        }
        public State state;
       
    }
}
