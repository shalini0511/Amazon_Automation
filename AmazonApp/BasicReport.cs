using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;

namespace AmazonApp
{
    [TestFixture]
    public class BasicReport
    {
        public static ExtentHtmlReporter htmlReporter;
        public static ExtentReports extent;
        public static ExtentTest test;
        
        public static ExtentReports report()
        {
            if (extent == null)
            {
                string reportPath = @"C:\Users\HP\source\repos\AmazonApp\AmazonApp\Reports\Amazon.html";
                htmlReporter = new ExtentHtmlReporter(reportPath);
                extent = new ExtentReports();
                extent.AttachReporter(htmlReporter);
                extent.AddSystemInfo("OS", "Windows");
                extent.AddSystemInfo("UserName", "shalini");
                extent.AddSystemInfo("ProviderName", "shalini");
                extent.AddSystemInfo("Domain", "QA");
                extent.AddSystemInfo("ProjectName", "Amazon Automation");

                string conifgPath = @"C:\Users\HP\source\repos\AmazonApp\AmazonApp\extent-config.xml";
                htmlReporter.LoadConfig(conifgPath);
                
            }
            return extent;

        }
    }
}
