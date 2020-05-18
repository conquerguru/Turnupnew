using System;
using System.Threading;
using OpenQA.Selenium;

namespace TurnupMay20
{
    internal class TimeMaterial
    {
        private IWebDriver driver;

        public TimeMaterial(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void clickCreateNew()
        {
            //CreateNew button and then click//
            IWebElement createNew = driver.FindElement(By.XPath("//a[@href='/TimeMaterial/Create']"));
            createNew.Click();
        }

        internal void createNewRecord()
        {
            //Find Code button
            IWebElement Code = driver.FindElement(By.Id("Code"));
            Code.SendKeys("123");
            //Find description button and entering value//
            IWebElement description = driver.FindElement(By.XPath("//input[contains(@id,'Description')]"));
            description.SendKeys("Purple");
            //Finding pricePerUnit and entering value//
            IWebElement pricePerUnit = driver.FindElement(By.XPath("//input[contains(@class,'k-formatted-value k-input')]"));
            pricePerUnit.SendKeys("3000");
            //finding  save button and then click
            IWebElement saveButton = driver.FindElement(By.XPath("//input[contains(@id,'SaveButton')]"));
            saveButton.Click();
        }

        internal void validateRecord()
        {
            // Wait for 1 second
            Thread.Sleep(1500);
            IWebElement lastPage = driver.FindElement(By.XPath("//span[contains(.,'Go to the last page')]"));
            lastPage.Click();

            //
            for (int i = 1; i <=10; i++)
            {
                IWebElement code = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr["+i+"]/td[1]"));
            }
        }
    }
}