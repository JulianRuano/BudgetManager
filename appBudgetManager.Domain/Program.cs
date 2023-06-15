using System;
using AppBudGetManager.Domain.System;

namespace AppBudGetManager.Domain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// 

            ClsSystem clsSystem = new ClsSystem();
            clsSystem.CreateBudGet();
            clsSystem.CreateCategory(1, "Food", "Food expenses");
            clsSystem.CreateCategory(2, "Transport", "Transport expenses");
            clsSystem.CreateCategory(3, "Salary", "Salary incomes");
            clsSystem.CreateCategory(4, "Extra", "Extra incomes");

            clsSystem.CreateTransaction(1, 1000, default, "Salary incomes", clsSystem.fldMyCategory[2], "Incomes");
            clsSystem.CreateTransaction(2, 3000, default, "Extra incomes", clsSystem.fldMyCategory[3], "Incomes");
            clsSystem.CreateTransaction(3, 2000, default, "Food expenses", clsSystem.fldMyCategory[0], "Expenses");
                    
            
            Console.WriteLine("Total Incomes: " + clsSystem.GetClsBudGet().GetTotalIncomes());
            Console.WriteLine("Total Expenses: " + clsSystem.GetClsBudGet().GetTotalExpenses());
            Console.WriteLine("Balance: " + clsSystem.GetClsBudGet().GetBalance());
            Console.WriteLine("Categoria: " + clsSystem.GetClsBudGet().fldMyIncomes[0].GetCategory().GetName());
            Console.WriteLine("Categoria: " + clsSystem.GetClsBudGet().fldMyIncomes[1].GetCategory().GetName());
            Console.WriteLine("Categoria: " + clsSystem.GetClsBudGet().flbMyExpenses[0].GetCategory().GetName());
            Console.ReadLine();
        }
    }
}
