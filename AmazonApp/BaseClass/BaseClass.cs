/* Project = Automating Amazon using DDT and POM
 * Created by = V SHALINI
 * created on = 16/09/21
 */
using System;
using System.IO;
using System.Reflection;
using log4net;
using log4net.Repository;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace AmazonApp.BaseClass
{
   //[TestFixture]
    public class BaseClass
    {
        public static IWebDriver driver;
        //Get Logger for fully qualified name for type of 'Tests'
        public static readonly ILog log = LogManager.GetLogger(typeof(Tests));

        //Get the default ILoggingRepository
        private static readonly ILoggerRepository repository = log4net.LogManager.GetRepository(Assembly.GetCallingAssembly());
       /* protected string browser;
        //default constructor
        public BaseClass()
        {

        }
        //parameterized constructor
        public BaseClass(string browser)
        {
            this.browser = browser;
        }*/
        [SetUp]
        public void SetUp()
        {
            // Configuring Log4Net
            // BasicConfigurator.Configure();
            // Valid XML file with Log4Net Configurations
            var fileInfo = new FileInfo(@"App.config");

            // Configure default logging repository with Log4Net configurations
            log4net.Config.XmlConfigurator.Configure(repository, fileInfo);
            log.Info("Entering Setup");
            try
            {
                /* switch (browser)
                 {

                     case "chrome":
                         //Creating an instance of chrome webdriver
                         ChromeOptions options = new ChromeOptions();
                         options.AddArguments("--disable-notifications");
                         options.AddArguments("--disable-bubbles");
                         driver = new ChromeDriver(options);
                        
                         break;
                     case "firefox":
                         //Creating an instance of firefox webdriver
                         driver = new FirefoxDriver();
                        System.Threading.Thread.Sleep(4000);
                         break;
                        
                     default:
                         driver = new ChromeDriver();
                         break;
                 }*/
                driver = new ChromeDriver();
                log.Debug("navigating to url");
                driver.Url = "http://www.amazon.in/";
                // To maximize browser
                driver.Manage().Window.Maximize();
                //driver.Close();s


                log.Info("Exiting setup");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void Takescreenshot()
        {
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\HP\source\repos\AmazonApp\AmazonApp\Screenshot\test7.jpg");
        }
        [TearDown]
        public void TearDown()
        {

            driver.Quit();
        }


    }

    
    
}
