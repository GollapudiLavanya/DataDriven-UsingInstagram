/*
 * project = DataDrivenFrameworkUsingInstagram
 * Author = Lavanya Gollapudi
 * Created Date = 15/09/2021
 */

using System;
using System.Diagnostics;
using DataDriven_Instagram.page;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DataDriven_Instagram
{

    public class Tests : Base.BaseClass
    {
        [Test]
        public static void ReadingDataFromExcelTestMethodAndLoginToFb()
        {
            Actions.ActionsDone.AssertAfterLauching(driver);
            ExcelOperations.PopulateInCollection(@"C:\Users\lavanya.g\source\repos\DataDriven_Instagram\DataDriven_Instagram\Resources\InstagramCredentials.xlsx");

            Login_page login = new Login_page(driver);
            login.email.SendKeys(ExcelOperations.ReadData(1, "Username"));
            System.Threading.Thread.Sleep(2000);


            login.password.SendKeys(ExcelOperations.ReadData(1, "Password"));
            System.Threading.Thread.Sleep(2000);


            login.loginButton.Click();
            System.Threading.Thread.Sleep(15000);


        }
    }
}
