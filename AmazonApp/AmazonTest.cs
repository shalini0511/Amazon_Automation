/* Project = Automating Amazon using DDT and POM
 * Created by = V SHALINI
 * created on = 16/09/21
 */
using AventStack.ExtentReports;
using NUnit.Framework;

namespace AmazonApp
{
    public class Tests : BaseClass.BaseClass
    {
        public static ExtentReports report = BasicReport.report();
        public static ExtentTest test;
        [Test, Order(1)]
        public static void TestMethodForSignInToAmazon()
        {
            test = report.CreateTest("Tests");
            test.Log(Status.Info, "Amazon Automation");
            DoActions.LoginDoAction.SignInToAmazon(driver);
            System.Threading.Thread.Sleep(1000);
            Takescreenshot();
            test.Info("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\HP\source\repos\AmazonApp\AmazonApp\Screenshot\test2.jpg").Build());
            test.Log(Status.Pass, "TestCases Passed");
            report.Flush();

        }
        [Test, Order(2)]
        public static void TestMethodForSearchInToAmazon()
        {
            test = report.CreateTest("Tests");
            test.Log(Status.Info, "Amazon Automation");
            DoActions.SearchDoAction.SearchOperation();
            test.Log(Status.Pass, "Search TestCases Passed");
            Pages.ProductPage.ProductList();
            System.Threading.Thread.Sleep(1000);
            Takescreenshot();
            test.Info("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\HP\source\repos\AmazonApp\AmazonApp\Screenshot\test3.jpg").Build());
            test.Log(Status.Pass, "Product list TestCases Passed");
            Pages.ProductPage.PriceList();
            test.Log(Status.Pass, "price list TestCases Passed");
            report.Flush();

        }
        
        [Test,Order(3)]
        public static void NegativeTest()
        {
            test = report.CreateTest("Tests");
            test.Log(Status.Info, "Amazon Automation");
            NegativeTestCase.NegativeDoAction.InvalidData(driver);
            System.Threading.Thread.Sleep(1000);
            Takescreenshot();
            test.Info("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\HP\source\repos\AmazonApp\AmazonApp\Screenshot\test4.jpg").Build());
            test.Log(Status.Pass, "Invalid Data TestCases Passed");
            report.Flush();
        }
        [Test,Order(4)]
        public static void TestMethodForGMail()
        {
            MailPage.MailLoginPage.ReadDataFromExcel();
            MailPage.MailLoginPage.email_send();

        }
    }
}

        


    
