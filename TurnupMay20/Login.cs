using System;
using OpenQA.Selenium;

namespace TurnupMay20
{
    public class Login
    {
        private IWebDriver driver; 
             
        public Login(IWebDriver driver)
        {
            this.driver = driver; 
        }

        public void LoginSuccess()
        {

            // open turn up application
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");


            //Identify username
            IWebElement userName = driver.FindElement(By.Id("UserName"));
            // enter hari as username
            userName.SendKeys("hari");

            //identfying password & sending password
            IWebElement password = driver.FindElement(By.Name("Password"));
            password.SendKeys("123123");

            //clicked login btn
            IWebElement loginBtn = driver.FindElement(By.XPath("//input[@type='submit']"));
            loginBtn.Click();
        }
    }
}
