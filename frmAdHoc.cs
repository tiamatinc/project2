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
    public partial class frmAdHoc : Form
    {
        private frmMenu _menu;
        private String _strRecipeName;
        private List<String> _strSeason;
        private List<clsIngredient> _strIngredients;
        private List<String> _strCategories;
        private List<String> _strStyles;
        private clsSQL _data;
        private DataTable _styles;
        private DataTable _categories;
        private DataTable _ingredients;
        public frmAdHoc(frmMenu menu)
        {
            _menu = menu;
            _data = new clsSQL();
            _strCategories = new List<String>();
            _strIngredients = new List<clsIngredient>();
            _strRecipeName = "";
            _strSeason = new List<String>();
            _strStyles = new List<String>();
            InitializeComponent();
            populate();
        }
        private void populate()
        {
            populateIngredients();
            populateCategories();
            populateStyles();
        }
        private void populateIngredients()
        {
            lstIngredients.Items.Clear();
            _ingredients = _data.getAllIngredients();
            for (int i = 0; i < _ingredients.Rows.Count; ++i)
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
        private void btnBack_Click(object sender, EventArgs e)
        {
            _menu.Show();
            this.Hide();
        }

        private void txbRecipeName_TextChanged(object sender, EventArgs e)
        {
            _strRecipeName = txbRecipeName.Text;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            buildStrings();
            frmShowResults showResults = new frmShowResults(_data.search(_strRecipeName, _strIngredients, _strSeason, _strStyles, _strCategories));
            showResults.Show();
            this.Hide();
        }
        private void buildStrings()
        {
            getIngredients();
            getStyles();
            getCats();
        }
        private void getCats()
        {
            foreach(ListViewItem i in lstCategories.CheckedItems)
            {
                _strCategories.Add(i.Text);
            }
        }
        private void getStyles()
        {
            foreach(ListViewItem i in lstStyles.CheckedItems)
            {
                _strStyles.Add(i.Text);
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
                _strIngredients.Add(ingr);

            }
        }

        private void frmAdHoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }
    }
}
