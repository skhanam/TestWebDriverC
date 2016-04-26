using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

using TestWebDriver.com.cf.webdriver.src.Common;
using TestWebDriver.com.cf.webdriver.src.ModuleObject;
using TestWebDriver.com.cf.webdriver.src.PageObject;
using OpenQA.Selenium;
using System.Configuration;


namespace TestWebDriver.com.cf.webdriver.src.RegressionUSTests
{
    [TestFixture]
    [Category("Regression")]
    public class BeInspiredTest
    {


                [SetUp]
                public void TestSetUp()
                {
                    //do nothing
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
                        Utility.SwitchMainTabs(context,BaseModule.ObjectLookup["inspired"]);
                        beInspiredModule.GetBeInspiredPage().BeInspiredSearch(context, BaseModule.ObjectLookup["beaches"], BaseModule.DataLookup["toDestination"]);
                     }finally
                    {
                           if (context != null){Utility.Cleanup(context);}
                    } 
                }

                               

                [Test]
                public void TestSearchByNoDeparture() 
                {

                    Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                    try 
                    {

                        BaseModule baseModule = new BaseModule();
                        context = Drivercontext.Create("beInspiredSearch", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                        BeInspiredModule beInspiredModule = new BeInspiredModule();
                        Utility.SwitchMainTabs(context,BaseModule.ObjectLookup["inspired"]);
                        beInspiredModule.GetBeInspiredPage().WithoutDeparture(context);
                    }finally{

                       if (context != null){Utility.Cleanup(context);}
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
                        Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["inspired"]);
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
                        context = Drivercontext.Create("HomePageTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                        HomeModule homeModule = new HomeModule();
                        Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["inspired"]);
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
                        context = Drivercontext.Create("InspireMeTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                        HomeModule homeModule = new HomeModule();
                        Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["inspired"]);
                        homeModule.GetHomepage().FollowUS(context, BaseModule.ObjectLookup["gplusUI"]);
                    }
                    finally
                    {
                       if (context != null){Utility.Cleanup(context);}

                    }
                }


                [Test]
                public void TestCheckForOptionsAvailable() 
                {
                    Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                    try 
                    {
                        context = Drivercontext.Create("InspireMeTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                        BeInspiredModule beInspiredModule = new BeInspiredModule();
                        Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["inspired"]);
                        beInspiredModule.GetBeInspiredPage().GetAllWhenOptions(context);
                        
                    }finally
                    {

                       if (context != null){Utility.Cleanup(context);}
                    
                    }
                
                }

                

                [Test]
                public void TestValidateBinspiredPageExists()
                {
                    Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];

                    try
                    {
                        context = Drivercontext.Create("InpireMeTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                        BeInspiredModule beInspiredModule = new BeInspiredModule();
                        Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["inspired"]);
                        beInspiredModule.GetBeInspiredPage().GetHeader(context);
                       
                    }
                   finally
                    {
                       if (context != null){Utility.Cleanup(context);}
                    }
                
                }



                [Test]
                public void TestWhatOptionsAvailable()
                {
                    Drivercontext context = null;
                    string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                    try
                    {
                        context = Drivercontext.Create("InspireMeTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                        BeInspiredModule beInspiredModule = new BeInspiredModule();
                        Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["inspired"]);
                        beInspiredModule.GetBeInspiredPage().GetWhatOptions(context);
                    }
                    finally
                    {
                       if (context != null){Utility.Cleanup(context);}
                        
                    } 
                }



                [Test]
                public void TestCookiedData() 
                {

                    Drivercontext context = null;
                    string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["USwebsiteurl"];
                    try
                    {
                        context = Drivercontext.Create("InspiredCookiedTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                        BeInspiredModule beInspiredModule = new BeInspiredModule();
                        beInspiredModule.GetBeInspiredPage().DealspageCookie(context);
                    }
                    finally
                    {
                       if (context != null){Utility.Cleanup(context);}
                    
                    } 
                
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

    }
}
