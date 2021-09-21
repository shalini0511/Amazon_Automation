/* Project = Automating Amazon using DDT and POM
 * Created by = V SHALINI
 * created on = 16/09/21
 */
using System;
using NUnit.Framework;
using OpenQA.Selenium;


namespace AmazonApp.DoActions
{
    public class LoginDoAction : BaseClass.BaseClass
    {
        public static void AssertAfterLaunch(IWebDriver driver)
        {
            string title1 = "Online Shopping site in India: Shop Online for Mobiles, Books, Watches, Shoes and More - Amazon.in";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }
        public static void SignInToAmazon(IWebDriver driver)
        {
            //Path for read data from Excel sheet
            ExcelOperation.PopulateInCollection(@"C:\Users\HP\source\repos\AmazonApp\AmazonApp\User_Data.xlsx");
            LoginPage.LoginPage login = new LoginPage.LoginPage(driver);

            //For Sign In
            login.signIn.Click();
            System.Threading.Thread.Sleep(1000);
            ScreenShot();
            try
            {
                log.Info("SignIn is Clicked");
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }


            //For email field
            login.email.SendKeys(ExcelOperation.ReadData(1, "email"));
            System.Threading.Thread.Sleep(1000);
            login.click_Continue.Click();
            ScreenShot();
            try
            {
                log.Info("email entered");
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }


            //For password field
            login.password.SendKeys(ExcelOperation.ReadData(1, "password"));
            System.Threading.Thread.Sleep(1000);
            ScreenShot();
            try
            {
                log.Info("Password entered");
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }


            //For log in button
            login.loginBtn.Click();
            System.Threading.Thread.Sleep(12000);
            ScreenShot();
            Assert.AreEqual(driver.Url, "https://www.amazon.in/?ref_=nav_ya_signin&");
            try
            {
                log.Info("Login is clicked");
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }
        }
        //Method for ScreenShot
        public static void ScreenShot()
        {
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\HP\source\repos\AmazonApp\AmazonApp\ScreenShots\Screenshot-1" + DateTime.Now.ToString("hhmmss") + ".png");
        }
    }
}





    
