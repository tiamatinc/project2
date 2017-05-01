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
    public partial class frmAddCategory : Form
    {
        private String _cat;
        private frmAddRecipe _frmRec;
        public frmAddCategory(frmAddRecipe frmRec)
        {
            _frmRec = frmRec;
            InitializeComponent();
        }

        private void txb_TextChanged(object sender, EventArgs e)
        {
            _cat = txb.Text;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            clsSQL data = new clsSQL();
            data.addCategory(_cat);
            _frmRec.populate("C");
            this.Close();
        }
    }
}
