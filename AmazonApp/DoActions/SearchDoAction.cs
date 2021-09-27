using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AmazonApp.DoActions
{
    public class SearchDoAction:BaseClass.BaseClass
    {
        public static void SearchOperation()
        {
            //search product
            Pages.SearchPage search = new Pages.SearchPage(driver);
            search.search.SendKeys(ExcelOperation.ReadData(1, "search"));
            System.Threading.Thread.Sleep(2000);
            Assert.True(search.search.Displayed);
            search.search.SendKeys(Keys.ArrowDown);
            search.search.SendKeys(Keys.Enter);
            
            System.Threading.Thread.Sleep(4000);
            try
            {
                log.Info("product searched");
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }
            //Select dress
            /*search.dress.Click();
            System.Threading.Thread.Sleep(2000);
           
            try
            {
                log.Info("item Selected");
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }*/
            



        }
    }
}
