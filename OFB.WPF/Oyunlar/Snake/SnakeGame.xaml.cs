using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace OFB.WPF.Oyunlar.Snake
{

    public partial class SnakeGame : Window
    {
        private List<Point> bonusPoints = new List<Point>();
        private List<Point> snakePoints = new List<Point>();

        private Brush snakeColor = Brushes.Green;
        private enum SIZE
        {
            THIN = 4,
            NORMAL = 6,
            THICK = 8
        };
        private enum MOVINGDIRECTION
        {
            UPWARDS = 8,
            DOWNWARDS = 2,
            TOLEFT = 4,
            TORIGHT = 6
        };



        private Point startingPoint = new Point(100, 100);
        private Point currentPosition = new Point();

        private int direction = 0;
        private int previousDirection = 0;

        private int headSize = (int)SIZE.THICK;

        DispatcherTimer timer = new DispatcherTimer();

        private int length = 100;
        private int score = 0;

        private Random rnd = new Random();

        public SnakeGame()
        {
            InitializeComponent();

            btnDevam.IsEnabled = false;
            btnDurdur.IsEnabled = false;
            btnBaslat.IsEnabled = true;

            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = SLOW;

            this.KeyDown += new KeyEventHandler(OnButtonKeyDown);
        }
        private void OnButtonKeyDown(object sender, KeyEventArgs e)
        {



            switch (e.Key)
            {
                case Key.Down:
                    if (previousDirection != (int)MOVINGDIRECTION.UPWARDS)
                        direction = (int)MOVINGDIRECTION.DOWNWARDS;
                    break;
                case Key.Up:
                    if (previousDirection != (int)MOVINGDIRECTION.DOWNWARDS)
                        direction = (int)MOVINGDIRECTION.UPWARDS;
                    break;
                case Key.Left:
                    if (previousDirection != (int)MOVINGDIRECTION.TORIGHT)
                        direction = (int)MOVINGDIRECTION.TOLEFT;
                    break;
                case Key.Right:
                    if (previousDirection != (int)MOVINGDIRECTION.TOLEFT)
                        direction = (int)MOVINGDIRECTION.TORIGHT;
                    break;

            }
            previousDirection = direction;

        }



        private void GameOver()
        {
            timer.Stop();
            btnDurdur.IsEnabled = false;
            btnDevam.IsEnabled = false;
            btnBaslat.IsEnabled = true;

            MessageBox.PopupCenterMessage.Show("Oyun bitti", "Çarptığınız için yandınız. \n\nSkorunuz: " + score.ToString());
            paintCanvas.Children.Clear();
            snakePoints.Clear();
            length = 100;

        }
        private void paintSnake(Point currentposition)
        {
            Ellipse newEllipse = new Ellipse();
            newEllipse.Fill = snakeColor;
            newEllipse.Width = headSize;
            newEllipse.Height = headSize;

            Canvas.SetTop(newEllipse, currentposition.Y);
            Canvas.SetLeft(newEllipse, currentposition.X);

            int count = paintCanvas.Children.Count;
            paintCanvas.Children.Add(newEllipse);
            snakePoints.Add(currentposition);

            if (count > length)
            {
                paintCanvas.Children.RemoveAt(count - length + 9);
                snakePoints.RemoveAt(count - length);
            }
        }


        private void paintBonus(int index)
        {
            Point bonusPoint = new Point(rnd.Next(5, 790), rnd.Next(5, 580));

            Ellipse newEllipse = new Ellipse();
            newEllipse.Fill = Brushes.Red;
            newEllipse.Width = headSize;
            newEllipse.Height = headSize;

            Canvas.SetTop(newEllipse, bonusPoint.Y);
            Canvas.SetLeft(newEllipse, bonusPoint.X);
            paintCanvas.Children.Insert(index, newEllipse);
            bonusPoints.Insert(index, bonusPoint);

        }


        private void timer_Tick(object sender, EventArgs e)
        {


            switch (direction)
            {
                case (int)MOVINGDIRECTION.DOWNWARDS:
                    currentPosition.Y += 1;
                    paintSnake(currentPosition);
                    break;
                case (int)MOVINGDIRECTION.UPWARDS:
                    currentPosition.Y -= 1;
                    paintSnake(currentPosition);
                    break;
                case (int)MOVINGDIRECTION.TOLEFT:
                    currentPosition.X -= 1;
                    paintSnake(currentPosition);
                    break;
                case (int)MOVINGDIRECTION.TORIGHT:
                    currentPosition.X += 1;
                    paintSnake(currentPosition);
                    break;
            }

            if ((currentPosition.X < 0) || (currentPosition.X > 794) ||
                (currentPosition.Y < 0) || (currentPosition.Y > 584))
                GameOver();


            int n = 0;
            foreach (Point point in bonusPoints)
            {

                if ((Math.Abs(point.X - currentPosition.X) < headSize) &&
                    (Math.Abs(point.Y - currentPosition.Y) < headSize))
                {
                    length += 10;


                    score += rnd.Next(9, 12);
                    label.Content = score.ToString();

                    bonusPoints.RemoveAt(n);
                    paintCanvas.Children.RemoveAt(n);
                    paintBonus(n);
                    break;
                }
                n++;
            }



            for (int q = 0; q < (snakePoints.Count - headSize * 2); q++)
            {
                Point point = new Point(snakePoints[q].X, snakePoints[q].Y);
                if ((Math.Abs(point.X - currentPosition.X) < (headSize)) && (Math.Abs(point.Y - currentPosition.Y) < (headSize)))
                {
                    GameOver();
                    break;
                }

            }


        }


        Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
        void wClose()
        {
            timer.Stop();
            _Window.Opacity = 1;
            this.Close();
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            wClose();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnKapat_Click(object sender, RoutedEventArgs e)
        {
            wClose();
        }
        private TimeSpan FAST = new TimeSpan(1);
        private TimeSpan MODERATE = new TimeSpan(10000);
        private TimeSpan SLOW = new TimeSpan(20000);
        private TimeSpan DAMNSLOW = new TimeSpan(500000);

        private void button_Click(object sender, RoutedEventArgs e)
        {
            btnBaslat.IsEnabled = false;
            btnDevam.IsEnabled = false;
            btnDurdur.IsEnabled = true;

            score = 0;
            label.Content = score.ToString();

            timer.Start();

            startingPoint = new Point(100, 100);
            currentPosition = new Point();

            paintSnake(startingPoint);
            currentPosition = startingPoint;

            for (int n = 0; n < 10; n++)
            {
                paintBonus(n);
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            btnDurdur.IsEnabled = false;
            btnDevam.IsEnabled = true;
            timer.Stop();
        }

        private void btnDevam_Click(object sender, RoutedEventArgs e)
        {
            btnDevam.IsEnabled = false;
            btnDurdur.IsEnabled = true;
            timer.Start();
        }
    }
}
