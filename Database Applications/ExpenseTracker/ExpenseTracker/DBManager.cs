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

        public static event EventHandler<string> OnDbUpdated;

        public static void GetConnection()
        {
            Connection = new MySqlConnection(connectionString);      
        }

        public static void AddExpense(Expense expense)
        {
            DBManager.Connection.Open();

            string insertQuery = $"insert into expenses(DATE,CATEGORY,NAME,AMOUNT,DESCRIPTION) values('{expense.Date.ToString("yyyy-MM-dd")}'," +
                                 $" '{expense.Category}','{expense.Name}',{expense.Amount},'{expense.Description}')";

            MySqlCommand cmd = new MySqlCommand(insertQuery, DBManager.Connection);

            int rowsAffected = cmd.ExecuteNonQuery();
     
            DBManager.Connection.Close();

            OnDbUpdated?.Invoke(null, "SELECT * FROM expenses");
        }

        public static void UpdateExpense(Expense expense , int id )
        {
            DBManager.Connection.Open();

            string updateQuery = $"Update expenses set DATE='{expense.Date.ToString("yyyy-MM-dd")}', CATEGORY='{expense.Category}',NAME ='{expense.Name}'" +
                $",AMOUNT ='{expense.Amount}',DESCRIPTION ='{expense.Description}' where EXPENSE_ID ='{id}'";

            MySqlCommand cmd = new MySqlCommand(updateQuery, DBManager.Connection);

            int rowsAffected = cmd.ExecuteNonQuery();

            DBManager.Connection.Close();

            OnDbUpdated?.Invoke(null, "SELECT * FROM expenses");
        }

        public static void DeleteExpense(int id)
        {
            DBManager.Connection.Open();

            string deleteQuery = $"DELETE FROM expenses WHERE EXPENSE_ID = {id}";

            MySqlCommand cmd = new MySqlCommand(deleteQuery, DBManager.Connection);

            int rowsAffected = cmd.ExecuteNonQuery();

            DBManager.Connection.Close();

            OnDbUpdated?.Invoke(null, "SELECT * FROM expenses");
        }

        //public static MySqlDataReader GetCategoriesasReader()
        //{

        //    DBManager.Connection.Open();

        //    string query = "SELECT CAT_NAME FROM categories";
        //    MySqlCommand cmd = new MySqlCommand(query, DBManager.Connection);

        //    MySqlDataReader reader = cmd.ExecuteReader();  

        //    // db manger is closed in form1 and expenseinput form

        //    return reader;

        //}

        //public static void GetMinAndMaxDate()
        //{
        //    DBManager.Connection.Open();

        //    string query = "SELECT MIN(DATE) FROM expenses";
        //    MySqlCommand cmd = new MySqlCommand(query, DBManager.Connection);

        //    MySqlDataReader reader = cmd.ExecuteReader();

        //    DBManager.Connection.Close();

        //}

        public static MySqlDataReader GetReader(string query)
        {

              DBManager.Connection.Open();

              MySqlCommand cmd = new MySqlCommand(query, DBManager.Connection);

              MySqlDataReader reader = cmd.ExecuteReader();  

              // db manger is closed in form1 and expenseinput form

              return reader;
        }

    }
}
