using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace TestAutomationDemoProject.Pages
{
    class AddressPage
    {
        private IWebDriver driver;

        public AddressPage(IWebDriver driver)
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
