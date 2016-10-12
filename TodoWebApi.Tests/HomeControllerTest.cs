using Microsoft.VisualStudio.TestTools.UnitTesting;
using TodoWebApi.Controllers;

namespace TodoWebApi.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Test_Home_Get()
        {
            HomeController hm = new HomeController();
            var response = hm.Get("danny");

            Assert.IsNotNull(response);
        }
    }
}