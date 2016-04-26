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
    public class StaffPicksTest
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
                                context = Drivercontext.Create("StaffPicksTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                HomeModule homeModule = new HomeModule();
                                Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Staff"]);
                                 
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
                    Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                try
                                {
                                    context = Drivercontext.Create("StaffPicksTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    HomeModule homeModule = new HomeModule();
                                    Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Staff"]);
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

                    Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                try
                                {
                                    context = Drivercontext.Create("StaffPicksTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    HomeModule homeModule = new HomeModule();
                                    Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Staff"]);
                                    homeModule.GetHomepage().FollowUS(context, BaseModule.ObjectLookup["gplusUI"]);
                                    
                                }
                                finally
                                {
                                   if (context != null){Utility.Cleanup(context);}

                                }
                }

                [Test]
                public void TestDisplayHandPickedDeals() 
                {
                    Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                            try 
                            {
                                context = Drivercontext.Create("StaffPicksTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                StaffPicksModule staffPicksModule = new StaffPicksModule();
                                staffPicksModule.GetStaffPicksPage().Handpickdeals(context,BaseModule.ObjectLookup["Staff"]);
                               
                         }
                            finally 
                            {
                               if (context != null){Utility.Cleanup(context);}
                    
                            }
                
                }


                [Test]
                public void TestDisplayDate() 
                {
                    Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                try 
                                {
                                    context = Drivercontext.Create("StaffPicksTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                        StaffPicksModule staffPicks = new StaffPicksModule();
                                        staffPicks.GetStaffPicksPage().CheckDatePosted(context, BaseModule.ObjectLookup["Staff"]);
                                      
                    
                                }finally
                                {
                                   if (context != null){Utility.Cleanup(context);}
                    
                                }
                }


                [Test]
                public void TestDisplayHeader()
                {
                    Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                            try 
                            {
                                context = Drivercontext.Create("StaffPicksTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                        StaffPicksModule staffPicks = new StaffPicksModule();
                                        staffPicks.GetStaffPicksPage().CheckHeader(context, BaseModule.ObjectLookup["Staff"]);
                                       
                            }finally
                            {
                               if (context != null){Utility.Cleanup(context);}
                    
                            }

                }
    }
}
