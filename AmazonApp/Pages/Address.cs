using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AmazonApp.Pages
{
    public class Address:BaseClass.BaseClass
    {
        //Using page factory for initialization of Page objects
        public Address(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.PartialLinkText, Using = "Deliver to this addr")]
        [CacheLookup]
        public IWebElement address;
    }
}

