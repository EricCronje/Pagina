using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using WADotNet48APIPagination;
using WADotNet48APIPagination.Controllers;

namespace WADotNet48APIPagination.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
