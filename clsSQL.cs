using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
        private DataTable _dtResult;
        
        clsSQL()
        {
            _strSQL = "";
            _conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\RecipeDB.mdf;Integrated Security=True");
            
        }
        public void addRecipe(clsRecipe rec)
        {
            _strSQL = "INSERT INTO Recipes (Season, Directions, Favorite, Name) VALUES (" + rec.season + ", " +
                       rec.directions + ", " + rec.favorite + ", " + rec.name + ");";
            
            executesql();
        }
        private void executesql()
        {
            connect();
            SqlDataAdapter dataAdapt = new SqlDataAdapter(_strSQL, _conn);
            _dtResult = new DataTable();
            try
            {
                dataAdapt.Fill(_dtResult);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Query failed to execute properly. \n" + ex.Message);
            }
            finally
            {
                close();
            }
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
