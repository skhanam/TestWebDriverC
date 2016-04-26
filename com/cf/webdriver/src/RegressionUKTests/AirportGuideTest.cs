using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using TestWebDriver.com.cf.webdriver.src.PageObject;
using TestWebDriver.com.cf.webdriver.src.ModuleObject;
using TestWebDriver.com.cf.webdriver.src.Common;
using System.Configuration;


namespace TestWebDriver.com.cf.webdriver.src.RegressionUKTests
{
    [TestFixture]
    [Category("Regression")]

    public class AirportGuideTest
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
                       
                        public void TestAirportGuideIndex()
                        {
                                Drivercontext context = null;
                                string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                //String websiteurl;
                                try {
                                            BaseModule basemodule = new BaseModule();
                                            context = Drivercontext.Create("AirportGuideTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                            AirportGuideModule airportguidemodule = new AirportGuideModule();
                                            airportguidemodule.GetAirportGuidePage().AirportGuideIndex(context);
                                }
                                finally {
                                           if (context != null){Utility.Cleanup(context);}
                                }
                        }


                        [Test]
                      
                        public void TestAirportGuideSearch() 
                        {
                            Drivercontext context = null;
                            string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                            try {
                                    BaseModule basemodule = new BaseModule();
                                    context = Drivercontext.Create("AirportGuideSearchTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    AirportGuideModule airportguidemodule = new AirportGuideModule();
                                    airportguidemodule.GetAirportGuidePage().AirportGuideIndex(context);
                                    airportguidemodule.GetAirportGuidePage().AGSearch(context);
                            }
                            finally {

                               if (context != null){Utility.Cleanup(context);}
                            }
        
                        }


                        [Test]
                        public void TestAGMiniBEEngine() 
                        {
                                Drivercontext context = null;
                                string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                try
                                {
                                    BaseModule basemodule = new BaseModule();
                                    context = Drivercontext.Create("AirportGuideBE", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    TravelGuideModule travelguidemodule = new TravelGuideModule();
                                    //airportguidemodule.GetAirportGuidePage().AirportGuideIndex(context);
                                    travelguidemodule.getTravelguidepage().MiniBookingEngine(context, BaseModule.ObjectLookup["AirportGuide"]);

                                }
                                finally {
                                   if (context != null){Utility.Cleanup(context);}
                                }
                        }


                            [Test]
                           
                            public void TestAGPoplarAirports() 
                            {
                                    Drivercontext context = null;
                                    string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                    try {
                                                BaseModule basemodule = new BaseModule();
                                                context = Drivercontext.Create("AGPoplarlinks", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                                AirportGuideModule airportModule = new AirportGuideModule();
                                                airportModule.GetAirportGuidePage().AGPoplarAirports(context);
                
                                    }
                                    finally {

                                       if (context != null){Utility.Cleanup(context);}
                                    }
        
                            }

                            [Test]
                           
                           public void TestAGTravelTipModule() 
                            {
                                        Drivercontext context = null;
                                        string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                        try {

                                                    BaseModule basemodule = new BaseModule();
                                                    context = Drivercontext.Create("AGTravelTips", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                                    TravelGuideModule travelmodule = new TravelGuideModule();
                                                    travelmodule.getTravelguidepage().TravelTip(context, 
                                                        BaseModule.ObjectLookup["AirportGuide"],
                                                        BaseModule.ObjectLookup["traveltipmoduleAG"]);
                                        }
                                        finally { 
                                           if (context != null){Utility.Cleanup(context);} 
                                         }
        
                            }

                          [Test]
                        
                          public void TestAGUsefulLinksModule()
                          {
                                Drivercontext context = null;
                                string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                try
                                {

                                    BaseModule basemodule = new BaseModule();
                                    context = Drivercontext.Create("AGUsefulLinks", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    TravelGuideModule travelguidemodule = new TravelGuideModule();
                                    Utility.GoToURL(context,BaseModule.ObjectLookup["AirportGuide"]);
                                    travelguidemodule.getTravelguidepage().TravelGuideUsefulLinks(context, BaseModule.ObjectLookup["usefullinkleftmoduleAG"],
                                        BaseModule.ObjectLookup["AirportGuide"]);
                                    travelguidemodule.getTravelguidepage().TravelGuideUsefulLinks(context, BaseModule.ObjectLookup["usefullinkrightmoduleAG"],
                                        BaseModule.ObjectLookup["AirportGuide"]);
                                }
                                finally {
                                   if (context != null){Utility.Cleanup(context);}
                                }
                          }

                          [Test]
                    
                          public void TestAGFlightnewsModule() 
                          {
                              Drivercontext context = null;
                              string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                              try {
                                        BaseModule basemodule = new BaseModule();
                                        context = Drivercontext.Create("AGFlightnews", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                        AirportGuideModule airportmodule = new AirportGuideModule();
                                        airportmodule.GetAirportGuidePage().AGFlightnews(context, BaseModule.ObjectLookup["AirportGuide"]);
          
                              }
                              finally {
                                 if (context != null){Utility.Cleanup(context);}
                              }
      
                          }



                          [Test]
                          public void TestAirportContents() 
                          {
                              Drivercontext context = null;
                              string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                              try {
                                        BaseModule basemodule = new BaseModule();
                                        context = Drivercontext.Create("AGContents", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                        AirportGuideModule airportmodule = new AirportGuideModule();
                                        airportmodule.GetAirportGuidePage().AGDisplayContents(context);

                              }
                              finally 
                              {
                                  if (context != null) { Utility.Cleanup(context); }
                              }
                          
                          }


                          [Test]
                          public void TestAGFlightguide() 
                          {
                              Drivercontext context = null;
                              string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                              try {
                                  BaseModule basemodule = new BaseModule();
                                  context = Drivercontext.Create("AGContents", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                  AirportGuideModule airportmodule = new AirportGuideModule();
                                  airportmodule.GetAirportGuidePage().AGFlightguide(context);
                              }
                              finally {
                                  if (context != null) { Utility.Cleanup(context); }
                              }
                          
                          }


                          [Test]
                          public void TestAGCountrySearch() 
                          {

                              Drivercontext context = null;
                              string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                              try {
                                  BaseModule basemodule = new BaseModule();
                                  context = Drivercontext.Create("AGContents", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                  AirportGuideModule airportmodule = new AirportGuideModule();
                                  airportmodule.GetAirportGuidePage().AirportGuideIndex(context);
                                  airportmodule.GetAirportGuidePage().AGcontents(context, BaseModule.ObjectLookup["agcountry"]);
                                  airportmodule.GetAirportGuidePage().AGSearch(context);
                              }
                              finally {
                                  if (context != null) { Utility.Cleanup(context); }
                              }
                          
                          }


                          [Test]
                          public void TestAGCitySearch() 
                          {
                              Drivercontext context = null;
                              string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                              try {
                                          BaseModule basemodule = new BaseModule();
                                          context = Drivercontext.Create("AGContents", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                          AirportGuideModule airportmodule = new AirportGuideModule();
                                          airportmodule.GetAirportGuidePage().AirportGuideIndex(context);
                                          airportmodule.GetAirportGuidePage().AGcontents(context, BaseModule.ObjectLookup["agcountry"]);
                                          airportmodule.GetAirportGuidePage().AGcontents(context, BaseModule.ObjectLookup["agcity"]);
                                          airportmodule.GetAirportGuidePage().AGSearch(context);
                                          
                              }
                              finally {

                                  if (context != null) { Utility.Cleanup(context); }
                              }
                          
                          }

                            
                          [Test]
                          public void TestAGMiniBECity() 
                          {
                                     Drivercontext context = null;
                                     string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                              try {
                                          BaseModule basemodule = new BaseModule();
                                          context = Drivercontext.Create("AGContents", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                          AirportGuideModule airportmodule = new AirportGuideModule();
                                          airportmodule.GetAirportGuidePage().AirportGuideIndex(context);
                                          airportmodule.GetAirportGuidePage().AGcontents(context, BaseModule.ObjectLookup["agcountry"]);
                                          airportmodule.GetAirportGuidePage().AGcontents(context, BaseModule.ObjectLookup["agcity"]);
                                          airportmodule.GetAirportGuidePage().AGBookingEngine(context);
                              }
                              finally
                              {

                                  if (context != null) { Utility.Cleanup(context); }
                              }
                          }


                          [Test]
                          public void TestAGMiniBECountry() 
                          {

                              Drivercontext context = null;
                              string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                              try
                              {
                                  BaseModule basemodule = new BaseModule();
                                  context = Drivercontext.Create("AGContents", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                  AirportGuideModule airportmodule = new AirportGuideModule();
                                  airportmodule.GetAirportGuidePage().AirportGuideIndex(context);
                                  airportmodule.GetAirportGuidePage().AGcontents(context, BaseModule.ObjectLookup["agcountry"]);
                                  airportmodule.GetAirportGuidePage().AGFlightguide(context);
                                  airportmodule.GetAirportGuidePage().AGBookingEngine(context);
                              }
                              finally
                              {
                                  if (context != null) { Utility.Cleanup(context); 
                                  }
                              }
                          
                          }

                          [Test]
                          public void TestModulesPresentCity() 
                          {
                              Drivercontext context = null;
                              string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                              try {
                                  BaseModule basemodule = new BaseModule();
                                  context = Drivercontext.Create("AGContents", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                  AirportGuideModule airportmodule = new AirportGuideModule();
                                  airportmodule.GetAirportGuidePage().AirportGuideIndex(context);
                                  airportmodule.GetAirportGuidePage().AGcontents(context, BaseModule.ObjectLookup["agcountry"]);
                                  airportmodule.GetAirportGuidePage().AGcontents(context, BaseModule.ObjectLookup["agcity"]);
                                  airportmodule.GetAirportGuidePage().allmodules(context);
                              }
                              finally {
                                  if (context != null)
                                  {
                                      Utility.Cleanup(context);
                                  }
                              }
                          
                          }

                           
                         [Test]
                          public void TestAllModulesAirportGuide() 
                          {
                              Drivercontext context = null;
                              string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                              try {
                                        BaseModule basemodule = new BaseModule();
                                        context = Drivercontext.Create("AGAllmodules", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                        AirportGuideModule airportmodule = new AirportGuideModule();
                                        airportmodule.GetAirportGuidePage().AirportGuideIndex(context);
                                        airportmodule.GetAirportGuidePage().allmodulesairportguide(context);

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
                         public void TestAGContinent() 
                         {

                             Drivercontext context = null;
                             string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                             try {

                                 BaseModule basemodule = new BaseModule();
                                 context = Drivercontext.Create("AGAllmodules", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                 AirportGuideModule airportmodule = new AirportGuideModule();
                                 airportmodule.GetAirportGuidePage().AirportGuideIndex(context);
                                 airportmodule.GetAirportGuidePage().AGcontents(context, BaseModule.ObjectLookup["agcontinent"]);
                                 airportmodule.GetAirportGuidePage().allmodules(context);
                             }
                             finally {

                                 if (context != null)
                                 {
                                     Utility.Cleanup(context);
                                 }
                             }
                         
                         }


                        [Test]
                        public void TestAGMiniBEContinent() 
                        {
                            
                            
                             Drivercontext context = null;
                             string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                             try {
                                        BaseModule basemodule = new BaseModule();
                                        context = Drivercontext.Create("AGAllmodules", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                        AirportGuideModule airportmodule = new AirportGuideModule();
                                        airportmodule.GetAirportGuidePage().AirportGuideIndex(context);
                                        airportmodule.GetAirportGuidePage().AGcontents(context, BaseModule.ObjectLookup["agcontinent"]);
                                        //airportmodule.GetAirportGuidePage().AGFlightguide(context);
                                        airportmodule.GetAirportGuidePage().AGBookingEngine(context);

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
                        public void TestAGtopCountrylinks() 
                        {
                             Drivercontext context = null;
                             string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                             try {
                                        BaseModule basemodule = new BaseModule();
                                        context = Drivercontext.Create("AGAllmodules", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                        AirportGuideModule airportmodule = new AirportGuideModule();
                                        airportmodule.GetAirportGuidePage().AirportGuideIndex(context);
                                        airportmodule.GetAirportGuidePage().AGcontents(context, BaseModule.ObjectLookup["agcontinent"]);
                                        airportmodule.GetAirportGuidePage().getalllinks(context, BaseModule.ObjectLookup["getallinks"]);
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
                        public void TestAGtopCitieslinks() 
                        {
                            Drivercontext context = null;
                            string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                            try
                            {
                                BaseModule basemodule = new BaseModule();
                                context = Drivercontext.Create("AGAllmodules", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                AirportGuideModule airportmodule = new AirportGuideModule();
                                airportmodule.GetAirportGuidePage().AirportGuideIndex(context);
                                airportmodule.GetAirportGuidePage().AGcontents(context, BaseModule.ObjectLookup["agcountry"]);
                                airportmodule.GetAirportGuidePage().getalllinks(context, BaseModule.ObjectLookup["getallcities"]);
                            
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
