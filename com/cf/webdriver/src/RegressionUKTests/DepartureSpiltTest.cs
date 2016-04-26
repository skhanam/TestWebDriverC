using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using TestWebDriver.com.cf.webdriver.src.Common;
using TestWebDriver.com.cf.webdriver.src.ModuleObject;
using System.Configuration;

namespace TestWebDriver.com.cf.webdriver.src.RegressionUKTests
{
    [TestFixture]
    [Category("Regression")]
    public class DepartureSpiltTest
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
                            public void TestDepartureSpiltBeaches()
                            {
                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                try
                                {
                                    context = Drivercontext.Create("HomeDepartureSpiltPage", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    HomeModule homeModule = new HomeModule();
                                    homeModule.GetDepartureSpiltPage().Departurespilt(context, "Alicante");

                                }
                                finally
                                {
                                    if (context != null) { Utility.Cleanup(context); }

                                }

                            }

                            [Test]
                            public void TestDepartureSpiltCity() 
                            {
                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                        try
                                        {
                                            context = Drivercontext.Create("HomeDepartureSpiltPage", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                            HomeModule homeModule = new HomeModule();
                                            homeModule.GetDepartureSpiltPage().Departurespilt(context, "Venice");

                                        }
                                        finally
                                        {
                                            if (context != null) { Utility.Cleanup(context); }

                                        }
                            
                            }

                            [Test]
                            public void TestDepartureSpiltCountry()
                            {
                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                try
                                {
                                    context = Drivercontext.Create("HomeDepartureSpiltPage", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    HomeModule homeModule = new HomeModule();
                                    homeModule.GetDepartureSpiltPage().Departurespilt(context, "Johannesburg");

                                }
                                finally
                                {
                                    if (context != null) { Utility.Cleanup(context); }

                                }
                            }

                            [Test]
                            public void TestDepartureSpiltModules() 
                            {
                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                try
                                {
                                    context = Drivercontext.Create("HomeDepartureSpiltPage", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    HomeModule homeModule = new HomeModule();
                                    homeModule.GetDepartureSpiltPage().DepartureSpiltModules(context, "Alicante");

                                }
                                finally
                                {
                                    if (context != null) { Utility.Cleanup(context); }

                                }    
                            
                            }


                            [Test]
                            public void TestDSSearchFlex() 
                            {
                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                try
                                {
                                    context = Drivercontext.Create("HomeDepartureSpiltPage", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    HomeModule homeModule = new HomeModule();
                                    Utility.GoToURL(context, "Goa");
                                    homeModule.GetDepartureSpiltPage().DSSearchFlex(context);
                                }
                                finally
                                {
                                    if (context != null) { Utility.Cleanup(context); }

                                } 
                            
                            }
                            


                            [Test]
                            //This test os for displaying nl module from the dep spilt page
                            public void TestDSViewNewsLetter() 
                            {
                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                try
                                {
                                    context = Drivercontext.Create("HomeDepartureSpiltPage", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    HomeModule homeModule = new HomeModule();
                                    Utility.GoToURL(context, "Florida");
                                    homeModule.GetDepartureSpiltPage().DSViewNewsLetter(context);
                                }
                                finally
                                {
                                    if (context != null) { Utility.Cleanup(context); }

                                } 
                            
                            }


                            [Test]
                            public void TestDSNewsLetterSignUp() 
                            {
                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                try
                                {
                                    context = Drivercontext.Create("HomeDepartureSpiltPage", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    HomeModule homeModule = new HomeModule();
                                    Utility.GoToURL(context, "Florida");
                                    homeModule.GetDepartureSpiltPage().NewsletterSignup(context);
                                }
                                finally
                                {
                                    if (context != null) { Utility.Cleanup(context); }

                                } 
                            
                            }



                            [Test]
                            public void TestDSAirportModule() 
                            {
                                Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                    try 
                                    {
                                        context = Drivercontext.Create("DepartureSpiltpage", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                        HomeModule homeModule = new HomeModule();
                                        Utility.GoToURL(context, "Florida");
                                        Utility.GoToURL(context, "Heathrow");
                                        string getTitle = context.GetDriver().Title;
                                        System.Console.WriteLine("Get Title !!!"+getTitle);
                                        if (getTitle.Contains("Heathrow")) 
                                        {
                                            Utility.TakeScreenShot(context, "DSAirportlink");
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
