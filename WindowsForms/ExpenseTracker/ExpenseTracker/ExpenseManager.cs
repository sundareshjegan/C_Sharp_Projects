using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public static class ExpenseManager
    {
        public static List<Expense> ExpensesList = new List<Expense>();
        public static List<string> categories = new List<string>() { "Food", "Snacks", "Travel", "Others" };
        public static Dictionary<string, List<int>> categoryDict = new Dictionary<string, List<int>>()
        {
            { "Food" ,   new List<int>{0,0} }  ,
            { "Snacks" ,   new List<int>{0,0} }  ,
            { "Travel" ,   new List<int>{0,0} }  ,
            { "Others" ,   new List<int>{0,0} }
        };

        public static List<List<int>> monthExpenseList = new List<List<int>>()
        {
          new List<int>{0,0} ,   new List<int>{0,0} ,   new List<int>{0,0} ,   new List<int>{0,0},
          new List<int>{0,0} ,   new List<int>{0,0} ,   new List<int>{0,0} ,   new List<int>{0,0},
          new List<int>{0,0} ,   new List<int>{0,0} ,   new List<int>{0,0} ,   new List<int>{0,0}
        };

        public static event EventHandler<string> OnExpenseUpdated;
        public static event EventHandler<string> OnCategoryUpdated;
        private static int expenseId;

        #region Expense Management methods
        public static void AddExpense(Expense expense)
        {
            expense.Id = (++expenseId);
            ExpensesList.Add(expense);


            // checks and add montly expense
            if (monthExpenseList[expense.Date.Month - 1][1] + expense.Amount > monthExpenseList[expense.Date.Month - 1][0])
            {
                MessageBox.Show("You are exceeding your monthly Budget");
            }

            // checks and add cateogry expense
            foreach (var it in categoryDict)
            {
                if (it.Key == expense.Category)
                {
                    if(it.Value[1] + expense.Amount > it.Value[0] )
                        MessageBox.Show("You are exceeding your category Budget");

                    it.Value[1] += expense.Amount;
                }
                    
            }


            monthExpenseList[expense.Date.Month - 1][1] += expense.Amount;
            OnExpenseUpdated?.Invoke(ExpensesList, "add");
        }

        public static void RemoveExpense(Expense expense)
        {
            ExpensesList.Remove(expense);
        }


        public static void RemoveExpense(int idToRemove)
        {
            try
            {
                ExpensesList.RemoveAt(idToRemove);

                // it reduce deleted row amount in the current montly spend amount

                monthExpenseList[ExpensesList[idToRemove].Date.Month - 1][1] -= ExpensesList[idToRemove].Amount;

                //  it reduce deleted row amount in the current categoey wise spend amount             
                foreach (var it in categoryDict)
                {
                    if (it.Key == ExpensesList[idToRemove].Category)
                        it.Value[1]  -= ExpensesList[idToRemove].Amount;
                }

                OnExpenseUpdated?.Invoke(ExpensesList, "remove");

            }
            catch (Exception e) { }
        }



        #endregion

        #region Category Management methods
        public static void AddCategory(string categoryName)
        {
            categories.Add(categoryName);

            // add category to dictionary
            categoryDict.Add(categoryName, new List<int>() { 0, 0 });
            OnCategoryUpdated?.Invoke(categories, "Category");
        }

        public static void RemoveCategory(string categoryNameToRemove)
        {
            categories.Remove(categoryNameToRemove);
            categoryDict.Remove(categoryNameToRemove);

            // removing category from dictionary list
            foreach (Expense expense in ExpensesList)
            {
                if (expense.Category == categoryNameToRemove)
                {
                    expense.Category = "Others";
                }
            }

            OnExpenseUpdated?.Invoke(ExpensesList, "CategoryUpdated");
            OnCategoryUpdated?.Invoke(categories, "Category");
        }

        public static void UpdateCategory(string oldCategoryName, string newCategoryName)
        {
            // updating category name in only cateogry list

            for (int i = 0; i < categories.Count; i++)
            {
                if (categories[i].Equals(oldCategoryName, StringComparison.OrdinalIgnoreCase))
                {
                    categories[i] = newCategoryName;
                }
            }


            // update catgeory name in big list

            foreach (Expense expense in ExpensesList)
            {
                if (expense.Category == oldCategoryName)
                {
                    expense.Category = newCategoryName;
                }
            }

            //foreach (var it in categoryDict)
            //{
            //    if (it.Key == oldCategoryName)
            //    //    it.Key = newCategoryName;
            //}

                OnCategoryUpdated?.Invoke(categories, "CategoryUpdated");
            OnExpenseUpdated?.Invoke(ExpensesList, "CategoryUpdated");
        }
        #endregion
        
        #region Budget methods
        public static void SetBudget(int month, int limit)
        {
            monthExpenseList[month][0] = limit;

        }

        // adding category budget
          // pass two paameter category , amonunt
        //{

        //    foreach(var it in categoryDict)
        //    {
        //        if (it.Key == category)
        //            it.Value[0] = amount;
        //    }
        //}


        #endregion
    }
}
