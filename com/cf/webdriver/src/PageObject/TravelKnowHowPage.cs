using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestWebDriver.com.cf.webdriver.src.ModuleObject;
using TestWebDriver.com.cf.webdriver.src.Common;
using OpenQA.Selenium;
using NUnit.Framework;

namespace TestWebDriver.com.cf.webdriver.src.PageObject
{
    public class TravelKnowHowPage : BaseModule
    {

                    public void GetAllTitles(Drivercontext context)
                    {

                        Utility.FindElement(context, By.LinkText("Travel tips"), 10).Click();
                         
                        IList<IWebElement> getAllLinks = Utility.FindElements(context,By.XPath(BaseModule.ObjectLookup["travelTitles"]),10);
                        int countTiTles = getAllLinks.Count;
                        Console.WriteLine("Get TravelTips Titles : " + countTiTles);
                        if (countTiTles.Equals(8))
                        {
                            for (int title = 1; title <= countTiTles; title++)
                            {
                                string eachTitle = BaseModule.ObjectLookup["travelTitles"] + "[" + title + "]";
                                var titleClick = Utility.FindElement(context, By.XPath(eachTitle), 10);
                                titleClick.Click();
                                 
                                Utility.TakeScreenShot(context, "TitleShots_" + title + "_");
                                string EachTitleText = Utility.FindElement(context, By.XPath(eachTitle), 10).Text;
                                Console.WriteLine("Each Title Text is :" + EachTitleText);

                            }
                            // Utility.TakeScreenShot(context, "TravelTipsTitlesFound");
                        }

                    }



                    public void ValidateContents(Drivercontext context) 
                    {
                            
                    
                    
                    }

        /* This method is written to get all titles & traverse through the Articles at the moment there is an error as there is extra div in getting the param @articleDiv*/

