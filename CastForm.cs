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
    public partial class CastForm : Form
    {
        MainForm mainform = new MainForm();

        public CastForm(MainForm mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
            castBindingSource.DataSource = mainform.database.casts;
        }

        private void castBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate(); 
            castBindingSource.EndEdit();
            mainform.database.SubmitChanges(); 
        }

        private void CastForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'moviesDataSet.cast' table. You can move, or remove it, as needed.
            this.castTableAdapter.Fill(this.moviesDataSet.cast);

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
