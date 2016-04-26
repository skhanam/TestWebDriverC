using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using TestWebDriver.com.cf.webdriver.src.Common;
using TestWebDriver.com.cf.webdriver.src.ModuleObject;
using System.Configuration;

namespace TestWebDriver.com.cf.webdriver.src.RegressionAusTests
{
    [TestFixture]
    [Category("Regression")]
    public class AusHomeTest
    {
        
                             [Test]
                            public void TestFollowusFacebook()
                            {
                                Drivercontext context = null;
                                string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Auwebsiteurl"];
                                try
                                {
                                    context = Drivercontext.Create("HomePageTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    HomeModule homeModule = new HomeModule();
                                    homeModule.GetHomepage().FollowUS(context, BaseModule.ObjectLookup["faceBookUI"]);
                                   if (context != null){Utility.Cleanup(context);}
                                }
                                catch (TimeoutException exp)
                                {
                                    Console.WriteLine(exp.ToString());

                                }
                            }

                             

                            

                            [Test]
                            public void TestFollowusTwitter()
                            {
                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Auwebsiteurl"];
                                try
                                {
                                    context = Drivercontext.Create("HomePageTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    HomeModule homeModule = new HomeModule();
                                    homeModule.GetHomepage().FollowUS(context, BaseModule.ObjectLookup["twitterUI"]);
                                   if (context != null){Utility.Cleanup(context);}
                                }
                                catch (TimeoutException exp)
                                {
                                    Console.WriteLine(exp.ToString());

                                }
                            }

                            [Test]
                            public void TestFollowusGPlus()
                            {

                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Auwebsiteurl"];
                                try
                                {
                                    context = Drivercontext.Create("HomePageTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    HomeModule homeModule = new HomeModule();
                                    homeModule.GetHomepage().FollowUS(context, BaseModule.ObjectLookup["gplusUI"]);
                                   if (context != null){Utility.Cleanup(context);}
                                }
                                catch (TimeoutException exp)
                                {
                                    Console.WriteLine(exp.ToString());

                                }
                            } 
        
                            [Test]
                            public void TestSearch()
                            {

                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Auwebsiteurl"];
                                try
                                {

                                    context = Drivercontext.Create("homePagetests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    HomeModule homeModule = new HomeModule();
                                    // homeModule.GetHomepage().SearchFlexnChangeSearch(context);
                                    //homeModule.GetHomepage().SearchFixed(context);
                                    homeModule.GetHomepage().SearchFlex(context, BaseModule.DataLookup["fromsourceAu"], BaseModule.DataLookup["toDestination"], BaseModule.ObjectLookup["newsletterHP"]);

                                }



                                finally
                                {
                                    if (context != null) { Utility.Cleanup(context); }
                                }
                            } 

                            [Test]
                            public void TestSearchFlex()
                            {

                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Auwebsiteurl"];
                                try
                                {

                                    context = Drivercontext.Create("homePagetests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    HomeModule homeModule = new HomeModule();
                                    homeModule.GetHomepage().SearchFlex(context, BaseModule.DataLookup["fromsourceAu"],
                                            BaseModule.DataLookup["toDestination"], BaseModule.ObjectLookup["newsletterHP"]);

                                }
                                finally
                                {
                                    if (context != null) { Utility.Cleanup(context); }

                                }

                            }


                            [Test]
                            public void TestSearchByNoReturn()
                            {

                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Auwebsiteurl"];
                                try
                                {

                                    context = Drivercontext.Create("homePagetests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    HomeModule homeModule = new HomeModule();
                                    homeModule.GetHomepage().MissingFixedSearchCriteria(context, BaseModule.ObjectLookup["fromSource"], BaseModule.DataLookup["fromsourceAu"], BaseModule.ObjectLookup["fromDate"], BaseModule.DataLookup["fromDate"], BaseModule.ObjectLookup["toDate"], BaseModule.DataLookup["toDate"]);
                                    bool WarningMesgDepature = Utility.IsTextPresent(BaseModule.AssertLookup["destinationWarningHome"], context);
                                    if (WarningMesgDepature.Equals(true))
                                    {
                                        Utility.TakeScreenShot(context, "SearchWithoutReturnplace");
                                        Console.WriteLine("Enter Destination to Search");
                                    }

                                }
                                finally
                                {
                                    if (context != null) { Utility.Cleanup(context); }

                                }

                            }



                            [Test]
                            public void TestSearchByNoDeparture()
                            {

                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Auwebsiteurl"];
                                try
                                {

                                    context = Drivercontext.Create("homePagetests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    HomeModule homeModule = new HomeModule();
                                    //Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Home"]);
                                    //Utility.popUp(context, BaseModule.DataLookup["email"], BaseModule.DataLookup["postcode"]);
                                    homeModule.GetHomepage().MissingFixedSearchCriteria(context, BaseModule.ObjectLookup["toDestination"], BaseModule.DataLookup["toDestination"], BaseModule.ObjectLookup["fromDate"], BaseModule.DataLookup["fromDate"], BaseModule.ObjectLookup["toDate"], BaseModule.DataLookup["toDate"]);
                                    bool WarningMesgDepature = Utility.IsTextPresent(BaseModule.AssertLookup["departureWarning"], context);
                                    if (WarningMesgDepature.Equals(true))
                                    {
                                        Utility.TakeScreenShot(context, "SearchWithoutDestinationPlace");
                                        Console.WriteLine("Enter Destination to Search");
                                    }

                                }
                                finally
                                {
                                    if (context != null) { Utility.Cleanup(context); }

                                }
                            }



                            [Test]
                            [Ignore]
                            //This test is not needed as the dates are pre-populated for CFAU
                            public void TestSearchByNoReturnDate()
                            {

                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Auwebsiteurl"];
                                try
                                {

                                    context = Drivercontext.Create("homePagetests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    HomeModule homeModule = new HomeModule();
                                    //Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Home"]);
                                    //Utility.popUp(context, BaseModule.DataLookup["email"], BaseModule.DataLookup["postcode"]);
                                    homeModule.GetHomepage().MissingFixedSearchCriteria(context, BaseModule.ObjectLookup["fromSource"], BaseModule.DataLookup["fromsourceAu"], BaseModule.ObjectLookup["toDestination"], BaseModule.DataLookup["toDestination"], BaseModule.ObjectLookup["fromDate"], BaseModule.DataLookup["fromDate"]);
                                    bool WarningMesgDepature = Utility.IsTextPresent(BaseModule.AssertLookup["dateWarningReturn"], context);
                                    if (WarningMesgDepature.Equals(true))
                                    {
                                        Utility.TakeScreenShot(context, "SearchWithoutReturnDate");
                                        Console.WriteLine("Enter Return date to Search");
                                    }

                                }
                                finally
                                {
                                    if (context != null) { Utility.Cleanup(context); }

                                }

                            }



                            [Test]
                            [Ignore]
                            //This test is not needed as the dates are pre-populated for CFAU
                            public void TestSearchByNoDepartDate()
                            {
                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Auwebsiteurl"];
                                try
                                {

                                    context = Drivercontext.Create("homePagetests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    HomeModule homeModule = new HomeModule();
                                    //Utility.popUp(context,BaseModule.DataLookup["email"],BaseModule.DataLookup["postcode"]);
                                    //Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Home"]);
                                    homeModule.GetHomepage().MissingFixedSearchCriteria(context, BaseModule.ObjectLookup["fromSource"], BaseModule.DataLookup["fromsourceAu"], BaseModule.ObjectLookup["toDestination"], BaseModule.DataLookup["toDestination"], BaseModule.ObjectLookup["toDate"], BaseModule.DataLookup["toDate"]);
                                    bool WarningMesgDepature = Utility.IsTextPresent(BaseModule.AssertLookup["dateWarningDeparture"], context);
                                    if (WarningMesgDepature.Equals(true))
                                    {
                                        Utility.TakeScreenShot(context, "SearchWithoutDepartDate");
                                        Console.WriteLine("Enter Depart date  to Search");
                                    }

                                }
                                finally
                                {
                                    if (context != null) { Utility.Cleanup(context); }

                                }

                            }


                            [Test]
                            [Ignore]
                            //Selenium fix needed for this
                            public void TestContinentMap()
                            {
                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Auwebsiteurl"];
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
                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Auwebsiteurl"];
                                try
                                {
                                    context = Drivercontext.Create("HomePageTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    HomeModule homeModule = new HomeModule();
                                    homeModule.GetHomepage().SearchFlex(context, BaseModule.DataLookup["AusourceAlternateDeals"],
                                        BaseModule.DataLookup["destinationAlternateDeals"], BaseModule.ObjectLookup["newsletterHP"]);
                                    homeModule.GetHomepage().GetMetaName(context);
                                    homeModule.GetHomepage().ValidateWarningMessage(context);
                                }
                                finally
                                {
                                    if (context != null) { Utility.Cleanup(context); }

                                }

                            }


                            [Test]
                            public void Testtabs()
                            {
                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Auwebsiteurl"];
                                try
                                {

                                    context = Drivercontext.Create("HomePageTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    //Utility.popUp(context, BaseModule.DataLookup["email"], BaseModule.DataLookup["postcode"]);
                                    Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["flightdeals"]);
                                    Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);
                                    Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Hotdeals"]);
                                    //Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["inspired"]);
                                    Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["travelguides"]);
                                    Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Newsletter"]);
                                }
                                finally
                                {

                                    if (context != null) { Utility.Cleanup(context); }

                                }


                            }


                            [Test]
                            [Ignore]
                            //This test is ignored as there needs to be a proper build related to Market place
                            public void TestAgentDetails()
                            {
                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Auwebsiteurl"];
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
                                    Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Auwebsiteurl"];
                                            try {

                                                context = Drivercontext.Create("HomeWarningMessageTest", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                                        HomeModule homeModule = new HomeModule();
                                                        homeModule.GetHomepage().FixedwithoutinputnNL(context);
                                                    
                                            }
                                            finally
                                            {
                                               if (context != null){Utility.Cleanup(context);}
                                            }
                        
                    
                                }


                                [Test]
                                public void TestBookingGuideModuleExists() 
                                {
                                    Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Auwebsiteurl"];
                                            try
                                            {
                                                context = Drivercontext.Create("HomeBEnGuideExistsTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                                HomeModule homeModule = new HomeModule();
                                                homeModule.GetHomepage().SearchFlex(context, BaseModule.DataLookup["AusourceAlternateDeals"],
                                                    BaseModule.DataLookup["destinationAlternateDeals"], BaseModule.ObjectLookup["newsletterHP"]);
                                                homeModule.GetHomepage().GetMetaName(context);
                                                homeModule.GetHomepage().BookingEngineExists(context);
                                               
                                            }
                                            finally 
                                            {
                                                if (context != null){Utility.Cleanup(context);}
                                            }
                                
                                }



                                [Test]
                                public void TestFlagDropDown() 
                                {
                                    Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Auwebsiteurl"];
                                    try {
                                        context = Drivercontext.Create("HomeFlagCountry", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                                HomeModule homeModule = new HomeModule();
                                                homeModule.GetHomepage().FlagDropDown(context);
                                              
                                    }
                                    finally {

                                       if (context != null){Utility.Cleanup(context);}

                                    }
                                
                                
                                }
                                



                                [Test]
                                public void TestValidateCountrylabelPresent() 
                                {

                                    Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Auwebsiteurl"];
                                    try {

                                        context = Drivercontext.Create("HomeCountryLabelExists", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                                HomeModule homeModule = new HomeModule();
                                                homeModule.GetHomepage().CountryText(context);
                                             
                                    }
                                    finally
                                    {
                                       if (context != null){Utility.Cleanup(context);}
                                    }
                                
                                
                                }



                                [Test]
                                public void TestValidateLogo() 
                                {
                                    Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Auwebsiteurl"];
                                    try {
                                        context = Drivercontext.Create("HomeValidateLogo", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                                HomeModule homeModule = new HomeModule();
                                                homeModule.GetHomepage().MainLogo(context);
                                           
                                    }finally{
                                       if (context != null){Utility.Cleanup(context);}
                                    
                                    }
                                
                                }

                                [Test]
                                public void TestStrapLine() 
                                {
                                    Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Auwebsiteurl"];
                                        try {
                                            context = Drivercontext.Create("HomeValidateStrapLine", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                                HomeModule homeModule = new HomeModule();
                                                homeModule.GetHomepage().StrapLineValidate(context);
                                        
                                        }
                                        finally
                                        {
                                           if (context != null){Utility.Cleanup(context);}
                                        
                                        }
                                
                                
                                }


                                [Test]
                                [Ignore]
                                //Travel tips module is not present on CFAU
                                public void TestHomeTravelTips() 
                                {
                                    Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Auwebsiteurl"];
                                    try {
                                        context = Drivercontext.Create("HomeTravelTips", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                                HomeModule homeModule = new HomeModule();
                                                homeModule.GetHomepage().TravelTips(context);
                                                
                                    }
                                    finally
                                    {
                                       if (context != null){Utility.Cleanup(context);}
                                    
                                    }
                                        
                                
                                }

                                [Test]
                                [Ignore]
                                //Selenium fix needed for this
                                public void TestHomeDepartureSpilt()
                                {
                                    Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Auwebsiteurl"];
                                    try
                                    {
                                        context = Drivercontext.Create("HomeDepartureSpiltPage", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                            HomeModule homeModule = new HomeModule();
                                            homeModule.GetHomepage().DepartureSpilt(context);
                                           
                                    }
                                    finally 
                                    {
                                       if (context != null){Utility.Cleanup(context);}
                                    
                                    }
                                
                                }


                                [Test]
                                public void TestWorldMap() 
                                {
                                    Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Auwebsiteurl"];
                                    try {
                                        context = Drivercontext.Create("HomeWorldMap", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                                HomeModule homeModule = new HomeModule();
                                                homeModule.GetHomepage().DestinationSpiltMap(context);
                                              
                                    }
                                    finally
                                    {
                                       if (context != null){Utility.Cleanup(context);}
                                    
                                    }
                                
                                }


                                //This Test is not there for Canada as it is changed
                                [Test]
                                [Ignore]
                                //Selenium fix needed for this
                                 public void TestEditorsPick()
                                 {
                                     Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Auwebsiteurl"];

                                        try
                                        {
                                            context = Drivercontext.Create("HomeEditorsPick", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                            HomeModule homeModule = new HomeModule();
                                            homeModule.GetHomepage().EditorsPick(context);
                                          }
                                        finally
                                        {
                                           if (context != null){Utility.Cleanup(context);}

                                        }
                                 
                                 }


                                [TestFixtureTearDown]
                                public void TestFixtureTearDown()
                                {
                                    Drivercontext context = null;
                                    if (context != null)
                                    {
                                        Utility.Cleanup(context);
                                    }
                                }


    }
}







