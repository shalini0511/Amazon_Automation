/* Project = Automating Amazon using DDT and POM
 * Created by = V SHALINI
 * created on = 16/09/21
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AmazonApp.LoginPage
{
    public class LoginPage
    {
        //Using page factory for initialization of Page objects
        public LoginPage(IWebDriver driver)
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


        [FindsBy(How = How.Id, Using = "ap_password")]
        [CacheLookup]
        public IWebElement password;

        [FindsBy(How = How.Id, Using = "signInSubmit")]
        [CacheLookup]
        public IWebElement loginBtn;

        [FindsBy(How = How.Id, Using = "twotabsearchtextbox")]
        [CacheLookup]
        public IWebElement search;

        [FindsBy(How = How.XPath, Using = "//span[@class='nav-cart-icon nav-sprite'] ")]
        [CacheLookup]
        public IWebElement addToCart;
    }
}
