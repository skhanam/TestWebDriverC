﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using TestWebDriver.com.cf.webdriver.src.Common;
using TestWebDriver.com.cf.webdriver.src.ModuleObject;
using System.Configuration;

namespace TestWebDriver.com.cf.webdriver.src.RegressionUSTests
{
    [TestFixture]
    [Category("Sanity")]
    public class USSanityTest
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
                    public void TestSearchByIATAtoIATA()
                    {

                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                        try
                        {

                            context = Drivercontext.Create("searchByIATAtests", BaseModule.GetDataLookup(), WebSiteUrlFromConfig,Utility.GetFireFoxDriver());
                            SearchByDateModule searchByDateModule = new SearchByDateModule();

                            Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);

                            searchByDateModule.GetSearchByDatePage().ProductTypeSearch(context, BaseModule.ObjectLookup["FlightsnHotels"],
                                BaseModule.ObjectLookup["beSource"], BaseModule.DataLookup["fromSourceUSIATA"], BaseModule.ObjectLookup["beDestination"],
                                BaseModule.DataLookup["toDestinationIATA"], BaseModule.ObjectLookup["beFromDate"],
                                BaseModule.DataLookup["fromDateUS"], BaseModule.ObjectLookup["beToDate"], BaseModule.DataLookup["toDateUS"],
                                BaseModule.ObjectLookup["newsletter"],
                                BaseModule.ObjectLookup["txtEmail"], BaseModule.DataLookup["email"],
                                BaseModule.ObjectLookup["befindDeals"]);
                            Utility.TakeScreenShot(context, "IATAtoIATASearch");

                        }
                        finally
                        {
                           if (context != null){Utility.Cleanup(context);}

                        }

                    }


                    [Test]
                    public void TestSearchOneWay()
                    {

                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                        try
                        {

                            context = Drivercontext.Create("SearchOneWaytests", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            SearchByDateModule searchByDateModule = new SearchByDateModule();
                            Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);

                            searchByDateModule.GetSearchByDatePage().OnewaySearch(context, BaseModule.ObjectLookup["ticketType"],
                                BaseModule.ObjectLookup["beSource"], BaseModule.DataLookup["toDestination"], BaseModule.ObjectLookup["beDestination"],
                                BaseModule.DataLookup["changeDestinationData"], BaseModule.ObjectLookup["beFromDate"],
                                BaseModule.DataLookup["fromDateUS"], BaseModule.ObjectLookup["beToDate"], BaseModule.DataLookup["toDateUS"],
                                BaseModule.ObjectLookup["befindDeals"]);

                        }
                        finally
                        {
                           if (context != null){Utility.Cleanup(context);}

                        }

                    }

                    [Test]
                    public void TestNLSignup()
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                        try
                        {

                            context = Drivercontext.Create("NLSignup", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            SearchByDateModule searchByDateModule = new SearchByDateModule();
                            Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);

                            searchByDateModule.GetSearchByDatePage().NLSignup(context, BaseModule.ObjectLookup["FlightsnHotels"],
                                BaseModule.ObjectLookup["beSource"], BaseModule.DataLookup["toDestination"],
                                BaseModule.ObjectLookup["beDestination"], BaseModule.DataLookup["changeDestinationData"],
                                BaseModule.ObjectLookup["beFromDate"], BaseModule.DataLookup["fromDateUS"],
                                BaseModule.ObjectLookup["beToDate"], BaseModule.DataLookup["toDateUS"], BaseModule.ObjectLookup["newsletter"],
                                BaseModule.ObjectLookup["txtEmail"], BaseModule.DataLookup["email"], BaseModule.ObjectLookup["befindDeals"]);

                        }
                        finally
                        {

                            if (context != null) { Utility.Cleanup(context); }

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
                    public void TestSearchFixed()
                    {

                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                        try
                        {

                            context = Drivercontext.Create("homePagetests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig,Utility.GetFireFoxDriver());
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
                    public void TestTabs()
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


                // There is a bug raised which need fixes from Development team.

                    //[Test]
                    public void TestHomeDepartureSpilt()
                    {
                        Drivercontext context = null; 
                        string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
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
                    public void TestBEReSearch()
                    {

                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                        try
                        {

                            context = Drivercontext.Create("BEResearchTests", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            SearchByDateModule searchByDateModule = new SearchByDateModule();
                            Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);

                            searchByDateModule.GetSearchByDatePage().ProductTypeSearch(context, BaseModule.ObjectLookup["FlightsnHotels"],
                                BaseModule.ObjectLookup["beSource"], BaseModule.DataLookup["toDestination"],
                                BaseModule.ObjectLookup["beDestination"], BaseModule.DataLookup["toDestinationRegion"],
                                BaseModule.ObjectLookup["beFromDate"], BaseModule.DataLookup["fromDateUS"], BaseModule.ObjectLookup["beToDate"],
                                BaseModule.DataLookup["toDateUS"], BaseModule.ObjectLookup["newsletter"],
                                BaseModule.ObjectLookup["txtEmail"], BaseModule.DataLookup["email"],
                                BaseModule.ObjectLookup["befindDeals"]);

                            searchByDateModule.GetSearchByDatePage().BookingEngineReSearch(context, BaseModule.ObjectLookup["FlightsnHotels"],
                                BaseModule.ObjectLookup["beFromDate"], BaseModule.DataLookup["fromDateUS"],
                                BaseModule.ObjectLookup["beToDate"], BaseModule.DataLookup["toDateUS"], BaseModule.ObjectLookup["newsletter"], 
                                BaseModule.ObjectLookup["txtEmail"], BaseModule.DataLookup["email"],
                                BaseModule.ObjectLookup["befindDeals"]);

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
                    public void TestFlightnHotelSearch()
                    {

                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                        try
                        {

                            context = Drivercontext.Create("searchByIATAtests", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            SearchByDateModule searchByDateModule = new SearchByDateModule();
                            Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);

                            searchByDateModule.GetSearchByDatePage().ProductTypeSearch(context, BaseModule.ObjectLookup["FlightsnHotels"],
                                BaseModule.ObjectLookup["beSource"], BaseModule.DataLookup["toDestination"],
                                BaseModule.ObjectLookup["beDestination"], BaseModule.DataLookup["fromSource"],
                                BaseModule.ObjectLookup["beFromDate"], BaseModule.DataLookup["fromDateUS"], BaseModule.ObjectLookup["beToDate"],
                                BaseModule.DataLookup["toDateUS"], BaseModule.ObjectLookup["newsletter"],
                                BaseModule.ObjectLookup["txtEmail"], BaseModule.DataLookup["email"],
                                BaseModule.ObjectLookup["befindDeals"]);
                        }
                        finally
                        {

                            if (context != null) { Utility.Cleanup(context); }

                        }

                    }



                    [Test]
                    public void TestBeInspired()
                    {

                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                        try
                        {
                            BaseModule baseModule = new BaseModule();
                            context = Drivercontext.Create("beInspiredTests", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            BeInspiredModule beInspiredModule = new BeInspiredModule();
                            Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["inspired"]);
                            beInspiredModule.GetBeInspiredPage().BeInspiredSearch(context, BaseModule.ObjectLookup["any"], BaseModule.DataLookup["toDestination"]);
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

                           if (context != null){Utility.Cleanup(context);}

                        }


                    }


                    [Test]
                    public void TestFlightdeals()
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                        try
                        {
                            context = Drivercontext.Create("FlightDealsTest", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());

                            //Don't need to switch tabs, as the SearchFlightDeals method does this.
                            //Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["flightdeals"]);

                            FlightDealsModule flightDealsModule = new FlightDealsModule();
                            flightDealsModule.GetFlightdealsPage().SearchFlightDeals(context, BaseModule.DataLookup["toDestination"],
                                BaseModule.DataLookup["flightDealsSearch"], BaseModule.DataLookup["fromDateUS"], BaseModule.DataLookup["toDateUS"]);

                        }
                        finally
                        {

                           if (context != null){Utility.Cleanup(context);}

                        }


                    }


                    [Test]
                    public void TestFlightDealsFixed()
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                        try
                        {
                            context = Drivercontext.Create("FlightDealFixedSearch", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            FlightDealsModule flightModule = new FlightDealsModule();
                            flightModule.GetFlightdealsPage().FixedSearch(context, BaseModule.DataLookup["fromSourceUSIATA"], BaseModule.DataLookup["toDestinationIATA"], BaseModule.DataLookup["fromDateUS"], BaseModule.DataLookup["toDateUS"]);

                        }
                        finally
                        {
                           if (context != null){Utility.Cleanup(context);}

                        }


                    }


                    [Test]
                    public void TestProductTypeDisplayed()
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                        try
                        {
                            context = Drivercontext.Create("SearchbyDateTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            SearchByDateModule searchByDate = new SearchByDateModule();
                            searchByDate.GetSearchByDatePage().GetProductTypeCount(context);

                        }
                        finally
                        {

                           if (context != null){Utility.Cleanup(context);}

                        }


                    }


                    // There is a bug for this test to pass 
                    //[Test]
                    public void TestSpiltLink()
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                        try
                        {
                            BaseModule baseModule = new BaseModule();
                            context = Drivercontext.Create("TravelGuideCityPageTest", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            TravelGuideModule travelGuideModule = new TravelGuideModule();
                            travelGuideModule.getTravelguidepage().TGSpiltLink(context, BaseModule.ObjectLookup["poplarLinks"], "[1]/a");

                        }

                        finally
                        {

                           if (context != null){Utility.Cleanup(context);}

                        }


                    }


                    // There is a bug for this test to pass 
                    //[Test]
                    public void TestSpiltLinkCountry()
                    {

                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                        try
                        {
                            BaseModule baseModule = new BaseModule();
                            context = Drivercontext.Create("TravelGuideCityPageTest", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            TravelGuideModule travelGuideModule = new TravelGuideModule();
                            travelGuideModule.getTravelguidepage().TGSpiltLink(context, BaseModule.ObjectLookup["TGEurope"], "/ul/li[6]/a");
                        }

                        finally
                        {

                           if (context != null){Utility.Cleanup(context);}

                        }



                    }


                    [Test]
                    public void TestAdultNumberCount()
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                        try
                        {
                            context = Drivercontext.Create("SearchbyDateTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            SearchByDateModule searchbyDate = new SearchByDateModule();
                            searchbyDate.GetSearchByDatePage().GetAdultNumberCount(context);

                        }
                        finally
                        {

                           if (context != null){Utility.Cleanup(context);}

                        }

                    }


                    [Test]
                    public void TestChildrenNumberCount()
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                        try
                        {
                            context = Drivercontext.Create("SearchByDateTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            SearchByDateModule searchbyDate = new SearchByDateModule();
                            searchbyDate.GetSearchByDatePage().GetChildrenNumberCount(context);

                        }

                        finally
                        {

                           if (context != null){Utility.Cleanup(context);}

                        }

                    }


        // This test is not there for US WebSite.
                    //[Test]
                    public void TestInfantNumberCount()
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                        try
                        {
                            context = Drivercontext.Create("SearchByDateTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            SearchByDateModule searchbyDate = new SearchByDateModule();
                            searchbyDate.GetSearchByDatePage().GetInfantNumberCount(context);

                        }
                        finally
                        {

                           if (context != null){Utility.Cleanup(context);}

                        }

                    }



                    [Test]
                    public void TestClickOnPartner()
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                        try
                        {
                            context = Drivercontext.Create("SearchbydateTests", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            SearchByDateModule searchbyDate = new SearchByDateModule();
                            searchbyDate.GetSearchByDatePage().ClickonPartner(context,BaseModule.DataLookup["toDestination"],  BaseModule.DataLookup["fromSource"] ,BaseModule.DataLookup["toDateUS"], BaseModule.DataLookup["fromDateUS"]);
                        }
                        finally
                        {

                           if (context != null){Utility.Cleanup(context);}

                        }
                    }



        // This test is not there for US webSite
                    //[Test]
                    public void TestDealsBelowBookingEngine()
                    {

                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                        try
                        {
                            context = Drivercontext.Create("SearchbydateTests", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            SearchByDateModule searchbyDateModule = new SearchByDateModule();
                            searchbyDateModule.GetSearchByDatePage().DealsBelowBE(context);
                        }
                        finally
                        {

                           if (context != null){Utility.Cleanup(context);}

                        }
                    }



                    [Test]
                    [Ignore]
                    //Ignore this test as there is a build merge issue. 
                    public void TestTGAgentDetails()
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                        try
                        {
                            context = Drivercontext.Create("TravelGuideCityPageTest", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            TravelGuideModule travelGuideModule = new TravelGuideModule();
                            travelGuideModule.getTravelguidepage().AirlineAgents(context);
                        }
                        finally
                        {
                           if (context != null){Utility.Cleanup(context);}

                        }
                    }

        // There is a bug for this test to pass 

                    [Test]
                    public void TestMiniBookingEngine()
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                        try
                        {
                            BaseModule baseModule = new BaseModule();
                            context = Drivercontext.Create("TravelGuideTests", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            TravelGuideModule travelGuideModule = new TravelGuideModule();
                            travelGuideModule.getTravelguidepage().MiniBookingEngine(context, BaseModule.ObjectLookup["TravelGuide"]);

                        }
                        finally
                        {
                           if (context != null){Utility.Cleanup(context);}

                        }
                    }

                }
  }

