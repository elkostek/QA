using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium.Module.Utility;
using Selenium.Module.Utility.PageObject;

namespace Selenium.Module.Tests
{
    [TestClass]
    public class UserCanOpenProfileSections : TestBase
    {
        [TestMethod]
        public void RunTest1()
        {
            Pages.Main.ClickMainTabBooks();
            Pages.Main.ClickMainTabEbooks();
        }

        [TestMethod]
        public void RunTest2()
        {
            Pages.Main.ClickMainTabBooks();
            Pages.Main.ClickMainTabEbooks();
        }
    }
}
