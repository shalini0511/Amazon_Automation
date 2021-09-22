using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AmazonApp.MailPage
{
    public class MailLoginPage
    {
        public static GMExcelOperation excel;
        //Here we are reading the data from excel
        public static void ReadDataFromExcel()
        {
            excel = new GMExcelOperation();
            excel.PopulateFromExcel(@"C:\Users\HP\source\repos\AmazonApp\AmazonApp\GMData.xlsx");
        }



        public static void email_send()
        {
            excel = new GMExcelOperation();
            MailMessage mail = new MailMessage();
            System.Threading.Thread.Sleep(300);
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            //we are sending our from mail id
            System.Threading.Thread.Sleep(300);
            mail.From = new MailAddress(excel.ReadData(1, "FromMail"));
            //we are adding to mail id
            System.Threading.Thread.Sleep(300);
            mail.To.Add(excel.ReadData(1, "ToMail"));
            System.Threading.Thread.Sleep(300);
            //Subject of the mail is added
            mail.Subject = "Amazon test mail";
            //Body of the mail is added
            mail.Body = "mail with amazon report attachmement";
            Attachment attachment;
            attachment = new Attachment(@"C:\Users\HP\source\repos\AmazonApp\AmazonApp\Reports\index.html");
            Assert.NotNull(attachment);
            //here we attach the report of the automation
            mail.Attachments.Add(attachment);
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new NetworkCredential(excel.ReadData(1, "FromMail"), excel.ReadData(1, "Password"));
            SmtpServer.EnableSsl = true;
            //Here we click send mail 
            System.Threading.Thread.Sleep(300);
            SmtpServer.Send(mail);
        }
    }

}

