using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestWebDriver.com.cf.webdriver.src.Common;
using TestWebDriver.com.cf.webdriver.src.ModuleObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace TestWebDriver.com.cf.webdriver.src.PageObject
{
    public class GooglePPCPage : BaseModule
    {
        public static string googleLandingPage = "http://uk-t7-web-st.qa.cheapflights.net/cheapflights/";

                    public void GetSearchHeaderPPC(Drivercontext context) 
                    {

                            
                            context.GetDriver().Navigate().GoToUrl(googleLandingPage);
                             
                            var getHeaderBE = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["getSearchHeader"]),10);
                            string getHeaderBEtext = getHeaderBE.Text;
                            Console.WriteLine("Medium Design BE Engine Exists !!!"+getHeaderBEtext);
                            if (getHeaderBEtext.Equals(BaseModule.AssertLookup["assertheaderPPC"])) 
                            {

                                    Utility.TakeScreenShot(context,"BEMediumExists");
                    
                            }
               
                    }




                    public void HandpickedDeals(Drivercontext context) 
                    {
                            context.GetDriver().Navigate().GoToUrl(googleLandingPage);
                            var gethpdHeader = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["gethpdHeader"]),10);
                            string gethpdHeaderText = gethpdHeader.Text;
                            Console.WriteLine("Hand Pick Deals Found !!!! "+gethpdHeaderText);
                            if(gethpdHeaderText.Equals(BaseModule.AssertLookup[""]))
                            {
                                Utility.TakeScreenShot(context,"HandPickedDealsExists");

                            }
                    }



    }
}