                            public void ClickTitles(Drivercontext context)
                            {
                                Utility.FindElement(context, By.LinkText(BaseModule.ObjectLookup["travelTips"]), 10).Click();
                                 
                                IList<IWebElement> getAllLinks = Utility.FindElements(context,By.XPath(BaseModule.ObjectLookup["travelTitles"]),10);
                                int countTiTles = getAllLinks.Count;
                                Console.WriteLine("Get TravelTips Titles : " + countTiTles);
                                if (countTiTles.Equals(8))
                                {
                                    for (int title = 1; title <= countTiTles; title++)
                                    {
                                        string eachTitle = BaseModule.ObjectLookup["travelTitles"] + "[" + title + "]/span";
                                        Console.WriteLine("Each Title is : " + eachTitle);
                                        Console.WriteLine("***************************************");
                                        var eachLink = Utility.FindElement(context, By.XPath(eachTitle), 10);
                                        if (eachLink.Displayed && eachLink.Enabled)
                                        {
                                            Console.WriteLine(eachLink.GetAttribute("href"));
                                            eachLink.Click();
                                            Console.WriteLine("Here is the Title : " + eachLink.Text);
                                            IList<IWebElement> getalldivs = Utility.FindElements(context,By.XPath(BaseModule.ObjectLookup["traveltipdivs"]),30);
                                            int getalldivcount = getalldivs.Count;
                                            Console.WriteLine("List of Categories : "+getalldivcount);
                                            for(int i=2;i<=getalldivcount;i++)
                                            {
                                                            string eachdivlist =  BaseModule.ObjectLookup["traveltipdivs"] +"["+i+"]"+"/ul/li";
                                                            Console.WriteLine("This is how the xpath looks like : " +eachdivlist);
                                                            IList<IWebElement> articleObject = Utility.FindElements(context, By.XPath(eachdivlist), 10);
                                                            int getlistarticles = articleObject.Count;
                                                            Console.WriteLine("Count of Articles within each Category  : " + getlistarticles);
                                                            if (getlistarticles > 0)
                                                            {
                                                                Console.WriteLine("This is how the xpath looks : " + eachdivlist);
                                                                for (int article = 1; article <= getlistarticles; article++)
                                                                {
                                                                    string eacharticle = eachdivlist+ "[" + article + "]/a";
                                                                    Console.WriteLine("This is how the xpath looks : " + eacharticle);
                                                                    var articleName = Utility.FindElement(context, By.XPath(eacharticle), 40);
                                                                    Console.WriteLine("Text for Article is : " + articleName.GetAttribute("href"));
                                                                }
                                                                Utility.TakeScreenShot(context, "ArticleFound_" + getlistarticles + "_");
                                                            }
                                                var clickondiv = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["traveltipdivs"]),40);
                                                clickondiv.Click();

                                            }

                                            
                                        }
                                    }
                                }

                            }



                        public void ClickArticle(Drivercontext context)
                        {
                            Utility.FindElement(context, By.LinkText(BaseModule.ObjectLookup["travelTips"]), Utility.TIME_OUT).Click();
                            var gettravelarticle = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["travelarticle"]), 100);
                            System.Console.WriteLine("Get Text of Link  : "+gettravelarticle.Text);
                            gettravelarticle.Click();
                            //Utility.ClickAndWaitForCheapflightsPageToLoad(context, gettravelarticle);
                            IList<IWebElement> getsubtitles = Utility.FindElements(context, By.XPath(BaseModule.ObjectLookup["travelarticlesub"]), 100);
                            var countsubtitles = getsubtitles.Count;
                            System.Console.WriteLine("Count of all Sub Articles : "+countsubtitles);
                            if (!countsubtitles.Equals(0))
                            {
                                string subarticle = BaseModule.ObjectLookup["travelarticlesub"] + "[3]/a";
                                Console.WriteLine("SubArticle xpath is : " + subarticle);
                                var gettextofsubarticle = Utility.FindElement(context, By.XPath(subarticle),Utility.TIME_OUT);
                                string getsubarticle = gettextofsubarticle.GetAttribute("href");
                                Console.WriteLine("SubArticle text is : " + getsubarticle);
                                gettextofsubarticle.Click();
                                //Utility.FindElement(context, By.XPath(subarticle), Utility.TIME_OUT).Click();
                                string getsubarticleTitle = context.GetDriver().Title;
                                if (getsubarticle.Equals(getsubarticleTitle))
                                {
                                    Assert.True(true);

                                }
                                else {
                                    Assert.Fail();
                                    Console.WriteLine("Title or text may be differenrt !!");
                                }
                            }

                        }


                        public void ValidateArticle(Drivercontext context)
                        {
                            Utility.FindElement(context, By.LinkText(BaseModule.ObjectLookup["travelTips"]), Utility.TIME_OUT).Click();
                             
                            IList<IWebElement> getAllLinks = Utility.FindElements(context,By.XPath(BaseModule.ObjectLookup["travelTitles"]),Utility.TIME_OUT);
                            int countTiTles = getAllLinks.Count;
                            var titleText = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup[""]),Utility.TIME_OUT);

                        }



                        public void UseFulLinks(Drivercontext context)
                        {
                            NavigateUsefulLinks(context);
                            var usefulheader = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["usefulHeader"]),10);
                            string getTextUseful = usefulheader.Text;
                            Console.WriteLine("Useful link Header : " + getTextUseful);
                            if (getTextUseful.Equals(BaseModule.AssertLookup["validateUsefulLinks"]))
                            {
                                Console.WriteLine("You are on UseFul Links Page ");
                                Utility.TakeScreenShot(context, "UsefulLink");
                            }
                        }



                    public void NavigateUsefulLinks(Drivercontext context)
                    {
                        Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["knowhow"]);
                        
                        Utility.FindElement(context, By.LinkText("Useful links"), 10).Click();
                         
                    }


                    public void ContinentModules(Drivercontext context)
                    {

                        NavigateUsefulLinks(context);
                        IList<IWebElement> getModules = Utility.FindElements(context,By.XPath(BaseModule.ObjectLookup["modules"]),10);
                        int getCountModules = getModules.Count;
                        Console.WriteLine("Count of Modules : "+ getCountModules);
                        var getFlightnewsModule = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["flightNews"]),10);
                        string getFnewsText = getFlightnewsModule.Text;
                        Console.WriteLine("Flight News Text : "+ getFnewsText);
                        var getTTips = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["travelTipsheader"]),10);
                        string tTipsText = getTTips.Text;
                        Console.WriteLine("Travel Tips Text : "+ tTipsText);
                        if ( (getCountModules.Equals(7))  && (getFnewsText.Equals(BaseModule.AssertLookup["flightnews"])) && (tTipsText.Equals(BaseModule.AssertLookup["travelTips"])))
                           {
                               Console.WriteLine("Found all modules !!!");
                               Utility.TakeScreenShot(context, "UseFulLinkModules");

                           }else
                           {
                                       Console.WriteLine("Not all Modules are present");
                                       Utility.TakeScreenShot(context,"InsufficientModules");
                           }

                    }




                    public void ContinentLink(Drivercontext context,string continentName) 
                    {
                        NavigateUsefulLinks(context);
                        Utility.FindElement(context, By.LinkText(continentName), 10).Click();
                        
                                if (context.GetDriver().PageSource.Contains(BaseModule.AssertLookup["continentAssert"])) 
                                {
                                            Console.WriteLine("You are on the Continent Page");
                                            Utility.TakeScreenShot(context, "ContinentPage");
                                                          
                                }
                    }


                    public void ValidateContinentContents(Drivercontext context, string continentName, string countriesList, string flightData, string headerData) 
                    {
                              ContinentLink(context, continentName);
                              ValidateContents(context, continentName, countriesList, flightData, headerData);
                            
                    }



                    public void ValidateContents(Drivercontext context, string continentName, string countriesList, string flightData, string headerData) 
                    {

                                        IList<IWebElement> getCountries = Utility.FindElements(context, By.XPath(countriesList), Utility.TIME_OUT);
                                        int countCountries = getCountries.Count;
                                        Console.WriteLine("Count of  : "+countCountries);
                                        var travelTipHeader = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["travelTipsModule"]),10);
                                        string txtTravelTip = travelTipHeader.Text;
                                        Console.WriteLine("Travel Tip Header : " + txtTravelTip);
                                        var flightGuideHeader = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["flightDealModule"]),10);
                                        string txtFlightguide = flightGuideHeader.Text;
                                        Console.WriteLine("Flight Guide Header : " + txtFlightguide);
                                        var airportGuide = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["airportGuide"]),10);
                                        string txtAirportGuide = airportGuide.Text;
                                        Console.WriteLine("Airport Guide Header : " + txtAirportGuide);
                                        var topcheapFlights = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["topCheapFlights"]),10);
                                        string txtcheapFlights = topcheapFlights.Text;
                                        Console.WriteLine("CheapFlight Deals  : " + txtcheapFlights);
                                        //var miniFlightSearch = Utility.FindElement(context,By.XPath(),10);
                                        var miniFlightSearch = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["miniFlightSearch"]), 10);
                                        string txtminiFlight = miniFlightSearch.Text;
                                        Console.WriteLine("Mini Flight search  : " + txtminiFlight);
                                        Console.WriteLine("********Check for Validations ****************");
                                        Console.WriteLine("Travel Tips : " + BaseModule.AssertLookup["travelTips"]);
                                        Console.WriteLine(" Mini deals : " + BaseModule.AssertLookup["minideals"]);
                                        Console.WriteLine("Airport Guide  : " + BaseModule.AssertLookup["airportGuide"]);
                                        Console.WriteLine("FlightData  : "+ flightData);
                                        Console.WriteLine("CheapFlights Header : "+headerData);
                                        
                                        if ((countCountries == 1) && txtTravelTip.Equals(BaseModule.AssertLookup["travelTips"]) && txtminiFlight.Equals(BaseModule.AssertLookup["minideals"]) &&
                                            txtFlightguide.Equals(flightData) && txtcheapFlights.Equals(headerData) && txtAirportGuide.Equals(BaseModule.AssertLookup["airportGuide"]))
                                        {
                                            Console.WriteLine("Countries Displayed");
                                            Utility.TakeScreenShot(context, "ValidatedExistenceModules");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Some Validations are not right ");
                                            Utility.TakeScreenShot(context, "FailMismatchContents");
                                            
                                        }
                    
                    }


                    public void CountryLink(Drivercontext context, string country, string getCityList,string flightData,string headerData) 
                    {

                                ContinentLink(context, BaseModule.DataLookup["continentEurope"]);
                                 
                                Utility.FindElement(context, By.PartialLinkText("Ireland"), 30).Click();

                                ValidateContents(context, country, getCityList, flightData, headerData);
                    }


                    public void CityLink(Drivercontext context, string city, string getCityList, string flightData, string headerData) 
                    {
                                CountryLink(context, BaseModule.DataLookup["countryIreland"], BaseModule.ObjectLookup["listCities"],
                                    BaseModule.AssertLookup["flightGuideCountry"], BaseModule.AssertLookup["cheapflightsCountry"]);
                                Utility.FindElement(context, By.PartialLinkText("Dublin"), 10).Click();
                                ValidateContents(context, city, getCityList, flightData, headerData);
                    }

    }
}
