using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AmazonApp.Pages
{
    public class AddToCart
    {
        //Using page factory for initialization of Page objects
        public AddToCart(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//img[@class='s-image']")]
        [CacheLookup]
        public IWebElement dress;

        [FindsBy(How = How.XPath, Using = "//*[@class='a-box-inner']")]
        [CacheLookup]
        public IWebElement box;

        //*[@class='a-box-inner']
        [FindsBy(How = How.Id, Using = "buy-now-button")]
        [CacheLookup]
        public IWebElement buyNow;
    }
}
