using AppBudGetManager.Domain;
using AppBudGetManager.Domain.System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestAppBudgetManager
{
    [TestClass]
    public class UTestSystem
    {


        [TestMethod]
        public void TestCreateCategory()
        {
            // config
            ClsSystem objSystem = ClsSystem.GetInstance();
            ClsCategory objCategory = new ClsCategory(6, "Food", "Food plus");


            // create verification test
            objSystem.CreateCategory(6, "Food", "Food plus");


            // verification
            Assert.IsNotNull(objSystem.GetListCategories());
            Assert.AreEqual(0,objSystem.GetListCategories()[0].CompareTo(objCategory));


        }

        [TestMethod]
        public void TestUpdateCategory()
        {
            //config
            ClsSystem objSystem = ClsSystem.GetInstance();
            ClsCategory objCategory = new ClsCategory(6, "Travel", "travel plus");

            //create verification test    
            if(objSystem.GetListCategories().Count == 0)
            {
                objSystem.CreateCategory(6, "Food", "Food plus");
            }
            objSystem.UpdateCategory(6, "Travel", "travel plus");

            //verification
            Assert.IsNotNull(objSystem.GetListCategories());
            Assert.AreEqual(0, objSystem.GetListCategories()[0].CompareTo(objCategory));
        }

        [TestMethod]
        public void TestDeleteCategory()
        {
            //config
            ClsSystem objSystem = ClsSystem.GetInstance();

            //create verification test
            if (objSystem.GetListCategories().Count == 0)
            {
                objSystem.CreateCategory(6, "Food", "Food plus");
            }
            objSystem.DeleteCategory(6);

            //verification
            Assert.IsTrue(objSystem.CategoryExistsBool(6) == false ); 
            Assert.IsTrue(objSystem.GetListCategories().Count == 0);
        }



        [TestMethod]
        public void TestCreateTransaction()
        {
            //config
            ClsSystem objSystem = ClsSystem.GetInstance();
            ClsBudGet objBudGet = objSystem.GetClsBudGet();
            ClsCategory objCategory = new ClsCategory(6, "Food", "Food plus");
            ClsTransaction objTransaction = new ClsTransaction(1,1000, "10/09/2023", "Transaction 1");
            objTransaction.SetCategory(objCategory);

            //create verification test
            objBudGet.CreateTransaction(1,1000,"10/09/2023","Transaction 1",objCategory, "Incomes");

            //verification
            Assert.IsNotNull(objBudGet.MyIncomes);
            Assert.AreEqual(0, objBudGet.MyIncomes[0].CompareTo(objTransaction));

        }

        [TestMethod]
        public void TestUpdateTransaction()
        {
            //config
            ClsSystem objSystem = ClsSystem.GetInstance();
            ClsBudGet objBudGet = objSystem.GetClsBudGet();
            ClsCategory objCategory = new ClsCategory(6, "Food", "Food plus");
            ClsTransaction objTransaction = new ClsTransaction(1, 2000, "11/09/2023", "Transaction cambio");
            objTransaction.SetCategory(objCategory);

            //create verification test
            if (objBudGet.MyIncomes.Count == 0)
            {
                objBudGet.CreateTransaction(1, 1000, "10/09/2023", "Transaction 1", objCategory, "Incomes");
            }
            objBudGet.UpdateTransaction(1, 2000, "11/09/2023", "Transaction cambio", objCategory, "Incomes");

            //verification
            Assert.IsNotNull(objBudGet.MyIncomes);
            Assert.AreEqual(0, objBudGet.MyIncomes[0].CompareTo(objTransaction));         
        }
        [TestMethod]
        public void TestDeleteTransaction()
        {
            //config
            ClsSystem objSystem = ClsSystem.GetInstance();
            ClsBudGet objBudGet = objSystem.GetClsBudGet();
            ClsCategory objCategory = new ClsCategory(6, "Food", "Food plus");

            //create verification test
            if (objBudGet.MyIncomes.Count == 0)
            {
                objBudGet.CreateTransaction(1, 1000, "10/09/2023", "Transaction 1", objCategory, "Incomes");
            }
            objBudGet.DeleteTransaction(1, "Incomes");

            //verification
            Assert.IsTrue(objBudGet.MyIncomes.Count == 0);
            
        }
     
    }
}
