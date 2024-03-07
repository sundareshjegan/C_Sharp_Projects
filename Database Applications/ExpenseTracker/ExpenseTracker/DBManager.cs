using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

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
        public static event EventHandler<string> OnAddCategoryUpdated;

        public static void GetConnection()
        {       
            Connection = new MySqlConnection(connectionString);
            Connection.Open();
        }

        public static void AddExpense(Expense expense)
        {
          //  DBManager.Connection.Close();
         //   DBManager.Connection.Open();

            string insertQuery = $"insert into expenses(DATE,CATEGORY,NAME,AMOUNT,DESCRIPTION) values('{expense.Date.ToString("yyyy-MM-dd")}'," +
                                 $" '{expense.Category}','{expense.Name}',{expense.Amount},'{expense.Description}')";

            MySqlCommand cmd = new MySqlCommand(insertQuery, Connection);

            int rowsAffected = cmd.ExecuteNonQuery();
     
         //   DBManager.Connection.Close();

            OnDbUpdated?.Invoke(null, "SELECT * FROM expenses");
        }

        public static void UpdateExpense(Expense expense , int id )
        {
            //DBManager.Connection.Open();

            string updateQuery = $"Update expenses set DATE='{expense.Date.ToString("yyyy-MM-dd")}', CATEGORY='{expense.Category}',NAME ='{expense.Name}'" +
                $",AMOUNT ='{expense.Amount}',DESCRIPTION ='{expense.Description}' where EXPENSE_ID ='{id}'";

            MySqlCommand cmd = new MySqlCommand(updateQuery, Connection);

            int rowsAffected = cmd.ExecuteNonQuery();

            //DBManager.Connection.Close();

            OnDbUpdated?.Invoke(null, "SELECT * FROM expenses");
        }

        public static void DeleteExpense(int id)
        {
            //DBManager.Connection.Open();

            string deleteQuery = $"DELETE FROM expenses WHERE EXPENSE_ID = {id}";

            MySqlCommand cmd = new MySqlCommand(deleteQuery, Connection);

            int rowsAffected = cmd.ExecuteNonQuery();

            //DBManager.Connection.Close();

            OnDbUpdated?.Invoke(null, "SELECT * FROM expenses");
        }


        public static void ModifyMonthBudget(int month,int budget)
        {
            string updateQuery = $"update months set monthly_budget = {budget} where month_id = {month}";

            MySqlCommand cmd = new MySqlCommand(updateQuery, Connection);

            int rowsAffected = cmd.ExecuteNonQuery();

        }

        public static void AddCategory(string category , int month , int budget)
        {
            string insertQuery = $"insert into categories(CAT_NAME,MONTH_ID,CAT_BUDGET) values('{category}',{month},{budget})";

            MySqlCommand cmd = new MySqlCommand(insertQuery, Connection);

            int rowsAffected = cmd.ExecuteNonQuery();

            
            OnAddCategoryUpdated?.Invoke(null, "set category in expense input form");
        }

        public static void UpdateCategory(string oldCategory , string newCategory , int budget)
        {
            string updateQuery = $"update categories set CAT_NAME = '{newCategory}', CAT_BUDGET = {budget} where CAT_NAME = '{oldCategory}'";

            MySqlCommand cmd = new MySqlCommand(updateQuery, Connection);

            int rowsAffected = cmd.ExecuteNonQuery();
        }

        public static void DeleteCategory(string category) {

            string deleteQuery = $"DELETE FROM CATEGORIES WHERE CAT_NAME ='{category}'";

            MySqlCommand cmd = new MySqlCommand(deleteQuery, DBManager.Connection);

            int rowsAffected = cmd.ExecuteNonQuery();
        }

        
        public static MySqlDataReader GetReader(string query)
        {

       //   DBManager.Connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, DBManager.Connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            // db manger is closed in form1 and expenseinput form

            return reader;
        }

        #region Operational Functions and Variables
        public static Dictionary<string, int> monthNumberMap = new Dictionary<string, int>
        {
            {"January", 1},
            {"February", 2},
            {"March", 3},
            {"April", 4},
            {"May", 5},
            {"June", 6},
            {"July", 7},
            {"August", 8},
            {"September", 9},
            {"October", 10},
            {"November", 11},
            {"December", 12}
        };

        public static int GetMonthNumber(string monthName)
        {
            monthName = char.ToUpper(monthName[0]) + monthName.Substring(1).ToLower();
            
            if (monthNumberMap.ContainsKey(monthName))
            {
                return monthNumberMap[monthName];
            }
            else
            {
                throw new ArgumentException("Invalid month name");
            }

        }

        public static Dictionary<int, string> monthNameMap = new Dictionary<int, string>
        {
            {1, "January"},
            {2, "February"},
            {3, "March"},
            {4, "April"},
            {5, "May"},
            {6, "June"},
            {7, "July"},
            {8, "August"},
            {9, "September"},
            {10, "October"},
            {11, "November"},
            {12, "December"}
        };

        public static string GetMonthName(int monthNumber)
        {
            if (monthNameMap.ContainsKey(monthNumber))
            {
                return monthNameMap[monthNumber];
            }
            else
            {
                throw new ArgumentException("Invalid month number");
            }
        }


        public static Boolean IsCategoryExisted(string categroy)
        {
            

            return true;
        }
        #endregion


        //public static void GetMinAndMaxDate()
        //{
        //  //  DBManager.Connection.Open();

        //    string query = "SELECT MIN(DATE) FROM expenses";
        //    MySqlCommand cmd = new MySqlCommand(query, DBManager.Connection);

        //    MySqlDataReader reader = cmd.ExecuteReader();

        // //   DBManager.Connection.Close();

        //}


        //public static MySqlDataReader GetCategoriesasReader()
        //{

        //    DBManager.Connection.Open();

        //    string query = "SELECT CAT_NAME FROM categories";
        //    MySqlCommand cmd = new MySqlCommand(query, DBManager.Connection);

        //    MySqlDataReader reader = cmd.ExecuteReader();

        //    // db manger is closed in form1 and expenseinput form

        //    return reader;

        //}
    }
}
