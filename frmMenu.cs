using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeMadness1
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //Go to the adHoc query form and allow the user to set up their query
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            //Go to the Add Recipe form
            frmAddRecipe addRec = new frmAddRecipe();
            this.Hide();
            addRec.Show();
        }

        private void btnSeeAll_Click(object sender, EventArgs e)
        {
            //Go to the results form after querying all recipes
        }

        private void btnFavorites_Click(object sender, EventArgs e)
        {
            //Go to the results form after querying favorite recipes
        }
    }
}
