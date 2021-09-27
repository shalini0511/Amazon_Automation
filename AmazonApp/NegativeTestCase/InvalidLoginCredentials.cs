using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AmazonApp.NegativeTestCase
{
    public class InvalidLoginCredentials
    {
        //Using page factory for initialization of Page objects
        public InvalidLoginCredentials(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        //using FindsBy locating the element
        [FindsBy(How = How.XPath, Using = "//a[@id='nav-link-accountList']")]
        [CacheLookup]
        public IWebElement signIn;

        [FindsBy(How = How.Id, Using = "ap_email")]
        [CacheLookup]
        public IWebElement email;


        [FindsBy(How = How.Id, Using = "continue")]
        [CacheLookup]
        public IWebElement click_Continue;
        
        [FindsBy(How = How.XPath, Using = " //span[contains(text(),'We cannot find an account with that email address')]")]
        [CacheLookup]
        public IWebElement error;


    }
}
