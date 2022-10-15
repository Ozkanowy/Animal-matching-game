using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
namespace Animal_matching_game  
{
    using System.Windows.Threading;
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer= new DispatcherTimer();
        int tenthsOfSecondsElapsed;
        int matchesFound;
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(.1);
            timer.Tick += Timer_Tick;
            SetUpGame();
            {
                timer.Start();
                tenthsOfSecondsElapsed = 0;
                matchesFound = 0;
            }

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tenthsOfSecondsElapsed++;
            TimeBlock.Text = (tenthsOfSecondsElapsed / 10F).ToString("0.0s");
            if (matchesFound == 8) ;
            {
                timer.Stop();
                TimeBlock.Text = TimeBlock.Text + "- Play Again?";
            }
          
            
        }

        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>
            {
                "🐈", "🐈",
                "🦁", "🦁",
                "🐯", "🐯",
                "🐴", "🐴",
                "🐷", "🐷",
                "🐭", "🐭",
                "🐨", "🐨",
                "🦭", "🦭",

            };
            Random random = new Random();

            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {

                if (textBlock.Name != "timeTextBlock")
                {

                    int index = random.Next(animalEmoji.Count);
                    string nextEmoji = animalEmoji[index];
                    textBlock.Text = nextEmoji;
                    animalEmoji.RemoveAt(index);
                    {
                        timer.Start();
                        tenthsOfSecondsElapsed = 0;
                        matchesFound = 0;

                    }
                    
                }
            }
        }

        TextBlock lasttextblockClicked;
        bool findingMatch = false;


        private void TextBlock_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;  
            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lasttextblockClicked = textBlock;
                findingMatch = true;
            }
            else if (textBlock.Text ==lasttextblockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                findingMatch =false;
            }
            else
            {
                lasttextblockClicked.Visibility = Visibility.Visible;
                findingMatch=false;
            }
        }

        private void TextBlock_MouseDown_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            TextBlock textBlock = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lasttextblockClicked = textBlock;
                findingMatch = true;
            }
            else if (textBlock.Text == lasttextblockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lasttextblockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void TextBlock_MouseDown_2(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            TextBlock textBlock = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lasttextblockClicked = textBlock;
                findingMatch = true;
            }
            else if (textBlock.Text == lasttextblockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lasttextblockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void TextBlock_MouseDown_3(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            TextBlock textBlock = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lasttextblockClicked = textBlock;
                findingMatch = true;
            }
            else if (textBlock.Text == lasttextblockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lasttextblockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void TextBlock_MouseDown_4(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            TextBlock textBlock = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lasttextblockClicked = textBlock;
                findingMatch = true;
            }
            else if (textBlock.Text == lasttextblockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lasttextblockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void TextBlock_MouseDown_5(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            TextBlock textBlock = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lasttextblockClicked = textBlock;
                findingMatch = true;
            }
            else if (textBlock.Text == lasttextblockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lasttextblockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void TextBlock_MouseDown_6(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            TextBlock textBlock = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lasttextblockClicked = textBlock;
                findingMatch = true;
            }
            else if (textBlock.Text == lasttextblockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lasttextblockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void TextBlock_MouseDown_7(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            TextBlock textBlock = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lasttextblockClicked = textBlock;
                findingMatch = true;
            }
            else if (textBlock.Text == lasttextblockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lasttextblockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void TextBlock_MouseDown_8(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            TextBlock textBlock = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lasttextblockClicked = textBlock;
                findingMatch = true;
            }
            else if (textBlock.Text == lasttextblockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lasttextblockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void TextBlock_MouseDown_9(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            TextBlock textBlock = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lasttextblockClicked = textBlock;
                findingMatch = true;
            }
            else if (textBlock.Text == lasttextblockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lasttextblockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void TextBlock_MouseDown_10(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            TextBlock textBlock = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lasttextblockClicked = textBlock;
                findingMatch = true;
            }
            else if (textBlock.Text == lasttextblockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lasttextblockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void TextBlock_MouseDown_11(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            TextBlock textBlock = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lasttextblockClicked = textBlock;
                findingMatch = true;
            }
            else if (textBlock.Text == lasttextblockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lasttextblockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void TextBlock_MouseDown_12(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            TextBlock textBlock = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lasttextblockClicked = textBlock;
                findingMatch = true;
            }
            else if (textBlock.Text == lasttextblockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lasttextblockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void TextBlock_MouseDown_13(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            TextBlock textBlock = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lasttextblockClicked = textBlock;
                findingMatch = true;
            }
            else if (textBlock.Text == lasttextblockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lasttextblockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void TextBlock_MouseDown_14(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            TextBlock textBlock = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lasttextblockClicked = textBlock;
                findingMatch = true;
            }
            else if (textBlock.Text == lasttextblockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lasttextblockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void TextBlock_MouseDown_15(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            TextBlock textBlock = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lasttextblockClicked = textBlock;
                findingMatch = true;
            }
            else if (textBlock.Text == lasttextblockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lasttextblockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void TextBlock_MouseDown_16(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            TextBlock textBlock = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lasttextblockClicked = textBlock;
                findingMatch = true;
            }
            else if (textBlock.Text == lasttextblockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lasttextblockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void TextBlock_MouseDown_17(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            TextBlock textBlock = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lasttextblockClicked = textBlock;
                findingMatch = true;
            }
            else if (textBlock.Text == lasttextblockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lasttextblockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void TextBlock_MouseDown_18(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            TextBlock textBlock = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lasttextblockClicked = textBlock;
                findingMatch = true;
            }
            else if (textBlock.Text == lasttextblockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lasttextblockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void TextBlock_MouseDown_19(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            TextBlock textBlock = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lasttextblockClicked = textBlock;
                findingMatch = true;
            }
            else if (textBlock.Text == lasttextblockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lasttextblockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void TextBlock_MouseDown_20(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            TextBlock textBlock = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lasttextblockClicked = textBlock;
                findingMatch = true;
            }
            else if (textBlock.Text == lasttextblockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lasttextblockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void TimeBlock_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (matchesFound == 8)
            {
                SetUpGame();
                {
                    timer.Start();
                    tenthsOfSecondsElapsed = 0;
                    matchesFound = 0;
                }
                

            }
           
        }
    }
}
