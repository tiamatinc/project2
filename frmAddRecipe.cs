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
            lstIngredients = new ListView();
            lstCategories = new ListView();
            lstStyles = new ListView();
            InitializeComponent();
            populateIngredients();
            populateCategories();
            populateStyles();
            
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
            lstIngredients.Items.Clear();
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
            lstCategories.Items.Clear();
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
            lstStyles.Items.Clear();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            //collect the selected items from all of the lists
            getIngredients();
            getStyles();
            getCats();
            if (_recNewRecipe.directions != "" && _recNewRecipe.name != "" && _stylesUsed.Count > 0 && _catsUsed.Count > 0
                && _ingredientsUsed.Count > 0)
            {
                _data.addRecipe(_recNewRecipe, _ingredientsUsed, _stylesUsed, _catsUsed);
                MessageBox.Show("Recipe Added!");
            }
            else
            {
                MessageBox.Show("Make sure you have at least one ingredient, style, category selected and that you've given" +
                            "the recipe a name and instructions.", "Error!");
            }
            clearlists();
        }
        private void clearlists()
        {
            _catsUsed.Clear();
            _ingredientsUsed.Clear();
            _stylesUsed.Clear();
        }
        private void getCats()
        {
            foreach (ListViewItem i in lstCategories.CheckedItems)
            {
                _catsUsed.Add(i.Text);
            }
        }
        private void getStyles()
        {
            foreach(ListViewItem i in lstStyles.CheckedItems)
            {
                _stylesUsed.Add(i.Text);
            }
        }
        private void getIngredients()
        {
            foreach (ListViewItem item in lstIngredients.CheckedItems)
            {
                String query = "Name='" + item.Text + "'";
                DataRow[] dr = _ingredients.Select(query);
                clsIngredient ingr = new clsIngredient();
                ingr.id = Int32.Parse(dr[0]["Ingr_id"].ToString());
                ingr.name = dr[0]["Name"].ToString();
                ingr.description = dr[0]["Description"].ToString();
                ingr.season = dr[0]["Season"].ToString();
                _ingredientsUsed.Add(ingr);
                
            }


            //for (int i = 0; i < lstIngredients.CheckedItems.Count; ++i)
            //{

            //    string itemname = lstIngredients.Items[i].Text;
            //    for (int k = 0; k < _ingredients.Rows.Count; ++k)
            //    {
            //        DataRow dr = _ingredients.Rows[k];
            //        if (dr["Name"].ToString().Equals(itemname))
            //        {
            //            clsIngredient ingr = new clsIngredient();
            //            ingr.id = Int32.Parse(dr["Ingr_id"].ToString());
            //            ingr.name = dr["Name"].ToString();
            //            ingr.description = dr["Description"].ToString();
            //            ingr.season = dr["Season"].ToString();
            //            _ingredientsUsed.Add(ingr);
            //        }
            //    }
            //}
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
            addStyle.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }

        private void frmAddRecipe_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }
    }
}
