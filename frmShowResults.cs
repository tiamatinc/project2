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
    public partial class frmShowResults : Form
    {
        DataTable _dtResults;
        BindingSource _bind;
        public frmShowResults(DataTable result)
        {
            _dtResults = result;
            _bind = new BindingSource();
            _bind.DataSource = _dtResults;
            InitializeComponent();
            populate();
        }
        private void populate()
        {
            //GET IT TO SHOW ON THE DGV FFS
            dgvResults.DataSource = _bind;
            dgvResults.Update();
        }

        private void frmShowResults_Load(object sender, EventArgs e)
        {
           // dgvResults.DataSource = _dtResults;
        }
    }
}
