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
        private static int expenseId;
        public static List<Expense> ExpensesList = new List<Expense>();
        public static List<string> categories = new List<string>() { "Food", "Snacks", "Travel", "Others" };
        public static List<List<int>> monthExpenseList = GetMonthWiseList(2000);
        public static Dictionary<string, List<List<int>> > categoryDict = new Dictionary<string, List<List<int>> >()
        {
            { "Food" ,      GetMonthWiseList(1000)  }  ,
            { "Snacks" ,    GetMonthWiseList(1000)  }  ,
            { "Travel" ,    GetMonthWiseList(1000)  }  ,
            { "Others" ,    GetMonthWiseList(1000)  } 
        };
        public static Dictionary<int, string> MonthNumberAndName = new Dictionary<int, string>()
        {
            {1,"January" },{2,"February" },{3,"March" },{4,"April" },{5,"May" },{6,"June" },
            {7,"July" },{8,"August" },{9,"September" },{10,"October" },{11,"November" },{12,"December" },
        };

        public static event EventHandler<string> OnExpenseUpdated;
        public static event EventHandler<string> OnCategoryUpdated;


        #region Expense Management methods
        public static void AddExpense(Expense expense)
        {
            expense.Id = (++expenseId);
            ExpensesList.Add(expense);
            CheckBudget(expense);
            monthExpenseList[expense.Date.Month - 1][1] += expense.Amount;
            ExpensesList = ExpensesList.OrderBy(x => x.Date).ToList();
            OnExpenseUpdated?.Invoke(ExpensesList, "add");
        }
        
        public static void UpdateExpense(Expense expense,int id)
        {
            monthExpenseList[expense.Date.Month - 1][1] -= ExpensesList[id].Amount;
            ExpensesList[id].Date = expense.Date;
            ExpensesList[id].Name = expense.Name;
            ExpensesList[id].Category = expense.Category;       
            ExpensesList[id].Amount = expense.Amount;
            ExpensesList[id].Description = expense.Description;           
            CheckBudget(expense);

            OnExpenseUpdated?.Invoke(ExpensesList, "add");


        }

        public static void CheckBudget(Expense expense)
        {
            //// checks and add montly expense
            if (monthExpenseList[expense.Date.Month - 1][1] + expense.Amount > monthExpenseList[expense.Date.Month - 1][0])
            {
                MessageBox.Show($"You are exceeding your {MonthNumberAndName[expense.Date.Month] } Budget");
            }

            // checks and add cateogry expense
            foreach (var it in categoryDict)
            {
                if (it.Key == expense.Category)
                {
                    if (it.Value[expense.Date.Month - 1][1] + expense.Amount > it.Value[expense.Date.Month - 1][0])
                        MessageBox.Show($"You are exceeding your {expense.Category}  Budget limit { it.Value[expense.Date.Month - 1][0] }");

                    it.Value[expense.Date.Month - 1][1] += expense.Amount;
                }
            }
        }


        public static void RemoveExpense(Expense expense)
        {
            ExpensesList.Remove(expense);
        }

        public static void RemoveExpense(int idToRemove)
        {
            int month = ExpensesList[idToRemove].Date.Month - 1; // as per index wise
            try
            {
                // it reduce deleted row amount in the current montly spend amount
                monthExpenseList[ExpensesList[idToRemove].Date.Month - 1][1] -= ExpensesList[idToRemove].Amount;

                //  it reduce deleted row amount in the current categoey wise spend amount             
                foreach (var it in categoryDict)
                {
                    if (it.Key == ExpensesList[idToRemove].Category)
                        it.Value[month][1]  -= ExpensesList[idToRemove].Amount;
                }

                // finally removing from all collections , remove from big list
                ExpensesList.RemoveAt(idToRemove);

                OnExpenseUpdated?.Invoke(ExpensesList, "remove");

            }
            catch (Exception e) { }
        }
        #endregion

        #region Category Management methods
        public static void AddCategory(string categoryName, int amount)
        {
            categories.Add(categoryName);

            // add category to dictionary
            categoryDict.Add(categoryName, GetMonthWiseList(amount));

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

        public static void UpdateCategory(string oldCategoryName, string newCategoryName,int month, int newBudget)
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

            // updating category in dictionary

            foreach (var it in categoryDict)
            {
                if (it.Key == oldCategoryName)
                {
                    // List<List<int>> tempList = it.Value;
                    it.Value[month][0] = newBudget;
                    categoryDict.Remove(it.Key);
                    categoryDict.Add(newCategoryName, it.Value);
               
                    break;
                }

            }

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

        #region Add-on methods
        // TO get all 12 months budget and current value
        public static List<List<int>> GetMonthWiseList(int amount)
        {
            return new List<List<int>>()
            {
              new List<int>{ amount, 0} ,   new List<int>{ amount, 0} ,   new List<int>{ amount, 0} ,   new List<int>{ amount, 0},
              new List<int>{ amount, 0} ,   new List<int>{ amount, 0} ,   new List<int>{ amount, 0} ,   new List<int>{ amount, 0},
              new List<int>{ amount, 0} ,   new List<int>{ amount, 0} ,   new List<int>{ amount, 0} ,   new List<int>{ amount, 0}
            };
        }
        #endregion
    }
}
