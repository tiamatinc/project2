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
    public partial class frmShowRecipe : Form
    {
        private frmShowResults _resultsForm;
        private clsRecipe _thisRecipe;
        private clsSQL _data;
        private DataTable _ingredients;
        public frmShowRecipe(frmShowResults resultsForm, clsRecipe thisRec)
        {
            _data = new clsSQL();
            _resultsForm = resultsForm;
            _thisRecipe = thisRec;
            _ingredients = _data.getIngredients(_thisRecipe);
            InitializeComponent();
            populate();
        }

        private void populate()
        {
            txbDirections.Text = _thisRecipe.directions;
            lblSeasons.Text = _thisRecipe.season;
            lblRecipeName.Text = _thisRecipe.name;
            lblStyles.Text = getStyles();
            lblCategories.Text = getCats();
            getIngredients();
        }
        
        private String getStyles()
        {
            String str = "";
            DataTable result = _data.getStyles(_thisRecipe);
            for(int i = 0; i < result.Rows.Count; ++i)
            {
                DataRow dr = result.Rows[i];
                str += dr["Name"].ToString() + ",";
            }
            str = str.TrimEnd(',');
            return str;
        }

        private String getCats()
        {
            String str = "";
            DataTable result = _data.getCategories(_thisRecipe);
            for(int i = 0; i < result.Rows.Count; ++i)
            {
                DataRow dr = result.Rows[i];
                str += dr["Name"].ToString() + ",";
            }
            str = str.TrimEnd(',');
            return str;
        }

        private void getIngredients()
        {
            
            for(int i = 0; i < _ingredients.Rows.Count; ++i)
            {
                DataRow dr = _ingredients.Rows[i];
                dgvIngredients.Rows.Add(dr);
            }
            dgvIngredients.Update();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            _resultsForm.Show();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            _data.favoriteRecipe(_thisRecipe);
            MessageBox.Show(_thisRecipe.name + " has been added to your favorites!");
        }

        private void frmShowRecipe_Load(object sender, EventArgs e)
        {
            dgvIngredients.DataSource = _ingredients;
        }
    }
}
