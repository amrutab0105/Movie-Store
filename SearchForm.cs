using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Amruta
{
    public partial class SearchForm : Form
    {
     	moviesDataContext database = new moviesDataContext();
		public SearchForm()
		{
			InitializeComponent();
			resultDataGrid.AutoGenerateColumns = true;
		}

        //get list of movies director by the directorName specified
        private void searchByDirector_Click(object sender, EventArgs e)
		{
            string director = directorList.GetItemText(directorList.SelectedItem);
            bindingSource1.DataSource =
                from getMovies in database.movies
                from getCast in database.casts
                where director == getCast.name
                && getMovies.directorID == getCast.castID
               select new { getMovies.title };
              
		}

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //get list of movies in which the actorName has acted
        private void searchByActor_Click(object sender, EventArgs e)
        {
            string casts = castName.GetItemText(castName.SelectedItem);

            bindingSource1.DataSource =
              from getCast in database.casts
              from getMovie in database.movie_casts
              from getmovies in database.movies
              where getCast.name == casts &&
                    getMovie.movieID == getmovies.movieID &&
                    getCast.castID == getMovie.actorID
             select new { getmovies.title };
        }

        //get list of movies released in the year specified
        private void searchByReleaseYear_Click(object sender, EventArgs e)
        {
            bindingSource1.DataSource =
                from getmovies in database.movies
                where getmovies.releaseYear <= int.Parse(releaseYear.Text)
                select new { getmovies.title };
        }

        //get list of movies in the specific language
        private void searchBylanguage_Click(object sender, EventArgs e)
        {
            string lang = languages.GetItemText(languages.SelectedItem);

            bindingSource1.DataSource =
                from getmovies in database.movies
                where getmovies.language == lang
                select new { getmovies.title };
        }

        //get list of movies of specific genre
        private void searchByGenre_Click(object sender, EventArgs e)
        {
            string genre = genres.GetItemText(genres.SelectedItem);

            bindingSource1.DataSource =
                from getmovies in database.movies
                from getgenre in database.movie_genres
                where getmovies.movieID == getgenre.movieID
                && getgenre.genreName == genre
                select new { getmovies.title };
        }

        //get list of movies containing the partial title
        private void searchByPartialTitle_Click(object sender, EventArgs e)
        {
            
            bindingSource1.DataSource =
                    from getmovies in database.movies
                    where getmovies.title.Contains(partialTitle.Text)
                    select new { getmovies.title };
        }

        //get list of movies that have the specified rating
        private void searchByRating_Click(object sender, EventArgs e)
        {
            string rate = ratings.GetItemText(ratings.SelectedItem);

            bindingSource1.DataSource =
                from getmovies in database.movies
                where getmovies.rating == int.Parse(rate)
                select new { getmovies.title };
        }

        private void resultDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            result.Text = "";
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.resultDataGrid.Rows[e.RowIndex];
                string movieName = row.Cells["title"].Value.ToString();
                
             var moviesInfo =
                from getMovie in database.movies
                from getGenre in database.movie_genres
             
                where getMovie.title == movieName &&
               getMovie.movieID == getGenre.movieID 
                select new 
                {
                    getMovie.title,
                    getMovie.language,
                    getMovie.releaseYear,
                    getMovie.rating,
                   getGenre.genreName
                };
                result.AppendText("\r\r\nDetails of the Selected Movie:");
                //117 103
                foreach (var element in moviesInfo)
                {
                    result.AppendText(
                       String.Format("\r\n\t{0,-10} {1,-10} {2, -10} {3, -10} {4, -10}",
                          element.title, element.language, element.releaseYear, element.rating, element.genreName));
                }

                 var castInfo =
                    from getCast in database.casts
                    from getCastInfo in database.movie_casts
                    from getMovie in database.movies
                    where getMovie.title == movieName &&
                         getMovie.movieID == getCastInfo.movieID &&
                         getCast.castID == getCastInfo.actorID
                    select new 
                    {
                        getCast.name
 
                    };
                result.AppendText("\r\r\nCast and Crew:");
                foreach (var element in castInfo)
                {
                    result.AppendText(
                       String.Format("\r\n\t{0,-10}",
                          element.name));
                }


            }
       
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            var directors =
                from getDirector in database.movies
                from getDirectorName in database.casts
                where getDirector.directorID == getDirectorName.castID
                select new { getDirectorName.name };
            foreach (var directorName in directors)
            {
                directorList.Items.Add(directorName.name);
            }
            var casts =
                from getCasts in database.casts
                select new { getCasts.name };
            foreach (var nameCast in casts)
            {
                 castName.Items.Add(nameCast.name);
            }
            var years =
                from getYear in database.movies
                select new { getYear.releaseYear };
            foreach (var yearValue in years)
            {
                releaseYear.Items.Add(yearValue.releaseYear);
            }
            var language =
                from getLanguages in database.movies
                select new { getLanguages.language };
            foreach (var lang in language)
            {
                languages.Items.Add(lang.language);
            }
            var genre =
                from getGenres in database.movie_genres
                select new { getGenres.genreName };
            foreach (var gen in genre)
            {
                genres.Items.Add(gen.genreName);
            }
            var rating =
                from getRatings in database.movies
                select new { getRatings.rating };
            foreach (var rate in rating)
            {
                ratings.Items.Add(rate.rating);
            }



        }

       
       


       
	}
}
