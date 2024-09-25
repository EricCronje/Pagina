using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestDataSourceDotNet4._8
{
    [TestClass]
    public class UnitTestDataSource
    {
        [TestMethod]
        public void Valid_TestDefaultData()
        {
            //Arrange
            DefaultPaginationData paginationData = new DefaultPaginationData();

            //Assign
            List<string> PaginationList = paginationData.GetData();

            //Assert
            Assert.IsFalse(PaginationList == null);
            Assert.IsTrue(PaginationList.Count == 9);
            Assert.IsTrue(PaginationList[0].Equals("Apple"));

        }
    }
}
