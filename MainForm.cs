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
   
    public partial class MainForm : Form
    {
       public moviesDataContext database = new moviesDataContext();
       
        public MainForm()
        {
            InitializeComponent();

        }

        private void movies_Click(object sender, EventArgs e)
        {
            MoviesForm moviesForm = new MoviesForm(this);
            moviesForm.Show();

        }

        private void cast_Click(object sender, EventArgs e)
        {
            CastForm castForm = new CastForm(this);
            castForm.Show();

        }

        private void genre_Click(object sender, EventArgs e)
        {
            GenreForm genreform = new GenreForm(this);
            genreform.Show();
        }

        private void director_Click(object sender, EventArgs e)
        {
            DirectorForm directorForm = new DirectorForm(this);
            directorForm.Show();
        }

        private void search_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
        }

      }
}
