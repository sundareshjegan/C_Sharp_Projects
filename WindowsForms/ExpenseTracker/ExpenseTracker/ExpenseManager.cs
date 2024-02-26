using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker
{
    public static class ExpenseManager
    {
        public static List<Expense> ExpensesList = new List<Expense>();
        public static List<string> categories = new List<string>() { "Food", "Snacks", "Travel", "Other" };

        public static event EventHandler<string> OnDataUpdated;

        private static int expenseId;
        
        #region Expense Management methods
        public static void AddExpense(Expense expense)
        {
            expense.Id = (++expenseId);
            ExpensesList.Add(expense);
            OnDataUpdated?.Invoke(ExpensesList, "add");
        }

        public static void RemoveExpense(Expense expense)
        {
            ExpensesList.Remove(expense);
        }

        public static void RemoveExpense(int idToRemove)
        {
            //foreach(Expense expense in ExpensesList)
            //{
            //    if (expense.Id == idToRemove)
            //    {
            //        ExpensesList.Remove(expense);
            //    }
            //}
            ExpensesList.RemoveAt(idToRemove);
            OnDataUpdated?.Invoke(ExpensesList, "remove");
        }


        #endregion

        #region Category Management methods
        public static void AddCategory(string categoryName)
        {
            categories.Add(categoryName);
        }

        public static void RemoveCategory(string categoryNameToRemove)
        {
            categories.Remove(categoryNameToRemove);
        }
        #endregion
    }
}
