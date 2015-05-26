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
    public partial class GenreForm : Form
    {
        MainForm mainform = new MainForm();
        public GenreForm(MainForm mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
            movie_genreBindingSource.DataSource = mainform.database.movie_genres;
        }

        private void movie_genreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate(); // validate input fields
            movie_genreBindingSource.EndEdit(); // indicate edits are complete
            mainform.database.SubmitChanges(); 
        }

        private void GenreForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'moviesDataSet.movie_genre' table. You can move, or remove it, as needed.
            this.movie_genreTableAdapter.Fill(this.moviesDataSet.movie_genre);

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
