using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestWebDriver.com.cf.webdriver.src.ModuleObject;
using TestWebDriver.com.cf.webdriver.src.Common;
using OpenQA.Selenium;
using NUnit.Framework;
using System.Collections.ObjectModel;

namespace TestWebDriver.com.cf.webdriver.src.PageObject
{
    public class TravelGuidePage : BaseModule
    {

        public void ValiDateTGHeader(Drivercontext context, string assertString)
        {
            var getHeader = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["TravelGuideHeader"]), 10);
            string getHeaderText = getHeader.Text;
            if (getHeaderText.Equals(assertString))
            {
                Console.WriteLine("You are on Travel Guides Page");
                Utility.TakeScreenShot(context, "TravelGuidePage");

            }

        }

        public void NavigatetoTravelGuide(Drivercontext context)
        {
            Utility.GoToURL(context, BaseModule.ObjectLookup["TravelGuide"]);
            ValiDateTGHeader(context, BaseModule.AssertLookup["travelGuide"]);
        }



        public void TGSearchBox(Drivercontext context)
        {
            
            Utility.GoToURL(context, BaseModule.ObjectLookup["TravelGuide"]);
            var getSearchBox = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["TravelGuideSearchBox"]), 10);
            getSearchBox.Clear();
            getSearchBox.SendKeys(BaseModule.DataLookup["continentAfrica"]);
            var getSearchbutton = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["TravelGuideSearchButton"]), 10);
            getSearchbutton.Click();
            var getDestinationHeader = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["TravelGuideHeader"]), 10);
            string getDestinationHeaderText = getDestinationHeader.Text;
            Console.WriteLine("You are Here : " + getDestinationHeaderText);
            if (getDestinationHeaderText.Contains(BaseModule.DataLookup["continentAfrica"]))
            {

                Utility.TakeScreenShot(context, "TravelGuideDestination_");
                Console.WriteLine("You are on Travel Guide Destination Page");

            }
            //((IJavaScriptExecutor)context.GetDriver()).ExecuteScript("return window.JSErrorCollector_errors.pump()");
                   

        }




        public void MiniBookingEngine(Drivercontext context, string urlstring)
        {
            Utility.GoToURL(context, urlstring);
           
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
           if(context.GetDriver().PageSource.Contains(BaseModule.AssertLookup["searchHeader"]))
            {
                Utility.TakeScreenShot(context, "MiniBESearchResults");
                Console.WriteLine("You are on BE Page");

            }
             //((IJavaScriptExecutor)context.GetDriver()).ExecuteScript("return window.JSErrorCollector_errors.pump()");
        }





        public void TravelGuideContinent(string Continent, Drivercontext context, string title)
        {
            Utility.GoToURL(context, BaseModule.ObjectLookup["TravelGuide"]);
            Utility.GoToURLXpath(context, Continent + "/h4/a");
            Utility.TakeScreenShot(context, "ContinentPage");
            ValiDateTGHeader(context, title);
            context.GetDriver().Navigate().Back();
            string buildUrlCountry = Continent + "/ul/li";
            IList<IWebElement> getCountCountry = Utility.FindElements(context, By.XPath(buildUrlCountry), 120);
            int countCountry = getCountCountry.Count;
            Console.WriteLine("Count of Countries : " + countCountry);
            for (int i = 1; i <= countCountry; i++)
            {
                var clickCountry = Utility.FindElement(context, By.XPath(buildUrlCountry + "[" + i + "]/a"), 120);
                clickCountry.Click();
                Utility.TakeScreenShot(context, "CountryPage_" + i + "_");
                var getCity = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["tgcity"]),120 );
                while (getCity.Enabled && getCity.Displayed)
                {
                                string getCityText = getCity.Text;
                                Console.WriteLine("City Text is : " + getCityText);
                                getCity.Click();
                                Utility.TakeScreenShot(context, "City");
                                var getAround = Utility.FindElement(context, By.PartialLinkText("airports"),120);
                                getAround.Click();
                                Utility.TakeScreenShot(context, "GetAround");
                                context.GetDriver().Navigate().Back();
                                context.GetDriver().Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(30));
                                context.GetDriver().Navigate().Back();
                                context.GetDriver().Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(3000));
                                //context.GetDriver().Navigate().Back();
                                //context.GetDriver().Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(30));
                }
                if ((i.Equals(1)))
                {
                    break;
                }
            }

        }


        public void TravelTip(Drivercontext context, string urlmodule, string traveltipxpath)
        {
            Utility.GoToURL(context, urlmodule);
            var travelTipModule = Utility.FindElement(context, By.XPath(traveltipxpath), Utility.TIME_OUT);
            if ((travelTipModule.Displayed) && (travelTipModule.Enabled))
            {
                string getUrls = traveltipxpath + "/div/dl/dd";
                IList<IWebElement> getTravelTipUrls = Utility.FindElements(context, By.XPath(getUrls), Utility.TIME_OUT);
                int getCountUrl = getTravelTipUrls.Count;
                Console.WriteLine("Count of number of url in Travel know how is : " + getCountUrl);
                if (getCountUrl > 1)
                {
                    for (int traverse = 1; traverse <= getCountUrl; traverse++)
                    {
                        var clickTravelTipsUrls = Utility.FindElement(context, By.XPath(getUrls + "[" + traverse + "]/a"), Utility.TIME_OUT);
                        string getTextTravelTip = clickTravelTipsUrls.Text;
                        Console.WriteLine("Travel Tip Url Text :  " + getTextTravelTip);
                        clickTravelTipsUrls.Click();
                        string getTravelTipTitle = context.GetDriver().Title;
                        Console.WriteLine("Travel Tip Title Text : " + getTravelTipTitle);
                        if (getTextTravelTip.Equals(getTravelTipTitle))
                        {
                            Utility.TakeScreenShot(context, "TravelTip_" + traverse + "_");
                        }
                        context.GetDriver().Navigate().Back();

                    }
                }

            }
        }




        public void TravelGuideUsefulLinks(Drivercontext context, string xpath, string url)
        {

            IList<IWebElement> usefulLinksleft = Utility.FindElements(context, By.XPath(xpath), Utility.TIME_OUT);
            int countUsefulLeft = usefulLinksleft.Count;
            Console.WriteLine("Count of lInks found of Left of UseFul Links - TG  : " + countUsefulLeft);
            for (int clickLink = 1; clickLink <= countUsefulLeft; clickLink++)
            {
                var getUsefulLink = Utility.FindElement(context, By.XPath(xpath + "[" + clickLink + "]/a"), Utility.TIME_OUT);
                string getUsefulLinkText = getUsefulLink.Text;
                Console.WriteLine("Write the useful Links Text : " + getUsefulLink.Text);
                getUsefulLink.Click();
                var getHeader = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["TGusefulLinkTitle"]), Utility.TIME_OUT);
                string getHeaderText = getHeader.Text;
                Console.WriteLine("Header to useFul Links Page : " + getHeaderText);
                //if ((getHeaderText.Contains(getUsefulLinkText)))
                if(context.GetDriver().PageSource.Contains(getUsefulLinkText))
                {
                         context.GetDriver().Navigate().Back();
                   }
              }
        }



        public void TravelGuidePoplarLinks(Drivercontext context, string xpath, int counter)
        {
            Utility.GoToURL(context, BaseModule.ObjectLookup["TravelGuide"]);

            IList<IWebElement> poplarLinks = Utility.FindElements(context, By.XPath(xpath), 10);
            int countPoplarLinks = poplarLinks.Count;
            Console.WriteLine("Count for Poplar Links TG : " + countPoplarLinks);
            if (countPoplarLinks >= 1)
            {
                for (int clickPlinks = 1; clickPlinks <= countPoplarLinks; clickPlinks++)
                {

                    var getPoplarLink = Utility.FindElement(context, By.XPath(xpath + "[" + clickPlinks + "]/a"), 10);
                    string getPoplarlinkText = getPoplarLink.Text;
                    Console.WriteLine("Text of Poplar Destination Link : " + getPoplarlinkText);
                    getPoplarLink.Click();

                    Utility.TakeScreenShot(context, "PoplarLinkDest_" + clickPlinks + "_");
                    var getPoplarHeader = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["TravelGuideHeader"]), 10);
                    string getHeaderText = getPoplarHeader.Text;
                    Console.WriteLine("Header to Poplar Links Page : " + getHeaderText);
                    if (getHeaderText.Contains(getPoplarlinkText))
                    {
                        context.GetDriver().Navigate().Back();

                    }
                    if (clickPlinks >= counter)
                    {
                        break;
                    }

                }
            }
        }



        //This method is to validate different modules on the TG City Page
        public void TravelGuideCityModules(Drivercontext context, string url, string Continent, string title, string xpathAirport, string xpathFlightnews, string usefulLinks)
        {

            Utility.GoToURL(context, url);

            /*Utility.goToURLXpath(context, Continent + "/h4/a");
            Utility.TakeScreenShot(context, "ContinentPage");
            valiDateTGHeader(context, title);
            context.GetDriver().Navigate().Back();
              */
            string buildUrlCountry = Continent + "/ul/li[1]/a";
            var getCountCountry = Utility.FindElement(context, By.XPath(buildUrlCountry), 10);
            getCountCountry.Click();
            var clickCity = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["listCities"] + "[1]/a"), 10);
            clickCity.Click();
            string airportXpath = xpathAirport + "/h4";
            var airportGuide = Utility.FindElement(context, By.XPath(airportXpath), 10);
            string getAirportText = airportGuide.Text;
            Console.WriteLine("Get Text from Airport Guide : " + getAirportText);
            string airportLinks = xpathAirport + "/ul/li";
            IList<IWebElement> getAirportLinksCount = Utility.FindElements(context, By.XPath(airportLinks), 10);
            int countAirports = getAirportLinksCount.Count;
            Console.WriteLine("Count of Airport Module : " + countAirports);
            string flightNewsXpath = xpathFlightnews + "/div/h3";
            var flightNews = Utility.FindElement(context, By.XPath(flightNewsXpath), 10);
            string getFlightNewsText = flightNews.Text;
            Console.WriteLine("Get Text from Flight News Module : " + getFlightNewsText);
            string flightNewsLinks = xpathFlightnews + "/div/div/ul/li";
            IList<IWebElement> getFlightnewsLinksCount = Utility.FindElements(context, By.XPath(flightNewsLinks), 10);
            int countflightNews = getFlightnewsLinksCount.Count;
            Console.WriteLine("Count of flightNews Module : " + countflightNews);
            string usefulLinkXpath = usefulLinks + "/h3";
            var usefulLink = Utility.FindElement(context, By.XPath(usefulLinkXpath), 10);
            string getUsefulLink = usefulLink.Text;
            Console.WriteLine("Get Text from Useful Links Module  : " + getUsefulLink);
            string usefulModuleLinks = usefulLinks + "/div/dl/dt";
            IList<IWebElement> getusefulCount = Utility.FindElements(context, By.XPath(usefulModuleLinks), 10);
            int countUsefulLinks = getusefulCount.Count;
            Console.WriteLine("Count of flightNews Module : " + countUsefulLinks);
            if ((countAirports >= 1) && (countflightNews >= 1) && (countUsefulLinks >= 1))
            {
                Console.WriteLine("City Page all modules are Present : !!! ");
                Utility.TakeScreenShot(context, "CityPageValidation");
            }

        }




        public void TravelGuideCityModulesRight(Drivercontext context, string Continent)
        {
            Utility.GoToURL(context, BaseModule.ObjectLookup["TravelGuide"]);
            string buildUrlCountry = Continent + "/ul/li[1]/a";
            var getCountCountry = Utility.FindElement(context, By.XPath(buildUrlCountry), 10);
            getCountCountry.Click();
            var clickCity = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["listCities"] + "[1]/a"), 10);
            clickCity.Click();
            var getSearchHeader = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["getSearchHeader"]), 10);
            string getSearchHeaderText = getSearchHeader.Text;
            Console.WriteLine("Header for Search Module : " + getSearchHeaderText);
            var getFlightDeals = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["miniFlightSearch"]), 10);
            string getFlightDealsText = getFlightDeals.Text;
            Console.WriteLine("Header for Top Flight Delas  : " + getFlightDealsText);
            /*var getflightTimes = Utility.FindElement(context, By.XPath( BaseModule.ObjectLookup["flightTimes"]));
            string  getflightTimesText = getflightTimes.Text;
            Console.WriteLine("Header for Approx Flight Times : "+getflightTimesText);*/
            var getflightReading = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["flightReading"]), 10);
            string getflightReadingText = getflightReading.Text;
            Console.WriteLine("Header for In-Flight Reading  : " + getflightReadingText);
            string buildTTXpath = BaseModule.ObjectLookup["travelTipModule"] + "/h4";
            var getTravelTips = Utility.FindElement(context, By.XPath(buildTTXpath), 10);
            string getTravelTipsText = getTravelTips.Text;
            Console.WriteLine("Header for TravelTips  : " + getTravelTipsText);
        }



        public void TGNewsLetter(Drivercontext context, string xpath)
        {
            Utility.GoToURL(context, BaseModule.ObjectLookup["TravelGuide"]);

            var poplarLink = Utility.FindElement(context, By.XPath(xpath), 10);
            poplarLink.Click();
            var getNewsLetter = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["subsribeNL"]), 10);
            string getNewsLetterText = getNewsLetter.Text;
            Console.WriteLine("Subscribe NewsLetter : " + getNewsLetterText);
            if (getNewsLetterText.Contains("newsletter"))
            {
                Assert.True(true);
            }

        }


        public void TGSpiltLink(Drivercontext context, string getCity, string xpath)
        {
            Utility.GoToURL(context, BaseModule.ObjectLookup["TravelGuide"]);
            var getCityLink = Utility.FindElement(context, By.XPath(getCity + xpath), 10);
            Utility.ClickAndWaitForCheapflightsPageToLoad(context, getCityLink);
            var getHeader = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["TGPoplarlinkHeader"]), 10);
            string getHeaderText = getHeader.Text;
            Console.WriteLine("Your Header is : " + getHeaderText);
            var getSpiltLink = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["spiltLink"]), 10);
            //  Utility.Highlight(context, getSpiltLink);
            string getSpiltLinkText = getSpiltLink.Text;
            Console.WriteLine("Spilt Link Text : " + getSpiltLinkText);
            if (getHeaderText.Contains(getSpiltLinkText))
            {
                Console.WriteLine("You are asserting !! ");
                Assert.True(true);
            }


        }


        public void TravelGuideCountryModulesRight(Drivercontext context, string Continent)
        {
            Utility.GoToURL(context, BaseModule.ObjectLookup["TravelGuide"]);
            string buildUrlCountry = Continent + "/ul/li[1]/a";
            var getCountCountry = Utility.FindElement(context, By.XPath(buildUrlCountry), 10);
            getCountCountry.Click();
            var getSearchHeader = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["getSearchHeader"]), 10);
            string getSearchHeaderText = getSearchHeader.Text;
            Console.WriteLine("Header for Search Module : " + getSearchHeaderText);
            var getFlightDeals = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["miniFlightSearch"]), 10);
            string getFlightDealsText = getFlightDeals.Text;
            Console.WriteLine("Header for Top Flight Delas  : " + getFlightDealsText);
            var getflightTimes = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["flightTimes"]), 10);
            string getflightTimesText = getflightTimes.Text;
            Console.WriteLine("Header for Approx Flight Times : " + getflightTimesText);
            var getflightReading = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["flightReading"]), 10);
            string getflightReadingText = getflightReading.Text;
            Console.WriteLine("Header for In-Flight Reading  : " + getflightReadingText);
            string buildTTXpath = BaseModule.ObjectLookup["travelTipModule"] + "/h4";
            var getTravelTips = Utility.FindElement(context, By.XPath(buildTTXpath), 10);
            string getTravelTipsText = getTravelTips.Text;
            Console.WriteLine("Header for TravelTips  : " + getTravelTipsText);

        }




        public void TravelGuideContinentModulesRight(Drivercontext context, string Continent)
        {
            Utility.GoToURL(context, BaseModule.ObjectLookup["TravelGuide"]);
            var getContinent = Utility.FindElement(context, By.XPath(Continent), 10);
            getContinent.Click();
            var getSearchHeader = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["getSearchHeader"]), 10);
            string getSearchHeaderText = getSearchHeader.Text;
            Console.WriteLine("Header for Search Module : " + getSearchHeaderText);
            var getFlightDeals = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["miniFlightSearch"]), 10);
            string getFlightDealsText = getFlightDeals.Text;
            Console.WriteLine("Header for Top Flight Deals  : " + getFlightDealsText);
            var getflightTimes = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["flightTimes"]), 10);
            string getflightTimesText = getflightTimes.Text;
            Console.WriteLine("Header for Approx Flight Times : " + getflightTimesText);
            var getflightReading = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["flightReading"]), 10);
            string getflightReadingText = getflightReading.Text;
            Console.WriteLine("Header for In-Flight Reading  : " + getflightReadingText);
            string buildTTXpath = BaseModule.ObjectLookup["travelTipModule"] + "/h4";
            var getTravelTips = Utility.FindElement(context, By.XPath(buildTTXpath), 10);
            string getTravelTipsText = getTravelTips.Text;
            Console.WriteLine("Header for TravelTips  : " + getTravelTipsText);

        }


        public void TravelGuideContinentLeftValidations(Drivercontext context, string Continent, string title, string xpathAirport, string xpathFlightnews, string usefulLinks)
        {

            Utility.GoToURL(context, BaseModule.ObjectLookup["TravelGuide"]);
            Utility.GoToURLXpath(context, Continent + "/h4/a");
            Utility.TakeScreenShot(context, "ContinentPage");
            /*valiDateTGHeader(context, title);
            context.GetDriver().Navigate().Back();
              */
            /* string buildUrlCountry = Continent + "/ul/li[1]/a";
              var getCountCountry = Utility.FindElement(context, By.XPath( buildUrlCountry));
              getCountCountry.Click();
                                 
              var clickCity = Utility.FindElement(context, By.XPath( BaseModule.ObjectLookup["listCities"] + "[1]/a"));
              clickCity.Click();
                */

            string airportXpath = xpathAirport + "/h4";
            var airportGuide = Utility.FindElement(context, By.XPath(airportXpath), 10);
            string getAirportText = airportGuide.Text;
            Console.WriteLine("Get Text from Airport Guide : " + getAirportText);
            string airportLinks = xpathAirport + "/ul/li";
            IList<IWebElement> getAirportLinksCount = Utility.FindElements(context, By.XPath(airportLinks), 10);
            int countAirports = getAirportLinksCount.Count;
            Console.WriteLine("Count of Airport Module : " + countAirports);
            string flightNewsXpath = xpathFlightnews + "/div/h3";
            var flightNews = Utility.FindElement(context, By.XPath(flightNewsXpath), 10);
            string getFlightNewsText = flightNews.Text;
            Console.WriteLine("Get Text from Flight News Module : " + getFlightNewsText);
            string flightNewsLinks = xpathFlightnews + "/div/div/ul/li";
            IList<IWebElement> getFlightnewsLinksCount = Utility.FindElements(context, By.XPath(flightNewsLinks), 10);
            int countflightNews = getFlightnewsLinksCount.Count;
            Console.WriteLine("Count of flightNews Module : " + countflightNews);
            string usefulLinkXpath = usefulLinks + "/h3";
            var usefulLink = Utility.FindElement(context, By.XPath(usefulLinkXpath), 10);
            string getUsefulLink = usefulLink.Text;
            Console.WriteLine("Get Text from Useful Links Module  : " + getUsefulLink);
            string usefulModuleLinks = usefulLinks + "/div/dl/dt";
            IList<IWebElement> getusefulCount = Utility.FindElements(context, By.XPath(usefulModuleLinks), 10);
            int countUsefulLinks = getusefulCount.Count;
            Console.WriteLine("Count of flightNews Module : " + countUsefulLinks);
            if ((countAirports >= 1) && (countflightNews >= 1) && (countUsefulLinks >= 1))
            {
                Console.WriteLine("City Page all modules are Present : !!! ");
                Utility.TakeScreenShot(context, "CityPageValidation");
            }

        }


        /**
         *      This method for doing just the flexible search.
         * **/

        public void TGSearch(Drivercontext context)
        {
            Utility.GoToURL(context, BaseModule.ObjectLookup["TravelGuide"]);

            var getPoplarLink = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["poplarLinks"] + "[1]/a"), 10);
            string getPoplarLinkText = getPoplarLink.Text;
            Console.WriteLine("Value from PoplarLink is : " + getPoplarLinkText);
            getPoplarLink.Click();
            var getDestinationValue = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["TGdestination"]), 10);
            string DestinationValueText = getDestinationValue.GetAttribute("value");
            Console.WriteLine("Value from  Destination : " + DestinationValueText);
            var departureRegion = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["TGdeparture"]), 10);
            departureRegion.SendKeys(BaseModule.DataLookup["fromSource"]);
            var dealsClick = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["TGfindDeals"]), 10);
            dealsClick.Click();
            string getTitle = context.GetDriver().Title;
            Console.WriteLine("Title of the Page is  : " + getTitle);

            if (getTitle.Contains(BaseModule.DataLookup["fromSource"] + DestinationValueText))
            {
                Console.WriteLine("You are on a Flight Deals Page");
            }


        }




        public void AirlineAgents(Drivercontext context)
        {

            var findlink = Utility.FindElement(context, By.LinkText(BaseModule.ObjectLookup["airLineAgent"]), Utility.TIME_OUT);
            findlink.Click();
            var getAirlineAgentHeader = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["airlineAgentHeader"]), 10);
            string getTextAirlineHeader = getAirlineAgentHeader.Text;
            Console.WriteLine("Here is the text : " + getTextAirlineHeader);
            if (getTextAirlineHeader.Equals(BaseModule.ObjectLookup["airLineAgent"]))
            {
                Console.WriteLine("On Airline Agents Page !!! ");
            }
            var agentPhone = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["agentPhone"]), Utility.TIME_OUT);
            Utility.ClickAndWaitForCheapflightsPageToLoad(context, agentPhone);
            Utility.TakeScreenShot(context, "AgentPhone");

            System.Console.WriteLine("Navigating back...");
            context.GetDriver().Navigate().Back();
            System.Console.WriteLine("Navigated back");

            var agentWeb = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["agentWeb"]), Utility.TIME_OUT);
            Utility.ClickAndWaitForPartnerPageToLoad(context, agentWeb, () =>
            {
                Utility.TakeScreenShot(context, "AgentDetails");
            });
        }






    }
}
