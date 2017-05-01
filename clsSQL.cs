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
        
        public clsSQL()
        {
            _strSQL = "";
            _conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\RecipeDB.mdf;Integrated Security=True");
            
        }
        public void addRecipe(clsRecipe rec, List<clsIngredient> ingrs)
        {
            _strSQL = "INSERT INTO Recipes (Season, Directions, Favorite, Name) VALUES ('" + rec.season + "', '" +
                       rec.directions + "', '" + rec.favorite + "', '" + rec.name + "'); SELECT TOP 1 Rec_id " +
                       "FROM RECIPES ORDER BY Rec_id DESC;";
            executesql();
            //update ingredient relations here. all ingredients in list should have an id value and should
            //already be added to the db
        }
        public void addIngredient(clsIngredient ingr)
        {
            _strSQL = "INSERT INTO Ingredients (Name, Description, Season) VALUES ('" + ingr.name + "', '" +
                      ingr.description + "', '" + ingr.season + "')";

            executesql();
        }
        public void addCategory(String catname)
        {
            _strSQL = "INSERT INTO Categories (Name) VALUES ('" + catname + "');";
            executesql();
        }
        public void addStyle(String style)
        {
            _strSQL = "INSERT INTO Styles (Name) VALUES ('" + style + "');";
            executesql();
        }
        public DataTable getAllIngredients()
        {
            _strSQL = "SELECT * FROM Ingredients;";
            executesql();
            return _dtResult;
        }

        public DataTable getAllCategories()
        {
            _strSQL = "SELECT * FROM Categories;";
            executesql();
            return _dtResult;
        }
        public DataTable getAllStyles()
        {
            _strSQL = "SELECT * FROM Styles;";
            executesql();
            return _dtResult;
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
