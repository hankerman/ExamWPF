using ExamWPF.Model;
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

namespace ExamWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _nodes = new List<INode>(Movie_DB.Context.MoviesNode);
            MoviesTree.ItemsSource = _nodes;
        }

        private List<INode> _nodes;

        private void DeliteMovie_Clic(object sender, RoutedEventArgs e)
        {
            Movie movie = MoviesTree.SelectedItem as Movie;
            if(movie != null)
            {
                Movie_DB.Context.Movies.Remove(movie);
            }
        }
    }
}
