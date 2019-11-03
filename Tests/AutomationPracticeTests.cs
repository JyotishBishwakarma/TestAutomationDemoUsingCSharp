using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using TestAutomationDemoProject.Pages;
using System.Threading;
using TestAutomationDemoProject.Utils;

namespace TestAutomationDemoProject.Tests
{
    class AutomationPracticeTests
    {
        private IWebDriver driver;
        private static Random rnd = new Random();
       
        [OneTimeSetUp]
        public void Initialization()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }

        [Test]
        public void TC01_RegistrationTest()
        {
            String randomText = Utilities.RandomString(10, rnd);
            String email = "testautomation" + randomText + "@gmail.com";
            driver.Navigate().GoToUrl("http://automationpractice.com/");
            LandingPage lp = new LandingPage(driver);
            lp.ClickLogInButton();
            SignInPage sp = new SignInPage(driver);
            sp.registerEmail(email);
            Thread.Sleep(5000);
            RegistrationPage rp = new RegistrationPage(driver);
            rp.registerDetails(email);
            Thread.Sleep(5000);
        }

        [Test]
        public void TC02_AddProductsToCartAndPurchase()
        {

            CommonPage cp = new CommonPage(driver);
            cp.ClickWomenCategory();
            Thread.Sleep(5000);
            WomensCatPage wp = new WomensCatPage(driver);
            wp.AddFirstItemtoCart();
            wp.ClickContinueShopping();
            cp.ClickDresses_category();
            CatDressesPage dp = new CatDressesPage(driver);
            dp.AddFirstItemtoCart();
            dp.ClickCheckOut();
            AddressPage addresspage = new AddressPage(driver);
            addresspage.ClickProceedtoCheckout();   //it is for summary page 
            addresspage.ClickProceedtoCheckout();
            ShippingPage shippingpage = new ShippingPage(driver);
            shippingpage.ClickProceedtoCheckout();
            PaymentPage paymentpage = new PaymentPage(driver);
            paymentpage.CompletePayment();
            Thread.Sleep(5000);
            
        }
            

        [OneTimeTearDown]
        public void CleanUp()
        {
            driver.Close();

        }
    }
}
