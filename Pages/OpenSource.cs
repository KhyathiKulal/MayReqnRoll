//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OpenQA.Selenium;

//namespace ReqnrollProject.Pages
//{
//    internal class OpenSource
//    {
//        private readonly IWebDriver _driver;

//        public opensource(IWebDriver driver)
//        {
//            _driver = driver;
//        }

//        // locators on the login page
//        By firstName = By.XPath("//input[@id='name']");
//        By emailField = By.XPath("//input[@id='email']");
//        By gender = By.XPath("//div[3]//div[1]//div[1]//div[2]//input[1]");
//        By phone = By.XPath("//input[@id='mobile']");
//        By homepagedisplayed = By.XPath("(//a[@class = 'oxd-main-menu-item'])[1]");

//        // laucnh browser

//        public void launchbrowser()
//        {

//            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com");
//        }

//        // enter username and password
//        public void enterusernamepass(String username, String password)
//        {

//            _driver.FindElement(usernameField).SendKeys(username);
//            _driver.FindElement(passwordField).SendKeys(password);

//        }

//        // submit method

//        public void submit()
//        {
//            _driver.FindElement(loginFormLocator).Click();
//        }

//        // home page is displayed

//        public void homepagedisplay()
//        {

//            Thread.Sleep(3000);
//            IWebElement homepage = _driver.FindElement(homepagedisplayed);

//            if (homepage.Displayed)
//            {
//                Console.WriteLine("Home page is displayed");
//            }
//            else
//            {

//                Console.WriteLine("Home page is not displayed");
//            }
//        }
//    }
//}
