using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AmazonApp.Pages
{
    public class Payment:BaseClass.BaseClass
    {
        //Using page factory for initialization of Page objects
        public Payment(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//span[text()='Add Debit/Credit/ATM Card']")]
        [CacheLookup]
        public IWebElement payment;
    }
}
