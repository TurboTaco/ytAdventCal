using System;
using System.Collections.Generic;
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

namespace musicalAdventCalender
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            drawChristmasDays();


        }


        private int daysUntilChristmas()
        {

            DateTime thisDay = DateTime.Today;
            DateTime christmasDay = new DateTime(thisDay.Year, 12, 25);
            TimeSpan diffBetween = christmasDay - thisDay;
            string timeDifference = diffBetween.ToString(@"dd");
            int christmasDays = Int32.Parse(timeDifference);
            return christmasDays;


        }

        private void refreshButton_Click(object sender, RoutedEventArgs e)
        {
            drawChristmasDays();
        }

        private void playYoutubeButton_Click(object sender, RoutedEventArgs e)
        {
            startChristmasChrome();
        }

        private void startChristmasChrome()
        {
            string[] links = new string[25] {
                "https://www.youtube.com/watch?v=j9jbdgZidu8",
                "https://www.youtube.com/watch?v=V9BZDpni56Y",
                "https://www.youtube.com/watch?v=VQhuoY5h2kE",
                "https://www.youtube.com/watch?v=KI5ze9rBlpk",
                "https://www.youtube.com/watch?v=B0zaDApGBbI",
                "https://www.youtube.com/watch?v=IM_H4CAAYxc",
                "https://www.youtube.com/watch?v=HeEo9a8rbYk",
                "https://www.youtube.com/watch?v=3IyaHwwqn-c",
                "https://www.youtube.com/watch?v=yN4Uu0OlmTg",
                "https://www.youtube.com/watch?v=0A8KT365wlA",
                "https://www.youtube.com/watch?v=9YUsiwRlz2s",
                "https://www.youtube.com/watch?v=ZeyHl1tQeaQ",
                "https://www.youtube.com/watch?v=P8MntONTbuA",
                "https://www.youtube.com/watch?v=5aw2yuYAKoE",
                "https://www.youtube.com/watch?v=DDt3u2Ev1cI",
                "https://www.youtube.com/watch?v=olYhTePkTxA",
                "https://www.youtube.com/watch?v=LAdmdunWvsA",
                "https://www.youtube.com/watch?v=_93Uun_YclM",
                "https://www.youtube.com/watch?v=DiXjbI3kRus",
                "https://www.youtube.com/watch?v=ChU4M3fe-9Q",
                "https://www.youtube.com/watch?v=5r8bZCXdVNA",
                "https://www.youtube.com/watch?v=5aw2yuYAKoE",
                "https://www.youtube.com/watch?v=lkN5M-nJx6A",
                "https://www.youtube.com/watch?v=8OsgqpnuizY",
                "https://www.youtube.com/watch?v=19vVSxyWFSU"

            };
            int christmasDays = daysUntilChristmas();
            if (christmasDays < 26)
            {
                string linkCommand = links[christmasDays];
                System.Diagnostics.Process.Start("chrome.exe", linkCommand);
            }
            else if (christmasDays < 0)
            {
                string linkCommand = "https://www.youtube.com/watch?v=2HkJHApgKqw";
                System.Diagnostics.Process.Start("chrome.exe", linkCommand);
            }
            else
            {
                string linkCommand = "https://www.youtube.com/watch?v=2HkJHApgKqw";
                System.Diagnostics.Process.Start("chrome.exe", linkCommand);
            }
        }
        private void drawChristmasDays()
        {
            textBlock.Text = daysUntilChristmas().ToString();
        }
    }
}
