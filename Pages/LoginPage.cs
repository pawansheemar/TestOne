using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestOne.Helpers;

namespace TestOne.Pages
{
    class LoginPage
    {
        public void LoginSteps()
        {
            
            //Enter the url
            CommonDriver.driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            //Enter valid username
            IWebElement username = CommonDriver.driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");

            //Enter valid password
            IWebElement password = CommonDriver.driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");

            //Click on login button
            IWebElement LoginButton = CommonDriver.driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            LoginButton.Click();

            //Verify if you are on the homescreen

            //Identify "Hello hari"
            IWebElement helloHomepage = CommonDriver.driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            if (helloHomepage.Text == "Hello hari!")
            {
                Console.WriteLine("Hello Hari displayed, Test Passesd");

            }
            else
            {
                Console.WriteLine("Hello Hari displayed, Test Passesd");

            }
        }
    }
}
