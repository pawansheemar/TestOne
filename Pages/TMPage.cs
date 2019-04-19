using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestOne.Helpers;

namespace TestOne.Pages
{
    class TMPage
    {
        public void createTM()
        {
            //Click on Create New button
            IWebElement create = CommonDriver.driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            create.Click();

            //Enter value in Code textbox
            IWebElement code = CommonDriver.driver.FindElement(By.Id("Code"));
            code.SendKeys("Code01");

            //Enter characters in Description Textbox
            IWebElement description = CommonDriver.driver.FindElement(By.Id("Description"));
            description.SendKeys("Made in NZ");

            //Enter Price per unit value
            IWebElement price = CommonDriver.driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            price.SendKeys("1000");

            //click on Save button
            CommonDriver.driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();
            System.Threading.Thread.Sleep(1000);

        }

        public void editTM()
        {
            //Click on Edit for any one record


            CommonDriver.driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[5]/a[1]")).Click();
            System.Threading.Thread.Sleep(1000);


            //Edit/Update a value for the selected record
            CommonDriver.driver.FindElement(By.XPath("//*[@id='Code']")).Clear();
            CommonDriver.driver.FindElement(By.XPath("//*[@id='Code']")).SendKeys("updatecode01");

            //Save the updated record
            CommonDriver.driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();
            System.Threading.Thread.Sleep(1000);

            //Verify if the record is updated
            IWebElement actualCode = CommonDriver.driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]"));

            if (actualCode.Text == "updatecode01")
            {
                Console.WriteLine("TM record edited succesfully, test passed");

            }
            else
            {
                Console.WriteLine("TM record NOT edited succesfully, test failed");


            }
           

        }
    }
}



        
    

