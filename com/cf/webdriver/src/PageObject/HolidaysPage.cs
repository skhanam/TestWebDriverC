using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestWebDriver.com.cf.webdriver.src.ModuleObject;
using TestWebDriver.com.cf.webdriver.src.Common;
using TestWebDriver.com.cf.webdriver.src.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;

namespace TestWebDriver.com.cf.webdriver.src.PageObject
{
    public class HolidaysPage : BaseModule
    {

        public void nofollow(Drivercontext context) 
        {

                var getNofollow = Utility.FindElement(context,By.Name("robots"),Utility.TIME_OUT);
                string getAttrib = getNofollow.GetAttribute("content");
                System.Console.WriteLine("Here is the Attribute ... "+getAttrib);
        
        }



        public void departureModule(Drivercontext context) 
        {
                    var getto = Utility.FindElement(context, By.Id(BaseModule.ObjectLookup["holidaysdestination"]), Utility.TIME_OUT);
                    getto.SendKeys(BaseModule.DataLookup["destinationholidays"]);
                    //var optionFlex = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["flexradio"]), Utility.TIME_OUT);
                    //optionFlex.Click();
                    var departdate = Utility.FindElement(context,By.Id(BaseModule.ObjectLookup["departdate"]), Utility.TIME_OUT);
                    departdate.SendKeys(Utility.GetDate(30));
                    var departend = Utility.FindElement(context, By.Id(BaseModule.ObjectLookup["departend"]), Utility.TIME_OUT);
                    departend.SendKeys(Utility.GetDate(35));
                    var searchclick = Utility.FindElement(context, By.Id(BaseModule.ObjectLookup["searchbutn"]), Utility.TIME_OUT);
                    searchclick.Click();
        }


        public void topDestinations(Drivercontext context) 
        {
            IList<IWebElement> getAllLinks = Utility.FindElements(context, By.XPath(BaseModule.ObjectLookup["topdest"]), Utility.TIME_OUT);
            int getcounttopdestinations = getAllLinks.Count();
            System.Console.WriteLine("Count of Top Destinations : "+ getcounttopdestinations);
                   
        }


        public void template(Drivercontext context,string url) 
        {
            context.GetDriver().Navigate().GoToUrl(url);
            System.Console.WriteLine("Here is the Url : "+url);
            if (!(context.GetDriver().PageSource.Contains(BaseModule.AssertLookup["warning404"])) )
            {
                Console.WriteLine("You are on a Template page !!! ");
                Utility.TakeScreenShot(context,"holidaysTemplate");
            }
        }


        public void validatethirdpartyRedirect(Drivercontext context, string partialurl) 
        {
            string getTitle = context.GetDriver().Title;
            System.Console.WriteLine("Here is the title : " + getTitle);
            string getUrl = context.GetDriver().Url;
            System.Console.WriteLine("Here is the Url : " + getUrl);
            if (getUrl.Contains(partialurl))
            {
                System.Console.WriteLine("You are redirected to 3rd party page !!! ");
                Utility.TakeScreenShot(context, "Redirect3rdparty");
            }
            else
            {
                Assert.Fail();
            }
        }

        public void searchWhiteLabel(Drivercontext context,string partialurl) 
        {
               departureModule(context);
               validatethirdpartyRedirect(context, partialurl);
               
        }


        public void linkWhiteLabel(Drivercontext context,string partialurl) 
        {
                context.GetDriver().FindElement(By.LinkText("Spain")).Click();
                validatethirdpartyRedirect(context, partialurl);
        }

    }
}
