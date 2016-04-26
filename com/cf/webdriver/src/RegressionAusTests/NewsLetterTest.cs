using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using TestWebDriver.com.cf.webdriver.src.Common;
using TestWebDriver.com.cf.webdriver.src.ModuleObject;
using System.Configuration;

namespace TestWebDriver.com.cf.webdriver.src.RegressionAusTests
{
    [TestFixture]
    public class NewsLetterTest
    {
                    [Test]
                    public void TestFollowusFacebook()
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                        try
                        {
                            context = Drivercontext.Create("travelguidesTest", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            HomeModule homeModule = new HomeModule();
                            Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Newsletter"]);
                            homeModule.GetHomepage().FollowUS(context, BaseModule.ObjectLookup["faceBookUI"]);
                           if (context != null){Utility.Cleanup(context);}
                        }
                        catch (TimeoutException exp)
                        {
                            Console.WriteLine(exp.ToString());

                        }
                    }



                    [Test]
                    public void TestFollowusTwitter()
                    {
                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                        try
                        {
                            context = Drivercontext.Create("travelguidesTest", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            HomeModule homeModule = new HomeModule();
                            Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Newsletter"]);
                            homeModule.GetHomepage().FollowUS(context, BaseModule.ObjectLookup["twitterUI"]);
                           if (context != null){Utility.Cleanup(context);}
                        }
                        catch (TimeoutException exp)
                        {
                            Console.WriteLine(exp.ToString());

                        }
                    }

                    [Test]
                    public void TestFollowusGPlus()
                    {

                        Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                        try
                        {
                            context = Drivercontext.Create("FlightdealsTest", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            HomeModule homeModule = new HomeModule();
                            Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Newsletter"]);
                            homeModule.GetHomepage().FollowUS(context, BaseModule.ObjectLookup["gplusUI"]);
                           if (context != null){Utility.Cleanup(context);}
                        }
                        catch (TimeoutException exp)
                        {
                            Console.WriteLine(exp.ToString());

                        }
                    } 
    }
}
