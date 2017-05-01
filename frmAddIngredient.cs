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
    public partial class frmAddIngredient : Form
    {
       
        private clsIngredient _ingredient;
        public frmAddIngredient()
        {
            InitializeComponent();
        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {
            _ingredient.name = txbName.Text;
        }

        private void txbDescription_TextChanged(object sender, EventArgs e)
        {
            _ingredient.description = txbDescription.Text;
        }

        private void cmbSeason_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ingredient.season = cmbSeason.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsSQL data = new clsSQL();
            data.addIngredient(_ingredient);
        }
    }
}
