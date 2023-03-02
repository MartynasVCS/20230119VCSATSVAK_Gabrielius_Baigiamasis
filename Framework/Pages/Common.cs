﻿using OpenQA.Selenium;

namespace Framework.Pages
{
    public class Common
    {
        private static IWebElement GetElement (string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        internal static void ClickElement(string locator)
        {
            GetElement (locator).Click();
        }

        internal static void SendKeys(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);
        }
    }
}
