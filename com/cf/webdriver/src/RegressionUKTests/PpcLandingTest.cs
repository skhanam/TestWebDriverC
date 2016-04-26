using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using TestWebDriver.com.cf.webdriver.src.Common;
using TestWebDriver.com.cf.webdriver.src.ModuleObject;
using TestWebDriver.com.cf.webdriver.src.PageObject;
using System.Configuration;


namespace TestWebDriver.com.cf.webdriver.src.RegressionUKTests
{
    [TestFixture]
    [Category("Regression")]
    public class PpcLandingTest
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
        public void TestMainPage()
        {

            Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                 try
                 {

                     context = Drivercontext.Create("searchByDatePagetests", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                     GooglePPCModule googlePPCModule = new GooglePPCModule();
                     googlePPCModule.getGooglePPCPage().GetSearchHeaderPPC(context);
                     
                 }finally{
                    if (context != null){Utility.Cleanup(context);}
                 }
        }
    }
}
