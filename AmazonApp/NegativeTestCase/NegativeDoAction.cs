using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AmazonApp.NegativeTestCase
{
    public class NegativeDoAction:BaseClass.BaseClass
    {
        public static void InvalidData(IWebDriver driver)
        {
            try
            {


                //Path for read data from Excel sheet
                NegativeTestCase.NegativeExcelOperation.PopulateInCollection(@"C:\Users\HP\source\repos\AmazonApp\AmazonApp\NegativeTestData.xlsx");
                NegativeTestCase.InvalidLoginCredentials invalid = new InvalidLoginCredentials(driver);
                //For Sign In
                invalid.signIn.Click();
                System.Threading.Thread.Sleep(1000);



                //For email field
                invalid.email.SendKeys(NegativeExcelOperation.ReadData(1, "email"));
                System.Threading.Thread.Sleep(1000);
                invalid.click_Continue.Click();

                //Validation for neagtive test case
                Assert.True(invalid.error.Displayed);
            }
            catch(NoSuchElementException ex)
            {
                Console.WriteLine(ex.Message);
            }




        }

         
    }
}
