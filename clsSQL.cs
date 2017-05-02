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
        public void addRecipe(clsRecipe recNewRecipe, List<clsIngredient> ingredientsUsed,
                               List<String> stylesUsed,List<String> catsUsed)
        {
            _strSQL = "INSERT INTO Recipes (Season, Directions, Favorite, Name) VALUES ('" + recNewRecipe.season + "', '" +
                       recNewRecipe.directions + "', '" + recNewRecipe.favorite + "', '" + recNewRecipe.name + "'); SELECT TOP 1 Rec_id " +
                       "FROM RECIPES ORDER BY Rec_id DESC;";
            executesql();
            int recID = Convert.ToInt32(_dtResult.Rows[0]["Rec_id"]);
            containsInsert(ingredientsUsed, recID);
            recStylesInsert(stylesUsed, recID);
            recCatsInsert(catsUsed, recID);
        }
        private void recCatsInsert(List<String> catsUsed, int recID)
        {
            _strSQL = "SELECT Cat_id FROM Categories WHERE Name IN (";
            foreach (String c in catsUsed)
            {
                _strSQL += "'" + c + "',";
            }
            _strSQL = _strSQL.TrimEnd(',');
            _strSQL += ");";
            executesql();
         
            _strSQL = "INSERT INTO Recipe_Categories (Cat_fk, Rec_fk) VALUES ";
            for (int i = 0; i < _dtResult.Rows.Count; ++i)
            {
                DataRow dr = _dtResult.Rows[i];
                _strSQL += "(" + Int32.Parse(dr["Cat_id"].ToString()) + ", " + recID + "),";

            }
            _strSQL = _strSQL.TrimEnd(',');
            _strSQL += ";";
            executesql();
        }
        private void recStylesInsert(List<String> styles, int recID)
        {
            _strSQL = "SELECT Style_id FROM Styles WHERE Name IN (";
            foreach (String s in styles) 
            {
                _strSQL += "'" + s + "',";
            }
            _strSQL = _strSQL.TrimEnd(',');
            _strSQL += ");";
            executesql();

            _strSQL = "INSERT INTO Recipe_Styles (Style_fk, Rec_fk) VALUES ";    
            for (int i = 0; i < _dtResult.Rows.Count; ++i)
            {
                DataRow dr = _dtResult.Rows[i];
                _strSQL += "(" + Int32.Parse(dr["Style_id"].ToString()) + ", " + recID + "),";

            }
            _strSQL = _strSQL.TrimEnd(',');
            _strSQL += ";";
            executesql();
        }
        private void containsInsert(List<clsIngredient> ingredientsUsed, int recID)
        {
            _strSQL = "INSERT INTO Recipe_Contains (Ingr_fk, Rec_fk) VALUES ";
            foreach (clsIngredient i in ingredientsUsed)
            {
                _strSQL += "(" + i.id + ", " + recID + "),";
            }
            _strSQL =_strSQL.TrimEnd(',');
            _strSQL += ";";
            executesql();
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
        public DataTable getAllTheRecipes()
        {
            _strSQL = "SELECT * FROM Recipes;";
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
                MessageBox.Show("Query failed to execute properly. \n QUERY: " + _strSQL + "\n\n" + ex.Message);
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
