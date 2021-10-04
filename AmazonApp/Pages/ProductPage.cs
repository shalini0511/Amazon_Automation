/* Project = Automating Amazon using DDT and POM
 * Created by = V SHALINI
 * created on = 21/09/21
 */
using System;
using System.Collections.Generic;
using OpenQA.Selenium;

namespace AmazonApp.Pages
{
    public class ProductPage:BaseClass.BaseClass
    {
        
        public static void ProductList()
        {
            //Product items
            Console.WriteLine("-----------------------------BRAND NAMES------------------------------");
            IList<IWebElement> brandname = driver.FindElements(By.XPath("//*[@class='a-size-base-plus a-color-base']"));
           
            foreach (IWebElement brand in brandname)
            {
                string brandNames = brand.Text;
                Console.WriteLine(brandNames);         
                   
            }
            
        }
        
        public static void PriceList()
        {
            //Product Price List
            Console.WriteLine("-----------------------------PRICE LIST------------------------------");
            IList<IWebElement> price = driver.FindElements(By.XPath("//span[@class='a-price-whole']"));
            foreach (IWebElement amount in price)
            {
                string totalamt = amount.Text;
                Console.WriteLine(totalamt);

            }
        }
        public static void ProductRatings()
        {
            IList<string> productRating = new List<string>();
            foreach (var r in driver.FindElements(By.XPath("//*[@class='a-popover-trigger a-declarative']")))
            {
                r.Click();
                System.Threading.Thread.Sleep(8000);
                foreach (var rating in driver.FindElements(By.CssSelector("span[class='a-size-medium a-color-base a-text-beside-button a-text-bold']")))
                {
                    if (!string.IsNullOrEmpty(rating.Text))
                    {
                        productRating.Add(rating.Text);
                        Console.WriteLine("Product Rating {0}", rating.Text);
                    }
                    else
                    {
                        productRating.Remove(rating.Text);
                    }
                }
            }
        }
    }
}
