using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AmazonApp.Pages
{
    public class LogoutPage : BaseClass.BaseClass
    {
        public LogoutPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        //using FindsBy locating the element
        [FindsBy(How = How.XPath, Using = "//a[@id='nav-link-accountList']")]
        [CacheLookup]
        public IWebElement signIn;

        [FindsBy(How = How.XPath, Using = "//div[@id='nav-al-container']")]
        [CacheLookup]
        public IWebElement account;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Sign Out')]")]
        [CacheLookup]
        public IWebElement signOut;

        [FindsBy(How = How.Id, Using = "ap_email")]
        [CacheLookup]
        public IWebElement email;

        [FindsBy(How = How.Id, Using = "continue")]
        [CacheLookup]
        public IWebElement click_Continue;

    }
}