using Minesweeper.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Minesweeper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Stopwatch _stopwatch;
        private DispatcherTimer _timer;
        public static bool gameOver =false;
        public static bool gameWon = false;
        int rows = 8;
        int columns = 8;
        Board board { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            _stopwatch = new Stopwatch();
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += Timer_Tick;
            InitializeBoard(rows, columns);

           
        }

        public void InitializeBoard(int rows, int columns)
        {
            
            gameOver = false;
            gameWon = false;
            gameGrid.RowDefinitions.Clear();
            gameGrid.ColumnDefinitions.Clear();
            gameGrid.Children.Clear();
            board = new Board(rows, columns);
           
            for (int i = 0; i < rows; i++)
            {

                RowDefinition row = new RowDefinition();
                row.Height = new GridLength(35);
                gameGrid.RowDefinitions.Add(row);

                for (int j = 0; j < columns; j++)
                {
                    ColumnDefinition column = new ColumnDefinition();
                    column.Width = new GridLength(35);
                    gameGrid.ColumnDefinitions.Add(column);

                    board.board[i, j] = new Tile();
                    board.board[i, j].Name = "Button" + i +"a"+ j;
                    board.board[i, j].Style = (Style)FindResource("TileStyle");
                    board.board[i, j].Content = new Image() { Source = ((ImageBrush)FindResource("TileImage")).ImageSource };
                    Grid.SetRow(board.board[i, j], i);
                    Grid.SetColumn(board.board[i, j], j);
                    gameGrid.Children.Add(board.board[i, j]);
                    board.board[i, j].MouseRightButtonUp += Right_Button_Click;
                    board.board[i, j].Click += Left_Button_Click;
                    
                }
            }
            board.Initialize();

        }
        private void Left_Button_Click(object sender, RoutedEventArgs e)
        {
            if (!_stopwatch.IsRunning)
            {
                _stopwatch.Start();
                _timer.Start();
            }
            Tile button = (Tile)sender;
           board.Reveal(button);
            if(gameOver)
            {
                foreach(UIElement child in gameGrid.Children)
                {
                    if(child is Button)
                    {
                        child.IsEnabled = false;
                    }
                }
                _stopwatch.Stop();
                MessageBox.Show("Wybuchła bomba!!!");
                
            }
            if (gameWon)
            {
                foreach (UIElement child in gameGrid.Children)
                {
                    if (child is Button)
                    {
                        child.IsEnabled = false;
                    }
                }
                _stopwatch.Stop();
                MessageBox.Show("Gratulacje, wygrałeś!\n Twój czas: "+ Math.Round(_stopwatch.Elapsed.TotalSeconds, 2));

            }
        }

        private void Right_Button_Click(object sender, RoutedEventArgs e)
        {

            Tile button = (Tile)sender;
            if (!button.isFlagged)
                board.Flag(button);
            else
                board.unFlag(button);

            
            
            //  Console.WriteLine("Helelo");
            // sender.Content = new Image() { Source = ((ImageBrush)FindResource("FlagImage")).ImageSource };
        }


        private void Timer_Tick(object sender, EventArgs e)
        {

            TimePassed.Text = ((int)_stopwatch.Elapsed.TotalSeconds).ToString();
           // Title = $"Minesweeper - Time: {((int)_stopwatch.Elapsed.TotalSeconds)}";
        }


        private void Easy_Click(object sender, RoutedEventArgs e)
        {
            rows = 8;
            columns = 8;
            _stopwatch.Reset();
            InitializeBoard(rows, columns);
            
        }

        private void Medium_Click(object sender, RoutedEventArgs e)
        {
            rows = 16;
            columns = 16;
            _stopwatch.Reset();
            InitializeBoard(rows, columns);
        }
    }
}
