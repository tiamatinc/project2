using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeMadness1
{
    class clsSQL
    {
        private String _strSQL;
        private SqlConnection _conn;
        
        clsSQL()
        {
            _strSQL = "";
            _conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\RecipeDB.mdf;Integrated Security=True");
        }
        public bool addRecipe(clsRecipe rec)
        {
            

            return true; //if successful
            //return false; //if failure
        }
        private void connect()
        {
            try
            {
                _conn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database connection failed to open. \n" + ex.Message);
            }
        }
        private void close()
        {
            try
            {
                _conn.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Database connection failed to close. \n" + ex.Message);
            }
        }

    }
}
