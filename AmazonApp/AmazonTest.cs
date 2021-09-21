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
            test.Log(Status.Info, "Facebook Automation");
            DoActions.LoginDoAction.AssertAfterLaunch(driver);
            test.Log(Status.Pass, "Title Validation TestCases Passed");
            report.Flush();
        }
        [Test, Order(2)]
        public static void TestMethodForSignInToAmazon()
        {
            test = report.CreateTest("Tests");
            test.Log(Status.Info, "Facebook Automation");
            DoActions.LoginDoAction.SignInToAmazon(driver);
            test.Log(Status.Pass, "TestCases Passed");
            report.Flush();

        }
        /*[Test, Order(3)]
        public static void ValidateSearchTitle()
        {
            test = report.CreateTest("Tests");
            test.Log(Status.Info, "Facebook Automation");
            DoActions.SearchDoAction.AssertForSearch(driver);
            test.Log(Status.Pass, "Search Validation TestCases Passed");
            report.Flush();
        }*/

        [Test, Order(3)]
        public static void TestMethodForSearchInToAmazon()
        {
            test = report.CreateTest("Tests");
            test.Log(Status.Info, "Facebook Automation");
            DoActions.SearchDoAction.SearchOperation();
            test.Log(Status.Pass, "Search TestCases Passed");
            Pages.ProductPage.ProductList();
            test.Log(Status.Pass, "Product list TestCases Passed");
            Pages.ProductPage.ProductRatings();
            test.Log(Status.Pass, "Product list TestCases Passed");
            Pages.ProductPage.PriceList();
            report.Flush();

        }
    }
}

        


    
