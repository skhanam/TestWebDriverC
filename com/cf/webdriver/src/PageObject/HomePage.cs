using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestWebDriver.com.cf.webdriver.src.ModuleObject;
using TestWebDriver.com.cf.webdriver.src.Common;
using OpenQA.Selenium;
using NUnit.Framework;
using System.Collections;


namespace TestWebDriver.com.cf.webdriver.src.PageObject
{
    public class HomePage : BaseModule
    {



                public void SearchFlex(Drivercontext context,string sourceData,string destinationData,string checkNL) 
                {
                            var fromSourceUI = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["fromSource"]),Utility.TIME_OUT);
                            fromSourceUI.Clear();
                            Utility.HighlightElement(context, fromSourceUI);
                            fromSourceUI.SendKeys(sourceData);
                            fromSourceUI.SendKeys(Keys.Tab);
                            var toDestinationUI = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["toDestination"]), Utility.TIME_OUT);
                            toDestinationUI.Clear();
                            toDestinationUI.SendKeys(destinationData);
                            toDestinationUI.SendKeys(Keys.Tab);
                            var newsletterUI = Utility.FindElement(context, By.XPath(checkNL), Utility.TIME_OUT);
                            //Utility.HighlightElement(context, newsletterUI);
                            newsletterUI.Click();
                            Console.WriteLine("Uncheck NL Box ");
                            newsletterUI.Click();
                            var findDealsUI = Utility.FindElement(context, By.PartialLinkText("Find deals"), Utility.TIME_OUT);
                            //Utility.HighlightElement(context, findDealsUI);
                            findDealsUI.Click();
                            Utility.TakeScreenShot(context, "ResultsFlexSearch");
                          
                
                }


                public void SearchFlexnChangeSearch(Drivercontext context)
                {
                            var fromSourceUI = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["fromSource"]),10);
                            fromSourceUI.Clear();
                            fromSourceUI.SendKeys(BaseModule.DataLookup["fromSource"]);
                            fromSourceUI.SendKeys(Keys.Tab);
                            var toDestinationUI = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["toDestination"]),10);
                            toDestinationUI.Clear();
                            toDestinationUI.SendKeys(BaseModule.DataLookup["toDestination"]);
                            toDestinationUI.SendKeys(Keys.Tab);
                            var findDealsUI = Utility.FindElement(context, By.PartialLinkText("Find deals"), 10);
                            findDealsUI.Click();
                             
                            Utility.TakeScreenShot(context, "ResultsFlexSearchNChange");
                            ChangeSearch(context);
                          
                }


                public void SearchFixed(Drivercontext context,string sourceData,string destinationData,string fromDateData,string toDateData)
                {
                         
                            var fromSourceUI = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["fromSource"]),10);
                            fromSourceUI.SendKeys(sourceData);
                            fromSourceUI.SendKeys(Keys.Tab);
                           
                            
                            var toDestinationUI = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["toDestination"]),10);
                            toDestinationUI.SendKeys(destinationData);
                            toDestinationUI.SendKeys(Keys.Tab);
                            
                            var fixedRateUI = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["fixedRate"]),10);
                            fixedRateUI.Click();
                            var fromDateUI = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["fromDate"]),10);
                            fromDateUI.SendKeys(fromDateData);
                            fromDateUI.SendKeys(Keys.Tab);
                            var toDateUI = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["toDate"]),10);
                            toDateUI.SendKeys(toDateData);
                            toDateUI.SendKeys(Keys.Tab);
                            var newsletterUI = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["newsletterHP"]),10);
                            newsletterUI.Click();
                            newsletterUI.Click();
                            var findDeals = Utility.FindElement(context, By.PartialLinkText("Find deals"), 10);
                            findDeals.Click();
                             
                            Utility.TakeScreenShot(context, "ResultsFixedSearch");
                          

                }


        // This method is written as we don't get to switch to fixed in US site.
                public void SearchFixedUS(Drivercontext context, string sourceData, string destinationData, string fromDateData, string toDateData)
                {

                    var fromSourceUI = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["fromSource"]), 10);
                    fromSourceUI.SendKeys(sourceData);
                    fromSourceUI.SendKeys(Keys.Tab);
                    var toDestinationUI = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["toDestination"]), 10);
                    toDestinationUI.SendKeys(destinationData);
                    toDestinationUI.SendKeys(Keys.Tab);
                    var fromDateUI = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["fromDate"]), 10);
                    fromDateUI.SendKeys(fromDateData);
                    fromDateUI.SendKeys(Keys.Tab);
                    var toDateUI = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["toDate"]), 10);
                    toDateUI.SendKeys(toDateData);
                    toDateUI.SendKeys(Keys.Tab);
                    var newsletterUI = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["newsletterHP"]), 10);
                    newsletterUI.Click();
                    newsletterUI.Click();
                    var findDeals = Utility.FindElement(context, By.PartialLinkText("Find deals"), 10);
                    findDeals.Click();
                    Utility.TakeScreenShot(context, "ResultsFixedSearch");
                }
                



                public void ChangeSearch(Drivercontext context)
                {
                            var changeSearchLinkUI = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["changeSearch"]),10);
                            var changeLinkUI = Utility.FindElement(context, By.LinkText("Change search"), 10);
                            changeLinkUI.Click();
                            Utility.FindElement(context, By.LinkText("Change search"), 10).Click();
                            var changeDestinationUI = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["changeDestination"]),10);
                            changeDestinationUI.Clear();
                            changeDestinationUI.SendKeys(BaseModule.DataLookup["changeDestinationData"]);
                            Utility.TakeScreenShot(context, "changeSearchPopUp");
                            var searchButton = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["SearchButton"]),10);
                            searchButton.Click();
                             
                            Utility.TakeScreenShot(context, "changeSearchResults");

                }


                public void ChangeRoute(Drivercontext context)
                {
                            var changeRouteUI = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["changeRoute"]),Utility.TIME_OUT);
                            changeRouteUI.Click();
                            Utility.TakeScreenShot(context, "BeforeChangingRoute");
                            var destinationUI = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["beDestination"]),Utility.TIME_OUT);
                            destinationUI.Clear();
                            destinationUI.SendKeys(BaseModule.DataLookup["changeDestinationData"]);
                            Utility.TakeScreenShot(context, "AfterChangeDestination");
                            var findDeals = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["befindDeals"]),Utility.TIME_OUT);
                            findDeals.Click();
                             
                }



                //This method doesn't use meaningful signatures for it to be reused in diffrent context
                public void MissingFixedSearchCriteria(Drivercontext context, string param1UI, string param1, string param2UI, string param2, string param3UI, string param3)
                {
                   
                            var fixedRateUI = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["fixedRate"]),10);
                            fixedRateUI.Click();
                            var fromSourceUI = Utility.FindElement(context, By.XPath(param1UI), 10);
                            fromSourceUI.SendKeys(param1);
                            fromSourceUI.SendKeys(Keys.Tab);
                            var fromDateUI = Utility.FindElement(context, By.XPath(param2UI), 10);
                            fromDateUI.SendKeys(param2);
                            fromDateUI.SendKeys(Keys.Tab);
                            var toDateUI = Utility.FindElement(context, By.XPath(param3UI), 10);
                            toDateUI.SendKeys(param3);
                            toDateUI.SendKeys(Keys.Tab);
                            var findDeals = Utility.FindElement(context, By.PartialLinkText("Find deals"), 10);
                            findDeals.Click();

                }




                public void ContinentSearch(Drivercontext context, string continent)
                {
                    var imageContinentMap = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["mapContainer"]),10);
                    bool imagePresent = imageContinentMap.Displayed;
                            if (imagePresent.Equals(true))
                            {
                                        Utility.TakeScreenShot(context, "MapContinent");
                                        Console.WriteLine("Continent Map exists");
                                        var clickContinent = Utility.FindElement(context, By.PartialLinkText(continent), 10);
                                        clickContinent.Click();
                                        var headerContinent = Utility.FindElement(context, By.XPath(".//*[@id='ctl00_cp1_heading']"), 10);
                                        string getheaderContinentText = headerContinent.Text;
                                        Console.WriteLine(getheaderContinentText);
                                        Utility.TakeScreenShot(context, "ContinentDeals");
                                        GetAllLinks(context, BaseModule.ObjectLookup["containerParentDiv"]);
                                        /*var searchAllContinent = Utility.FindElement(context,By.XPath(".//*[@id='ctl00_cp1_searchAllLink']"));
                                        string searchlinkContinent = searchAllContinent.Text;
                                        Console.WriteLine(searchlinkContinent);
                                        searchAllContinent.Click();*/
                                        Utility.TakeScreenShot(context, "findDeals");

                            }

                 }


                        public void GetAllLinks(Drivercontext context,string parentContainer)
                        {
                            /*var findOrderListLinks = Utility.FindElement(context,By.XPath(".//*[@id='ctl00_cp1_destinationList']/ol[@class='dl-col']"));
                            int countOfOL = findOrderListLinks.ToString().Count();
                            Console.WriteLine(countOfOL); */
                            var findParentLinks = Utility.FindElement(context, By.XPath(parentContainer), 10);
                            int countOfParent = findParentLinks.ToString().Count();
                          
                            Console.WriteLine(countOfParent);
                    
                                for (int clickLink = 1; clickLink <= countOfParent; clickLink++) 
                                {
                                      // string xpathBuild = ".//*[@id='ctl00_cp1_destinationList']/ol[1]"+"/li["+clickLink+"]"+"/h3/a";
                                       /*string xpathBuild = ".//*[@id='ctl00_cp1_destinationList']/ol[1]" + "/li[" + clickLink + "]" + "/";
                                       Console.WriteLine(xpathBuild); */
                                       //var clickOnLinkHeaders = Utility.FindElement(context,By.XPath(xpathBuild));
                                    var clickOnLinkHeaders = Utility.FindElement(context, By.PartialLinkText("Flights to"), 10);
                                       if (clickOnLinkHeaders.Displayed && clickOnLinkHeaders.Enabled) 
                                       {
                                                    Console.WriteLine(clickOnLinkHeaders.GetAttribute("href"));
                                                    Console.WriteLine(clickOnLinkHeaders.Text);
                                                    clickOnLinkHeaders.Click();
                                                    //findParentLinks.Click();
                                                    var headerContinent = Utility.FindElement(context, By.XPath(".//*[@id='ctl00_cp1_heading']"), 10);
                                                    string getheaderContinentText = headerContinent.Text;
                                                    Console.WriteLine(getheaderContinentText);
                                        }
                                        context.GetDriver().Navigate().Back();
                                         
                                }
                        }



                        public void FollowUS(Drivercontext context,string socialMediaOption) 
                        {
                          //  Utility.SwitchToFrame(context, BaseModule.ObjectLookup["followusIframe"]);
                            string getWindowHandle = context.GetDriver().CurrentWindowHandle;
                    
                            Console.WriteLine(getWindowHandle); 

                            //Above snippet is commented & left as is nots ure if Iframes are going to come back 

                            var followUSUI = Utility.FindElement(context, By.XPath(socialMediaOption), Utility.TIME_OUT);
                            followUSUI.Click();
                                    foreach (string winHandle in context.GetDriver().WindowHandles)
                                    {
                                
                                        context.GetDriver().SwitchTo().Window(winHandle);
                                        Console.WriteLine(winHandle);
                                        string getTitle = context.GetDriver().Title;
                                        Console.WriteLine(getTitle);
                                        if (getTitle.Equals(BaseModule.AssertLookup["facebookTitle"]) || getTitle.Equals(BaseModule.AssertLookup["twitterTitle"]) || getTitle.Equals(BaseModule.AssertLookup["gPlusTitle"]))
                                        {
                                            Utility.TakeScreenShot(context,"SocialMediaPage");
                                         
                                        }

                                
                                     }
                             
                                     context.GetDriver().Close();
                                 context.GetDriver().SwitchTo().Window(getWindowHandle);     
                        }


                        public void GetAgentDetails(Drivercontext context,string agentLink)
                        {          var getAgentLink = Utility.FindElement(context,By.LinkText(BaseModule.DataLookup["agentLink"]),Utility.TIME_OUT);
                                    getAgentLink.Click();
                                    Utility.FindElement(context, By.LinkText(agentLink), 10).Click();
                                    var getPhone = Utility.FindElement(context, By.LinkText("Phone"), 10);
                                    getPhone.Click();
                                    Utility.TakeScreenShot(context, "AgentPhoneDetails");
                                    context.GetDriver().Navigate().Back();
                                    var getWeb = Utility.FindElement(context, By.LinkText("Web"), 10);
                                    getWeb.Click();
                                    Utility.TakeScreenShot(context, "AgentWeb");
                       }



                        public void FixedwithoutinputnNL(Drivercontext context) 
                        {
                               
                                        var fromSourceUI = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["fromSource"]),10);
                                        fromSourceUI.SendKeys(Keys.Tab);
                                        var toDestinationUI = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["toDestination"]),10);
                                        toDestinationUI.SendKeys(Keys.Tab);
                                        var fixedRateUI = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["fixedRate"]),10);
                                        fixedRateUI.Click();
                                        var fromDateUI = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["fromDate"]),10);
                                        fromDateUI.SendKeys(Keys.Tab);
                                        var toDateUI = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["toDate"]),10);
                                        toDateUI.SendKeys(Keys.Tab);
                                        var clickCheckBox = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["nlcheckbox"]),10);
                                        clickCheckBox.Click();
                                        var findDeals = Utility.FindElement(context, By.PartialLinkText("Find deals"), 10);
                                        findDeals.Click();
                                         
                                        if ((context.GetDriver().PageSource.Contains(BaseModule.AssertLookup["missingEmail"])) && (context.GetDriver().PageSource.Contains(BaseModule.AssertLookup["missingAirports"])) && (context.GetDriver().PageSource.Contains(BaseModule.AssertLookup["missingDates"])))
                                        {
                                            Console.WriteLine("All Validations in Place !!!");
                                            Utility.TakeScreenShot(context, "FixedSearchMissingInput");
                           
                                        }
                                        else {
                                                Console.WriteLine("Validation is not in place !!!");
                                                Utility.TakeScreenShot(context, "MissingValidationFixedSearch");
                      
                                        }
                    
                        }


                        public void FixedwithoutimputNlforUSonly(Drivercontext context) 
                        {
                                    var fromSourceUI = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["fromSource"]), 10);
                                    fromSourceUI.SendKeys(Keys.Tab);
                                    var toDestinationUI = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["toDestination"]), 10);
                                    toDestinationUI.SendKeys(Keys.Tab);
                                    var fromDateUI = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["fromDate"]), 10);
                                    fromDateUI.SendKeys(Keys.Tab);
                                    var toDateUI = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["toDate"]), 10);
                                    toDateUI.SendKeys(Keys.Tab);
                                    var clickCheckBox = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["nlcheckbox"]), 10);
                                    clickCheckBox.Click();
                                    var findDeals = Utility.FindElement(context, By.PartialLinkText("Find deals"), 10);
                                    findDeals.Click();

                                    if ((context.GetDriver().PageSource.Contains(BaseModule.AssertLookup["missingEmail"])) && (context.GetDriver().PageSource.Contains(BaseModule.AssertLookup["missingAirports"])) && (context.GetDriver().PageSource.Contains(BaseModule.AssertLookup["missingDates"])))
                                    {
                                        Console.WriteLine("All Validations in Place !!!");
                                        Utility.TakeScreenShot(context, "FixedSearchMissingInput");

                                    }
                                    else
                                    {
                                        Console.WriteLine("Validation is not in place !!!");
                                        Utility.TakeScreenShot(context, "MissingValidationFixedSearch");

                                    }
                        }



                        public void ValidateWarningMessage(Drivercontext context) 
                        {
                                var getWarningMessage = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["validateWarningAlternateDeals"]),10);
                                string getWarning = getWarningMessage.Text;
                                Console.WriteLine("Warning String is  : "+getWarning);
                                if (getWarning.Equals(BaseModule.AssertLookup["warningAlternateDeals"])) 
                                {
                                    Console.WriteLine("You have Validated the warning message !!! ");
            
                    
                                }
 
                        }


                        public void GetMetaName(Drivercontext context) 
                        {
                            var getMetaValue = Utility.FindElement(context, By.Name("WT.cg_n"), 10);
                                    string alternateDealsValue = getMetaValue.GetAttribute("content");
                                    Console.WriteLine("Value of Metaname  :  " + getMetaValue.GetAttribute("content"));
                                    if (alternateDealsValue.Equals(BaseModule.AssertLookup["metaValue"])) 
                                    {
                                        Console.WriteLine("You have Found the MetaValue !!! ");
                                     }

                        }


                        public void BookingEngineExists(Drivercontext context) 
                        {
                                    bool objFoundBE = Utility.IsElementPresent(context,By.XPath(BaseModule.ObjectLookup["beLookUp"]));
                                        if (objFoundBE.Equals(true)) 
                                        {
                                            Console.WriteLine("Booking Engine Div is Displayed !!!");
                    
                                        }
                                        var guideHeaderText = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["headerGuideModule"]),10);
                                        string headerText = guideHeaderText.Text;
                                        Console.WriteLine("Header Text is" + headerText);
                                        if (headerText.Contains(BaseModule.AssertLookup["alternateHeader"]))
                                        {
                                            Console.WriteLine("The Guide Module Is Displayed ");
                                       }
                        
                        }

                                    




                        public void FlagDropDown(Drivercontext context) 
                        {
                            var flagId = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["getFlagId"]),10);
                            flagId.Click();
                             
                            IList<IWebElement> getallFlagCountries = Utility.FindElements(context,By.XPath(BaseModule.ObjectLookup["getFlagLink"]),10);
                            int countFlagCountries = getallFlagCountries.Count();
                            Console.WriteLine("Count for Number of Countries ... "+countFlagCountries);
                                 if (countFlagCountries > 1 && countFlagCountries.Equals(7)) 
                                    {
                                            for (int i = 1; i <= countFlagCountries; i++) 
                                            {
                                                    string getUrl = BaseModule.ObjectLookup["getFlagLink"]+ "[" + i + "]" + "/a";
                                                    var geturlpath = Utility.FindElement(context, By.XPath(getUrl), 10);
                                                    string gethref = geturlpath.GetAttribute("href");
                                                    Console.WriteLine("Flag Country url is .. :  " + gethref);
                                                    string getURlText = geturlpath.Text;
                                                    Console.WriteLine("Flag Country Test is  .. : " + getURlText);
                                            }
                    
                                    }
                            Utility.TakeScreenShot(context, "FlagDropDown");
                        }

                        public void CountryText(Drivercontext context) 
                        {
                            var getText = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["getFlagLabel"]),10);
                            string getLabel = getText.Text;
                            Console.WriteLine("Get Label Country : " + getLabel);
                            Utility.TakeScreenShot(context, "FlagLabel");

                        }

                        public void MainLogo(Drivercontext context) 
                        {
                              var getLogoPlaceHolder = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["getMainLogo"]),10);
                              if(getLogoPlaceHolder.Displayed.Equals(true))
                              {
                                  Utility.TakeScreenShot(context, "DisplayLogo");
                              }
                        }


                        public void StrapLineValidate(Drivercontext context) 
                        {

                                var getStrapLine = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["getStrap"]),10);
                                string getstrapText = getStrapLine.Text;
                                Console.WriteLine("Your strapLine :  " +getstrapText);
                                if ((getstrapText.Equals(BaseModule.AssertLookup["strapUK"])) || (getstrapText.Equals(BaseModule.AssertLookup["strapUS"])) || (getstrapText.Equals(BaseModule.AssertLookup["strapAus"])) || (getstrapText.Equals(BaseModule.AssertLookup["strapCanada"]))) 
                                {
                                        Console.WriteLine("Validated the StrapLine");
                                        Utility.TakeScreenShot(context, "strapLineValidate");
                                
                                }
                        }


                        public void TravelTips(Drivercontext context) 
                        {
                                Console.WriteLine("You are here !!!!!!! ");
                                 
                                IList <IWebElement> getTravelTipsLinks = Utility.FindElements(context,By.XPath(BaseModule.ObjectLookup["travelTipHome"]),10);
                                int countLink = getTravelTipsLinks.Count;
                                if ( (countLink >3) || countLink.Equals(3))
                                {
                                    Utility.TakeScreenShot(context, "TravelTipsFoundHome");
                                    for (int i = 1; i <= countLink; i++)
                                    {
                                            string getUrl = BaseModule.ObjectLookup["travelTipHome"] + "[" + i + "]" + "/a";
                                            var geturlpath = Utility.FindElement(context, By.XPath(getUrl), 10);
                                            string gethref = geturlpath.GetAttribute("href");
                                                if (geturlpath.Enabled && geturlpath.Displayed)
                                                {
                                                            Console.WriteLine("URL Travel Tips .. :  " + gethref);
                                                            string getURlText = geturlpath.Text;
                                                            Console.WriteLine("Travel Tip Test is  .. : " + getURlText);
                                                            geturlpath.Click();
                                                            string getTitleTravelTips = context.GetDriver().Title;
                                                            Console.WriteLine("Title of Redirected page is : " + getTitleTravelTips);
                                                            if (getTitleTravelTips.Equals(getURlText)) 
                                                            {
                                                                Console.WriteLine("You are redirected to Travel Tip Content Page");
                                                                    Utility.TakeScreenShot(context,"travelTipsContent_"+i+"_");
                                                
                                                            }
                                                            context.GetDriver().Navigate().Back();
                                                             

                                                }
                                        
                                    }


                                }
                                else {
                                                Console.WriteLine("No Travel Tips Found");
                                                Utility.TakeScreenShot(context, "NotravelTipsHome");
                                      }
                                
                             
                        }




                        public void DepartureSpilt(Drivercontext context) 
                        {
                             IList<IWebElement> getSpiltHeader = Utility.FindElements(context,By.XPath(BaseModule.ObjectLookup["departureSpiltPage"]),10);
                             int countGetSpiltHeader = getSpiltHeader.Count;
                             Console.WriteLine("Counter for spiltHeaders  : " + countGetSpiltHeader);
                             if (countGetSpiltHeader.Equals(3)) 
                             {
                                        for(int i=1; i <=countGetSpiltHeader; i++)
                                        {
                                            var eachSpiltHeader = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["departureSpiltPage"] + "[" + i + "]" + "/h3"), 60);
                                                string getSpiltHeaderText = eachSpiltHeader.Text;
                                                Console.WriteLine("Text Spilt Header  :  " + getSpiltHeaderText);
                                                IList<IWebElement> eachSpiltDiv = Utility.FindElements(context, By.XPath(BaseModule.ObjectLookup["departureSpiltPage"] + "[" + i + "]" + "/ul/li"), 60);
                                                int countLinkSpilt = eachSpiltDiv.Count;
                                                Console.WriteLine("Count of Links on Each Div are  :" +countLinkSpilt);
                                                if((countLinkSpilt > 1) || (countLinkSpilt.Equals(1)))
                                                {
                                                        for (int departureLink = 1; departureLink <= countLinkSpilt; departureLink++) 
                                                        {
                                                            var eachDepartureLink = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["departureSpiltPage"] + "[" + i + "]" + "/ul/li" + "[" + departureLink + "]" + "/a"), 60);
                                                                    string getDepartureLinkText = eachDepartureLink.Text;
                                                                    Console.WriteLine("Each Departure Link Text  :  "+getDepartureLinkText);
                                                                    eachDepartureLink.Click();
                                                                    
                                                                    var eachDepartureHeader = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["departureCityHeader"]),60);
                                                                    string getDepartureHeaderText = eachDepartureHeader.Text;
                                                                    Console.WriteLine("Header of Departure Text : "+getDepartureHeaderText);
                                                                    if (getDepartureLinkText.Contains(getDepartureLinkText)) 
                                                                    {
                                                                            
                                                                            Utility.TakeScreenShot(context, "DepartureCityPage_"+departureLink+"_");
                                                                    
                                                                    }
                                                                    context.GetDriver().Navigate().Back();
                                                                    if (departureLink.Equals(3))
                                                                    {
                                                                        
                                                                        Console.WriteLine("Have tested for about : " + departureLink + " : Link pages ");
                                                                        break;
                                                                    }
                                                        }
                                                        
                                                }
                                                
                                                
                                        }
                             
                             }   
                        
                        }




                        public void DestinationSpiltMap(Drivercontext context) 
                        {
                                    //string getcontinentlinks = ""
                                    IList<IWebElement> getContinentLinks = Utility.FindElements(context,By.XPath(BaseModule.ObjectLookup["continentLinks"]),Utility.TIME_OUT);
                                    
                                    int countContinentLinks = getContinentLinks.Count;
                                    Console.WriteLine("Count of Continent links on World Map : " + countContinentLinks);
                                    if (countContinentLinks.Equals(6))
                                    {
                                        Utility.TakeScreenShot(context, "FoundWorldMap");
                                        IList<IWebElement> buildXpathContinentlist= Utility.FindElements(context,By.XPath(BaseModule.ObjectLookup["continentcountry"]),Utility.TIME_OUT);
                                            int getCountCoutries = buildXpathContinentlist.Count;
                                            System.Console.WriteLine("List of Countries : "+getCountCoutries);
                                           if(getCountCoutries!=0)
                                            {
                                                for (int i = 1; i <= getCountCoutries; i++)
                                                { 
                                                    string buildXpathContinent = BaseModule.ObjectLookup["continentcountry"] + "[" + i + "]/a";
                                                      Console.WriteLine("XPath is : "+ buildXpathContinent);
                                                    var clickContinent = Utility.FindElement(context, By.XPath(buildXpathContinent), 10);
                                                    string getContinentName = clickContinent.Text;
                                                    Console.WriteLine("Name of Continent is : " + getContinentName);
                                                    if ((clickContinent.Displayed) && (clickContinent.Enabled))
                                                    {
                                                                clickContinent.Click();
                                                                var getContinentHeader = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["continentHeader"]), 10);
                                                                string ContinentHeaderText = getContinentHeader.Text;
                                                                Console.WriteLine(" Continent Header Text is : " + ContinentHeaderText);
                                                                        if (ContinentHeaderText.Contains(getContinentName))
                                                                        {
                                                                            Console.WriteLine("You Have Landed on the right Page");
                                                                            Utility.TakeScreenShot(context, "ContinentPage_" + i + "_");
                                                                        }

                                                    }
                                                context.GetDriver().Navigate().Back();
                                                }
                                           }    
                                    }
                                    else
                                    {
                                        Assert.Fail();
                                    }
                        }


            //This method is not there for Canada as it is changed

                        public void EditorsPick(Drivercontext context) 
                        {
                            IList<IWebElement> getEditorLinks = Utility.FindElements(context,By.XPath(BaseModule.ObjectLookup["editorLinks"]),10);
                            int countEditorLinks = getEditorLinks.Count;
                            Console.WriteLine("Count of Continent links on World Map : " + countEditorLinks);
                            if (countEditorLinks.Equals(18))
                            {
                                Utility.TakeScreenShot(context, "FoundEditorLinks");
                                
                                for (int i = 1; i <= countEditorLinks; i++)
                                {
                                    string buildXpathEditor = BaseModule.ObjectLookup["editorLinks"] + "[" + i + "]/a";
                                   // Console.WriteLine("XPath is : " + buildXpathEditor);
                                    var clickEditorPickLinks = Utility.FindElement(context, By.XPath(buildXpathEditor), 10);
                                    string getEditorPickCityName = clickEditorPickLinks.Text;
                                    Console.WriteLine("Name of Continent is : " + getEditorPickCityName);
                                    if ((clickEditorPickLinks.Displayed) && (clickEditorPickLinks.Enabled))
                                    {
                                        clickEditorPickLinks.Click();
                                         
                                        var getCityHeader = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["continentHeader"]),10);
                                        string CityHeaderText = getCityHeader.Text;
                                        Console.WriteLine(" Continent Header Text is : " + CityHeaderText);
                                            if(CityHeaderText.Contains(getEditorPickCityName))
                                            {
                                                 Console.WriteLine("You Have Landed on the right Page");
                                                 Utility.TakeScreenShot(context, "ContinentPage_" + i + "_");
                                            }

                                    }
                                    context.GetDriver().Navigate().Back();
                                }
                            }            
                        
                       }




                        
    }
}
