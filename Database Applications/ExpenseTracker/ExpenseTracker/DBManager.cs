using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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

        public static Boolean AddExpense(Expense expense)
        {
          //  DBManager.Connection.Close();
         //   DBManager.Connection.Open();

            string insertQuery = $"insert into expenses(DATE,CATEGORY,NAME,AMOUNT,DESCRIPTION) values('{expense.Date.ToString("yyyy-MM-dd")}'," +
                                 $" '{expense.Category}','{expense.Name}',{expense.Amount},'{expense.Description}')";

            MySqlCommand cmd = new MySqlCommand(insertQuery, Connection);

            int rowsAffected = cmd.ExecuteNonQuery();

            OnDbUpdated?.Invoke(null, "SELECT * FROM expenses");


            MySqlDataReader reader = GetReader($"select CAT_BUDGET , CUR_BUDGET from categories where CAT_NAME ='{expense.Category}'");

            int curBudget = 0, totalBudget = 0;

            while (reader.Read())
            {
                totalBudget = int.Parse(reader.GetString(0));
                  curBudget = int.Parse(reader.GetString(1));
            }


            reader.Close();

            string updateQuery = $"update categories set CUR_BUDGET = CUR_BUDGET + {expense.Amount} where CAT_NAME = '{expense.Category}'";

            cmd = new MySqlCommand(updateQuery, Connection);

            rowsAffected = cmd.ExecuteNonQuery();


            if (expense.Amount + curBudget > totalBudget)
            {
                return true;
            }

            //   DBManager.Connection.Close();

            

            return false;
        }

        public static Boolean UpdateExpense(Expense expense, int id)
        {
            //DBManager.Connection.Open();


            int curAmount = 0;
            using (MySqlDataReader reader1 = GetReader($"select amount from expenses where expense_id = {id}"))
            {
                while (reader1.Read())
                {
                    curAmount = int.Parse(reader1.GetString(0));
                }
            }


            string updateQuery = $"Update expenses set DATE='{expense.Date.ToString("yyyy-MM-dd")}', CATEGORY='{expense.Category}',NAME ='{expense.Name}'" +
                $",AMOUNT ='{expense.Amount}',DESCRIPTION ='{expense.Description}' where EXPENSE_ID ={id}";

            MySqlCommand cmd = new MySqlCommand(updateQuery, Connection);

            int rowsAffected = cmd.ExecuteNonQuery();

            OnDbUpdated?.Invoke(null, "SELECT * FROM expenses");




            updateQuery = $"update categories set CUR_BUDGET = CUR_BUDGET - {curAmount} +{expense.Amount} where CAT_NAME  = '{expense.Category}'";

            cmd = new MySqlCommand(updateQuery, Connection);

            rowsAffected = cmd.ExecuteNonQuery();


            MySqlDataReader reader = GetReader($"SELECT CAT_BUDGET, CUR_BUDGET FROM categories WHERE CAT_NAME = '{expense.Category}'");

            int curBudget = 0, totalBudget = 0;

            while (reader.Read())
            {
                // Assuming CAT_BUDGET and CUR_BUDGET are integers
                totalBudget = reader.GetInt32(0); // Index 0 corresponds to CAT_BUDGET
                curBudget = reader.GetInt32(1);   // Index 1 corresponds to CUR_BUDGET
            }

            reader.Close();


            //updateQuery = $"update categories set CUR_BUDGET = CUR_BUDGET + {expense.Amount}  where CAT_NAME  = '{expense.Category}'";

            //cmd = new MySqlCommand(updateQuery, Connection);

            //rowsAffected = cmd.ExecuteNonQuery();


            if (curBudget > totalBudget)
            {
                return true;
            }


            //DBManager.Connection.Close();

            return false;

        }

        public static void DeleteExpense(Expense expense)
        {
            //DBManager.Connection.Open();

            string deleteQuery = $"DELETE FROM expenses WHERE EXPENSE_ID = {expense.Id}";

            MySqlCommand cmd = new MySqlCommand(deleteQuery, Connection);

            int rowsAffected = cmd.ExecuteNonQuery();

           string updateQuery = $"update categories set CUR_BUDGET = CUR_BUDGET - {expense.Amount} where CAT_NAME = '{expense.Category}'";

            cmd = new MySqlCommand(updateQuery, Connection);

            rowsAffected = cmd.ExecuteNonQuery();


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

            string updateExpense = $"update expenses set CATEGORY = '{newCategory}' where CATEGORY = '{oldCategory}' ";

            cmd = new MySqlCommand(updateExpense, Connection);

            rowsAffected = cmd.ExecuteNonQuery();

            OnDbUpdated?.Invoke(null, "SELECT * FROM expenses");

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
