using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestWebDriver.com.cf.webdriver.src.Common;
using TestWebDriver.com.cf.webdriver.src.ModuleObject;
using OpenQA.Selenium;
using NUnit.Framework;

namespace TestWebDriver.com.cf.webdriver.src.PageObject
{
    public class NewsLetterPage : BaseModule
    {

        public void nlsignup(Drivercontext context) 
        {
            var emailUI = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["nlemail"]), Utility.TIME_OUT);
            emailUI.SendKeys(BaseModule.DataLookup["email"]);
            var postcodeUI = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["nlpostcode"]), Utility.TIME_OUT);
            postcodeUI.SendKeys(BaseModule.DataLookup["postcode"]);
            var personaliseUI = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["Imenlpersonalise"]), Utility.TIME_OUT);
            personaliseUI.Click();
            var selectAll = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["nloptions"]), Utility.TIME_OUT);
            selectAll.Click();
            var done = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["IMenldone"]), Utility.TIME_OUT);
            done.Click();
            var signup = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["nlsignupbutton"]), Utility.TIME_OUT);
            signup.Click();
            var getHeaderConfirm = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["IMeconfirmHeader"]),Utility.TIME_OUT);
            string getHeaderText = getHeaderConfirm.Text;
            if (getHeaderText.Equals(BaseModule.AssertLookup["signupcreated"]))
            {
                Utility.GoToURL(context, "Go to home page");

            }
            else {
                Assert.Fail();
            }

        }


        public void unsubscribe(Drivercontext context) 
        {
            Utility.GoToURL(context, "unsubsribe");
        
        }

    }
}
