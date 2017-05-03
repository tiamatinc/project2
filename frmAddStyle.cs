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
    public partial class frmAddStyle : Form
    {
        private String style;
        private frmAddRecipe _frmRec;
        private clsSQL _data;
        public frmAddStyle(frmAddRecipe frmRec)
        {
            _frmRec = frmRec;
            _data = new clsSQL();
            InitializeComponent();
        }

        private void txbStyleName_TextChanged(object sender, EventArgs e)
        {
            style = txbStyleName.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (style != null && style != "")
            {
                _data.addStyle(style);
                this.Hide();
                _frmRec.populate("S");
                _frmRec.Show();
            }
            else
            {
                MessageBox.Show("Enter a style or close this window to exit adding a new style.");
            }
        }
    }
}
