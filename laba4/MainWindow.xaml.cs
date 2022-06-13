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

namespace laba4
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

        private void Solve_Click(object sender, RoutedEventArgs e)
        {
            Pair pair = new Pair(double.Parse(First.Text), double.Parse(Second.Text));
            Result.Text = pair.summ().ToString();
        }

        private void SolveDiff_Click(object sender, RoutedEventArgs e)
        {
            Pair pair = new Pair(double.Parse(First.Text), double.Parse(Second.Text));
            Result.Text = pair.Diff().ToString();
        }

        private void SolveDivis_Click(object sender, RoutedEventArgs e)
        {
            Pair pair = new Pair(double.Parse(First.Text), double.Parse(Second.Text));
            Result.Text = pair.Divis().ToString();
        }

        private void SolveMulti_Click(object sender, RoutedEventArgs e)
        {
            Pair pair = new Pair(double.Parse(First.Text), double.Parse(Second.Text));
            Result.Text = pair.Multi().ToString();
        }
    }
}
