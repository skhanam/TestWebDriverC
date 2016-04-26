using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestWebDriver.com.cf.webdriver.src.ModuleObject;
using TestWebDriver.com.cf.webdriver.src.Common;
using OpenQA.Selenium;

namespace TestWebDriver.com.cf.webdriver.src.PageObject
{
    public class AirportGuidePage : BaseModule
    {

        public void AirportGuideIndex(Drivercontext context) 
        {
           
            Utility.GoToURL(context, BaseModule.ObjectLookup["AirportGuide"]);
                
        }

        // There needs to be a fix from dev for this     
        public void AGSearch(Drivercontext context) 
        {
                var sourcetxtbox = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["agfromsource"]),Utility.TIME_OUT);
                sourcetxtbox.SendKeys(BaseModule.DataLookup["fromSource"]);
                var destnation = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["agtodest"]), Utility.TIME_OUT);
                destnation.Clear();
                destnation.SendKeys(BaseModule.DataLookup["toDestination"]);
                var finddeals = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["agfinddeals"]), Utility.TIME_OUT);
                finddeals.Click();
                Utility.TakeScreenShot(context, "searchresults");
                
        }


        //has an extra link needs dev to either  remove or add content.    
        public void AGPoplarAirports(Drivercontext context) 
        {
               
                Utility.GoToURL(context, BaseModule.ObjectLookup["AirportGuide"]);
                IList<IWebElement> getallpoplarlinks = Utility.FindElements(context, By.XPath(BaseModule.ObjectLookup["poplarairports"]), Utility.TIME_OUT);
                int countpoplarlinks = getallpoplarlinks.Count;
                System.Console.WriteLine("Count of Poplar links : "+countpoplarlinks);
                for (int i = 1; i <= countpoplarlinks-1; i++) 
                {
                        var clickeachlink = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["poplarairports"]+"["+i+"]/a"),Utility.TIME_OUT);
                        string getlinkText = clickeachlink.GetAttribute("href");
                        System.Console.WriteLine("Here is the Link Text  : "  + getlinkText);
                        clickeachlink.Click();
                        string getTitle = context.GetDriver().Title;
                        System.Console.WriteLine("Here is the Title : "+getTitle);
                        context.GetDriver().Navigate().Back();
                        context.GetDriver().Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(15));
                        if((i.Equals(5)))
                        {
                            break;
                        }
                }
        }

        public void AGFlightnews(Drivercontext context,string url) 
        {
                    
                    Utility.GoToURL(context, url);
                    IList<IWebElement> getflightsnewslinks= Utility.FindElements(context, By.XPath(BaseModule.ObjectLookup["flightnewsAG"]), Utility.TIME_OUT);
                    int getcountofflightnews = getflightsnewslinks.Count;
                    System.Console.WriteLine("Count of Flight news  : "+getcountofflightnews);
                    
                    for (int i = 1; i <= getcountofflightnews;i++ )
                    {
                        string eachurl = BaseModule.ObjectLookup["flightnewsAG"] + "[" + i + "]/a";
                        var geteachLink = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["flightnewsAG"]+"["+i+"]/a"), Utility.TIME_OUT);
                        geteachLink.Click();
                        string getWindowHandle = context.GetDriver().CurrentWindowHandle;
                        Console.WriteLine("You are here : " +getWindowHandle);
                        foreach (string winHandle in context.GetDriver().WindowHandles)
                        {

                            context.GetDriver().SwitchTo().Window(winHandle);
                            System.Console.WriteLine("Window handle with : "+winHandle);
                            string getTitle = context.GetDriver().Title;
                            System.Console.WriteLine(getTitle);
                            Utility.TakeScreenShot(context, "AGFlightnews");
                            if( !(getWindowHandle.Equals(winHandle)))
                            {
                                Console.WriteLine("Winhandle now is " + winHandle);
                                context.GetDriver().SwitchTo().Window(winHandle).Close();    
                            }
                                                     
                        }
                        context.GetDriver().SwitchTo().Window(getWindowHandle);
                    }
                    
            }



        public void AGDisplayContents(Drivercontext context) 
        {

                    Utility.GoToURL(context, BaseModule.ObjectLookup["AirportGuide"]);
                    var findpoplarlink = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["poplarLink"]), Utility.TIME_OUT);
                    string geturltext = findpoplarlink.Text;
                    System.Console.WriteLine("Text of url : "+geturltext);
                    findpoplarlink.Click();
                    var findairportdetails = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["airportheader"]), Utility.TIME_OUT);
                    string getairportdetails = findairportdetails.Text;
                    System.Console.WriteLine("Header Airport Guide Page :  " +getairportdetails );
                    if (geturltext.EndsWith(getairportdetails))
                    {
                        
                        var findairportiata = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["airportiata"]), Utility.TIME_OUT);
                        System.Console.WriteLine("Header Airport IATA :  " + findairportiata.Text);
                        var airportdetails = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["airportdetails"]), Utility.TIME_OUT);
                        System.Console.WriteLine("Header Airport IATA :  " + airportdetails.Text);
                    }
        }




        public void AGFlightguide(Drivercontext context) 
        {
                    Utility.GoToURL(context,BaseModule.ObjectLookup["AirportGuide"]);
                    var findpoplarlink = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["poplarLink"]), Utility.TIME_OUT);
                    findpoplarlink.Click();
                    var flightguide = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["flightguidecity"]), Utility.TIME_OUT);
                    string textflightguide = flightguide.Text;
                    if (textflightguide.StartsWith("Flight guide")) {
                         System.Console.WriteLine("Here is the Flight Guide :" + textflightguide);
                    }
                    Utility.TakeScreenShot(context, "flightguide");
                    
        
        }



        public void AGcontents(Drivercontext context,string destination) 
        {
                    
                    var finddestination = Utility.FindElement(context, By.XPath(destination), Utility.TIME_OUT);
                    finddestination.Click();
                    Utility.TakeScreenShot(context, "airportguidecontents");
        }


        public void AGBookingEngine(Drivercontext context) 
        {
                        var getSourcetxtBox = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["beSource"]), Utility.TIME_OUT);
                        getSourcetxtBox.Clear();
                        getSourcetxtBox.SendKeys(BaseModule.DataLookup["fromSource"]);
                        var getDestinationtxtBox = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["beDestination"]), Utility.TIME_OUT);
                        getDestinationtxtBox.Clear();
                        getDestinationtxtBox.SendKeys(BaseModule.DataLookup["toDestination"]);
                        var getDepartDate = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["beFromDate"]), 20);
                        getDepartDate.Clear();
                        getDepartDate.SendKeys(BaseModule.DataLookup["fromDate"]);
                        var getDestinationDate = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["beToDate"]), 20);
                        getDestinationDate.Clear();
                        getDestinationDate.SendKeys(BaseModule.DataLookup["toDate"]);
                        var getDealsbutn = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["befindDeals"]), Utility.TIME_OUT);
                        getDealsbutn.Click();
                        string getTitleBE = context.GetDriver().Title;
                        Console.WriteLine("BE Title is :  " + getTitleBE);
                        if (context.GetDriver().PageSource.Contains(BaseModule.AssertLookup["searchHeader"]))
                        {
                            Utility.TakeScreenShot(context, "MiniBESearchResults");
                            Console.WriteLine("You are on BE Page");

                        }
        
        }



        public void allmodules(Drivercontext context) 
        {
            var findusefullinkmodule = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["agusefullinks"]), Utility.TIME_OUT);
            string getusefullinks = findusefullinkmodule.Text;
            var findflightnewsmodule = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["agflightnews"]), Utility.TIME_OUT);
            string getflightnews = findflightnewsmodule.Text;
            if ((getusefullinks.Equals("Useful links")) && (getflightnews.Equals("Flight news")))
            {
                System.Console.WriteLine("Flight news and Useful links are present !!! ");
            
            }
        
        
        }



        public void allmodulesairportguide(Drivercontext context) 
        {
            var findminibe = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["getSearchHeader"]), Utility.TIME_OUT);
            string getbetext = findminibe.Text;
            System.Console.WriteLine("Booking engine Module :"+getbetext);
            var findusefullink = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["agusefullink"]), Utility.TIME_OUT);
            string getusefullinks = findusefullink.Text;
            System.Console.WriteLine("Useful link Module :" + getusefullinks);
            var findflightnews = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["agflightnews"]), Utility.TIME_OUT);
            string getflightnews = findflightnews.Text;
            System.Console.WriteLine("Useful link Module :" + getflightnews);
            var findtopflights = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["agtopflights"]), Utility.TIME_OUT);
            string gettopflights = findtopflights.Text;
        }


        public void getalllinks(Drivercontext context,string xpath) 
        {
                    IList<IWebElement> getallinks = Utility.FindElements(context,By.XPath(xpath),
                        Utility.TIME_OUT);
                    int getcount = getallinks.Count;
                    System.Console.WriteLine("Get count of all links on that page  : "+getcount);
                    if (!(getcount.Equals(0))) 
                    {
                        
                        System.Console.WriteLine("Get the count of links left nav ");
                    
                    }
        
        
        }
    }
}
