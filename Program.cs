using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestOne.Helpers;
using TestOne.Pages;

namespace TestOne
{
    [TestFixture]
    class Program
    {
        static void Main(string[] args)

        {
        }


       [SetUp]
        public void setup()
        {
            //defining driver
            CommonDriver.driver = new FirefoxDriver(@"E:\chromedriver\");

            // login object and logging in to TurnUp
            LoginPage loginPage = new LoginPage();
            loginPage.LoginSteps();

            //homePage object and navigating to TM page
            HomePage homePage = new HomePage();
            homePage.NavigateTM();

        }
        [Test]
        public void testCreateTM()
        {
            //TMPage object and Creating a record
            TMPage tMPage = new TMPage();
            tMPage.createTM();
        }
        [Test]
        public void testEditTM()
        {
            //TMPage object and Editing an record
            TMPage tMPage = new TMPage();
            tMPage.editTM();
        }
        [Test]
        public void testDeleteTM()
        {

        }

        [TearDown]
        public void tearDown()
        {
            CommonDriver.driver.Close();

        }


    }
}












              




