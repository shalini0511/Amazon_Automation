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
        public IWebElement product;

        [FindsBy(How = How.Id, Using = "add-to-cart-button")]
        [CacheLookup]
        public IWebElement addtocartbtn;

        [FindsBy(How = How.PartialLinkText, Using = "Cart")]
        [CacheLookup]
        public IWebElement cart;
    }
}
