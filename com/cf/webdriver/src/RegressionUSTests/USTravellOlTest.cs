using System;
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
    [Category("Regression")]
    public class USTravellOlTest
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
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                        try
                        {
                            context = Drivercontext.Create("TravellOlTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            HomeModule homeModule = new HomeModule();
                            Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["travel101"]);
                            homeModule.GetHomepage().FollowUS(context, BaseModule.ObjectLookup["faceBookUI"]);
                            
                        }
                        finally
                        {
                           if (context != null){Utility.Cleanup(context);}

                        }
                    }



                    [Test]
                    public void TestFollowusTwitter()
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                        try
                        {
                            context = Drivercontext.Create("TravellOlTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            HomeModule homeModule = new HomeModule();
                            Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["travel101"]);
                            homeModule.GetHomepage().FollowUS(context, BaseModule.ObjectLookup["twitterUI"]);
                            
                        }
                        finally
                        {
                           if (context != null){Utility.Cleanup(context);}

                        }
                    }

                    [Test]
                    public void TestFollowusGPlus()
                    {

                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                        try
                        {
                            context = Drivercontext.Create("TravellOlTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            HomeModule homeModule = new HomeModule();
                            Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["travel101"]);
                            homeModule.GetHomepage().FollowUS(context, BaseModule.ObjectLookup["gplusUI"]);
                            
                        }
                        finally
                        {
                           if (context != null){Utility.Cleanup(context);}

                        }
                    }



                    [Test]
                    public void TestGetAllTitles() 
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                        try
                        {
                            context = Drivercontext.Create("TravellOlTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            TravelKnowHowModule travelknowHowModule = new TravelKnowHowModule();
                            travelknowHowModule.GetTravelknowhowPage().GetAllTitles(context);
                          
                        }finally
                        {

                           if (context != null){Utility.Cleanup(context);}
                        }
                    
                    }

                    [Test]
                    //[Ignore]
                    //This is an extra div for which we cannot proceed further

                    public void TestListArticles() 
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                        try 
                        {
                            context = Drivercontext.Create("TravellOlTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            TravelKnowHowModule travelKnowHowModule = new TravelKnowHowModule();
                            travelKnowHowModule.GetTravelknowhowPage().ClickTitles(context);
                           
                        }finally
                        {
                           if (context != null){Utility.Cleanup(context);}
                        
                        }
                    
                    
                    }


                    [Test]
                    public void TestArticleDisplay() 
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                        try
                        {
                            context = Drivercontext.Create("TravellOlTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            TravelKnowHowModule travelKnowHowModule = new TravelKnowHowModule();
                            travelKnowHowModule.GetTravelknowhowPage().ClickArticle(context);
                           

                        }
                        finally 
                        {
                           if (context != null){Utility.Cleanup(context);}
                        
                        }
                    
                    }



                    [Test]
                    public void TestUseFulLink() 
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                        try 
                        {
                            context = Drivercontext.Create("TravellOlTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            TravelKnowHowModule travelKnowHowModule = new TravelKnowHowModule();
                            travelKnowHowModule.GetTravelknowhowPage().UseFulLinks(context);
                            
                        
                        }finally
                        {
                           if (context != null){Utility.Cleanup(context);}
                        
                        } 

                    
                    }



                    [Test]
                    public void TestModulesUseFulLinks() 
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                        try {
                            context = Drivercontext.Create("TravellOlTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    TravelKnowHowModule travelKnowHowModule = new TravelKnowHowModule();
                                    travelKnowHowModule.GetTravelknowhowPage().ContinentModules(context);
                                    
                                    
                        }
                        finally
                        {
                           if (context != null){Utility.Cleanup(context);}
                        }
                    
                    
                    }

                    [Test]
                    public void TestEurope() 
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                        try 
                        {
                            context = Drivercontext.Create("TravellOlTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            TravelKnowHowModule traveltravel101module = new TravelKnowHowModule();
                            traveltravel101module.GetTravelknowhowPage().ContinentLink(context, BaseModule.DataLookup["continentEurope"]);
                            
                        
                        }finally
                        {
                           if (context != null){Utility.Cleanup(context);}
                        
                        }
                    
                    }




                    [Test]
                    public void TestContinentContents() 
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                        try 
                        {
                            context = Drivercontext.Create("TravellOlTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            TravelKnowHowModule traveltravel101Module = new TravelKnowHowModule();
                            traveltravel101Module.GetTravelknowhowPage().ValidateContinentContents(context, 
                                BaseModule.DataLookup["continentEurope"],BaseModule.ObjectLookup["listCountries"], 
                                BaseModule.AssertLookup["flightGuide"], BaseModule.AssertLookup["cheapflights"]);
                           
                        }finally
                        {
                           if (context != null){Utility.Cleanup(context);}
                        
                        }
                    
                    }




                    [Test]
                     public void TestCountryExists() 
                     {
                         Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                        try
                        {
                            context = Drivercontext.Create("TravellOlTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    TravelKnowHowModule traveltravel101Module = new TravelKnowHowModule();
                                    traveltravel101Module.GetTravelknowhowPage().CountryLink(context, 
                                        BaseModule.DataLookup["countryIreland"], BaseModule.ObjectLookup["listCities"], 
                                        BaseModule.AssertLookup["flightGuideCountry"], BaseModule.AssertLookup["cheapflightsCountry"]);
                                 
                        }
                                          finally
                                          {
                                             if (context != null){Utility.Cleanup(context);}
                                          }
                   }
                    
                    
                    [Test]
                    public void TestCityExists() 
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                        try 
                        {
                            context = Drivercontext.Create("TravellOlTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            TravelKnowHowModule traveltravel101Module = new TravelKnowHowModule();
                            traveltravel101Module.GetTravelknowhowPage().CityLink(context, BaseModule.DataLookup["cityDublin"], 
                                BaseModule.ObjectLookup["listCities"], BaseModule.AssertLookup["flightGuideCity"], 
                                BaseModule.AssertLookup["cheapflightsCity"]);
                            
                        }finally
                        {
                           if (context != null){Utility.Cleanup(context);}
                        }
                    
                    }
                    
    }
}
