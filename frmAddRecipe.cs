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
    public partial class frmAddRecipe : Form
    {
        private clsRecipe _recNewRecipe;
        private List<clsIngredient> _ingredientsUsed;
        private clsSQL _data;
        private DataTable _ingredients;
        private DataTable _styles;
        private DataTable _categories;

        public frmAddRecipe()
        {
            _recNewRecipe = new clsRecipe();
            _data = new clsSQL();
            populateIngredients();
            populateCategories();
            populateStyles();
            InitializeComponent();
        }

        private void populateIngredients()
        {
            _ingredients = _data.getAllIngredients();
            for(int i = 0; i < _ingredients.Rows.Count; ++i)
            {
                DataRow dr = _ingredients.Rows[i];
                ListViewItem item = new ListViewItem(dr["Name"].ToString());
                lstIngredients.Items.Add(item); 
            }

        }
        private void populateCategories()
        {
            _categories = _data.getAllCategories();
            for (int i = 0; i < _categories.Rows.Count; ++i)
            {
                DataRow dr = _categories.Rows[i];
                ListViewItem item = new ListViewItem(dr["Name"].ToString());
                lstCategories.Items.Add(item);
            }
        }
        private void populateStyles()
        {
            _styles = _data.getAllStyles();
            for (int i = 0; i < _styles.Rows.Count; ++i)
            {
                DataRow dr = _styles.Rows[i];
                ListViewItem item = new ListViewItem(dr["Name"].ToString());
                lstStyles.Items.Add(item);
            }
        }
        private void txbRecipeName_TextChanged(object sender, EventArgs e)
        {
            _recNewRecipe.name = txbRecipeName.Text;
        }

        private void txbDescription_TextChanged(object sender, EventArgs e)
        {
            _recNewRecipe.directions = txbDescription.Text;
        }

        private void cmbSeason_SelectedIndexChanged(object sender, EventArgs e)
        {
            _recNewRecipe.season = cmbSeason.Text;
        }

        private void lstIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //collect the selected items from all of the lists
            foreach ()
            _data.addRecipe(_recNewRecipe, _ingredientsUsed);
        }
    }
}
