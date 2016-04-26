using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using TestWebDriver.com.cf.webdriver.src.PageObject;
using TestWebDriver.com.cf.webdriver.src.ModuleObject;
using TestWebDriver.com.cf.webdriver.src.Common;
using OpenQA.Selenium;
using System.Configuration;

namespace TestWebDriver.com.cf.webdriver.src.RegressionUKTests
{
    [TestFixture]
    [Category("Regression")]
    public class TravelGuideTest
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
                        public void TestLandTravelGuide()
                        {

                            Drivercontext context = null;
                            string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                            try
                            {
                                BaseModule baseModule = new BaseModule();
                                context = Drivercontext.Create("TravelGuideTests", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                TravelGuideModule travelGuideModule = new TravelGuideModule();
                                travelGuideModule.getTravelguidepage().NavigatetoTravelGuide(context);
                              
                            }
                            finally
                            {

                               if (context != null){Utility.Cleanup(context);}
                            }

                        }




                        [Test]
                        public void TestTGSearchBox()
                        {
                            Drivercontext context = null;
                            string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                            try {
                                    BaseModule baseModule = new BaseModule();
                                    context = Drivercontext.Create("TravelGuideTests", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    TravelGuideModule travelGuideModule = new TravelGuideModule();
                                    travelGuideModule.getTravelguidepage().TGSearchBox(context);
                                 
                            }finally
                            {
                               if (context != null){Utility.Cleanup(context);}
                            
                            }

                        }


                        [Test]
                        public void TestMiniBookingEngine() 
                        {
                                    Drivercontext context = null;
                                    string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                    try
                                    {
                                        BaseModule baseModule = new BaseModule();
                                        context = Drivercontext.Create("TravelGuideTests", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                        TravelGuideModule travelGuideModule = new TravelGuideModule();
                                        travelGuideModule.getTravelguidepage().MiniBookingEngine(context, BaseModule.ObjectLookup["TravelGuide"]);
                                      
                                    }
                                    finally {
                                       if (context != null){Utility.Cleanup(context);}
                                    }
                        
                        
                        }


                        [Test]
                        [Ignore]
                        //For some reason end up with different existing WebDriver errors - Ignore until it is fixed
                        public void TestContinentNAmerica() 
                        {
                                    Drivercontext context = null;
                                    string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                    try 
                                    {

                                        BaseModule baseModule = new BaseModule();
                                        context = Drivercontext.Create("TravelGuideContinentTest", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                        TravelGuideModule travelGuideModule = new TravelGuideModule();
                                        travelGuideModule.getTravelguidepage().TravelGuideContinent(BaseModule.ObjectLookup["TGNAmerica"], context, BaseModule.AssertLookup["TrvlGuideTitle"]);
                                      
                                    }
                                    finally 
                                    {

                                       if (context != null){Utility.Cleanup(context);}
                                    }
                        
                        
                        
                        }



                        [Test]
                        [Ignore]
                        //Selenium fix needed for this
                        public void TestContinentSAmerica() 
                        {
                                        Drivercontext context = null;
                                        string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                        try
                                        {

                                            BaseModule baseModule = new BaseModule();
                                            context = Drivercontext.Create("TravelGuideContinentTest", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                            TravelGuideModule travelGuideModule = new TravelGuideModule();
                                            travelGuideModule.getTravelguidepage().TravelGuideContinent(BaseModule.ObjectLookup["TGSAmerica"], context, BaseModule.AssertLookup["TrvlGuideTitle"]);
                                           
                                        }
                                        finally
                                        {

                                           if (context != null){Utility.Cleanup(context);}
                                        }
                        
                        
                        }

                        [Test]
                        [Ignore]
                        //For some reason end up with different existing WebDriver errors - Ignore until it is fixed
                        public void TestEurope() 
                        {
                                        Drivercontext context = null;
                                        string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                        try
                                        {

                                            BaseModule baseModule = new BaseModule();
                                            context = Drivercontext.Create("TravelGuideContinentTest", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                            TravelGuideModule travelGuideModule = new TravelGuideModule();
                                            travelGuideModule.getTravelguidepage().TravelGuideContinent(BaseModule.ObjectLookup["TGEurope"], context, BaseModule.AssertLookup["TrvlGuideTitle"]);
                                   }
                                        finally
                                        {

                                           if (context != null){Utility.Cleanup(context);}
                                        }
                        
                        
                        }


                        [Test]
                        [Ignore]
                        //Selenium fix needed for this
                        public void TestAfrica() 
                        {

                                        Drivercontext context = null;
                                        string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                        try
                                        {

                                            BaseModule baseModule = new BaseModule();
                                            context = Drivercontext.Create("TravelGuideContinentTest", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                            TravelGuideModule travelGuideModule = new TravelGuideModule();
                                            travelGuideModule.getTravelguidepage().TravelGuideContinent(BaseModule.ObjectLookup["TGAfrica"], context, BaseModule.AssertLookup["TrvlGuideTitle"]);
                                          }
                                        finally
                                        {

                                           if (context != null){Utility.Cleanup(context);}
                                        }
                        
                        
                        }

                        [Test]
                        [Ignore]
                        //For some reason end up with different existing WebDriver errors - Ignore until it is fixed
                        public void TestAsia() 
                        {
                                        Drivercontext context = null;
                                        string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                        try
                                        {

                                            BaseModule baseModule = new BaseModule();
                                            context = Drivercontext.Create("TravelGuideContinentTest", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                            TravelGuideModule travelGuideModule = new TravelGuideModule();
                                            travelGuideModule.getTravelguidepage().TravelGuideContinent(BaseModule.ObjectLookup["TGAsia"], 
                                                context, BaseModule.AssertLookup["TrvlGuideTitle"]);
                                        
                                        }
                                        finally
                                        {

                                           if (context != null){Utility.Cleanup(context);}
                                        }
                                                
                        }

                        [Test]
                        [Ignore]
                        //For some reason end up with different existing WebDriver errors - Ignore until it is fixed
                        public void TestOceania() 
                        {
                                    Drivercontext context = null;
                                    string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                    try
                                    {

                                        BaseModule baseModule = new BaseModule();
                                        context = Drivercontext.Create("TravelGuideContinentTest", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                        TravelGuideModule travelGuideModule = new TravelGuideModule();
                                        travelGuideModule.getTravelguidepage().TravelGuideContinent(BaseModule.ObjectLookup["TGOceania"], context, BaseModule.AssertLookup["TrvlGuideTitle"]);
                                       
                                    }
                                    finally
                                    {

                                       if (context != null){Utility.Cleanup(context);}
                                    }
                        
                        }



                        [Test]
                        [Ignore]
                        //Selenium fix needed for this
                        public void TestTGTravelTips() 
                        {

                                        Drivercontext context = null;
                                        string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                        try
                                        {

                                            BaseModule baseModule = new BaseModule();
                                            context = Drivercontext.Create("TravelGuideTravelTipTest", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                            TravelGuideModule travelGuideModule = new TravelGuideModule();
                                            travelGuideModule.getTravelguidepage().TravelTip(context, 
                                                BaseModule.ObjectLookup["TravelGuide"], 
                                                BaseModule.ObjectLookup["travelTipModule"]);
                                           
                                        }
                                        finally
                                        {
                                                  if (context != null){Utility.Cleanup(context);}
                                        }
                                
                       }





                        [Test]
                        public void TestTGUsefulLinks() 
                        {

                            Drivercontext context = null;
                            string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                            try 
                            {
                                            BaseModule baseModule = new BaseModule();
                                            context = Drivercontext.Create("TravelGuideUseFulLinkTest", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                            TravelGuideModule travelGuideModule = new TravelGuideModule();
                                            Utility.GoToURL(context, "Travel guides");
                                            travelGuideModule.getTravelguidepage().TravelGuideUsefulLinks(context, BaseModule.ObjectLookup["usefullinksLeft"],
                                                BaseModule.ObjectLookup["TravelGuide"]);
                                            travelGuideModule.getTravelguidepage().TravelGuideUsefulLinks(context, BaseModule.ObjectLookup["usefullinksRight"],
                                                BaseModule.ObjectLookup["TravelGuide"]);
                                           
                            }finally
                            {
                               if (context != null){Utility.Cleanup(context);}
                            
                            }
                       
                        }


                        [Test]
                        [Ignore]
                        //For some reason end up with different existing WebDriver errors - Ignore until it is fixed
                        public void TestPoplarLinks()
                        {
                                    Drivercontext context = null;
                                    string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                    try 
                                    {
                                        BaseModule baseModule = new BaseModule();
                                        context = Drivercontext.Create("TravelGuideUseFulLinkTest", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                        TravelGuideModule travelGuideModule = new TravelGuideModule();
                                        travelGuideModule.getTravelguidepage().TravelGuidePoplarLinks(context, BaseModule.ObjectLookup["poplarLinks"],10);
                                       
                                    }finally
                                    {
                                       if (context != null){Utility.Cleanup(context);}
                                    
                                    
                                    }
                        
                        }






                        [Test]
                        public void TestCityPageValidations()
                        {
                            Drivercontext context = null;
                            string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                            try
                            {
                                BaseModule baseModule = new BaseModule();
                                context = Drivercontext.Create("TravelGuideCityPageTest", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                TravelGuideModule travelGuideModule = new TravelGuideModule();
                                travelGuideModule.getTravelguidepage().TravelGuideCityModules(context,  BaseModule.ObjectLookup["TravelGuide"],
                                    BaseModule.ObjectLookup["TGNAmerica"], 
                                    BaseModule.AssertLookup["TrvlGuideTitle"], BaseModule.ObjectLookup["airportGuideTG"],
                                    BaseModule.ObjectLookup["flightNewsTG"], BaseModule.ObjectLookup["usefulLinksTG"]);
                               
                            }
                            finally
                            {
                               if (context != null){Utility.Cleanup(context);}


                            }

                        }



                        [Test]
                        public void TestCityPageVaidationsRHS() 
                        {

                                Drivercontext context = null;
                                string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                try
                                {
                                    BaseModule baseModule = new BaseModule();
                                    context = Drivercontext.Create("TravelGuideCityPageTest", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    TravelGuideModule travelGuideModule = new TravelGuideModule();
                                    travelGuideModule.getTravelguidepage().TravelGuideCityModulesRight(context, BaseModule.ObjectLookup["TGNAmerica"]);
                                  
                                }
                                finally
                                {
                                   if (context != null){Utility.Cleanup(context);}
                                
                                }
                        
                        }

                        [Test]
                        public void TestTravelGuideNL() 
                        {
                                    Drivercontext context = null;
                                    string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                    try 
                                    {
                                        BaseModule baseModule = new BaseModule();
                                        context = Drivercontext.Create("TravelGuideCityPageTest", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                        TravelGuideModule travelGuideModule = new TravelGuideModule();
                                        travelGuideModule.getTravelguidepage().TGNewsLetter(context, BaseModule.ObjectLookup["poplarLinks"] + "[1]/a");
                                        
                                    }finally
                                    {
                                       if (context != null){Utility.Cleanup(context);}
                                    
                                    }
                        
                        }



                        [Test]
                        public void TestSpiltLink() 
                        {
                                    Drivercontext context = null;
                                    string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                    try 
                                    {
                                            BaseModule baseModule = new BaseModule();
                                            context = Drivercontext.Create("TravelGuideCityPageTest", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                            TravelGuideModule travelGuideModule = new TravelGuideModule();
                                            travelGuideModule.getTravelguidepage().TGSpiltLink(context, BaseModule.ObjectLookup["poplarLinks"],"[1]/a");
                                          
                                    }finally
                                    {
                                       if (context != null){Utility.Cleanup(context);}
                                    }
                        
                        
                        }



                        [Test]
                        public void TestCountryTGRight() 
                        {
                        
                                    Drivercontext context = null;
                                    string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                    try 
                                    {
                                            BaseModule baseModule = new BaseModule();
                                            context = Drivercontext.Create("TravelGuideCityPageTest", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                            TravelGuideModule travelGuideModule = new TravelGuideModule();
                                            travelGuideModule.getTravelguidepage().TravelGuideCountryModulesRight(context, BaseModule.ObjectLookup["TGNAmerica"]);
                                          
                                    }
                                    finally
                                    {
                                       if (context != null){Utility.Cleanup(context);}
                                    }
                        
                        }



                        [Test]
                        public void TestSpiltLinkCountry() 
                        {

                            Drivercontext context = null;
                            string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                            try
                            {
                                BaseModule baseModule = new BaseModule();
                                context = Drivercontext.Create("TravelGuideCityPageTest", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                TravelGuideModule travelGuideModule = new TravelGuideModule();
                                travelGuideModule.getTravelguidepage().TGSpiltLink(context,BaseModule.ObjectLookup["TGEurope"],"");
                                
                            }
                            finally
                            {
                               if (context != null){Utility.Cleanup(context);}
                            }
                        
                        
                        }



                        [Test]
                        public void TestContinentTGRight() 
                        {
                            Drivercontext context = null;
                            string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                            try
                            {
                                BaseModule baseModule = new BaseModule();
                                context = Drivercontext.Create("TravelGuideCityPageTest", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                TravelGuideModule travelGuideModule = new TravelGuideModule();
                                travelGuideModule.getTravelguidepage().TravelGuideContinentModulesRight(context, BaseModule.ObjectLookup["TGNAmerica"]+"/h4/a");
                               
                            }
                            finally
                            {
                               if (context != null){Utility.Cleanup(context);}
                            }
                        
                        
                        
                        }

                    
                        [Test]
                        public void TestTGContinentNL() 
                        {
                            Drivercontext context = null;
                            string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                            try
                            {
                                BaseModule baseModule = new BaseModule();
                                context = Drivercontext.Create("TravelGuideCityPageTest", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                TravelGuideModule travelGuideModule = new TravelGuideModule();
                                travelGuideModule.getTravelguidepage().TGNewsLetter(context, BaseModule.ObjectLookup["TGOceania"]+"/h4/a");
                               
                            }
                            finally
                            {
                               if (context != null){Utility.Cleanup(context);}

                            }
                        
                        
                        }


                        [Test]
                        public void TestTGContinentLeft() 
                        {

                                        Drivercontext context = null;
                                        string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                        try
                                        { 
                                            BaseModule baseModule = new BaseModule();
                                            context = Drivercontext.Create("TravelGuideCityPageTest", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                            TravelGuideModule travelGuideModule = new TravelGuideModule();
                                            travelGuideModule.getTravelguidepage().TravelGuideContinentLeftValidations(context, BaseModule.ObjectLookup["TGAfrica"], BaseModule.AssertLookup["TrvlGuideTitle"], BaseModule.ObjectLookup["airportGuideTG"], BaseModule.ObjectLookup["flightNewsTG"], BaseModule.ObjectLookup["usefulLinksTG"]);
                                           
                                        }
                                        finally
                                        {
                                           if (context != null){Utility.Cleanup(context);}

                                        }
                        
                        }

                        [Test]
                        public void TestTGSearchHeader() 
                        {
                                        Drivercontext context = null;
                                        string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                        try
                                        {

                                            context = Drivercontext.Create("TravelGuideCityPageTest", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                            TravelGuideModule travelGuideModule = new TravelGuideModule();
                                            travelGuideModule.getTravelguidepage().TGSearch(context);
                                        }
                                        finally
                                        {
                                           if (context != null){Utility.Cleanup(context);}

                                        }
                        
                        }



                        [Test]
                        [Ignore]
                        //This needs a build fix
                        public void TGAgentDetails() 
                        {
                            Drivercontext context = null;
                            string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
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

                
    }       

}
