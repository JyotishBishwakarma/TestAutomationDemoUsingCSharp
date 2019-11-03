using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace TestAutomationDemoProject.Pages
{
    class WomensCatPage
    {
        private IWebDriver driver;

        public WomensCatPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement FadedShortSleeveTshirt => driver.FindElement(By.XPath("//img[contains(@alt,'Faded Short Sleeve T-shirts')]"));
        IWebElement AddtoCartFirstItem => driver.FindElement(By.XPath("(//span[contains(.,'Add to cart')])[1]"));
        
        IWebElement ContinueShopping => driver.FindElement(By.XPath("(//span[contains(.,'Continue shopping')])[2]"));
        IWebElement CheckOut => driver.FindElement(By.XPath("//span[contains(.,'Proceed to checkout')]"));

        public void AddFirstItemtoCart()
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(FadedShortSleeveTshirt).Perform();
            AddtoCartFirstItem.Click();
        }

        public void ClickContinueShopping()
        {
            ContinueShopping.Click();
        }

        public void ClickCheckOut()
        {
            CheckOut.Click();
        }

    }
}
