using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonApp.DoActions
{
    public class CartDoAction:BaseClass.BaseClass
    {
        public static void SelectItem()
        {
            SearchDoAction.SearchOperation();
            Pages.AddToCart item = new Pages.AddToCart(driver);
            //Select dress
            item.dress.Click();
            System.Threading.Thread.Sleep(20000);

            try
            {
                log.Info("item Selected");
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }
            item.box.Click();
            item.buyNow.Click();
        }
    }
}
