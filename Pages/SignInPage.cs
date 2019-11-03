using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;


namespace TestAutomationDemoProject.Pages
{
    class SignInPage
    {
        private IWebDriver driver;

        public SignInPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement RegistrationEmail => driver.FindElement(By.Id("email_create"));
        IWebElement CreateAccountButton => driver.FindElement(By.Id("SubmitCreate"));

        public void registerEmail(String email)
        {
            RegistrationEmail.SendKeys(email);
            CreateAccountButton.Submit();
        }
    }
}
