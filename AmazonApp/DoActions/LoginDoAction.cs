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
        public static void SignInToAmazon(IWebDriver driver)
        {
            try
            {
                //Path for read data from Excel sheet
                ExcelOperation.PopulateInCollection(@"C:\Users\HP\source\repos\AmazonApp\AmazonApp\User_Data.xlsx");
                LoginPage.LoginPage login = new LoginPage.LoginPage(driver);

                //Validating Title
                Assert.AreEqual(driver.Title, "Online Shopping site in India: Shop Online for Mobiles, Books, Watches, Shoes and More - Amazon.in");
                Console.WriteLine("Title Validated");
                //For Sign In
                login.signIn.Click();
                System.Threading.Thread.Sleep(1000);
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
                //Validating SignIn Url
                Assert.AreEqual(driver.Url, "https://www.amazon.in/?ref_=nav_ya_signin&");
                Console.WriteLine("Log in validated");
                try
                {
                    log.Info("Login is clicked");
                }
                catch (Exception ex)
                {
                    log.Error(ex.Message);
                }
            }
            catch(NoSuchElementException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
    }
}





    

