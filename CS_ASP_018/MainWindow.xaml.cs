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

namespace CS_ASP_018
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string daysbtwn;
        public DateTime date1, date2;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            blabel.Content = daysbtwn;
            BlackoutDates(date1, date2);
            int j = (date2 - date1).Days;
            blabel.Content = j;
        }


        private void BlackoutDates(DateTime date1, DateTime date2)
        {
            cldr3.BlackoutDates.Clear();
            cldr3.BlackoutDates.Add(new CalendarDateRange(date1, date2));
        }

        public void cldr1_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            date1 = cldr1.SelectedDate.Value;
            lb1.Content = date1.ToString();

        }
        private void cldr2_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            date2 = cldr2.SelectedDate.Value;
            lb2.Content = date2.ToString();
        }
    }
}
