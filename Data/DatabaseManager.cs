using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyper.Data
{
    public class DatabaseManager
    {
        public static SQLiteConnection CreateDatabase(string fileName)
        {
            SQLiteConnection.CreateFile(fileName);
            SQLiteConnection conn = new SQLiteConnection($"Data Source={fileName};Version=3;");

            conn.Open();

            return conn;
        }

        public static int InsertQuery(string query, SQLiteConnection connection)
        {
            SQLiteCommand command = new SQLiteCommand(query, connection);
            int result = command.ExecuteNonQuery();

            return result;
        }
    }
}
