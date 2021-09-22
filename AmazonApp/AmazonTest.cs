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
        [Test,Order(1)]
        public static void ValidateTitle()
        {
            test = report.CreateTest("Tests");
            test.Log(Status.Info, "Amazon Automation");
            DoActions.LoginDoAction.AssertAfterLaunch(driver);
            test.Log(Status.Pass, "Title Validation TestCases Passed");
            report.Flush();
        }
        [Test, Order(2)]
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
        [Test, Order(3)]
        public static void TestMethodForSearchInToAmazon()
        {
            test = report.CreateTest("Tests");
            test.Log(Status.Info, "Amazon Automation");
            DoActions.SearchDoAction.SearchOperation();
            test.Log(Status.Pass, "Search TestCases Passed");
            Pages.ProductPage.ProductList();
            test.Log(Status.Pass, "Product list TestCases Passed");
            //Pages.ProductPage.ProductRatings();
            //test.Log(Status.Pass, "rating list TestCases Passed");
            Pages.ProductPage.PriceList();
            test.Log(Status.Pass, "price list TestCases Passed");
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

        


    
