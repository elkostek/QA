using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium.Utility;

namespace Selenium.Module.Utility.PageObject
{
   public class MainPage
    {

        public void ClickMainTabBooks()
        {

            Browser.Wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy((By.XPath("//a[@title='książki']"))));
            var BooksField = Browser.Driver.FindElement(By.XPath("//a[@title='książki']"));
            BooksField.Click();
        }

        public void ClickMainTabEbooks()
        {

            Browser.Wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy((By.XPath("//a[@title='ebooki']"))));
            var EbooksField = Browser.Driver.FindElement(By.XPath("//a[@title='ebooki']"));
            EbooksField.Click();
        }
    }
}
