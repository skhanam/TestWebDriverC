using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using TestWebDriver.com.cf.webdriver.src.PageObject;
using TestWebDriver.com.cf.webdriver.src.ModuleObject;
using TestWebDriver.com.cf.webdriver.src.Common;
using System.Configuration;



namespace TestWebDriver.com.cf.webdriver.src.RegressionUKTests
{
    [TestFixture]
    [Category("Sanity")]
    class FooterTest
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

        public void TestFooter()
        {
            Drivercontext context = null;
            try
            {
                string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                string[] footerText = new string[] { "Popular cities", "Popular countries", "Departure Gate" };

                BaseModule basemodule = new BaseModule();
                context = Drivercontext.Create("Footer", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                FooterModule footermodule = new FooterModule();
                FooterPage pageToTest = footermodule.GetFooterPage();

                bool allTestsPassed = true;
                for (int i = 0; i < footerText.Length; i++)
                {
                    if (pageToTest.FooterTextCheck(context, footerText[i]) == false)
                    {
                        allTestsPassed = false;
                    }
                }

                if (allTestsPassed == false)
                {
                    Assert.Fail();
                }
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