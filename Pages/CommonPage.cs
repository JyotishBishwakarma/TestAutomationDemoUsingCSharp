using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace TestAutomationDemoProject.Pages
{
    class CommonPage
    {
        private IWebDriver driver;

        public CommonPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Locators for primary nav
        IWebElement Women_category => driver.FindElement(By.XPath("//a[contains(@title,'Women')]"));
        IWebElement Dresses_category => driver.FindElement(By.XPath("(//a[@title='Dresses'])[2]"));
        IWebElement Tshirt_category => driver.FindElement(By.XPath("(//a[@title='T-shirts'])[2]"));

        public void ClickWomenCategory()
        {
            Women_category.Click();
        }

        public void ClickDresses_category()
        {
            Dresses_category.Click();
        }

        public void ClickTshirt_category()
        {
            Tshirt_category.Click();
        }




    }
}
