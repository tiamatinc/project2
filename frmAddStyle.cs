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
        private String _style;
        public frmAddStyle()
        {
            InitializeComponent();
        }

        private void txbStyle_TextChanged(object sender, EventArgs e)
        {
            _style = txbStyle.Text;

        }

        private void btnAddStyle_Click(object sender, EventArgs e)
        {
            clsSQL data = new clsSQL();
            data.addStyle(_style);
        }
    }
}
