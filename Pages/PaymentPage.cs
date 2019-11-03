using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace TestAutomationDemoProject.Pages
{
    class PaymentPage
    {
        private IWebDriver driver;

        public PaymentPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement PayWithBankWire => driver.FindElement(By.XPath("//a[contains(@class,'bankwire')]"));
        IWebElement PayByCheck => driver.FindElement(By.XPath("(//span[contains(.,'(order processing will be longer)')])[2]"));
        IWebElement ConfirmOrder => driver.FindElement(By.XPath("//span[contains(.,'I confirm my order')]"));

        public void CompletePayment()
        {
            PayWithBankWire.Click();
            ConfirmOrder.Click();
            
        }
    }
}
