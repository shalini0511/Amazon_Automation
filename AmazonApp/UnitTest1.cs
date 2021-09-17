/* Project = Automating Amazon using DDT and POM
 * Created by = V SHALINI
 * created on = 16/09/21
 */
using NUnit.Framework;

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