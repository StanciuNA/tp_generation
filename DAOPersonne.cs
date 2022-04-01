using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Windows.Forms;

namespace tp_gene
{
    class DAOPersonne
    { 
        public static List<Personne> Load()
        {
            List<Personne> lespersonnes = new List<Personne>();

            string req = "SELECT * FROM Personne";
            SQLiteCommand command = new SQLiteCommand(req, Database.getConnection());

            try
            {
                SQLiteDataReader data = command.ExecuteReader();

                while (data.Read())
                {
                    Personne p = new Personne(data.GetInt32(0), data.GetString(1), data.GetString(2));
                    lespersonnes.Add(p);
                }

                return lespersonnes;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }



        }

    }
}
