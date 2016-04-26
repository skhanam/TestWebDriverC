using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using TestWebDriver.com.cf.webdriver.src.Common;
using System.Configuration;
using TestWebDriver.com.cf.webdriver.src.ModuleObject;

namespace TestWebDriver.com.cf.webdriver.src.RegressionUSTests
{
    [TestFixture]
    [Category("Regression")]
    public class USNewsLetterTest
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
        public void TestFollowusFacebook()
        {
            Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
            try
            {
                context = Drivercontext.Create("HomePageTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                HomeModule homeModule = new HomeModule();
                Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Newsletter"]);
                homeModule.GetHomepage().FollowUS(context, BaseModule.ObjectLookup["faceBookUI"]);
            }
            finally
            {
                if (context != null) { Utility.Cleanup(context); }

            }
        }



        [Test]
        public void TestFollowusTwitter()
        {
            Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
            try
            {
                context = Drivercontext.Create("HomePageTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                HomeModule homeModule = new HomeModule();
                Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Newsletter"]);
                homeModule.GetHomepage().FollowUS(context, BaseModule.ObjectLookup["twitterUI"]);

            }
            finally
            {
                if (context != null) { Utility.Cleanup(context); }

            }
        }

        [Test]
        public void TestFollowusGPlus()
        {

            Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
            try
            {
                context = Drivercontext.Create("HomePageTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                HomeModule homeModule = new HomeModule();
                Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Newsletter"]);
                homeModule.GetHomepage().FollowUS(context, BaseModule.ObjectLookup["gplusUI"]);

            }
            finally
            {
                if (context != null) { Utility.Cleanup(context); }

            }
        }


        
        
        [Test]
        public void TestSignup()
        {
            Drivercontext context = null;
            string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
            try
            {
                context = Drivercontext.Create("HomePageTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Newsletter"]);
                NewsLetterModule newsletterModule = new NewsLetterModule();
                newsletterModule.GetNewsLetterPage().nlsignup(context);
            }
            finally
            {
                if (context != null) { Utility.Cleanup(context); }

            }

        }
    }
}
