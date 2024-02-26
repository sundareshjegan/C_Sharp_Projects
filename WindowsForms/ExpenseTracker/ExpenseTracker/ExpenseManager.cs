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

        public static event EventHandler<string> OnExpenseUpdated;
        public static event EventHandler<string> OnCategoryUpdated;
        private static int expenseId;
        
        #region Expense Management methods
        public static void AddExpense(Expense expense)
        {
            expense.Id = (++expenseId);
            ExpensesList.Add(expense);
            OnExpenseUpdated?.Invoke(ExpensesList, "add");
        }

        public static void RemoveExpense(Expense expense)
        {
            ExpensesList.Remove(expense);
        }

        public static void RemoveExpense(int idToRemove)
        {
            ExpensesList.RemoveAt(idToRemove);
            OnExpenseUpdated?.Invoke(ExpensesList, "remove");
        }


        #endregion

        #region Category Management methods
        public static void AddCategory(string categoryName)
        {
            categories.Add(categoryName);
            OnCategoryUpdated.Invoke(categories, "Category");

        }

        public static void RemoveCategory(string categoryNameToRemove)
        {
            categories.Remove(categoryNameToRemove);
            OnCategoryUpdated.Invoke(categories, "Category");
        }

        public static void UpdateCategory(string oldCategoryName, string newCategoryName)
        {
            for(int i=0;i<categories.Count; i++)
            {
                if (categories[i].Equals(newCategoryName, StringComparison.OrdinalIgnoreCase))
                {
                    categories[i] = newCategoryName;
                }
            }
            foreach (Expense expense in ExpensesList)
            {
                if (expense.Category == oldCategoryName)
                {
                    expense.Category = newCategoryName;
                }
            }
            OnCategoryUpdated.Invoke(categories, "CategoryUpdated");
            OnExpenseUpdated.Invoke(ExpensesList, "CategoryUpdated");
        }
        #endregion
    }
}
