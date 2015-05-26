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
    public partial class DirectorForm : Form
    {
        MainForm mainform = new MainForm();

        public DirectorForm(MainForm mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
            movie_castBindingSource.DataSource = mainform.database.movie_casts;
        }

        private void movie_castBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate(); // validate input fields
            movie_castBindingSource.EndEdit(); // indicate edits are complete
            mainform.database.SubmitChanges(); 

        }

        private void DirectorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'moviesDataSet.movie_cast' table. You can move, or remove it, as needed.
            this.movie_castTableAdapter.Fill(this.moviesDataSet.movie_cast);

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
