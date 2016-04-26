using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestWebDriver.com.cf.webdriver.src.ModuleObject;
using TestWebDriver.com.cf.webdriver.src.Common;
using OpenQA.Selenium;
using NUnit.Framework;

namespace TestWebDriver.com.cf.webdriver.src.PageObject
{
    public class FooterPage : BaseModule
    {
        public bool FooterTextCheck(Drivercontext context, string validateText)
        {

            string someText = validateText;
            if (context.GetDriver().PageSource.Contains(someText))
            {
                System.Console.WriteLine("text assertion successful: " + someText + " was found in the page");
                return true;
            }
            else
            {
                Utility.TakeScreenShot(context, "FooterError");
                System.Console.WriteLine("text assertion unsuccessful text: " + someText + " not found in the page");
                return false;
            }
        }
    }
}

