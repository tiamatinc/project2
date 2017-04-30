using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeMadness1
{
    class clsSQL
    {
        private String _strSQL;
        private String _conn;
        
        clsSQL()
        {
            _strSQL = "";
            //_conn = connection string here
        }
        public bool addRecipe(clsRecipe rec)
        {
            return true; //if successful
            return false; //if failure
        }
        private void connect()
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;

            myConnectionString = "server=127.0.0.1;uid=root;" +
                "pwd=12345;database=test;";

            try
            {
                conn = new MySqlConnection(myConnectionString);
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
