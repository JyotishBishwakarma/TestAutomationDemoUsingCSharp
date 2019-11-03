using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace TestAutomationDemoProject.Pages
{
    class CartPage
    {
        private IWebDriver driver;

        public CartPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement ProceedToCheckOut => driver.FindElement(By.XPath("(//span[contains(.,'Proceed to checkout')])[2]"));

        public void ClickProceedtoCheckout()
        {
            ProceedToCheckOut.Click();
        }
    }
}
