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
    public class FlightDealsTest
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
                    public void TestFlightdeals()
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                            try {
                                context = Drivercontext.Create("FlightDealsTest", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    FlightDealsModule flightDealsModule = new FlightDealsModule();
                                    
                                    flightDealsModule.GetFlightdealsPage().SearchFlightDeals(context, BaseModule.DataLookup["fromSource"],
                                        BaseModule.DataLookup["toDestination"] , BaseModule.DataLookup["fromDate"], BaseModule.DataLookup["toDate"]);
                                   
                                 }
                            finally
                            {
                               if (context != null){Utility.Cleanup(context);}
                            }

                    }

                    [Test]
                    public void TestFollowusFacebook() 
                    {

                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                        try {
                            context = Drivercontext.Create("FlightDealsTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    HomeModule homeModule = new HomeModule();
                                    Utility.popUp(context, BaseModule.ObjectLookup["nlsignupbtn"], BaseModule.ObjectLookup["nlsignupemailtxt"], BaseModule.DataLookup["email"],
                                BaseModule.ObjectLookup["nlsignuppostcodetxt"], BaseModule.DataLookup["postcode"], BaseModule.ObjectLookup["nlsubmitsignup"]);

                                    Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["flightdeals"]);
                                    homeModule.GetHomepage().FollowUS(context, BaseModule.ObjectLookup["faceBookUI"]);
                                   
                         }finally
                        {
                           if (context != null){Utility.Cleanup(context);}
                        
                        }
        
                    }


                    [Test]
                    public void TestFollowusTwitter()
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                        try {
                            context = Drivercontext.Create("FlightDealsTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                HomeModule homeModule = new HomeModule();
                                Utility.popUp(context, BaseModule.ObjectLookup["nlsignupbtn"], BaseModule.ObjectLookup["nlsignupemailtxt"], BaseModule.DataLookup["email"],
                                BaseModule.ObjectLookup["nlsignuppostcodetxt"], BaseModule.DataLookup["postcode"], BaseModule.ObjectLookup["nlsubmitsignup"]);
                                Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["flightdeals"]);
                                homeModule.GetHomepage().FollowUS(context, BaseModule.ObjectLookup["twitterUI"]);
                              
                                 }finally
                                {
                                   if (context != null){Utility.Cleanup(context);}
                        
                          }
                    }

                    [Test]
                    public void TestFollowusGPlus()
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                        try
                        {
                            context = Drivercontext.Create("FlightDealsTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                HomeModule homeModule = new HomeModule();
                                Utility.popUp(context, BaseModule.ObjectLookup["nlsignupbtn"], BaseModule.ObjectLookup["nlsignupemailtxt"], BaseModule.DataLookup["email"],
                                BaseModule.ObjectLookup["nlsignuppostcodetxt"], BaseModule.DataLookup["postcode"], BaseModule.ObjectLookup["nlsubmitsignup"]);
                                Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["flightdeals"]);
                                homeModule.GetHomepage().FollowUS(context, BaseModule.ObjectLookup["gplusUI"]);
                                
                                 }finally{
                                   if (context != null){Utility.Cleanup(context);}
                        
                        }
                    }


                

                    [Test]
                    public void TestflightDealsTab()
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                        try 
                        {
                            context = Drivercontext.Create("FlightDealsTest", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    FlightDealsModule flightDealsModule = new FlightDealsModule();
                                    Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["flightdeals"]);
                                    Utility.TakeScreenShot(context, "FlightDealsPage");
                            
                        }finally
                        {
                           if (context != null){Utility.Cleanup(context);}
                            
                        }
                    
                    }



                    [Test]
                    public void TestfightDealsModule() 
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                try 
                                {
                                    context = Drivercontext.Create("FlightDealsTest", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                            FlightDealsModule flightDealsModule = new FlightDealsModule();
                                            Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["flightdeals"]);
                                             
                                            flightDealsModule.GetFlightdealsPage().SearchModule(context);
                                            flightDealsModule.GetFlightdealsPage().SocialMediaModule(context);
                                            flightDealsModule.GetFlightdealsPage().TopDestinations(context);
                                            flightDealsModule.GetFlightdealsPage().ContentModule(context);
                                            flightDealsModule.GetFlightdealsPage().OtherDestinations(context);
                                            flightDealsModule.GetFlightdealsPage().HandpickedDeals(context);
                                            Utility.TakeScreenShot(context, "FlightDealsModules");
                                           
                                
                                }finally
                                {
                                   if (context != null){Utility.Cleanup(context);}
                                
                                }
                    
                    }



                    [Test]
                    public void TestFlightDealsFixed() 
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                   try 
                                    {
                                        context = Drivercontext.Create("FlightDealFixedSearch", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                        FlightDealsModule flightModule = new FlightDealsModule();
                                        flightModule.GetFlightdealsPage().FixedSearch(context,BaseModule.DataLookup["fromSourceIATA"], BaseModule.DataLookup["toDestinationIATA"],BaseModule.DataLookup["fromDate"], BaseModule.DataLookup["toDate"]);
                                      
                                   }finally
                                    {

                                       if (context != null){Utility.Cleanup(context);}
                                    } 
                    
                    }



                    [Test]
                    public void TestFlightDealsTopDestination() 
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                        try {
                            context = Drivercontext.Create("FlightdealsTopDestinations", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                FlightDealsModule flightModule = new FlightDealsModule();
                                flightModule.GetFlightdealsPage().TopDestinationModule(context);
                        
                        }
                        finally {
                           if (context != null){Utility.Cleanup(context);}
                        }
                    }


                    [Test]
                    //[Ignore]
                    //Selenium fix needed for this
                    public void TestFlightDealsOtherDestinations() 
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                            try {
                                context = Drivercontext.Create("FlightdealsOtherDestinations", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    FlightDealsModule flightModule = new FlightDealsModule();
                                    flightModule.GetFlightdealsPage().OtherdestinationsModule(context);

                            }
                            finally {
                               if (context != null){Utility.Cleanup(context);}
                            }

                    
                    }


                    [Test]
                    public void TestFlightDealsContentModule() 
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                try
                                {
                                    context = Drivercontext.Create("FDContentModule", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    FlightDealsModule flightModule = new FlightDealsModule();
                                    flightModule.GetFlightdealsPage().ContentmoduleFD(context);
                                  }
                                finally { 
                                   if (context != null){Utility.Cleanup(context);}
                                }
                                 
                    
                    }

                    [Test]
                    public void TestSocialMediaModuleFB() 
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                        try {
                            context = Drivercontext.Create("FDSocialMedia", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                FlightDealsModule flightModule = new FlightDealsModule();
                                flightModule.GetFlightdealsPage().SocialMediaModuleFD(context, "Like Cheapflights on facebook");                         
                        }
                        finally 
                        { 
                           if (context != null){Utility.Cleanup(context);} 
                        }
                    
                    }

                    [Test]
                    public void TestSocialMediaModuleTwitter()
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                        try
                        {
                            context = Drivercontext.Create("FDSocialMedia", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            FlightDealsModule flightModule = new FlightDealsModule();
                            flightModule.GetFlightdealsPage().SocialMediaModuleFD(context, "Follow @Cheapflights on Twitter");
                           
                        }
                        finally
                        {
                           if (context != null){Utility.Cleanup(context);}
                        }

                    }


                    [Test]
                    public void TestSocialMediaModuleGplus()
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                        try
                        {
                            context = Drivercontext.Create("FDSocialMedia", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            FlightDealsModule flightModule = new FlightDealsModule();
                            flightModule.GetFlightdealsPage().SocialMediaModuleFD(context, "Add Cheapflights to G+ circles");

                        }
                        finally
                        {
                           if (context != null){Utility.Cleanup(context);}
                        }

                    }


                    [Test]
                    public void TestSocialMediaModuleNL()
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                        try
                        {
                            context = Drivercontext.Create("FDSocialMedia", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            FlightDealsModule flightModule = new FlightDealsModule();
                            flightModule.GetFlightdealsPage().SocialMediaModuleFD(context, "Subscribe to Cheapflights eNewsletter");

                        }
                        finally
                        {
                           if (context != null){Utility.Cleanup(context);}
                        }

                    }



                    [Test]
                    public void TesthandpickeddealsFD() 
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                            try 
                            {
                                context = Drivercontext.Create("", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                FlightDealsModule flightModule = new FlightDealsModule();
                                flightModule.GetFlightdealsPage().HandpickeddealsModuleFD(context);
                            }
                            finally
                            { 
                               if (context != null){Utility.Cleanup(context);} 
                            }
                    
                    }
                    
    }
}
