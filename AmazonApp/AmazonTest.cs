/* Project = Automating Amazon using DDT and POM
 * Created by = V SHALINI
 * created on = 16/09/21
 */
using AventStack.ExtentReports;
using NUnit.Framework;

namespace AmazonApp
{
    //[TestFixture("chrome")]
    //[TestFixture("firefox")]
   // [Parallelizable]
    //[Parallelizable(ParallelScope.Fixtures)]
    public class Tests : BaseClass.BaseClass
    {
        //public Tests(string browser) : base(browser) { }
        public static ExtentReports report = BasicReport.report();
        public static ExtentTest test;
        [Test, Order(1)]
        [Category("Positive TestCases")]
        public static void TestMethodForSignInToAmazon()
        {
            test = report.CreateTest("Tests");
            test.Log(Status.Info, "Amazon Automation");
            DoActions.DoAction.SignInToAmazon();
            System.Threading.Thread.Sleep(4000);
            Takescreenshot();
            test.Info("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\HP\source\repos\AmazonApp\AmazonApp\Screenshot\test.jpg").Build());
            test.Log(Status.Pass, "TestCases Passed");
            report.Flush();

        }
        [Test, Order(2)]
        public static void TestMethodForSearchInToAmazon()
        {
            test = report.CreateTest("Tests");
            test.Log(Status.Info, "Amazon Automation");
            DoActions.DoAction.SearchOperation();
            test.Log(Status.Pass, "Search TestCases Passed");
            Pages.ProductPage.ProductList();
            System.Threading.Thread.Sleep(4000);
            Takescreenshot();
            test.Info("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\HP\source\repos\AmazonApp\AmazonApp\Screenshot\test1.jpg").Build());
            test.Log(Status.Pass, "Product list TestCases Passed");
            Pages.ProductPage.PriceList();
            test.Log(Status.Pass, "price list TestCases Passed");
            report.Flush();

        }
        [Test, Order(3)]
         public static void TestAddToCart()
         {
            test = report.CreateTest("Tests");
            test.Log(Status.Info, "Amazon Automation");
            DoActions.DoAction.SelectItem();
            System.Threading.Thread.Sleep(4000);
            Takescreenshot();
            test.Info("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\HP\source\repos\AmazonApp\AmazonApp\Screenshot\test2.jpg").Build());
            test.Log(Status.Pass, "AddToCart TestCases Passed");
            report.Flush();
        }
         [Test,Order(4)]
         public static void TestProceedToBuy()
         {
            test = report.CreateTest("Tests");
            test.Log(Status.Info, "Amazon Automation");
            DoActions.DoAction.Buy();
            System.Threading.Thread.Sleep(4000);
            Takescreenshot();
            test.Info("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\HP\source\repos\AmazonApp\AmazonApp\Screenshot\test3.jpg").Build());
            test.Log(Status.Pass, "Proceed To Buy TestCases Passed");
            report.Flush();
        }
         [Test, Order(5)]
         public static void TestAddress()
         {
            test = report.CreateTest("Tests");
            test.Log(Status.Info, "Amazon Automation");
            DoActions.DoAction.AddressButton();
            System.Threading.Thread.Sleep(4000);
            Takescreenshot();
            test.Info("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\HP\source\repos\AmazonApp\AmazonApp\Screenshot\test4.jpg").Build());
            test.Log(Status.Pass, "Address TestCases Passed");
            report.Flush();
        }
        [Test, Order(6)]
       public static void TestPayment()
        {
            test = report.CreateTest("Tests");
            test.Log(Status.Info, "Amazon Automation");
            DoActions.DoAction.PaymentRadioButton();
            System.Threading.Thread.Sleep(4000);
            Takescreenshot();
            test.Info("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\HP\source\repos\AmazonApp\AmazonApp\Screenshot\test5.jpg").Build());
            test.Log(Status.Pass, "Payment TestCases Passed");
            report.Flush();
        }
       [Test, Order(7)]
        public static void TestLogout()
        {
            test = report.CreateTest("Tests");
            test.Log(Status.Info, "Amazon Automation");
            DoActions.DoAction.Logout();
            System.Threading.Thread.Sleep(4000);
            Takescreenshot();
            test.Info("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\HP\source\repos\AmazonApp\AmazonApp\Screenshot\test6.jpg").Build());
            test.Log(Status.Pass, "Logout TestCases Passed");
            report.Flush();
        }

         [Test,Order(8)]
          public static void NegativeTest()
          {
              test = report.CreateTest("Tests");
              test.Log(Status.Info, "Amazon Automation");
              NegativeTestCase.NegativeDoAction.InvalidData();
              System.Threading.Thread.Sleep(4000);
              Takescreenshot();
              test.Info("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\HP\source\repos\AmazonApp\AmazonApp\Screenshot\test7.jpg").Build());
              test.Log(Status.Pass, "Invalid Data TestCases Passed");
              report.Flush();
          }


          [Test,Order(9)]
          public static void TestMethodForGMail()
          {
              MailPage.MailLoginPage.ReadDataFromExcel();
              MailPage.MailLoginPage.email_send();

          }
      
    }
    
}

        


    
