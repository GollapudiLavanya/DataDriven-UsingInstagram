/*
 * project = DataDrivenFrameworkUsingInstagram
 * Author = Lavanya Gollapudi
 * Created Date = 15/09/2021
 */

using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataDriven_Instagram.Actions
{
    public class ActionsDone
    {

        public static void AssertAfterLauching(IWebDriver driver)
        {
            string title1 = "Instagram";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }
    }
}
