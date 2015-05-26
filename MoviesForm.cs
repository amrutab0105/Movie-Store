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
    public partial class MoviesForm : Form
    {
        MainForm mainform = new MainForm();
        public MoviesForm(MainForm mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
            movieBindingSource.DataSource = mainform.database.movies;
        }




        private void movieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate(); // validate input fields
            movieBindingSource.EndEdit(); // indicate edits are complete
            mainform.database.SubmitChanges();
        }

        private void MoviesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'moviesDataSet.movie' table. You can move, or remove it, as needed.
            this.movieTableAdapter.Fill(this.moviesDataSet.movie);

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       
    }
}
