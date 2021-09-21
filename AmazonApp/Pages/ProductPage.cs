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
        public static void ProductRatings()
        {
            IList<IWebElement> ratings = driver.FindElements(By.ClassName("a-icon-alt"));

            foreach (IWebElement rate in ratings)
            {
                var rating = rate.Text;
                Console.WriteLine(rating);

            }

            /*Product ratings
            String stars = driver.FindElement(By.XPath("//body/div[@id='a-page']/div[@id='search']/div[1]/div[1]/div[1]/span[3]/div[2]/div[3]/div[1]/span[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[3]/div[1]/span[1]/span[1]/a[1]/i[1]/span[1]")).Text;
            Console.WriteLine(stars);*/
        }
        public static void PriceList()
        {
            //Product items
            Console.WriteLine("-----------------------------PRICE LIST------------------------------");
            IList<IWebElement> price = driver.FindElements(By.XPath("//span[@class='a-price-whole']"));
            foreach (IWebElement amount in price)
            {
                string totalamt = amount.Text;
                Console.WriteLine(totalamt);

            }
        }
    }
}
