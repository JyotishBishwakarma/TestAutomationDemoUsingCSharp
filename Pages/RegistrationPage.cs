using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestAutomationDemoProject.Pages
{
    class RegistrationPage
    {
        private IWebDriver driver;

        public RegistrationPage(IWebDriver driver)
        {
            this.driver = driver;

        }

        //Locators for Personal Information Section
        IWebElement TitleMr => driver.FindElement(By.Id("id_gender1"));
        IWebElement TitleMrs => driver.FindElement(By.Id("id_gender2"));
        IWebElement FirstName => driver.FindElement(By.Id("customer_firstname"));
        IWebElement LastName => driver.FindElement(By.Id("customer_lastname"));
        IWebElement Email => driver.FindElement(By.Id("email"));
        IWebElement Password => driver.FindElement(By.Id("passwd"));
        IWebElement DOB_Day => driver.FindElement(By.Id("days"));
        IWebElement DOB_Month => driver.FindElement(By.Id("months"));
        IWebElement DOB_Year => driver.FindElement(By.Id("years"));
        IWebElement NewsLetterCheckBox => driver.FindElement(By.Id("uniform-newsletter")); 
        IWebElement SpecialOfferCheckBox => driver.FindElement(By.Id("optin"));

        //Locators for Your Address Section

        IWebElement Address_FirstName=> driver.FindElement(By.Id("firstname"));
        IWebElement Address_LastName => driver.FindElement(By.Id("lastname"));
        IWebElement Address_Company => driver.FindElement(By.Id("company"));
        IWebElement Address => driver.FindElement(By.Id("address1"));
        IWebElement Address_Line2 => driver.FindElement(By.Id("address2"));
        IWebElement City => driver.FindElement(By.Id("city"));
        IWebElement State => driver.FindElement(By.Id("id_state"));
        IWebElement PostalCode => driver.FindElement(By.Id("postcode"));
        IWebElement Country => driver.FindElement(By.Id("id_country"));
        IWebElement AdditionalInformation => driver.FindElement(By.Id("other"));
        IWebElement HomePhone => driver.FindElement(By.Id("phone"));
        IWebElement MobilePhone => driver.FindElement(By.Id("phone_mobile"));
        IWebElement Address_Alias => driver.FindElement(By.Id("alias"));

        IWebElement RegisterButton => driver.FindElement(By.Id("submitAccount"));

        public void registerDetails(String email)
        {
            TitleMr.Click();
            FirstName.SendKeys("Jyotish");
            LastName.SendKeys("Bishwakarma");
            if (Email.Text == " ")
            {
                Email.SendKeys(email);
            }
            Password.SendKeys("abc1234");
            SelectElement selectDay = new SelectElement(DOB_Day);
            selectDay.SelectByValue("23");
            SelectElement selectMonth = new SelectElement(DOB_Month);
            selectMonth.SelectByValue("4");
            SelectElement selectYear = new SelectElement(DOB_Year);
            selectYear.SelectByValue("1993");
            NewsLetterCheckBox.Click();
            SpecialOfferCheckBox.Click();
            Address_FirstName.SendKeys("Jyotish");
            Address_LastName.SendKeys("Bishwakarma");
            Address_Company.SendKeys("ABC");
            Address.SendKeys("Kathmandu");
            Address_Line2.SendKeys("Kalanki");
            City.SendKeys("kathmandu");
            SelectElement selectState = new SelectElement(State);
            selectState.SelectByValue("3");
            PostalCode.SendKeys("60007");
            SelectElement selectCountry = new SelectElement(Country);
            selectCountry.SelectByValue("21");
            AdditionalInformation.SendKeys("xyz");
            HomePhone.SendKeys("9876512323");
            MobilePhone.SendKeys("9817351720");
            Address_Alias.SendKeys("kalanki Kathmandu");
            RegisterButton.Submit();


        }











    }
}
