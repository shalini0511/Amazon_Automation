/* Project = Automating Amazon using DDT and POM
 * Created by = V SHALINI
 * created on = 16/09/21
 */
using AventStack.ExtentReports;
using NUnit.Framework;

namespace AmazonApp
{
    public class Tests:BaseClass.BaseClass
    {
        public static ExtentReports report = BasicReport.report();
        public static ExtentTest test;
        [Test]
        public static void TestMethodForSignInToAmazon()
        {
            test = report.CreateTest("Tests");
            test.Log(Status.Info, "Facebook Automation");
            DoActions.DoAction.SignInToAmazon(driver);
            test.Log(Status.Pass, "TestCases Passed");
            report.Flush();

        }
        
    }
}