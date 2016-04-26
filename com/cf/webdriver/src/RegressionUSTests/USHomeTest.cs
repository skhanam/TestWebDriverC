using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using TestWebDriver.com.cf.webdriver.src.Common;
using System.Configuration;
using TestWebDriver.com.cf.webdriver.src.ModuleObject;

namespace TestWebDriver.com.cf.webdriver.src.RegressionUSTests
{
    [TestFixture]
    [Category("Regression")]
    public class USHomeTest
    {

        [SetUp]
        public void TestFixtureSetUp()
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
        public void TestSearchFixed()
        {
            Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
            try
            {

                context = Drivercontext.Create("homePagetests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                HomeModule homeModule = new HomeModule();
                homeModule.GetHomepage().SearchFixedUS(context, BaseModule.DataLookup["toDestination"], BaseModule.DataLookup["fromSource"], BaseModule.DataLookup["fromDateUS"], BaseModule.DataLookup["toDateUS"]);

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
        public void TestSearchFlex()
        {

            Drivercontext context = null;
            string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
            try
            {

                context = Drivercontext.Create("homePagetests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                HomeModule homeModule = new HomeModule();
                //This is an extra step as compared to UK site 
                Utility.GoToURLXpath(context, BaseModule.ObjectLookup["switchflex"]);
                //uptill here
                homeModule.GetHomepage().SearchFlex(context, BaseModule.DataLookup["toDestination"],
                BaseModule.DataLookup["fromSource"], BaseModule.ObjectLookup["newsletterHP"]);

            }
            finally
            {

                if (context != null) { Utility.Cleanup(context); }

            }

        }



        [Test]
        public void TestSearchByNoReturn()
        {
            Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
         
                 try
                    {
                        context = Drivercontext.Create("NoDateSearch", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                        SearchByDateModule searchByDateModule = new SearchByDateModule();
                        Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);
                        searchByDateModule.GetSearchByDatePage().NoReturnPoint(context, BaseModule.DataLookup["toDestination"], BaseModule.DataLookup["fromDateUS"], BaseModule.DataLookup["toDateUS"]);
          
                                 }finally
                            {
                                if (context != null) { Utility.Cleanup(context); }
                            } 
                
                    }



        [Test]
        public void TestSearchByNoDeparture()
        {

            Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
            try
            {
                context = Drivercontext.Create("NoDateSearch", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                SearchByDateModule searchByDateModule = new SearchByDateModule();
                Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);
                searchByDateModule.GetSearchByDatePage().NodateReturn(context, BaseModule.DataLookup["toDestination"], BaseModule.DataLookup["fromDateUS"]);
            }
            finally
            {
                if (context != null) { Utility.Cleanup(context); }
            }
        }


        [Test]
        public void TestSearchByNoReturnDate()
        {

            Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
            try
            {
                context = Drivercontext.Create("NoDateSearch", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                SearchByDateModule searchByDateModule = new SearchByDateModule();
                Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);
                searchByDateModule.GetSearchByDatePage().NodateReturn(context, BaseModule.DataLookup["toDestination"], BaseModule.DataLookup["fromDateUS"]);
            }
            finally
            {
                if (context != null) { Utility.Cleanup(context); }
            }

        }


        [Test]
        public void TestSearchByNoDepartDate()
        {
            Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
            try
            {
                context = Drivercontext.Create("NoDateSearch", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                SearchByDateModule searchByDateModule = new SearchByDateModule();
                Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);
                searchByDateModule.GetSearchByDatePage().NodateDeparture(context, BaseModule.DataLookup["toDestination"], BaseModule.DataLookup["toDateUS"]);


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
        [Ignore]
        //Selenium fix needed for this
        public void TestContinentMap()
        {
            Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
            try
            {
                context = Drivercontext.Create("HomePageTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                HomeModule homeModule = new HomeModule();
                homeModule.GetHomepage().ContinentSearch(context, BaseModule.DataLookup["toDestinationContinent"]);
            }
            finally
            {

                if (context != null) { Utility.Cleanup(context); }
            }

        }

        [Test]
        public void TestAlternateDealsPage()
        {
            Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
            try
            {
                context = Drivercontext.Create("HomePageTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                HomeModule homeModule = new HomeModule();
                Utility.GoToURLXpath(context, BaseModule.ObjectLookup["switchflex"]);
                homeModule.GetHomepage().SearchFlex(context, BaseModule.DataLookup["toDestination"],
                    BaseModule.DataLookup["sourceAlternateDeals"], BaseModule.ObjectLookup["newsletterHP"]);
                homeModule.GetHomepage().GetMetaName(context);
                homeModule.GetHomepage().ValidateWarningMessage(context);

            }
            finally
            {

                if (context != null) { Utility.Cleanup(context); }

            }


        }

        [Test]
        public void TestFollowusFacebook()
        {
            Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
            try
            {
                context = Drivercontext.Create("HomePageTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                HomeModule homeModule = new HomeModule();
                //Utility.popUp(context, BaseModule.ObjectLookup["nlsignupbtn"], BaseModule.ObjectLookup["nlsignupemailtxt"], BaseModule.DataLookup["email"],
                //BaseModule.ObjectLookup["nlsignuppostcodetxt"], BaseModule.DataLookup["postcode"], BaseModule.ObjectLookup["nlsubmitsignup"]);
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
            Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
            try
            {
                context = Drivercontext.Create("HomePageTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                HomeModule homeModule = new HomeModule();
                Utility.popUp(context, BaseModule.ObjectLookup["nlsignupbtn"], BaseModule.ObjectLookup["nlsignupemailtxt"], BaseModule.DataLookup["email"],
BaseModule.ObjectLookup["nlsignuppostcodetxt"], BaseModule.DataLookup["postcode"], BaseModule.ObjectLookup["nlsubmitsignup"]);
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

            Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
            try
            {
                context = Drivercontext.Create("HomePageTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                HomeModule homeModule = new HomeModule();
                Utility.popUp(context, BaseModule.ObjectLookup["nlsignupbtn"], BaseModule.ObjectLookup["nlsignupemailtxt"], BaseModule.DataLookup["email"],
BaseModule.ObjectLookup["nlsignuppostcodetxt"], BaseModule.DataLookup["postcode"], BaseModule.ObjectLookup["nlsubmitsignup"]);
                homeModule.GetHomepage().FollowUS(context, BaseModule.ObjectLookup["gplusUI"]);

            }
            finally
            {
                if (context != null) { Utility.Cleanup(context); }

            }
        }


        [Test]
        public void Testtabs()
        {
            Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
            try
            {

                context = Drivercontext.Create("HomePageTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                //Utility.popUp(context, BaseModule.DataLookup["email"], BaseModule.DataLookup["postcode"]);

                // As newsletter pop up is turned off the below snippet is commented
                /* Utility.popUp(context, BaseModule.ObjectLookup["nlsignupbtn"], 
                     BaseModule.ObjectLookup["nlsignupemailtxt"], BaseModule.DataLookup["email"], BaseModule.ObjectLookup["nlsignuppostcodetxt"], BaseModule.DataLookup["postcode"], BaseModule.ObjectLookup["nlsubmitsignup"]); */

                Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);
                Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["flightdeals"]);
                Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["flightshotels"]);
                Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Staff"]);
                Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["inspired"]);
                Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["travel101"]);
                Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Newsletter"]);
            }
            finally
            {

                if (context != null) { Utility.Cleanup(context); }

            }

        }


        [Test]
        public void TestAgentDetails()
        {
            Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
            try
            {
                context = Drivercontext.Create("HomeFooterTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                HomeModule homeModule = new HomeModule();
                homeModule.GetHomepage().GetAgentDetails(context, "C");


            }
            finally
            {
                if (context != null) { Utility.Cleanup(context); }

            }
        }



        [Test]
        public void TestValidateWarningMessage()
        {
            Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
            try
            {

                context = Drivercontext.Create("HomeWarningMessageTest", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                HomeModule homeModule = new HomeModule();
                homeModule.GetHomepage().FixedwithoutimputNlforUSonly(context);

            }
            finally
            {
                if (context != null) { Utility.Cleanup(context); }
            }


        }


        [Test]
        public void TestBookingGuideModuleExists()
        {
            Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
            try
            {
                context = Drivercontext.Create("HomeBEnGuideExistsTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                HomeModule homeModule = new HomeModule();
                //This is an extra step as compared to UK site 
                Utility.GoToURLXpath(context, BaseModule.ObjectLookup["switchflex"]);
                //uptill here
                homeModule.GetHomepage().SearchFlex(context, BaseModule.DataLookup["toDestination"],
                BaseModule.DataLookup["destinationAlternateDeals"], BaseModule.ObjectLookup["newsletterHP"]);
                homeModule.GetHomepage().GetMetaName(context);
                homeModule.GetHomepage().BookingEngineExists(context);

            }
            finally
            {
                if (context != null) { Utility.Cleanup(context); }
            }

        }



        [Test]
        public void TestFlagDropDown()
        {
            Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
            try
            {
                context = Drivercontext.Create("HomeFlagCountry", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                HomeModule homeModule = new HomeModule();
                homeModule.GetHomepage().FlagDropDown(context);

            }
            finally
            {

                if (context != null) { Utility.Cleanup(context); }

            }


        }




        [Test]
        public void TestValidateCountrylabelPresent()
        {

            Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
            try
            {

                context = Drivercontext.Create("HomeCountryLabelExists", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                HomeModule homeModule = new HomeModule();
                homeModule.GetHomepage().CountryText(context);

            }
            finally
            {
                if (context != null) { Utility.Cleanup(context); }
            }


        }



        [Test]
        public void TestValidateLogo()
        {
            Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
            try
            {
                context = Drivercontext.Create("HomeValidateLogo", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                HomeModule homeModule = new HomeModule();
                homeModule.GetHomepage().MainLogo(context);

            }
            finally
            {
                if (context != null) { Utility.Cleanup(context); }

            }

        }

        [Test]
        public void TestStrapLine()
        {
            Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
            try
            {
                context = Drivercontext.Create("HomeValidateStrapLine", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                HomeModule homeModule = new HomeModule();
                homeModule.GetHomepage().StrapLineValidate(context);

            }
            finally
            {
                if (context != null) { Utility.Cleanup(context); }

            }


        }

        //Selenium fix needed - This is intermittent
        [Test]
        public void TestHomeTravelTips()
        {
            Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
            try
            {
                context = Drivercontext.Create("HomeTravelTips", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                HomeModule homeModule = new HomeModule();
                Utility.GoToURL(context, "Travel tips");
                homeModule.GetHomepage().TravelTips(context);

            }
            finally
            {
                if (context != null) { Utility.Cleanup(context); }

            }


        }

        [Test]
        [Ignore]
        //Selenium fix needed for this
        public void TestHomeDepartureSpilt()
        {
            Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
            try
            {
                context = Drivercontext.Create("HomeDepartureSpiltPage", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                HomeModule homeModule = new HomeModule();
                homeModule.GetHomepage().DepartureSpilt(context);

            }
            finally
            {
                if (context != null) { Utility.Cleanup(context); }

            }

        }


        [Test]
        public void TestWorldMap()
        {
            Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
            try
            {
                context = Drivercontext.Create("HomeWorldMap", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                HomeModule homeModule = new HomeModule();
                homeModule.GetHomepage().DestinationSpiltMap(context);

            }
            finally
            {
                if (context != null) { Utility.Cleanup(context); }

            }

        }


        //This Test is not there for Canada as it is changed
        //[Test]
        //[Ignore]
        //Selenium fix needed for this
        public void TestEditorsPick()
        {
            Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];

            try
            {
                context = Drivercontext.Create("HomeEditorsPick", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                HomeModule homeModule = new HomeModule();
                homeModule.GetHomepage().EditorsPick(context);
            }
            finally
            {
                if (context != null) { Utility.Cleanup(context); }

            }

        }
    }
}
