using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using TestWebDriver.com.cf.webdriver.src.Common;
using TestWebDriver.com.cf.webdriver.src.ModuleObject;
using TestWebDriver.com.cf.webdriver.src.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Configuration;

namespace TestWebDriver.com.cf.webdriver.src.RegressionUKTests
{       
    [TestFixture]
    [Category("Regression")]
    public class BookingEngineSearchTest
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

                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                try
                                {

                                    context = Drivercontext.Create("searchByIATAtests", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    SearchByDateModule searchByDateModule = new SearchByDateModule();

                                    Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);
                                     
                                    searchByDateModule.GetSearchByDatePage().ProductTypeSearch(context, BaseModule.ObjectLookup["FlightsnHotels"], 
                                        BaseModule.ObjectLookup["beSource"], BaseModule.DataLookup["fromSourceIATA"], BaseModule.ObjectLookup["beDestination"], 
                                        BaseModule.DataLookup["toDestinationIATA"], BaseModule.ObjectLookup["beFromDate"],
                                        BaseModule.DataLookup["fromDate"], BaseModule.ObjectLookup["beToDate"], BaseModule.DataLookup["toDate"],
                                        BaseModule.ObjectLookup["newsletter"],
                                        BaseModule.ObjectLookup["txtEmail"], BaseModule.DataLookup["email"],
                                        BaseModule.ObjectLookup["befindDeals"]);
                                   
                                }
                                finally
                                {
                                   if (context != null){Utility.Cleanup(context);}
                                 
                                }

                            }

                            [Test]
                            public void TestFlightnHotelSearch() 
                            {

                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                try
                                {

                                    context = Drivercontext.Create("searchByIATAtests", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    SearchByDateModule searchByDateModule = new SearchByDateModule();
                                    Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);
                                     
                                    searchByDateModule.GetSearchByDatePage().ProductTypeSearch(context, BaseModule.ObjectLookup["FlightsnHotels"],
                                        BaseModule.ObjectLookup["beSource"], BaseModule.DataLookup["fromSource"],
                                        BaseModule.ObjectLookup["beDestination"], BaseModule.DataLookup["toDestination"],
                                        BaseModule.ObjectLookup["beFromDate"], BaseModule.DataLookup["fromDate"], BaseModule.ObjectLookup["beToDate"],
                                        BaseModule.DataLookup["toDate"], BaseModule.ObjectLookup["newsletter"],
                                        BaseModule.ObjectLookup["txtEmail"], BaseModule.DataLookup["email"],
                                        BaseModule.ObjectLookup["befindDeals"]);
                                   
                                   
                                }
                                finally
                                {
                                   if (context != null){Utility.Cleanup(context);}
                                 
                                }
                            
                            }



                            [Test]
                            public void TestSearchByCitytoCity()
                            {

                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                try
                                {

                                    context = Drivercontext.Create("searchByIATAtests", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    SearchByDateModule searchByDateModule = new SearchByDateModule();
                                    Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);
                                     
                                    searchByDateModule.GetSearchByDatePage().ProductTypeSearch(context, BaseModule.ObjectLookup["FlightsnHotels"], 
                                        BaseModule.ObjectLookup["beSource"], BaseModule.DataLookup["fromSource"], 
                                        BaseModule.ObjectLookup["beDestination"], BaseModule.DataLookup["toDestination"], 
                                        BaseModule.ObjectLookup["beFromDate"], BaseModule.DataLookup["fromDate"], BaseModule.ObjectLookup["beToDate"],
                                        BaseModule.DataLookup["toDate"],BaseModule.ObjectLookup["newsletter"],
                                        BaseModule.ObjectLookup["txtEmail"], BaseModule.DataLookup["email"],
                                        BaseModule.ObjectLookup["befindDeals"]);
                                   
                               }
                                finally
                                {
                                   if (context != null){Utility.Cleanup(context);}
                                  
                                }
                            }



                            [Test]
                            public void TestSearchByIATAtoCity()
                            {

                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                try
                                {

                                    context = Drivercontext.Create("searchByIATAtests", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    SearchByDateModule searchByDateModule = new SearchByDateModule();
                                    Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);
                                     
                                    searchByDateModule.GetSearchByDatePage().ProductTypeSearch(context, BaseModule.ObjectLookup["FlightsnHotels"], 
                                        BaseModule.ObjectLookup["beSource"], BaseModule.DataLookup["fromSourceIATA"], BaseModule.ObjectLookup["beDestination"], 
                                        BaseModule.DataLookup["toDestination"], BaseModule.ObjectLookup["beFromDate"], 
                                        BaseModule.DataLookup["fromDate"], BaseModule.ObjectLookup["beToDate"], BaseModule.DataLookup["toDate"], 
                                        BaseModule.ObjectLookup["newsletter"],
                                        BaseModule.ObjectLookup["txtEmail"], BaseModule.DataLookup["email"],
                                        BaseModule.ObjectLookup["befindDeals"]);
                                    
                                }
                                finally
                                {
                                   if (context != null){Utility.Cleanup(context);}
                                   
                                }
                            }


                           
                            public void TestSearchByAlphanumeric()
                            {

                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                try
                                {

                                    context = Drivercontext.Create("searchByIATAtests", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    SearchByDateModule searchByDateModule = new SearchByDateModule();
                                    Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);
                                     
                                    searchByDateModule.GetSearchByDatePage().ProductTypeSearch(context, BaseModule.ObjectLookup["FlightsnHotels"], 
                                        BaseModule.ObjectLookup["beSource"], BaseModule.DataLookup["fromSourceAlpha"], 
                                        BaseModule.ObjectLookup["beDestination"], BaseModule.DataLookup["toDestinationAlpha"], 
                                        BaseModule.ObjectLookup["beFromDate"], BaseModule.DataLookup["fromDate"], BaseModule.ObjectLookup["beToDate"],
                                        BaseModule.DataLookup["toDate"], BaseModule.ObjectLookup["newsletter"],
                                        BaseModule.ObjectLookup["txtEmail"], BaseModule.DataLookup["email"],
                                        BaseModule.ObjectLookup["befindDeals"]);
                                    searchByDateModule.GetSearchByDatePage().LookforWarning(context);
                                   
                                }
                                finally
                                {
                                   if (context != null){Utility.Cleanup(context);}
                            
                                }
                            }

                            [Test]
                            public void TestSearchByCatchmentAirport()
                            {

                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                try
                                {

                                    context = Drivercontext.Create("searchByIATAtests", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    SearchByDateModule searchByDateModule = new SearchByDateModule();
                                    Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);
                                     
                                    searchByDateModule.GetSearchByDatePage().ProductTypeSearch(context, BaseModule.ObjectLookup["FlightsnHotels"],
                                        BaseModule.ObjectLookup["beSource"], BaseModule.DataLookup["fromSourceAirport"], BaseModule.ObjectLookup["beDestination"], 
                                        BaseModule.DataLookup["toDestinationIATA"], BaseModule.ObjectLookup["beFromDate"], 
                                        BaseModule.DataLookup["fromDate"], BaseModule.ObjectLookup["beToDate"], BaseModule.DataLookup["toDate"],
                                        BaseModule.ObjectLookup["newsletter"],
                                        BaseModule.ObjectLookup["txtEmail"], BaseModule.DataLookup["email"],
                                        BaseModule.ObjectLookup["befindDeals"]);
                                    
                                }
                                finally
                                {
                                   if (context != null){Utility.Cleanup(context);}
                                   
                                }
                            }


                            [Test]
                            public void TestSearchBySisterSite()
                            {

                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                try
                                {

                                    context = Drivercontext.Create("searchByIATAtests", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    SearchByDateModule searchByDateModule = new SearchByDateModule();
                                    Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);
                                     
                                    searchByDateModule.GetSearchByDatePage().ProductTypeSearch(context, BaseModule.ObjectLookup["FlightsnHotels"], 
                                        BaseModule.ObjectLookup["beSource"], BaseModule.DataLookup["toDestination"], 
                                        BaseModule.ObjectLookup["beDestination"], BaseModule.DataLookup["changeDestinationData"], 
                                        BaseModule.ObjectLookup["beFromDate"], BaseModule.DataLookup["fromDate"], BaseModule.ObjectLookup["beToDate"],
                                        BaseModule.DataLookup["toDate"],BaseModule.ObjectLookup["newsletter"],
                                        BaseModule.ObjectLookup["txtEmail"], BaseModule.DataLookup["email"],
                                        BaseModule.ObjectLookup["befindDeals"]);
                                    searchByDateModule.GetSearchByDatePage().GetSisterSiteMessage(context);
                                   
                                }
                                finally
                                {
                                   if (context != null){Utility.Cleanup(context);}
                                   
                                } 
                            }


                            [Test]
                            public void TestSearchByAnywhere()
                            {

                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                try
                                {

                                    context = Drivercontext.Create("searchByIATAtests", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    SearchByDateModule searchByDateModule = new SearchByDateModule();
                                    Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);
                                     
                                    searchByDateModule.GetSearchByDatePage().ProductTypeSearch(context, BaseModule.ObjectLookup["FlightsnHotels"], 
                                        BaseModule.ObjectLookup["beSource"], BaseModule.DataLookup["fromSourceAnywhere"],
                                        BaseModule.ObjectLookup["beDestination"], BaseModule.DataLookup["toDestinationAnywhere"], 
                                        BaseModule.ObjectLookup["beFromDate"], BaseModule.DataLookup["fromDate"], BaseModule.ObjectLookup["beToDate"],
                                        BaseModule.DataLookup["toDate"],BaseModule.ObjectLookup["newsletter"],
                                        BaseModule.ObjectLookup["txtEmail"], BaseModule.DataLookup["email"],
                                        BaseModule.ObjectLookup["befindDeals"]);
                                    Utility.TakeScreenShot(context,"MomondoPopup");
                               
                                }
                                finally
                                {
                                   if (context != null){Utility.Cleanup(context);}
                                    
                                }
                            }
                            

                            
                            [Test]
                            public void TestSearchByRegion()
                            {

                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                try
                                {

                                    context = Drivercontext.Create("searchByIATAtests", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    SearchByDateModule searchByDateModule = new SearchByDateModule();
                                    Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);
                                     
                                    searchByDateModule.GetSearchByDatePage().ProductTypeSearch(context, BaseModule.ObjectLookup["FlightsnHotels"],
                                        BaseModule.ObjectLookup["beSource"], BaseModule.DataLookup["fromSource"],
                                        BaseModule.ObjectLookup["beDestination"], BaseModule.DataLookup["toDestinationRegion"], 
                                        BaseModule.ObjectLookup["beFromDate"], BaseModule.DataLookup["fromDate"], BaseModule.ObjectLookup["beToDate"],
                                        BaseModule.DataLookup["toDate"], BaseModule.ObjectLookup["newsletter"],
                                        BaseModule.ObjectLookup["txtEmail"], BaseModule.DataLookup["email"],
                                        BaseModule.ObjectLookup["befindDeals"]);
                                  
                                    searchByDateModule.GetSearchByDatePage().BookingEngineReSearch(context, BaseModule.ObjectLookup["FlightsnHotels"], 
                                        BaseModule.ObjectLookup["beFromDate"], BaseModule.DataLookup["fromDate"],
                                        BaseModule.ObjectLookup["beToDate"], BaseModule.DataLookup["toDate"], 
                                        BaseModule.ObjectLookup["newsletter"],
                                        BaseModule.ObjectLookup["txtEmail"], BaseModule.DataLookup["email"],
                                        BaseModule.ObjectLookup["befindDeals"]);
                                   
                                }
                                finally
                                {
                                   if (context != null){Utility.Cleanup(context);}
                                   
                                } 
                            }

                            [Test]
                            public void TestSearchByState()
                            {

                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                try
                                {

                                    context = Drivercontext.Create("searchByIATAtests", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    SearchByDateModule searchByDateModule = new SearchByDateModule();
                                    Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);
                                     
                                    searchByDateModule.GetSearchByDatePage().ProductTypeSearch(context, BaseModule.ObjectLookup["FlightsnHotels"], 
                                        BaseModule.ObjectLookup["beSource"], BaseModule.DataLookup["fromSource"], BaseModule.ObjectLookup["beDestination"], 
                                        BaseModule.DataLookup["toDestinationState"], BaseModule.ObjectLookup["beFromDate"],
                                        BaseModule.DataLookup["fromDate"], BaseModule.ObjectLookup["beToDate"], BaseModule.DataLookup["toDate"], 
                                        BaseModule.ObjectLookup["newsletter"],
                                        BaseModule.ObjectLookup["txtEmail"], BaseModule.DataLookup["email"],
                                        BaseModule.ObjectLookup["befindDeals"]);
                                    context.GetDriver().Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(30));
                                    searchByDateModule.GetSearchByDatePage().BookingEngineReSearch(context, BaseModule.ObjectLookup["Flights"], 
                                        BaseModule.ObjectLookup["beFromDate"], BaseModule.DataLookup["fromDate"], BaseModule.ObjectLookup["beToDate"],
                                        BaseModule.DataLookup["toDate"], BaseModule.ObjectLookup["newsletter"],
                                        BaseModule.ObjectLookup["txtEmail"], BaseModule.DataLookup["email"],
                                        BaseModule.ObjectLookup["befindDeals"]);
                                    
                                }
                                finally
                                {
                                   if (context != null){
                                       Utility.Cleanup(context);
                                   }
                                     
                                }
                            }



                            [Test]
                            public void TestSearchByCountry()
                            {

                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                try
                                {

                                    context = Drivercontext.Create("searchByIATAtests", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    SearchByDateModule searchByDateModule = new SearchByDateModule();
                                    Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);
                                     
                                    searchByDateModule.GetSearchByDatePage().ProductTypeSearch(context, BaseModule.ObjectLookup["FlightsnHotels"], BaseModule.ObjectLookup["beSource"], BaseModule.DataLookup["fromSource"],
                                        BaseModule.ObjectLookup["beDestination"], BaseModule.DataLookup["toDestinationCountry"], 
                                        BaseModule.ObjectLookup["beFromDate"], BaseModule.DataLookup["fromDate"], BaseModule.ObjectLookup["beToDate"],
                                        BaseModule.DataLookup["toDate"], BaseModule.ObjectLookup["newsletter"],
                                        BaseModule.ObjectLookup["txtEmail"], BaseModule.DataLookup["email"],
                                        BaseModule.ObjectLookup["befindDeals"]);
                                    searchByDateModule.GetSearchByDatePage().BookingEngineReSearch(context, BaseModule.ObjectLookup["Flights"], 
                                        BaseModule.ObjectLookup["beFromDate"], BaseModule.DataLookup["fromDate"], BaseModule.ObjectLookup["beToDate"],
                                        BaseModule.DataLookup["toDate"], BaseModule.ObjectLookup["newsletter"],
                                        BaseModule.ObjectLookup["txtEmail"], BaseModule.DataLookup["email"],
                                        BaseModule.ObjectLookup["befindDeals"]);
                                    
                                }
                                finally
                                {
                                   if (context != null){Utility.Cleanup(context);}
                                     
                                }
                            }



                            [Test]
                            public void TestSearchByContinent()
                            {

                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                try
                                {

                                    context = Drivercontext.Create("searchByIATAtests", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    SearchByDateModule searchByDateModule = new SearchByDateModule();
                                    Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);
                                     
                                    searchByDateModule.GetSearchByDatePage().ProductTypeSearch(context, BaseModule.ObjectLookup["FlightsnHotels"], BaseModule.ObjectLookup["beSource"], BaseModule.DataLookup["fromSource"], 
                                        BaseModule.ObjectLookup["beDestination"], BaseModule.DataLookup["toDestinationCountry"], 
                                        BaseModule.ObjectLookup["beFromDate"], BaseModule.DataLookup["fromDate"], BaseModule.ObjectLookup["beToDate"], 
                                        BaseModule.DataLookup["toDate"], BaseModule.ObjectLookup["newsletter"],
                                        BaseModule.ObjectLookup["txtEmail"], BaseModule.DataLookup["email"],
                                        BaseModule.ObjectLookup["befindDeals"]);
                                    searchByDateModule.GetSearchByDatePage().BookingEngineReSearch(context, BaseModule.ObjectLookup["Flights"],
                                        BaseModule.ObjectLookup["beFromDate"],
                                        BaseModule.DataLookup["fromDate"], BaseModule.ObjectLookup["beToDate"],
                                        BaseModule.DataLookup["toDate"],BaseModule.ObjectLookup["newsletter"],
                                        BaseModule.ObjectLookup["txtEmail"], BaseModule.DataLookup["email"],
                                        BaseModule.ObjectLookup["befindDeals"]);
                                  
                                }
                                finally
                                {
                                   if (context != null){Utility.Cleanup(context);}
                                     
                                }
                            }

                            [Test]
                            public void TestSearchOneWay()
                            {

                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                try
                                {

                                    context = Drivercontext.Create("SearchOneWaytests", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    SearchByDateModule searchByDateModule = new SearchByDateModule();
                                    Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);
                                     
                                    searchByDateModule.GetSearchByDatePage().OnewaySearch(context, BaseModule.ObjectLookup["ticketType"], 
                                        BaseModule.ObjectLookup["beSource"], BaseModule.DataLookup["fromSource"], BaseModule.ObjectLookup["beDestination"], 
                                        BaseModule.DataLookup["changeDestinationData"], BaseModule.ObjectLookup["beFromDate"], 
                                        BaseModule.DataLookup["fromDate"], BaseModule.ObjectLookup["beToDate"], BaseModule.DataLookup["toDate"], 
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
                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                              try
                                {

                                    context = Drivercontext.Create("NLSignup", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    SearchByDateModule searchByDateModule = new SearchByDateModule();
                                    Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);
                                     
                                    searchByDateModule.GetSearchByDatePage().NLSignup(context,BaseModule.ObjectLookup["FlightsnHotels"], 
                                        BaseModule.ObjectLookup["beSource"], BaseModule.DataLookup["fromSource"], 
                                        BaseModule.ObjectLookup["beDestination"], BaseModule.DataLookup["changeDestinationData"], 
                                        BaseModule.ObjectLookup["beFromDate"], BaseModule.DataLookup["fromDate"], 
                                        BaseModule.ObjectLookup["beToDate"], BaseModule.DataLookup["toDate"], BaseModule.ObjectLookup["newsletter"], 
                                        BaseModule.ObjectLookup["txtEmail"], BaseModule.DataLookup["email"], BaseModule.ObjectLookup["befindDeals"]);
                                   
                              }
                               finally
                                {
                                   if (context != null){Utility.Cleanup(context);}
                                     
                                } 
                            }

                            

                            // this test needs dev fix 
                            
                            public void TestSearchByBusinessClass() 
                            {

                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                              /*  try
                                { */

                                context = Drivercontext.Create("BusinessClassSearch", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    SearchByDateModule searchByDateModule = new SearchByDateModule();
                                    Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);
                                     
                                    searchByDateModule.GetSearchByDatePage().BusinessClassSearch(context, BaseModule.ObjectLookup["beSource"], BaseModule.DataLookup["fromSource"], BaseModule.ObjectLookup["beDestination"], BaseModule.DataLookup["changeDestinationData"], BaseModule.ObjectLookup["beFromDate"], BaseModule.DataLookup["fromDate"], BaseModule.ObjectLookup["beToDate"], BaseModule.DataLookup["toDate"],BaseModule.ObjectLookup["befindDeals"]);
                                     
                                   if (context != null){Utility.Cleanup(context);}
                             /*   }
                                finally
                                {
                                   if (context != null){Utility.Cleanup(context);}
                                     
                                } */
                            
                            }


                            [Test]
                            public void TestSearchNoDepartDate() 
                            {
                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                               try
                                {
                                    context = Drivercontext.Create("NoDateSearch", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    SearchByDateModule searchByDateModule = new SearchByDateModule();
                                    Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);
                                    searchByDateModule.GetSearchByDatePage().NodateDeparture(context, BaseModule.DataLookup["fromSource"], BaseModule.DataLookup["toDate"]);
                                   
                                }
                                finally
                                {
                                   if (context != null){Utility.Cleanup(context);}     
                                }
                         
                            }


                            [Test]
                            public void TestSearchNoReturnDate() 
                            {
                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                try
                                {
                                    context = Drivercontext.Create("NoDateSearch", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    SearchByDateModule searchByDateModule = new SearchByDateModule();
                                    Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);
                                    searchByDateModule.GetSearchByDatePage().NodateReturn(context, BaseModule.DataLookup["fromSource"], BaseModule.DataLookup["fromDate"]);
                                   
                                }
                                finally
                                {
                                   if (context != null){Utility.Cleanup(context);}
                                }
                            
                            }


                            [Test]
                            public void TestSearchNoDeparture() 
                            {

                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                        try
                                        {
                                            context = Drivercontext.Create("NoDateSearch", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                            SearchByDateModule searchByDateModule = new SearchByDateModule();
                                            Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);
                                            searchByDateModule.GetSearchByDatePage().NoDepartPoint(context,BaseModule.DataLookup["fromDate"], BaseModule.DataLookup["toDate"]);
                                           
                                        }
                                        finally
                                        {
                                           if (context != null){Utility.Cleanup(context);}
                                        }
                            
                            
                            }


                            [Test]
                            public void TestSearchNoReturn() 
                            {

                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                        try
                                        {
                                            context = Drivercontext.Create("NoDateSearch", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                                    SearchByDateModule searchByDateModule = new SearchByDateModule();
                                                    Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);
                                                    searchByDateModule.GetSearchByDatePage().NoReturnPoint(context,BaseModule.DataLookup["fromSource"],BaseModule.DataLookup["fromDate"], BaseModule.DataLookup["toDate"]);
                                                
                                        }
                                        finally
                                        {
                                           if (context != null){Utility.Cleanup(context);}
                                        }
                            
                            }


                            [Test]
                            public void TestHotelsOnly()
                            {

                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                                try
                                {

                                    context = Drivercontext.Create("searchByIATAtests", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    SearchByDateModule searchByDateModule = new SearchByDateModule();
                                    Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);
                                    searchByDateModule.GetSearchByDatePage().HotelsOnly(context, BaseModule.ObjectLookup["Hotels"],
                                        BaseModule.ObjectLookup["beDestination"], BaseModule.DataLookup["toDestinationAnywhere"],
                                        BaseModule.ObjectLookup["beFromDate"], BaseModule.DataLookup["fromDateUS"], BaseModule.ObjectLookup["beToDate"],
                                        BaseModule.DataLookup["toDateUS"], BaseModule.ObjectLookup["newsletter"],
                                        BaseModule.ObjectLookup["befindDeals"]);
                                    Utility.TakeScreenShot(context, "HotelsSearch");

                                }
                                finally
                                {
                                    if (context != null) { Utility.Cleanup(context); }

                                }

                            }



                            [Test]
                            public void TestCarsOnly()
                            {

                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                                try
                                {

                                    context = Drivercontext.Create("searchByIATAtests", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    SearchByDateModule searchByDateModule = new SearchByDateModule();
                                    Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);
                                    searchByDateModule.GetSearchByDatePage().CarOnly(context, BaseModule.ObjectLookup["Car"],
                                        BaseModule.ObjectLookup["beDestination"], BaseModule.DataLookup["toDestinationAnywhere"],
                                        BaseModule.ObjectLookup["beFromDate"], BaseModule.DataLookup["fromDateUS"], BaseModule.ObjectLookup["beToDate"],
                                        BaseModule.DataLookup["toDateUS"], BaseModule.ObjectLookup["newsletter"],
                                        BaseModule.ObjectLookup["txtEmail"], BaseModule.DataLookup["email"],
                                        BaseModule.ObjectLookup["befindDeals"]);
                                    Utility.TakeScreenShot(context, "CarsSearch");

                                }
                                finally
                                {
                                    if (context != null) { Utility.Cleanup(context); }

                                }

                            }


                            [Test]
                            public void TestSearchFuzzySpellings()
                            {

                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                                try
                                {
                                    context = Drivercontext.Create("NoDateSearch", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    SearchByDateModule searchByDateModule = new SearchByDateModule();
                                    Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);
                                    searchByDateModule.GetSearchByDatePage().ProductTypeSearch(context, BaseModule.ObjectLookup["FlightsnHotels"],
                                BaseModule.ObjectLookup["beSource"], BaseModule.DataLookup["FuzzySource"],
                                BaseModule.ObjectLookup["beDestination"], BaseModule.DataLookup["FuzzyDestination"],
                                BaseModule.ObjectLookup["beFromDate"],
                                BaseModule.DataLookup["fromDateUS"], BaseModule.ObjectLookup["beToDate"], BaseModule.DataLookup["toDateUS"],
                                BaseModule.ObjectLookup["newsletter"],
                                BaseModule.ObjectLookup["txtEmail"], BaseModule.DataLookup["email"],
                                BaseModule.ObjectLookup["befindDeals"]);
                                }
                                finally
                                {
                                    if (context != null) { Utility.Cleanup(context); }
                                }

                            }


 
                    

    }
}
