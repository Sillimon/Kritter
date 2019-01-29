using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Entity.Migrations;

namespace KritterLib.Helpers
{
    public static class DatabaseHelper
    {
        public static String StrConnection
        {
            get { return @"Data Source=C:\Users\adai104\Desktop\Kritter\Kritter\DinoParc\Databases\local.db; Initial Catalog = local.db"; }
        }

        public static void FunctionResult()
        {
            SQLiteConnection sqlConn = new SQLiteConnection(StrConnection);

            Critter cr = new Critter("latin", "name", 22);

            //build QUERY
            String query = "INSERT INTO ";

            query += "Critter" + "(";

            if (cr.LatinName != null)
                query += "LatinName, ";

            query += "Name, Weight";

            if (cr.BirthDate != null)
                query += ", BirthDate";

            if (cr.Sex != 0)
                query += ", Sex";

            query += ") VALUES(";

            if (cr.LatinName != null)
                query += String.Format("'{0}', ", cr.LatinName);

            query += String.Format("'{0}', '{1}'", cr.Name, cr.Weight);

            if (cr.BirthDate != null)
                query += String.Format(", '{0}'", cr.BirthDate);

            if (cr.Sex != 0)
                query += String.Format(", '{0}'", cr.Sex);

            query += ")";

            SQLiteCommand sqlComm = new SQLiteCommand(query, sqlConn);

            sqlConn.Open();

            sqlComm.ExecuteNonQuery();

            sqlConn.Close();
        }
    }
}
