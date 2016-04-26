using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using TestWebDriver.com.cf.webdriver.src.Common;
using System.Configuration;
using TestWebDriver.com.cf.webdriver.src.ModuleObject;


namespace TestWebDriver.com.cf.webdriver.src.RegressionUKTests
{
    [TestFixture]
    [Category("Regression")]
    public class DestinationSpiltTest
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

        /* This test holds good for testing destinationforCountry too*/
        
        [Test]
        public void TestDestinationSpiltNavigation()
        {
            Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
            try
            {
                context = Drivercontext.Create("NavigateDestinationSpilt", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                DestinationSpiltModule destinationSpiltModule = new DestinationSpiltModule();
                destinationSpiltModule.GetDestinationSpiltPage().navigate(context, BaseModule.DataLookup["toDestinationCountry"]);
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
        public void TestContinentDestination() 
        {

                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                try
                {
                    context = Drivercontext.Create("NavigateDestinationSpilt", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                    DestinationSpiltModule destinationSpiltModule = new DestinationSpiltModule();
                    destinationSpiltModule.GetDestinationSpiltPage().navigate(context, BaseModule.DataLookup["toDestinationContinent"]);
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
        public void TestStateDestination() 
        {

                    Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                    try
                    {
                        context = Drivercontext.Create("NavigateDestinationSpilt", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                        DestinationSpiltModule destinationSpiltModule = new DestinationSpiltModule();
                        destinationSpiltModule.GetDestinationSpiltPage().navigate(context, BaseModule.DataLookup["toDestinationState"]);
                        
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
