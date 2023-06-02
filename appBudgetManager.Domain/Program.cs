using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBudGetManager.Domain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClsSystem clsSystem = new ClsSystem();
            clsSystem.CreateBudGet();
            clsSystem.CreateCategory(1, "Food", "Food expenses");
            clsSystem.CreateCategory(2, "Transport", "Transport expenses");
            clsSystem.CreateCategory(3, "Salary", "Salary incomes");
            clsSystem.CreateCategory(4, "Extra", "Extra incomes");

            clsSystem.CreateTransaction(1, 1, default, "Food expenses", clsSystem.fldMyCategory[1],"Incomes");
            clsSystem.CreateTransaction(2, 2, default, "Transport expenses", clsSystem.fldMyCategory[2], "Incomes");

            
            
            Console.WriteLine("BudGet created: "+ clsSystem.GetClsBudGet().GetBalance());
            Console.ReadLine();
        }
    }
}
