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

namespace MovieList
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

 

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string title = titleInput.Text;
            int releaseYear = Convert.ToInt32(releaseYearInput.Text);
            string director = directorInput.Text;
            string genre = genreInput.Text;
            int time = Convert.ToInt32(timeInput.Text);

            Movie movie = new Movie(title, releaseYear, director, genre, time);
            MessageBox.Show("Movie was added");

        
        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<Movie> Movies = null;
            foreach (Movie movie in Movies)
            {
                MessageBox.Show("The movie is " + movie.Title + "\r\n" + "The movie was released in" + movie.ReleaseYear 
                                 + "\r\n" + "The director was " +

                                );
                movie.ShowDetails();
            }
        }
    }
    
}
