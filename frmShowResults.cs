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
        private DataTable _dtResults;
        
        public frmShowResults(DataTable result)
        {
            _dtResults = result;
            InitializeComponent();
            populate();
        }
        private void populate()
        {
            //GET IT TO SHOW ON THE DGV FFS
            for (int i = 0; i < _dtResults.Rows.Count; ++i)
            {
                DataRow dr = _dtResults.Rows[i];
                dgvResults.Rows.Add(dr);
            }
            dgvResults.Update();
        }
        private void frmShowResults_Load(object sender, EventArgs e)
        {
            dgvResults.DataSource = _dtResults;
        }

        private void dgvResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnView.Enabled = true;
            btnFavorite.Enabled = true;
        }

        private void dgvResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            showView();
        }
        private void showView()
        {
            clsRecipe rec = new clsRecipe();
            // str = DataGridView1.Rows[DataGridView.SelectedRows[0].Index].Cells[X].Value.ToString();
            rec.id = Int32.Parse(dgvResults.Rows[dgvResults.SelectedRows[0].Index].Cells[1].Value.ToString());
            rec.name = dgvResults.Rows[dgvResults.SelectedRows[0].Index].Cells[2].Value.ToString();
            rec.season = dgvResults.Rows[dgvResults.SelectedRows[0].Index].Cells[3].Value.ToString();
            rec.directions = dgvResults.Rows[dgvResults.SelectedRows[0].Index].Cells[4].Value.ToString();
            Char[] chararr = dgvResults.Rows[dgvResults.SelectedRows[0].Index].Cells[5].Value.ToString().ToCharArray();
            rec.favorite = chararr[0];

            frmShowRecipe showRec = new frmShowRecipe(this, rec);
            showRec.Show();
            this.Hide();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if(dgvResults.SelectedRows.Count != 0)
            {
                showView();
            }
            else
            {
                MessageBox.Show("You need to select a recipe first.");
            }
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            clsRecipe rec = new clsRecipe();
            clsSQL data = new clsSQL();
            // str = DataGridView1.Rows[DataGridView.SelectedRows[0].Index].Cells[X].Value.ToString();
            rec.id = Int32.Parse(dgvResults.Rows[dgvResults.SelectedRows[0].Index].Cells[1].Value.ToString());
            rec.name = dgvResults.Rows[dgvResults.SelectedRows[0].Index].Cells[2].Value.ToString();
            rec.season = dgvResults.Rows[dgvResults.SelectedRows[0].Index].Cells[3].Value.ToString();
            rec.directions = dgvResults.Rows[dgvResults.SelectedRows[0].Index].Cells[4].Value.ToString();
            Char[] chararr = dgvResults.Rows[dgvResults.SelectedRows[0].Index].Cells[5].Value.ToString().ToCharArray();
            rec.favorite = chararr[0];
            data.favoriteRecipe(rec);
            MessageBox.Show(rec.name + " has been added to your favorites!");
            dgvResults.Rows[dgvResults.SelectedRows[0].Index].Cells[5].Value = "Y";

        }

        private void frmShowResults_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }
    }
}
