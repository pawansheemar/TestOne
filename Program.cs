using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOne
{
    class Program
    {
        static void Main(string[] args)

        {
            //Open up the Googlechrome

            IWebDriver driver = new FirefoxDriver(@"E:\chromedriver\");

            //Enter the url
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            //Enter valid username
            IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");

            //Enter valid password
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");

            //Click on login button
            IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            LoginButton.Click();

            //Verify if you are on the homescreen

            //Identify "Hello hari"
            IWebElement helloHomepage = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

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

     //Edit an existing time and materials record

    //Navigate to TM page
    

    //Click on Edit for one record

