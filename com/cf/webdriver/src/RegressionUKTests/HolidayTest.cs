using System; 
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using TestWebDriver.com.cf.webdriver.src.PageObject;
using TestWebDriver.com.cf.webdriver.src.ModuleObject;
using TestWebDriver.com.cf.webdriver.src.Common;
using OpenQA.Selenium.Support;
using System.Configuration;

namespace TestWebDriver.com.cf.webdriver.src.RegressionUKTests
{
    [TestFixture]
    [Category("Regression")]
    public class HolidayTest
    {

        [SetUp]
        public void TestSetUp()
        {
            //do nothing
        }

        [TearDown]
        public void TestTearDown()
        {
            Drivercontext context = null;
            if (context != null)
            {
                Utility.Cleanup(context);
            }
        }

        [Test]
        public void TestNoFollow()
        {
            Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
            try
            {
                context = Drivercontext.Create("NofollowAttrib", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                HolidaysModule holidaysModule = new HolidaysModule();
                Utility.SwitchMainTabs(context, "Holidays");
                holidaysModule.GetHolidaysPage().nofollow(context);
            }
            finally
            {
                if (context != null)
                {
                    Utility.Cleanup(context);
                }

            }

        }

        [Test]
        public void TestDepartModule()
        {
            Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
            try
            {
                context = Drivercontext.Create("GetAllModules", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                HolidaysModule holidaysModule = new HolidaysModule();
                Utility.SwitchMainTabs(context, "Holidays");
                holidaysModule.GetHolidaysPage().departureModule(context);
            }
            finally
            {
                if (context != null)
                {
                    Utility.Cleanup(context);

                }

            }

        }

        [Test]
        public void Testtemplate()
        {
            Drivercontext context = null; 
            string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
            try
            {
                context = Drivercontext.Create("GetAllModules", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                HolidaysModule holidaysModule = new HolidaysModule();
                string url = WebSiteUrlFromConfig+"holidays.aspx/template";
                holidaysModule.GetHolidaysPage().template(context,url);
            }
            finally
            {
                if (context != null)
                {
                    Utility.Cleanup(context);

                }

            }
        }


        [Test]
        public void TestWhiteLabel() 
        {
            Drivercontext context = null;
            string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
            try
            {
                context = Drivercontext.Create("GetAllModules", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                HolidaysModule holidaysModule = new HolidaysModule();
                Utility.SwitchMainTabs(context, "Holidays");
                holidaysModule.GetHolidaysPage().searchWhiteLabel(context, BaseModule.AssertLookup["partialUrl"]);
            }
            finally
            {
                if (context != null)
                {
                    Utility.Cleanup(context);

                }

            }
        
        }


        [Test]
        public void TestLinkWhiteLabel() 
        {
                    Drivercontext context = null;
                    string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                    try
                    {
                        context = Drivercontext.Create("GetAllModules", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                        HolidaysModule holidaysModule = new HolidaysModule();
                        Utility.SwitchMainTabs(context, "Holidays");
                        holidaysModule.GetHolidaysPage().linkWhiteLabel(context, BaseModule.AssertLookup["partialUrl"]);
                    }
                    finally
                    {
                        if (context != null)
                        {
                            Utility.Cleanup(context);

                        }

                    }
        }



    }
}
