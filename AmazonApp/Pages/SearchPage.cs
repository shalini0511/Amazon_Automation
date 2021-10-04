using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AmazonApp.Pages
{
    public class SearchPage
    {
        //Using page factory for initialization of Page objects
        public SearchPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "twotabsearchtextbox")]
        [CacheLookup]
        public IWebElement search;

        [FindsBy(How = How.Id, Using = "nav-search-submit-button")]
        [CacheLookup]
        public IWebElement searchIcon;
        


    }
}
