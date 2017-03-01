using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium.Utility;

namespace Selenium.Module.Utility.PageObject
{

        [TestClass]
        public class TestBase
        {
            [TestInitialize]
            public void Initialize()
            {
                Browser.Initialize();
               
        }

            [TestCleanup]
            public void Cleanup()
            {
                //Browser.Close();
               // Browser.Quit();
            }
        }
    
}
