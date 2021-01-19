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

namespace Saturn_11._1_medium
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Ttimes[] ttimes;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void AddTime_Click(object sender, RoutedEventArgs e)
        {
            ttimes = new Ttimes[5];
            ttimes[0] = new Ttimes(12, 45, 9);
            ttimes[1] = new Ttimes(8, 32, 44);
            ttimes[2] = new Ttimes(1, 4, 33);
            ttimes[3] = new Ttimes(23, 19, 27);
            ttimes[4] = new Ttimes(5, 38, 49);
            for(int i=0;i<ttimes.Length;i++)
            {
                list.Items.Add(ttimes[i].FHours + " " + ttimes[i].FMinutes + " " + ttimes[i].FSeconds);
            }
        }

        private void HowMuch_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < ttimes.Length; i++)
            {
                ttimes[i].howmuch();
                list.Items.Add(ttimes[i].FSeconds);
            }
        }

        private void Add5Sec_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < ttimes.Length; i++)
            {
                ttimes[i].fivesec();
                list.Items.Add(ttimes[i].FHours + " " + ttimes[i].FMinutes + " " + ttimes[i].FSeconds);
            }
        }
    }
}
