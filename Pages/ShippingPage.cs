using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace TestAutomationDemoProject.Pages
{
    class ShippingPage
    {
        private IWebDriver driver;

        public ShippingPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement ProceedToCheckOut => driver.FindElement(By.XPath("(//span[contains(.,'Proceed to checkout')])[2]"));
        IWebElement AgreeTermsCheckBox => driver.FindElement(By.XPath("//input[contains(@name,'cgv')]"));

        public void ClickProceedtoCheckout()
        {
            AgreeTermsCheckBox.Click();
            ProceedToCheckOut.Click();
        }
    }
}
