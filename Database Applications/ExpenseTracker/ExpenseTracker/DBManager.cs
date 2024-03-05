using MySql.Data.MySqlClient;
using System;

namespace ExpenseTracker
{
    public static class DBManager
    {
        private static readonly string server = "localhost";
        private static readonly string database = "expenseappdb";
        private static readonly string user = "root";
        private static readonly string password = "$Ss2606sS$";
        private static readonly string connectionString = $"server={server};user={user};password={password};database={database}";
        public static MySqlConnection Connection = null;

        public static void GetConnection()
        {
            Connection = new MySqlConnection(connectionString);
         
        }
    }
}
