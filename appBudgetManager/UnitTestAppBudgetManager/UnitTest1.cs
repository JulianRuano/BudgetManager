using AppBudGetManager.Domain;
using AppBudGetManager.Domain.System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestAppBudgetManager
{
    [TestClass]
    public class UTestSystem
    {
        private ClsSystem objSystem;
        private ClsCategory objCategory;

        [TestMethod]
        public void TestCreateCategory()
        {
            //config
            objSystem = new ClsSystem();
            objCategory = new ClsCategory(6, "Food", "Food plus");


            // prueba
            objSystem.CreateCategory(6, "Food", "Food plus");


            // comprobación

            Assert.IsNotNull(objSystem.GetListCategories());
            Assert.AreEqual(0,objSystem.GetListCategories()[0].CompareTo(objCategory));


        }
    }
}
