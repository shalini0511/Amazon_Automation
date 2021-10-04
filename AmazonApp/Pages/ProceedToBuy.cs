using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AmazonApp.Pages
{
    public class ProceedToBuy:BaseClass.BaseClass
    {
        //Using page factory for initialization of Page objects
        public ProceedToBuy(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//body/div[@id='a-page']/div[4]/div[1]/div[3]/div[1]/div[1]/div[3]/div[1]/form[1]/div[1]/div[3]/span[1]/span[1]/input[1]")]
        [CacheLookup]
        public IWebElement buy;
    }
}
