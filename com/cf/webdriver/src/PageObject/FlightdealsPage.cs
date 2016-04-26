using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestWebDriver.com.cf.webdriver.src.Common;
using TestWebDriver.com.cf.webdriver.src.ModuleObject;
using OpenQA.Selenium;
using log4net;
using log4net.Config;


namespace TestWebDriver.com.cf.webdriver.src.PageObject
{
   public class FlightdealsPage : BaseModule
    {
                public void Finddeals(String verifyString, Drivercontext context)
                {
                    //BaseModule baseModule = new BaseModule();
                    //Utility.IsTextPresent(verifyString, context);
                 }


                public void SearchFlightDeals(Drivercontext context,string sourceData,string destinationData,string fromDate,string toDate) 
                {
                            
                            Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["flightdeals"]);
                            var fromSource = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["fromSource"]),Utility.TIME_OUT);
                            fromSource.Clear();
                            fromSource.SendKeys(sourceData);
                            var toDestination = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["toDestination"]),Utility.TIME_OUT);
                            toDestination.Clear();
                            toDestination.SendKeys(destinationData);
                            var newsletterUI = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["flightdealsnl"]), 50);
                            newsletterUI.Click();
                            var emailUI = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["flightdealstxtemail"]), 50);
                            emailUI.Clear();
                            emailUI.SendKeys(BaseModule.DataLookup["email"]);
                            newsletterUI.Click();
                            var findDeals = Utility.FindElement(context,By.PartialLinkText("Find deals"),10);
                            findDeals.Click();
                            Utility.TakeScreenShot(context, "ResultsforFlightdeals");
                            RouteBookingEngine(context,fromDate,toDate);
                 }




                public void RouteBookingEngine(Drivercontext context,string fromDate,string toDate) 
                {
                            var pickupDate = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["beFromDate"]),Utility.TIME_OUT);
                            pickupDate.Clear();
                            pickupDate.SendKeys(fromDate);
                            pickupDate.SendKeys(Keys.Tab);
                            var dropOff = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["beToDate"]),Utility.TIME_OUT);
                            dropOff.Clear();
                            dropOff.SendKeys(toDate);
                            dropOff.SendKeys(Keys.Tab);
                            var findDeals = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["befindDeals"]),Utility.TIME_OUT);
                            findDeals.Click();
                             
                            Utility.TakeScreenShot(context, "RouteSpecificBEResults");
                           
                  }




                public void SearchModule(Drivercontext context) 
                {
                    var getSearchBox = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["searchModule"]),10);
                    bool foundSearchbox = getSearchBox.Displayed;
                    if (foundSearchbox.Equals(true)) 
                    {
                        Console.WriteLine("Found Search Box !!!! ");
            
                    }

        
                }



                public void TopDestinations(Drivercontext context) 
                {
                        var getTopDeals = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["topDestinations"]),10);
                        bool foundTopDest = getTopDeals.Displayed;
                        if (foundTopDest.Equals(true)) 
                        {
                            Console.WriteLine("Found Top Destination Module !!! ");
                            
                        }
                }


                public void ContentModule(Drivercontext context) 
                {
                            var getContentModule = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["content"]),10);
                            bool foundContent = getContentModule.Displayed;
                            if (foundContent.Equals(true)) 
                            {
                                Console.WriteLine("Found Content Module !!!");
                            }
                }


                public void SocialMediaModule(Drivercontext context) 
                {
                                var getSMModule = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["socialMedia"]),10);
                                bool foundSM = getSMModule.Displayed;
                                if (foundSM.Equals(true)) 
                                {
                                    Console.WriteLine("Found Social Media Content !!! ");
                                }
                
                }
                

                public void HandpickedDeals(Drivercontext context)
                {
                                var gethpdModule = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["hpd"]),10);
                                bool foundhpd = gethpdModule.Displayed;
                                if(foundhpd.Equals(true))
                                {
                                    Console.WriteLine("Found hand picked deals !!! ");
                                }
    
                }

                public void OtherDestinations(Drivercontext context) 
                {
                                var getOtherDestinations = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["otherDestinations"]),10);
                                bool foundODestinations = getOtherDestinations.Displayed;
                                if (foundODestinations.Equals(true)) 
                                {
                                    Console.WriteLine("Found Other Destinations !!!!");
                                }
                
                }

                public void FixedSearch(Drivercontext context,string fromSource,string toDestination,string fromDate,string toDate) 
                {
                                Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["flightdeals"]);
                                 
                                var clickFixed = Utility.FindElement(context,By.PartialLinkText("Search for advertisers with deals to suit your dates"),10);
                                clickFixed.Click();
                                 
                                var getBETitle = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["beHeader"]),10);
                                string getTitle = getBETitle.Text;
                                if (getTitle.Equals(BaseModule.AssertLookup["BEheaderTitle"]))
                                {
                                        Utility.TakeScreenShot(context, "BEPage");
                                        Console.WriteLine("You are on the BE page !!! " +getTitle);
                                }
                                SearchByDateModule searchByDatemodule = new SearchByDateModule();
                                searchByDatemodule.GetSearchByDatePage().ProductTypeSearch(context, BaseModule.ObjectLookup["FlightsnHotels"], 
                                        BaseModule.ObjectLookup["beSource"],fromSource, BaseModule.ObjectLookup["beDestination"], 
                                        toDestination, BaseModule.ObjectLookup["beFromDate"],
                                       fromDate, BaseModule.ObjectLookup["beToDate"], toDate,
                                        BaseModule.ObjectLookup["newsletter"],
                                        BaseModule.ObjectLookup["txtEmail"], BaseModule.DataLookup["email"],
                                        BaseModule.ObjectLookup["befindDeals"]);
                               
                }

       //DW method for AU dates written without picking dates

                public void FixedSearchAu(Drivercontext context,string sourcedata,string destinationData) 
                {

                    Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["flightdeals"]);

                    var clickFixed = Utility.FindElement(context, By.PartialLinkText("Search for advertisers with deals to suit your dates"), 10);
                    clickFixed.Click();

                    var getBETitle = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["beHeader"]), 10);
                    string getTitle = getBETitle.Text;
                    if (getTitle.Equals(BaseModule.AssertLookup["BEheaderTitle"]))
                    {
                        Utility.TakeScreenShot(context, "BEPage");
                        Console.WriteLine("You are on the BE page !!! " + getTitle);
                    }
                    var sourceUI = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["beSource"]), 50);
                    sourceUI.Clear();
                    sourceUI.SendKeys(sourcedata);
                    var destinationUI = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["beDestination"]), 50);
                    destinationUI.Clear();
                    destinationUI.SendKeys(destinationData);
                    var newsletterUI = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["newsletter"]), 50);
                    newsletterUI.Click();
                    var emailUI = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["txtEmail"]), 50);
                    emailUI.Clear();
                    emailUI.SendKeys(BaseModule.DataLookup["email"]);
                    newsletterUI.Click();
                    var findDeals = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["befindDeals"]), 50);
                    findDeals.Click();

                }
                

                
             
                
                public void TopDestinationModule(Drivercontext context) 
                { 
                            Utility.SwitchMainTabs(context,BaseModule.ObjectLookup["flightdeals"]);
                           
                            IList<IWebElement> gettopdestdivs = Utility.FindElements(context, By.XPath(BaseModule.ObjectLookup["topdest"]),Utility.TIME_OUT);
                            int counttopdestdivs = gettopdestdivs.Count;
                            System.Console.WriteLine("Count of Top destinations :  " + counttopdestdivs);
                            
                                for(int div = 1;div <= counttopdestdivs;div++)
                                {
                                    string buildurldiv = BaseModule.ObjectLookup["topdest"] +"["+ div +"]/p/a";
                                    IList<IWebElement> gettopdestinationcountry = Utility.FindElements(context, By.XPath(buildurldiv), Utility.TIME_OUT);
                                    int counttopdestinations = gettopdestinationcountry.Count;
                                    for (int i = 1; i <= counttopdestinations; i++)
                                    {
                                        string urlbuild = BaseModule.ObjectLookup["topdest"] + "[" + div + "]/p/a[" + i + "]";
                                        Utility.FindElement(context, By.XPath(urlbuild), Utility.TIME_OUT).Click();
                                        context.GetDriver().Navigate().Back();
                                        if (!(i.Equals(3)))
                                        {
                                            break;
                                        }
                                    }

                                }
                                   
                }


                public void OtherdestinationsModule(Drivercontext context) 
                {
                        Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["flightdeals"]);
                        IList<IWebElement> getotherdestdivs = Utility.FindElements(context, By.XPath(BaseModule.ObjectLookup["otherdest"]), Utility.TIME_OUT);
                        int countotherdestdivs = getotherdestdivs.Count;
                        System.Console.WriteLine("Count of other destinations  : "+countotherdestdivs);
                        for (int div = 1; div <= countotherdestdivs; div++) 
                        {
                                string buildurldest = BaseModule.ObjectLookup["otherdest"] + "[" + div + "]/p/a";
                                IList<IWebElement> getotherdestinationcountry = Utility.FindElements(context, By.XPath(buildurldest), Utility.TIME_OUT);
                                int countotherdestinations = getotherdestinationcountry.Count;
                                System.Console.WriteLine("Count of other destinations  with each div : " + countotherdestinations);
                                for (int i = 1; i <= countotherdestinations; i++) 
                                {
                                    
                                            string urlbuild = BaseModule.ObjectLookup["otherdest"] + "[" + div + "]/p/a[" + i + "]";
                                            Utility.FindElement(context, By.XPath(urlbuild), Utility.TIME_OUT).Click();
                                            context.GetDriver().Navigate().Back();
                                     if(!(i.Equals(3)))
                                     {
                                     break;}
                                }
                        }
                        
                        
                }


                public void ContentmoduleFD(Drivercontext context) 
                {
                        Utility.SwitchMainTabs(context,BaseModule.ObjectLookup["flightdeals"]);
                        var getcontentheader = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["getheadercontent"]), Utility.TIME_OUT);
                        string getcontenttext = getcontentheader.Text;
                        System.Console.WriteLine("Get Content Header Text : "+ getcontenttext);
                        if (getcontenttext.Equals(BaseModule.AssertLookup["contentmodule"]))
                        {

                            var belink = Utility.FindElement(context,By.LinkText("Search By Date page"),Utility.TIME_OUT);
                            belink.Click();
                            Utility.TakeScreenShot(context, "belinkflightdeals");
                            System.Console.WriteLine("Content Module Displayed !!! ");
                        
                        }

                }



                public void SocialMediaModuleFD(Drivercontext context,string linkText) 
                {
                        //Utility.popUp(context,BaseModule.DataLookup["email"],BaseModule.DataLookup["postcode"]);
                        Utility.SwitchMainTabs(context,BaseModule.ObjectLookup["flightdeals"]);
                        string getWinHandle = context.GetDriver().CurrentWindowHandle;
                        var fblink = Utility.FindElement(context, By.LinkText(linkText), Utility.TIME_OUT);
                        fblink.Click();
                        foreach (string winHandle in context.GetDriver().WindowHandles)
                        {

                            context.GetDriver().SwitchTo().Window(winHandle);
                            Console.WriteLine(winHandle);
                            string getTitle = context.GetDriver().Title;
                            Console.WriteLine(getTitle);
                            if (getTitle.Equals(BaseModule.AssertLookup["facebookTitle"]) || 
                                 getTitle.Equals(BaseModule.AssertLookup["twitterTitle"]) || 
                                 getTitle.Equals(BaseModule.AssertLookup["gPlusTitle"])|| 
                                 getTitle.Equals(BaseModule.AssertLookup["nlTitle"]))
                            {
                                Utility.TakeScreenShot(context, "SocialMediaPage");
                            }
                          }

                        context.GetDriver().Close();
                        context.GetDriver().SwitchTo().Window(getWinHandle); 
                
                }


                public void HandpickeddealsModuleFD(Drivercontext context) 
                {
                        Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["flightdeals"]);
                        var gethpdlinks = Utility.FindElements(context, By.XPath(BaseModule.ObjectLookup["handpickedlinks"]), Utility.TIME_OUT);
                        int gethpdlinkscount = gethpdlinks.Count;
                        System.Console.WriteLine("Hand picked deals  count !!! " + gethpdlinkscount );
                        if (gethpdlinkscount.Equals(4)) 
                        {
                            string buildurl = BaseModule.ObjectLookup["handpickedlinks"] + "[4]/a";
                            var clickhpdlink = Utility.FindElement(context, By.XPath(buildurl),Utility.TIME_OUT);
                            string getclickhpdtext = clickhpdlink.Text;
                            System.Console.WriteLine(" Text here is : " + getclickhpdtext);
                            if (getclickhpdtext.Equals(BaseModule.AssertLookup["hpdpage"])) 
                            {
                                        clickhpdlink.Click();
                                        string getTitle = context.GetDriver().Title;
                                        System.Console.WriteLine(" Text here is : " + getTitle);
                                        if (getTitle.Equals(BaseModule.AssertLookup["hpdtitle"])) 
                                        {
                                                Utility.TakeScreenShot(context,"hpdealspagefd");
                                                System.Console.WriteLine("You are on the HPD Page !! ");
                                        }

                            
                            }
                         }
                }
                
    }
}


