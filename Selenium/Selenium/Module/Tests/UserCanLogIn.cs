using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium.Utility;
using Selenium.Module.Utility;
using Selenium.Module.Utility.PageObject;

namespace Selenium
{
    [TestClass]
    public class UserCanLogIn : TestBase
    {
        [TestMethod]
        public void LogInTest()
        {
            Pages.Login.LogIn();
            Assert.IsTrue(Pages.Login.IsAt());
                
        }
    }
}
