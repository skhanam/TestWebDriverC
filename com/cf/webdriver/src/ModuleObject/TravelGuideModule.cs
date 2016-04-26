using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestWebDriver.com.cf.webdriver.src.ModuleObject;
using TestWebDriver.com.cf.webdriver.src.Common;
using TestWebDriver.com.cf.webdriver.src.PageObject;
using OpenQA.Selenium;
using NUnit.Framework;

namespace TestWebDriver.com.cf.webdriver.src.ModuleObject
{
    public class TravelGuideModule
    {
        public TravelGuidePage getTravelguidepage()
        {

            return new TravelGuidePage();
        }

            
    }
}
