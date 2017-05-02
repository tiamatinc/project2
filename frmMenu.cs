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

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            frmAddRecipe addRec = new frmAddRecipe();
            addRec.Show();
            this.Hide();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            clsSQL data = new clsSQL();
            frmShowResults results = new frmShowResults(data.getAllTheRecipes());
            results.Show();
            this.Hide();
        }
    }
}
