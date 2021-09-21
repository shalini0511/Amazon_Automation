using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AmazonApp.DoActions
{
    public class SearchDoAction:BaseClass.BaseClass
    {
        /*public static void AssertForSearch(IWebDriver driver)
        {
            string title1 = "Search in";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }*/
        public static void SearchOperation()
        {
            Pages.SearchPage search = new Pages.SearchPage(driver);
            search.search.SendKeys(ExcelOperation.ReadData(1, "search"));
            System.Threading.Thread.Sleep(2000);
            search.search.SendKeys(Keys.ArrowDown);
            search.search.SendKeys(Keys.Enter);
            
            System.Threading.Thread.Sleep(1000);
            try
            {
                log.Info("product searched");
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }

        }
    }
}
