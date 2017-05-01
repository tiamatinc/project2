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
        private List<String> _stylesUsed;
        private List<String> _catsUsed;
        private clsSQL _data;
        private DataTable _ingredients;
        private DataTable _styles;
        private DataTable _categories;

        public frmAddRecipe()
        {
            _recNewRecipe = new clsRecipe();
            _data = new clsSQL();
            _ingredientsUsed = new List<clsIngredient>();
            _stylesUsed = new List<String>();
            _catsUsed = new List<String>();
            populateIngredients();
            populateCategories();
            populateStyles();
            InitializeComponent();
        }
        public void populate(String what)
        {
            switch (what)
            {
                case "I":
                    populateIngredients();
                    break;
                case "S":
                    populateStyles();
                    break;
                case "C":
                    populateCategories();
                    break;
            }
        }
        private void populateIngredients()
        {
            if (lstIngredients != null) lstIngredients.Clear();
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
            if(lstCategories != null) lstCategories.Clear();
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
            if(lstStyles != null) lstStyles.Clear();
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
            getIngredients();
            getStyles();
            getCats();
            _data.addRecipe(_recNewRecipe, _ingredientsUsed, _stylesUsed, _catsUsed);
        }
        private void getCats()
        {
            foreach (int i in lstCategories.SelectedIndices)
            {
                _catsUsed.Add(lstCategories.Items[i].ToString());
            }
        }
        private void getStyles()
        {
            foreach (int i in lstStyles.SelectedIndices)
            {
                _stylesUsed.Add(lstStyles.Items[i].ToString());
            }
        }
        private void getIngredients()
        {
            foreach (int i in lstIngredients.SelectedIndices)
            {
                string itemname = lstIngredients.Items[i].ToString();
                for (int k = 0; k < _ingredients.Rows.Count; ++k)
                {
                    DataRow dr = _ingredients.Rows[k];
                    if (dr["Name"].ToString().Equals(itemname))
                    {
                        clsIngredient ingr = new clsIngredient();
                        ingr.id = Int32.Parse(dr["Ingr_id"].ToString());
                        ingr.name = dr["Name"].ToString();
                        ingr.description = dr["Description"].ToString();
                        ingr.season = dr["Season"].ToString();
                        _ingredientsUsed.Add(ingr);
                    }
                }
            }
        }

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            frmAddIngredient addIngr = new frmAddIngredient(this);
            addIngr.Show();
        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            frmAddCategory addCat = new frmAddCategory(this);
            addCat.Show();
        }

        private void btnAddNewStyle_Click(object sender, EventArgs e)
        {
            frmAddStyle addStyle = new frmAddStyle(this);
            addStyle.Close();
        }
    }
}
