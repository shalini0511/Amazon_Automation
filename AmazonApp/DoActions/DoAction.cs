using System;
using OpenQA.Selenium;


namespace AmazonApp.DoActions
{
    public class DoAction : BaseClass.BaseClass
    {
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
            try
            {
                log.Info("Login is clicked");
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }


            //For search for products
            login.search.SendKeys(ExcelOperation.ReadData(1, "search"));
            System.Threading.Thread.Sleep(2000);
            login.search.SendKeys(Keys.ArrowDown);
            login.search.SendKeys(Keys.Enter);
            ScreenShot();
            System.Threading.Thread.Sleep(1000);
            try
            {
                log.Info("product searched");
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





    
