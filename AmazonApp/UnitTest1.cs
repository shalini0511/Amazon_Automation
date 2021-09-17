using NUnit.Framework;
using OpenQA.Selenium;

namespace AmazonApp
{
    public class Tests:BaseClass.BaseClass
    {
        [Test]
        public static void TestMethodForSignInToAmazon()
        {
            DoActions.DoAction.SignInToAmazon(driver);
  
        }
        
    }
}