/* Project = Automating Amazon using DDT and POM
 * Created by = V SHALINI
 * created on = 16/09/21
 */
using System;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;

namespace AmazonApp.DoActions
{
    public class DoAction : BaseClass.BaseClass
    {
        public static void SignInToAmazon()
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
                System.Threading.Thread.Sleep(12000);

                try
                {
                    log.Info("Password entered");
                }
                catch (Exception ex)
                {
                    log.Error(ex.Message);
                }


                //For og in button
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
            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchElementException, "Webdriver unable to locate element");
            }
        }
        public static void SearchOperation()
        {
            try
            {
                //search product
                DoAction.SignInToAmazon();
                Pages.SearchPage search = new Pages.SearchPage(driver);
                search.search.SendKeys(ExcelOperation.ReadData(1, "search"));
                System.Threading.Thread.Sleep(2000);
                //Validation search query
                Assert.True(search.search.Displayed);
                System.Threading.Thread.Sleep(4000);
                try
                {
                    log.Info("product searched");
                }
                catch (Exception ex)
                {
                    log.Error(ex.Message);
                }
                //click on search icon
                search.searchIcon.Click();
                System.Threading.Thread.Sleep(8000);

            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchElementException, "Webdriver unable to locate element");
            }

        }
        public static void SelectItem()
        {
            try
            {
                DoAction.SearchOperation();
                Pages.AddToCart item = new Pages.AddToCart(driver);
                item.product.Click();
                //click the desired product
                driver.SwitchTo().Window(driver.WindowHandles[1]);
                log.Info("Product found");
                System.Threading.Thread.Sleep(10000);
                //click add to cart btton to added items into cart
                item.addtocartbtn.Click();
                log.Info("Add to cart is clicked");
                log.Info("Added to cart Sucessfully");
                System.Threading.Thread.Sleep(8000);
                item.cart.Click();
                log.Info("cart button clicked");
                System.Threading.Thread.Sleep(4000);
            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchElementException, "Webdriver unable to locate element");
            }
        }

        public static void Buy()
        {
            try
            {
                DoAction.SelectItem();
                Pages.ProceedToBuy buy = new Pages.ProceedToBuy(driver);
                //Validating product is added to cart
                Assert.AreEqual(driver.Title, "Amazon.in Shopping Cart");
                buy.buy.Click();
                log.Info("proceed to buy is clicked");
                System.Threading.Thread.Sleep(4000);
            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchElementException, "Webdriver unable to locate element");
            }




        }

        public static void AddressButton()
        {
            try
            {
                DoAction.Buy();
                Pages.Address addr = new Pages.Address(driver);
                //Validation Address Title
                Assert.AreEqual(driver.Title, "Select a delivery address");
                addr.address.Click();
                log.Info("Address button is clicked");
                //Assert.AreEqual(driver.Title, "Select a delivery address");
                System.Threading.Thread.Sleep(4000);
            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchElementException, "Webdriver unable to locate element");
            }


        }

        public static void PaymentRadioButton()
        {
            try
            {
                DoAction.AddressButton();
                Pages.Payment pay = new Pages.Payment(driver);
                //Validating Payment title
                Assert.AreEqual(driver.Title, "Select a Payment Method - Amazon.in Checkout");
                pay.payment.Click();
                log.Info("Payment button is clicked");
                //Assert.AreEqual(driver.Title, "Select a Payment Method - Amazon.in Checkout");
                System.Threading.Thread.Sleep(4000);
            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchElementException, "Webdriver unable to locate element");
            }


        }
        public static void Logout()
        {
            try
            {


                DoAction.SignInToAmazon();
                System.Threading.Thread.Sleep(2000);
                Pages.LogoutPage logout = new Pages.LogoutPage(driver);
                Actions action = new Actions(driver);
                action.MoveToElement(logout.signIn).Perform();
                logout.signOut.Click();
                logout.email.SendKeys(ExcelOperation.ReadData(1, "email"));
                System.Threading.Thread.Sleep(1000);
                logout.click_Continue.Click();
                Takescreenshot();
                Assert.AreEqual(driver.Url, "https://www.amazon.in/ap/signin");

                try
                {
                    log.Info("email entered");
                }
                catch (Exception ex)
                {
                    log.Error(ex.Message);
                }
            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchElementException, "Webdriver unable to locate element");
            }



        }

    }
}






    

