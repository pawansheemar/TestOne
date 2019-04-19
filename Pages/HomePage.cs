using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestOne.Helpers;

namespace TestOne.Pages
{
    class HomePage
    {
        public void NavigateTM()
        {
            //Navigate to TM page
            CommonDriver.driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
            System.Threading.Thread.Sleep(1000);

            CommonDriver.driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]")).Click();
            System.Threading.Thread.Sleep(1000);
        }
    }
}
