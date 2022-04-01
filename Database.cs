using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace tp_gene
{
    class Database
    {
        private static SQLiteConnection connection;

        public static SQLiteConnection getConnection()
        {
            if (Database.connection == null)
            {
                try
                {
                    Database.connection = new SQLiteConnection("Data Source=test.db; Version = 3;");
                    connection.Open();
                 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            }
            return Database.connection;
           
        }

    }
}
