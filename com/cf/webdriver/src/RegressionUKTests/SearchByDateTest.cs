using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using TestWebDriver.com.cf.webdriver.src.Common;
using TestWebDriver.com.cf.webdriver.src.ModuleObject;
using TestWebDriver.com.cf.webdriver.src.PageObject;
using NUnit.Framework;
using System.Configuration;


namespace TestWebDriver.com.cf.webdriver.src.RegressionUKTests
{
    [TestFixture]
    [Category("Regression")]
    public class SearchByDateTest
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
                    public void TestBookingEngine()
                    {
                        Drivercontext context = null;
                        string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                        try
                        {

                            context = Drivercontext.Create("searchByDatePagetests", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            SearchByDateModule searchByDateModule = new SearchByDateModule();
                            Utility.SwitchMainTabs(context,BaseModule.ObjectLookup["Searchbydate"]);
                            searchByDateModule.GetSearchByDatePage().SearchFlights(context);
                            
                        }
                        finally
                        {
                           if (context != null){Utility.Cleanup(context);}
                        } 
                    }





                    [Test]
                    public void TestFollowusFacebook() 
                    {
                                Drivercontext context = null;
                                string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                try
                                {
                                    context = Drivercontext.Create("SearchbyDateTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    HomeModule homeModule = new HomeModule();
                                    Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);
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
                        Drivercontext context = null;
                        string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                        try
                        {
                            context = Drivercontext.Create("SearchbyDateTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            HomeModule homeModule = new HomeModule();
                            Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);
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
                        Drivercontext context = null;
                        string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                        try
                        {
                            context = Drivercontext.Create("SearchbyDateTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            HomeModule homeModule = new HomeModule();
                            Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);
                            homeModule.GetHomepage().FollowUS(context, BaseModule.ObjectLookup["gplusUI"]);
                        }
                        finally
                        {
                           if (context != null){Utility.Cleanup(context);}

                        }
                    }


                    [Test]
                    public void TestProductTypeDisplayed() 
                    {
                        Drivercontext context = null;
                        string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
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


                    [Test]
                    public void TestAdultNumberCount() 
                    {
                        Drivercontext context = null;
                        string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
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
                        Drivercontext context = null;
                        string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
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



                    [Test]
                    public void TestInfantNumberCount() 
                    {
                        Drivercontext context = null;
                        string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
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
                    public void TestClickonPartner() 
                    {
                        Drivercontext context = null;
                        string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                        try 
                        {
                            context = Drivercontext.Create("SearchbydateTests", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                    SearchByDateModule searchbyDate = new SearchByDateModule();
                                    searchbyDate.GetSearchByDatePage().ClickonPartner(context, BaseModule.DataLookup["fromSource"],
                                        BaseModule.DataLookup["toDestination"], BaseModule.DataLookup["toDate"], BaseModule.DataLookup["fromDate"]);
                                  
                                }
                                finally 
                                {

                                   if (context != null){Utility.Cleanup(context);}
                        
                        }
                        
                    }




                    [Test]
                    public void TestDealsBelowBookingEngine() 
                    {

                        Drivercontext context = null;
                        string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                        try 
                        {
                            context = Drivercontext.Create("SearchbydateTests", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                SearchByDateModule searchbyDateModule = new SearchByDateModule();
                                searchbyDateModule.GetSearchByDatePage().DealsBelowBE(context);
                             
                        }finally
                        {
                           if (context != null){Utility.Cleanup(context);}
                        }
                   
                    }


                    [Test]    
                    public void TestReturnTime()
                    {
                                Drivercontext context = null;
                                string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                                try
                                {
                                    context = Drivercontext.Create("ReturnTime", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                            SearchByDateModule searchbydateModule = new SearchByDateModule();
                                            searchbydateModule.GetSearchByDatePage().GetReturnTime(context);
                                           
                                }
                                finally
                                {
                                   if (context != null){Utility.Cleanup(context);}
                                }

                    }


                    [Test]
                    public void TestDynamicSearch() 
                    {

                        Drivercontext context = null;
                        string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                          try
                                {
                                    context = Drivercontext.Create("ReturnTime", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                                            SearchByDateModule searchbydateModule = new SearchByDateModule();
                                            searchbydateModule.GetSearchByDatePage().DynamicSearch(context);
                                           
                                }
                          finally
                          {
                             if (context != null){Utility.Cleanup(context);}
                          }
                    
                    
                    }



                    [Test]
                    public void TestBEHeader() 
                    {
                        Drivercontext context = null;
                        string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                        try 
                        {
                            context = Drivercontext.Create("ReturnTime", BaseModule.GetDataLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            SearchByDateModule searchbydateModule = new SearchByDateModule();
                            searchbydateModule.GetSearchByDatePage().GetHeader(context);
                           
                        }
                        finally 
                        {
                           if (context != null){Utility.Cleanup(context);}  
                        }
                    
                    
                    }

                
    }
}
