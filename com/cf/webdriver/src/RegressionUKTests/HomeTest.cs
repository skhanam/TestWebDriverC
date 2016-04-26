using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TestWebDriver.com.cf.webdriver.src.Common;
using TestWebDriver.com.cf.webdriver.src.ModuleObject;
using System.Configuration;


namespace TestWebDriver.com.cf.webdriver.src.RegressionUKTests
{
    [TestFixture]
    [Category("Regression")]
    public class HomeTest
    {

                    [SetUp]
                    public void TestFixtureSetUp()
                    {
                        //do nothing
                    }
            
        
                    [Test]
                    public void TestSearch()
                    {

                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                        try
                        {

                            context = Drivercontext.Create("homePagetests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            HomeModule homeModule = new HomeModule();
                           // homeModule.GetHomepage().SearchFlexnChangeSearch(context);
                            homeModule.GetHomepage().SearchFixed(context, BaseModule.DataLookup["fromSource"],
                                BaseModule.DataLookup["toDestination"], BaseModule.DataLookup["fromDate"], BaseModule.DataLookup["toDate"]);
                          
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

                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                        try
                        {

                            context = Drivercontext.Create("homePagetests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            HomeModule homeModule = new HomeModule();
                            homeModule.GetHomepage().SearchFlex(context, BaseModule.DataLookup["fromSource"],
                                    BaseModule.DataLookup["toDestination"], BaseModule.ObjectLookup["newsletterHP"]);
                            
                        }
                        finally
                        {
                           if (context != null){Utility.Cleanup(context);}

                        } 

                    }

                    
  
                    [Test]
                    public void TestSearchByNoReturn() 
                    {

                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                    try
                                    {

                                        context = Drivercontext.Create("homePagetests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                        HomeModule homeModule = new HomeModule();
                                       homeModule.GetHomepage().MissingFixedSearchCriteria(context, BaseModule.ObjectLookup["fromSource"], BaseModule.DataLookup["fromSource"], BaseModule.ObjectLookup["fromDate"], BaseModule.DataLookup["fromDate"], BaseModule.ObjectLookup["toDate"], BaseModule.DataLookup["toDate"]);
                                        bool WarningMesgDepature = Utility.IsTextPresent(BaseModule.AssertLookup["destinationWarningHome"], context);
                                                if (WarningMesgDepature.Equals(true))
                                                {
                                                    Utility.TakeScreenShot(context, "SearchWithoutReturnplace");
                                                    Console.WriteLine("Enter Destination to Search");
                                                }
                                              
                                    }
                                    finally
                                    {
                                       if (context != null){Utility.Cleanup(context);}

                                    }
        
                    }



                    [Test]
                    public void TestSearchByNoDeparture() 
                    {

                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
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
                                                    Utility.TakeScreenShot(context,"SearchWithoutDestinationPlace");
                                                    Console.WriteLine("Enter Destination to Search");
                                                }
                                              
                                    }
                                    finally
                                    {
                                       if (context != null){Utility.Cleanup(context);}

                                    }
                    }


                    [Test]
                    public void TestSearchByNoReturnDate() 
                    {

                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                    try
                                    {

                                        context = Drivercontext.Create("homePagetests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                        HomeModule homeModule = new HomeModule();
                                        //Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Home"]);
                                        //Utility.popUp(context, BaseModule.DataLookup["email"], BaseModule.DataLookup["postcode"]);
                                        homeModule.GetHomepage().MissingFixedSearchCriteria(context,BaseModule.ObjectLookup["fromSource"], BaseModule.DataLookup["fromSource"],BaseModule.ObjectLookup["toDestination"], BaseModule.DataLookup["toDestination"], BaseModule.ObjectLookup["fromDate"], BaseModule.DataLookup["fromDate"]);
                                        bool WarningMesgDepature = Utility.IsTextPresent(BaseModule.AssertLookup["dateWarningReturn"], context);
                                                if (WarningMesgDepature.Equals(true))
                                                {
                                                    Utility.TakeScreenShot(context, "SearchWithoutReturnDate");
                                                    Console.WriteLine("Enter Return date to Search");
                                                }
                                           
                                    }
                                    finally
                                    {
                                       if (context != null){Utility.Cleanup(context);}

                                    }
        
                    }


                    [Test]
                    public void TestSearchByNoDepartDate() 
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                try
                                {

                                    context = Drivercontext.Create("homePagetests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    HomeModule homeModule = new HomeModule();
                                    //Utility.popUp(context,BaseModule.DataLookup["email"],BaseModule.DataLookup["postcode"]);
                                    //Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Home"]);
                                    homeModule.GetHomepage().MissingFixedSearchCriteria(context, BaseModule.ObjectLookup["fromSource"], BaseModule.DataLookup["fromSource"], BaseModule.ObjectLookup["toDestination"], BaseModule.DataLookup["toDestination"], BaseModule.ObjectLookup["toDate"], BaseModule.DataLookup["toDate"]);
                                    bool WarningMesgDepature = Utility.IsTextPresent(BaseModule.AssertLookup["dateWarningDeparture"], context);
                                        if (WarningMesgDepature.Equals(true))
                                        {
                                            Utility.TakeScreenShot(context, "SearchWithoutDepartDate");
                                            Console.WriteLine("Enter Depart date  to Search");
                                        }
                                  
                                }
                                finally
                                {
                                   if (context != null){Utility.Cleanup(context);}

                                }
        
                      }

                    [Test]
                    [Ignore]
                    //Selenium fix needed for this
                    public void TestContinentMap() 
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                try
                                {
                                    context = Drivercontext.Create("HomePageTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    HomeModule homeModule = new HomeModule();
                                    homeModule.GetHomepage().ContinentSearch(context, BaseModule.DataLookup["toDestinationContinent"]);
                                }
                                finally
                                {

                                   if (context != null){Utility.Cleanup(context);}
                                }
                             
                    }

                    [Test]
                    public void TestAlternateDealsPage() 
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                        try
                                        {
                                            context = Drivercontext.Create("HomePageTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                            HomeModule homeModule = new HomeModule();
                                            homeModule.GetHomepage().SearchFlex(context, BaseModule.DataLookup["sourceAlternateDeals"],
                                                BaseModule.DataLookup["destinationAlternateDeals"], BaseModule.ObjectLookup["newsletterHP"]);
                                            homeModule.GetHomepage().GetMetaName(context);
                                            homeModule.GetHomepage().ValidateWarningMessage(context);
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
                                            try
                                            {
                                                context = Drivercontext.Create("HomePageTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                                HomeModule homeModule = new HomeModule();
                                                Utility.popUp(context, BaseModule.ObjectLookup["nlsignupbtn"], BaseModule.ObjectLookup["nlsignupemailtxt"], BaseModule.DataLookup["email"],
                                BaseModule.ObjectLookup["nlsignuppostcodetxt"], BaseModule.DataLookup["postcode"], BaseModule.ObjectLookup["nlsubmitsignup"]);
                                                homeModule.GetHomepage().FollowUS(context, BaseModule.ObjectLookup["faceBookUI"]);
                                               
                                            }finally{
                                               if (context != null){Utility.Cleanup(context);}
                        
                                            }
                                }

                                [Test]
                                public void TestFollowusTwitter()
                                {
                                    Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                             try
                                            {
                                                context = Drivercontext.Create("HomePageTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                                        HomeModule homeModule = new HomeModule();
                                                        Utility.popUp(context, BaseModule.ObjectLookup["nlsignupbtn"], BaseModule.ObjectLookup["nlsignupemailtxt"], BaseModule.DataLookup["email"],
                                BaseModule.ObjectLookup["nlsignuppostcodetxt"], BaseModule.DataLookup["postcode"], BaseModule.ObjectLookup["nlsubmitsignup"]);
                                                        homeModule.GetHomepage().FollowUS(context, BaseModule.ObjectLookup["twitterUI"]);
                                                    
                                                  }finally{
                                               if (context != null){Utility.Cleanup(context);}
                        
                                            }
                                }

                                [Test]
                                public void TestFollowusGPlus()
                                {

                                    Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
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
                                                    if (context != null){Utility.Cleanup(context);}

                                                 }
                               }

                    
                                [Test]
                                public void Testtabs() 
                                {
                                    Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                           try
                                                        {

                                                            context = Drivercontext.Create("HomePageTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                                            //Utility.popUp(context,BaseModule.DataLookup["email"],BaseModule.DataLookup["postcode"]);
                                                            Utility.popUp(context, BaseModule.ObjectLookup["nlsignupbtn"], BaseModule.ObjectLookup["nlsignupemailtxt"], BaseModule.DataLookup["email"], BaseModule.ObjectLookup["nlsignuppostcodetxt"], 
                                                                BaseModule.DataLookup["postcode"], BaseModule.ObjectLookup["nlsubmitsignup"]);
                                                            Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["flightdeals"]);
                                                            Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);
                                                            Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Staff"]);
                                                            Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["inspired"]);
                                                            Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["knowhow"]);
                                                            Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Newsletter"]);
                                                        }
                                                        finally
                                                        {

                                                           if (context != null){Utility.Cleanup(context);}

                                                        }
                                          
                    
                                }


                                [Test]
                           
                                public void TestAgentDetails() 
                                {
                                    Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                            try 
                                            {
                                                context = Drivercontext.Create("HomeFooterTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                                HomeModule homeModule = new HomeModule();
                                                homeModule.GetHomepage().GetAgentDetails(context,"C");
                                             

                                            }
                                            finally
                                            {
                                               if (context != null){Utility.Cleanup(context);}
                        
                                            }
                                }



                                [Test]
                                public void TestValidateWarningMessage() 
                                {
                                    Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
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
                                    Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                            try
                                            {
                                                context = Drivercontext.Create("HomeBEnGuideExistsTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                                HomeModule homeModule = new HomeModule();
                                                homeModule.GetHomepage().SearchFlex(context, BaseModule.DataLookup["sourceAlternateDeals"],
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
                                    Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
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

                                    Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
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
                                    Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
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
                                    Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
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

        //Selenium fix needed - This is intermittent

                                [Test]
                                public void TestHomeTravelTips() 
                                {
                                    Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                    try {
                                        context = Drivercontext.Create("HomeTravelTips", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                                HomeModule homeModule = new HomeModule();
                                                Utility.GoToURL(context, "Travel tips");
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
                                    Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
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
                                    Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
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
                                //[Ignore]
                                //Selenium fix needed for this
                                 public void TestEditorsPick()
                                 {
                                     Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];

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
