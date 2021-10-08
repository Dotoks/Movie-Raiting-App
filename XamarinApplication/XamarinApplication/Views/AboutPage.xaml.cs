using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApplication.Models;

namespace XamarinApplication.Views
{
    public partial class AboutPage : ContentPage
    {

        public IList<Movie> Movies { get; private set; }
        public AboutPage()
        {
            InitializeComponent();
            Movies = new List<Movie>();

            Movies.Add(new Movie
            {
                Name = "John Wick",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/9/98/John_Wick_TeaserPoster.jpg/220px-John_Wick_TeaserPoster.jpg"
            });
            Movies.Add(new Movie
            {
                Name = "Hardcore Henry",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/e/ed/Hardcore_%282015_film%29.jpg/220px-Hardcore_%282015_film%29.jpg"
            });
            Movies.Add(new Movie
            {
                Name = "Deadpool",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/2/23/Deadpool_%282016_poster%29.png/220px-Deadpool_%282016_poster%29.png"
            });
            Movies.Add(new Movie
            {
                Name = "Avengers Endgame",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/0d/Avengers_Endgame_poster.jpg"
            });
            Movies.Add(new Movie
            {
                Name = "The Matrix",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c1/The_Matrix_Poster.jpg/220px-The_Matrix_Poster.jpg"
            });
            Movies.Add(new Movie
            {
                Name = "Pirates of the Caribbean ",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/89/Pirates_of_the_Caribbean_-_The_Curse_of_the_Black_Pearl.png"
            });

            BindingContext = this;
        }

        void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Movie selectedItem = e.CurrentSelection[0] as Movie;
        }
    }

   
}