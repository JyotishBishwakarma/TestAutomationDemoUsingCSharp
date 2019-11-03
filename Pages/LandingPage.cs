using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace TestAutomationDemoProject.Pages
{
    class LandingPage
    {
        private readonly IWebDriver _driver;

        public LandingPage(IWebDriver driver)
        {
            _driver = driver;

        }

        IWebElement SignInButton => _driver.FindElement(By.CssSelector("a[class='login']"));

        public void ClickLogInButton()
        {
            SignInButton.Click();
        }
    }
}
