using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestWebDriver.com.cf.webdriver.src.Common;
using TestWebDriver.com.cf.webdriver.src.ModuleObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace TestWebDriver.com.cf.webdriver.src.PageObject
{
    public class SearchByDatePage : BaseModule
    {
        public void SearchBookingEngine(Drivercontext context)
        {
            Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);

        }


        public void ClickOnAllTabs(Drivercontext context)
        {
            var homeTab = Utility.FindElement(context, By.PartialLinkText(BaseModule.ObjectLookup["Home"]), 50);
            homeTab.Click();
            var flightDealsTab = Utility.FindElement(context, By.PartialLinkText(BaseModule.ObjectLookup["flightdeals"]), 50);
            flightDealsTab.Click();
            var searchbyTab = Utility.FindElement(context, By.PartialLinkText(BaseModule.ObjectLookup["Searchbydate"]), 50);
            searchbyTab.Click();
            var staffTab = Utility.FindElement(context, By.PartialLinkText(BaseModule.ObjectLookup["Staff"]), 50);
            staffTab.Click();
            var inspiredTab = Utility.FindElement(context, By.PartialLinkText(BaseModule.ObjectLookup["inspired"]), 50);
            inspiredTab.Click();
            var knowhowTab = Utility.FindElement(context, By.PartialLinkText(BaseModule.ObjectLookup["knowhow"]), 50);
            knowhowTab.Click();
            var newsletterTab = Utility.FindElement(context, By.PartialLinkText(BaseModule.ObjectLookup["Newsletter"]), 50);
            newsletterTab.Click();
        }





        public void SwitchToBookingEngineProductTypes(Drivercontext context, string prdtType)
        {
            Utility.FindElement(context, By.XPath(prdtType), 50).Click();
        }



        public void SearchFlightHotels(Drivercontext context)
        {
            Utility.FindElement(context, By.PartialLinkText(BaseModule.ObjectLookup["FlightsnHotels"]), 50).Click();

        }



        public void SearchFlights(Drivercontext context)
        {
            ProductTypeSearch(context, BaseModule.ObjectLookup["FlightsnHotels"], BaseModule.ObjectLookup["beSource"],
                BaseModule.DataLookup["fromSource"],
                BaseModule.ObjectLookup["beDestination"], BaseModule.DataLookup["toDestination"],
                BaseModule.ObjectLookup["beFromDate"], BaseModule.DataLookup["fromDate"], BaseModule.ObjectLookup["beToDate"],
                BaseModule.DataLookup["toDate"], BaseModule.ObjectLookup["newsletter"],
                BaseModule.ObjectLookup["txtEmail"], BaseModule.DataLookup["email"],
                BaseModule.ObjectLookup["befindDeals"]);

            Utility.TakeScreenShot(context, "FoundBESearchResults");
            context.GetDriver().Manage().Cookies.DeleteAllCookies();
            bool searchResults = Utility.IsTextPresent(BaseModule.AssertLookup["searchHeader"], context);
            if (searchResults.Equals(true))
            {
                SwitchToBookingEngineProductTypes(context, BaseModule.ObjectLookup["beFlightsnHotelPrdtType"]);
                GetCountofResults(context);
                Utility.TakeScreenShot(context, "FoundbeFlightsnHotelPrdtTypeResults");

                SwitchToBookingEngineProductTypes(context, BaseModule.ObjectLookup["beHotelPrdtType"]);
                GetCountofResults(context);
                Utility.TakeScreenShot(context, "FoundbeHotelPrdtTypeResults");

                SwitchToBookingEngineProductTypes(context, BaseModule.ObjectLookup["beCarPrdtType"]);
                GetCountofResults(context);
                Utility.TakeScreenShot(context, "FoundbeCarPrdtTypeResults");

                SwitchToBookingEngineProductTypes(context, BaseModule.ObjectLookup["beFlightsPrdtType"]);
                GetCountofResults(context);
                Utility.TakeScreenShot(context, "FoundbeFlightsPrdtTypeResults");


            }
            else
            {
                Console.WriteLine("No Search Results Found");
                Utility.TakeScreenShot(context, "NoBESearchResults");

            }

        }


        public void HotelsOnly(Drivercontext context, string prdtType, 
            string destinationId, string destinationData, string fromDateId, string fromDateData, string toDateId,
            string toDateData, string emailData, string findDealsId) 
        {
                    var prdtTypeUI = Utility.FindElement(context, By.XPath(prdtType), 50);
                    prdtTypeUI.Click();
                    var destinationUI = Utility.FindElement(context, By.XPath(destinationId), 50);
                    destinationUI.Clear();
                    destinationUI.SendKeys(destinationData);
                    var fromDateUI = Utility.FindElement(context, By.XPath(fromDateId), 50);
                    fromDateUI.Clear();
                    fromDateUI.SendKeys(Keys.Tab);
                    fromDateUI.SendKeys(fromDateData);
                    var toDateUI = Utility.FindElement(context, By.XPath(toDateId), 50);
                    toDateUI.Clear();
                    toDateUI.SendKeys(toDateData);
                    var findDeals = Utility.FindElement(context, By.XPath(findDealsId), 50);
                    findDeals.Click();
        
        }

        public void CarOnly(Drivercontext context, string prdtType,
            string destinationId, string destinationData, string fromDateId, string fromDateData, string toDateId,
            string toDateData, string checkNL, string emailId, string emailData, string findDealsId) 
        {
            var prdtTypeUI = Utility.FindElement(context, By.XPath(prdtType), 50);
            prdtTypeUI.Click();
            var destinationUI = Utility.FindElement(context, By.XPath(destinationId), 50);
            destinationUI.Clear();
            destinationUI.SendKeys(destinationData);
            var fromDateUI = Utility.FindElement(context, By.XPath(fromDateId), 50);
            fromDateUI.Clear();
            fromDateUI.SendKeys(Keys.Tab);
            fromDateUI.SendKeys(fromDateData);
            var toDateUI = Utility.FindElement(context, By.XPath(toDateId), 50);
            toDateUI.Clear();
            toDateUI.SendKeys(toDateData);

            var newsletterUI = Utility.FindElement(context, By.XPath(checkNL), 50);
            newsletterUI.Click();
            var emailUI = Utility.FindElement(context, By.XPath(emailId), 50);
            emailUI.Clear();
            emailUI.SendKeys(emailData);
            newsletterUI.Click();
            var findDeals = Utility.FindElement(context, By.XPath(findDealsId), 50);
            findDeals.Click();
        
        }



        public void ProductTypeSearch(Drivercontext context, string prdtType, string sourceId, string sourcedata,
            string destinationId, string destinationData, string fromDateId, string fromDateData, string toDateId,
            string toDateData, string checkNL, string emailId, string emailData, string findDealsId)
        {
            var prdtTypeUI = Utility.FindElement(context, By.XPath(prdtType), 50);
            prdtTypeUI.Click();
            var sourceUI = Utility.FindElement(context, By.XPath(sourceId), 50);
            sourceUI.Clear();
            sourceUI.SendKeys(sourcedata);
            var destinationUI = Utility.FindElement(context, By.XPath(destinationId), 50);
            destinationUI.Clear();
            destinationUI.SendKeys(destinationData);
            var fromDateUI = Utility.FindElement(context, By.XPath(fromDateId), 50);
            fromDateUI.Clear();
            fromDateUI.SendKeys(Keys.Tab);
            fromDateUI.SendKeys(fromDateData);
            var toDateUI = Utility.FindElement(context, By.XPath(toDateId), 50);
            toDateUI.Clear();
            toDateUI.SendKeys(toDateData);

            var newsletterUI = Utility.FindElement(context, By.XPath(checkNL), 50);
            newsletterUI.Click();
            var emailUI = Utility.FindElement(context, By.XPath(emailId), 50);
            emailUI.Clear();
            emailUI.SendKeys(emailData);
            newsletterUI.Click();
            var findDeals = Utility.FindElement(context, By.XPath(findDealsId), 50);
            findDeals.Click();

        }


        public void BookingEngineReSearch(Drivercontext context, string prdtType, string fromDateId, string fromDateData, string toDateId,
            string toDateData, string checkNL, string emailId, string emailData, string findDealsId)
        {


            var selectRegion = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["tableRegionRadio"]), 50);
            selectRegion.Click();
            var continueButton = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["continueButton"]), 50);
            continueButton.Click();
            var prdtTypeUI = Utility.FindElement(context, By.XPath(prdtType), 50);
            prdtTypeUI.Click();
            var getDestination = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["beDestination"]), 50);
            string getDestinationText = getDestination.GetAttribute("value");
            Console.WriteLine(getDestinationText);
            var fromDateUI = Utility.FindElement(context, By.XPath(fromDateId), 50);
            fromDateUI.Clear();
            fromDateUI.SendKeys(Keys.Tab);
            fromDateUI.SendKeys(fromDateData);
            var toDateUI = Utility.FindElement(context, By.XPath(toDateId), 50);
            toDateUI.Clear();
            toDateUI.SendKeys(Keys.Tab);
            toDateUI.SendKeys(toDateData);
            var newsletterUI = Utility.FindElement(context, By.XPath(checkNL), 0);
            newsletterUI.Click();
            var emailUI = Utility.FindElement(context, By.XPath(emailId), 50);
            emailUI.Clear();
            emailUI.SendKeys(emailData);
            Console.WriteLine("Uncheck NL Box ");
            newsletterUI.Click();
            var findDeals = Utility.FindElement(context, By.XPath(findDealsId), 0);
            findDeals.Click();

            bool searchResults = Utility.IsTextPresent(BaseModule.AssertLookup["searchHeader"], context);
            if (searchResults.Equals(true))
            {
                Utility.TakeScreenShot(context, "FoundBESearchResultsForRegion");
                Console.WriteLine("End of Re Search !!!");
            }

        }

        // This method is used with Aphanumeric test.
        public void LookforWarning(Drivercontext context)
        {
            var getErrorElement = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["warningMesg"]), 50);
            String getErrorElementText = getErrorElement.Text;
            Console.WriteLine("Here is the Warning Message !! : "+getErrorElementText);

            if (getErrorElementText.Contains("Sorry"))
            {
                var getSourceError = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["alphaFailSourceResult"]), 50);
                String getSourceErrorText = getSourceError.Text;
                bool nextWarning = Utility.IsTextPresent(getSourceErrorText, context);
                if (nextWarning.Equals(true))
                {
                    Console.WriteLine("Here is the text from Source : "+getSourceErrorText);
                    BaseModule.AssertLookup.Add("actualAlphaSource", "getSourceErrorText");
                    Console.WriteLine("Here is the value in Assert Lookup  : " + BaseModule.AssertLookup["alphasearchSourceResult"]);
                    //StringAssert.AreEqualIgnoringCase(BaseModule.AssertLookup["actualAlphaSource"], BaseModule.AssertLookup["alphasearchSourceResult"]);
                    try
                    {
                        
                        //Assert.AreSame(BaseModule.AssertLookup["actualAlphaSource"], BaseModule.AssertLookup["alphasearchSourceResult"]);
                        Assert.AreSame(getSourceErrorText, BaseModule.AssertLookup["alphasearchSourceResult"]);

                    }
                    catch (AssertionException asx)
                    {
                        Console.WriteLine(asx.StackTrace);

                    }
                }
            }
        }



        public void SisterSiteWarning(Drivercontext context)
        {
            var getWarningSisterSite = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["warningSistersite"]), 50);
            String getWarningSisterSiteText = getWarningSisterSite.Text;
            Console.WriteLine("Warning SisterSIte Appearing !! :"+getWarningSisterSiteText);
            var getSisterSite = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["sisterSitelink"]), 50);
            string getSisterSiteText = getSisterSite.Text;
            Console.WriteLine("SisterSite Link Text : "+getSisterSiteText);

            if (getSisterSiteText.Contains("USA") || getSisterSiteText.Contains("momondo"))
            {
                getSisterSite.Click();

                Utility.TakeScreenShot(context, "RedirectSisterSite");

            }
        }




        public void OnewaySearch(Drivercontext context, string ticketType, string sourceId, string sourcedata, string destinationId, string destinationData, string fromDateId, string fromDateData, string toDateId, string toDateData, string findDealsId)
        {

            var ticketTypeUI = Utility.FindElement(context, By.XPath(ticketType), 50);
            ticketTypeUI.Click();
            var sourceUI = Utility.FindElement(context, By.XPath(sourceId), 50);
            sourceUI.Clear();
            sourceUI.SendKeys(sourcedata);
            var destinationUI = Utility.FindElement(context, By.XPath(destinationId), 50);
            destinationUI.Clear();
            destinationUI.SendKeys(destinationData);
            var fromDateUI = Utility.FindElement(context, By.XPath(fromDateId), 50);
            fromDateUI.Clear();
            fromDateUI.SendKeys(Keys.Tab);
            fromDateUI.SendKeys(fromDateData);
            var findDeals = Utility.FindElement(context, By.XPath(findDealsId), 50);
            findDeals.Click();

            bool searchResults = Utility.IsTextPresent(BaseModule.AssertLookup["searchHeader"], context);
            if (searchResults.Equals(true))
            {
                Utility.TakeScreenShot(context, "FoundBEOneWaySearchResults");
            }
        }




        public void NLSignup(Drivercontext context, string prdtType, string sourceId, string sourcedata, string destinationId,
            string destinationData, string fromDateId, string fromDateData, string toDateId, string toDateData,
            string checkNL, string emailId, string emailData, string findDealsId)
        {
            var prdtTypeUI = Utility.FindElement(context, By.XPath(prdtType), 50);
            prdtTypeUI.Click();
            var sourceUI = Utility.FindElement(context, By.XPath(sourceId), 50);
            sourceUI.Clear();
            sourceUI.SendKeys(sourcedata);
            var destinationUI = Utility.FindElement(context, By.XPath(destinationId), 50);
            destinationUI.Clear();
            destinationUI.SendKeys(destinationData);
            var fromDateUI = Utility.FindElement(context, By.XPath(fromDateId), 50);
            fromDateUI.Clear();
            fromDateUI.SendKeys(Keys.Tab);
            fromDateUI.SendKeys(fromDateData);
            var toDateUI = Utility.FindElement(context, By.XPath(toDateId), 50);
            toDateUI.Clear();
            toDateUI.SendKeys(Keys.Tab);
            toDateUI.SendKeys(toDateData);
            var newsletterUI = Utility.FindElement(context, By.XPath(checkNL), 50);
            newsletterUI.Click();
            var emailUI = Utility.FindElement(context, By.XPath(emailId), 50);
            emailUI.Clear();
            emailUI.SendKeys(emailData);
            var findDeals = Utility.FindElement(context, By.XPath(findDealsId), 50);
            findDeals.Click();

            bool searchResults = Utility.IsTextPresent(BaseModule.AssertLookup["searchHeader"], context);
            if (searchResults.Equals(true))
            {
                Utility.TakeScreenShot(context, "FoundBESearchNLSignup");
            }
        }





        public void BusinessClassSearch(Drivercontext context, string sourceId, string sourcedata, string destinationId, string destinationData, string fromDateId, string fromDateData, string toDateId, string toDateData, string findDealsId)
        {
            //var classUI = Utility.FindElement(context, By.XPath(".//*[@id='selectClassType']"), 50);
            var classUI = Utility.FindElement(context, By.XPath(".//*[@id='ctl00_ctl00_body']/ul[1]/li[2]"), Utility.TIME_OUT);
            classUI.Click();
            //SelectElement selBusiness = new SelectElement(classUI);
            //selBusiness.SelectByText("Business");
            var sourceUI = Utility.FindElement(context, By.XPath(sourceId), 50);
            sourceUI.Clear();
            sourceUI.SendKeys(sourcedata);
            var destinationUI = Utility.FindElement(context, By.XPath(destinationId), 50);
            destinationUI.Clear();
            destinationUI.SendKeys(destinationData);
            var fromDateUI = Utility.FindElement(context, By.XPath(fromDateId), 50);
            fromDateUI.Clear();
            fromDateUI.SendKeys(Keys.Tab);
            fromDateUI.SendKeys(fromDateData);
            var toDateUI = Utility.FindElement(context, By.XPath(toDateId), 50);
            toDateUI.Clear();
            toDateUI.SendKeys(Keys.Tab);
            toDateUI.SendKeys(toDateData);
            var findDeals = Utility.FindElement(context, By.XPath(findDealsId), 50);
            findDeals.Click();

            bool searchResults = Utility.IsTextPresent(BaseModule.AssertLookup["searchHeader"], context);
            if (searchResults.Equals(true))
            {
                Utility.TakeScreenShot(context, "FoundBESearchNLSignup");
            }

        }



        public void NodateDeparture(Drivercontext context,string fromSource,string fromDate)
        {

            ProductTypeSearch(context, BaseModule.ObjectLookup["FlightsnHotels"], 
                BaseModule.ObjectLookup["beSource"], fromSource,
                BaseModule.ObjectLookup["beDestination"], BaseModule.DataLookup["toDestinationCountry"], BaseModule.ObjectLookup["beFromDate"],
                BaseModule.DataLookup["fromSourceAlpha"],
                BaseModule.ObjectLookup["beToDate"], fromDate , BaseModule.ObjectLookup["newsletter"],
                BaseModule.ObjectLookup["txtEmail"], BaseModule.DataLookup["email"],
                BaseModule.ObjectLookup["befindDeals"]);
            bool WarningMesgDepature = Utility.IsTextPresent(BaseModule.AssertLookup["dateWarningDeparture"], context);
            if (WarningMesgDepature.Equals(true))
            {
                Utility.TakeScreenShot(context, "SearchWithoutDepartDates");
                Console.WriteLine("Enter Dates & Continue to Search");
            }
        }


        public void NodateReturn(Drivercontext context,string fromSource,string toDate)
        {
            ProductTypeSearch(context, BaseModule.ObjectLookup["FlightsnHotels"], BaseModule.ObjectLookup["beSource"],
                fromSource, BaseModule.ObjectLookup["beDestination"], BaseModule.DataLookup["toDestinationCountry"],
                BaseModule.ObjectLookup["beFromDate"], toDate, BaseModule.ObjectLookup["beToDate"],
                BaseModule.DataLookup["toDestinationAlpha"], BaseModule.ObjectLookup["newsletter"],
                BaseModule.ObjectLookup["txtEmail"], BaseModule.DataLookup["email"],
                BaseModule.ObjectLookup["befindDeals"]);
            bool WarningMesgReturn = Utility.IsTextPresent(BaseModule.AssertLookup["dateWarningReturn"], context);
            Console.WriteLine("Warning Message !!" + WarningMesgReturn);
            if (WarningMesgReturn.Equals(true))
            {
                Utility.TakeScreenShot(context, "SearchWithoutReturnDates");
                Console.WriteLine("Enter Dates & Continue to Search");
            }
        }



        public void NoDepartPoint(Drivercontext context,string fromDate,string toDate)
        {
            ProductTypeSearch(context, BaseModule.ObjectLookup["FlightsnHotels"], BaseModule.ObjectLookup["beSource"],
                BaseModule.DataLookup["empty"], BaseModule.ObjectLookup["beDestination"], BaseModule.DataLookup["toDestination"],
                BaseModule.ObjectLookup["beFromDate"], fromDate, BaseModule.ObjectLookup["beToDate"],
                toDate, BaseModule.ObjectLookup["newsletter"],
                BaseModule.ObjectLookup["txtEmail"], BaseModule.DataLookup["email"],
                BaseModule.ObjectLookup["befindDeals"]);

            bool WarningMesgDepart = Utility.IsTextPresent(BaseModule.AssertLookup["sourceWarning"], context);
            if (WarningMesgDepart.Equals(true))
            {
                Utility.TakeScreenShot(context, "SearchWithoutDestination");
                Console.WriteLine("Enter Depart Point");
            }


        }



        public void NoReturnPoint(Drivercontext context,string fromSource,string fromDate,string toDate)
        {

            ProductTypeSearch(context, BaseModule.ObjectLookup["FlightsnHotels"], BaseModule.ObjectLookup["beSource"],
                fromSource , BaseModule.ObjectLookup["beDestination"], BaseModule.DataLookup["toDestinationAlpha"],
                BaseModule.ObjectLookup["beFromDate"], fromDate, BaseModule.ObjectLookup["beToDate"],
                 toDate, BaseModule.ObjectLookup["newsletter"],
                BaseModule.ObjectLookup["txtEmail"], BaseModule.DataLookup["email"],
                BaseModule.ObjectLookup["befindDeals"]);
            bool WarningMesgReturn = Utility.IsTextPresent(BaseModule.AssertLookup["alphasearchDestinationResult"], context);
            if (WarningMesgReturn.Equals(true))
            {
                Utility.TakeScreenShot(context, "SearchWithoutSource");
                Console.WriteLine("Enter Return point");
            }
        }



        public static int GetCountofResults(Drivercontext context)
        {
            IList<IWebElement> getresultsGo = Utility.FindElements(context, By.XPath(BaseModule.ObjectLookup["goCount"]), 50);
            int countGo = getresultsGo.Count;
            Console.WriteLine("Count of Search results is : " + countGo);
            return countGo;

        }



        public void GetProductTypeCount(Drivercontext context)
        {
            Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);


            IList<IWebElement> getPrdtType = Utility.FindElements(context, By.XPath(BaseModule.ObjectLookup["prdtTypeCount"]), 50);
            int countPrdtType = getPrdtType.Count;
            Console.WriteLine("Count of Product Type is : " + countPrdtType);
            if (countPrdtType.Equals(4))
            {
                for (int prdtType = 1; prdtType <= countPrdtType; prdtType++)
                {
                    var getLabels = Utility.FindElement(context, By.XPath(".//*[@id='be-searchType']/div[" + prdtType + "]/label"), 50);
                    string getLabelsText = getLabels.Text;
                    Console.WriteLine("Value is : " + getLabels.Text);
                    
                    Utility.TakeScreenShot(context, "PrdttypeFound");

                }
                Console.WriteLine("All Product Type Found !!!");
            }
            else
            {
                Console.WriteLine("Missing a Prdt Type");
                Utility.TakeScreenShot(context, "MissingPrdtType");
            }
        }



        public void GetAdultNumberCount(Drivercontext context)
        {
            Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);

            SelectElement getSelectAdult = new SelectElement(Utility.FindElement(context, By.Id("selectAdultsNumber"), 50));
            IList<IWebElement> getAdultNumber = getSelectAdult.Options;
            int countAdultNumber = getAdultNumber.Count;
            Console.WriteLine("Count of Adult Number : " + countAdultNumber);
            if (countAdultNumber.Equals(9))
            {
                Console.WriteLine("Adult Drop down is populated rightly !!!!");

            }

        }




        public void GetChildrenNumberCount(Drivercontext context)
        {
            Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);

            SelectElement selectChildrenNumber = new SelectElement(Utility.FindElement(context, By.Id("selectChildrenNumber"), 50));
            IList<IWebElement> getChildrenNumber = selectChildrenNumber.Options;
            int countChildrenNumber = getChildrenNumber.Count;
            Console.WriteLine("Count of Children Number : " + countChildrenNumber);
            if (countChildrenNumber.Equals(50))
            {
                Console.WriteLine("Children Drop down is populated rightly !!!!");
            }

        }



        public void GetInfantNumberCount(Drivercontext context)
        {
            Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);

            SelectElement selectInfantNumber = new SelectElement(Utility.FindElement(context, By.Id("selectInfantsNumber"), 50));
            IList<IWebElement> getInfantNumber = selectInfantNumber.Options;
            int countInfantNumber = getInfantNumber.Count;
            Console.WriteLine("Count of Infant Number : " + countInfantNumber);
            if (countInfantNumber.Equals(3))
            {
                Console.WriteLine("Infants Drop Down is populated rightly !!!");
            }

        }


        public void ClickonPartner(Drivercontext context,string fromSource,string toDestination,string toDate,string fromDate)
        {
            Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);

            ProductTypeSearch(context, BaseModule.ObjectLookup["FlightsnHotels"], BaseModule.ObjectLookup["beSource"],
                fromSource, BaseModule.ObjectLookup["beDestination"],toDestination,
                BaseModule.ObjectLookup["beFromDate"],fromDate, BaseModule.ObjectLookup["beToDate"],
                toDate, BaseModule.ObjectLookup["newsletter"],
                BaseModule.ObjectLookup["txtEmail"], BaseModule.DataLookup["email"],
                BaseModule.ObjectLookup["befindDeals"]);

            Utility.TakeScreenShot(context, "FoundBESearchResults");

            bool searchResults = Utility.IsTextPresent(BaseModule.AssertLookup["searchHeader"], context);
            if (searchResults.Equals(true))
            {
                if (GetCountofResults(context) > 0)
                {
                    //Test clicking link text
                    var clickGo = Utility.FindElement(context, By.XPath(".//*[@id='results-list']/li[1]/a/span[1]"), 50);
                    Utility.ClickAndWaitForPartnerPageToLoad(context, clickGo, () => { Utility.TakeScreenShot(context, "PartnerSiteGo"); });
                    
                    //Test clicking partner logo
                    var clickPartner = Utility.FindElement(context, By.XPath(".//*[@id='results-list']/li[1]/img[1]"), 50);
                    Utility.ClickAndWaitForPartnerPageToLoad(context, clickGo, () => { Utility.TakeScreenShot(context, "PartnerSiteImage"); });
                }
            }

        }

        public void GetSisterSiteMessage(Drivercontext context)
        {
            var getSisterMessage = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["sisterMsgHeader"]), 50);
            string getTextSister = getSisterMessage.Text;
            Console.WriteLine("Sister Site Message  :" + getTextSister);
            if (getTextSister.Contains(BaseModule.AssertLookup["sisterMessage"]))
            {

                Console.WriteLine("Popup with site site is displayed");
                Utility.TakeScreenShot(context, "RedirectToSisSite");
            }


        }


        public static int GetCountofDeals(Drivercontext context)
        {

            IList<IWebElement> dealsFound = Utility.FindElements(context, By.XPath(BaseModule.ObjectLookup["dealsExist"]), 50);
            int countDeals = dealsFound.Count;
            Console.WriteLine("List of Deals Found : " + countDeals);
            return countDeals;
        }


        public void DealsBelowBE(Drivercontext context)
        {

            Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);

            ProductTypeSearch(context, BaseModule.ObjectLookup["FlightsnHotels"], BaseModule.ObjectLookup["beSource"],
                BaseModule.DataLookup["fromSource"], BaseModule.ObjectLookup["beDestination"], BaseModule.DataLookup["toDestination"],
                BaseModule.ObjectLookup["beFromDate"], BaseModule.DataLookup["fromDate"], BaseModule.ObjectLookup["beToDate"],
                BaseModule.DataLookup["toDate"], BaseModule.ObjectLookup["newsletter"],
                BaseModule.ObjectLookup["txtEmail"], BaseModule.DataLookup["email"],
                BaseModule.ObjectLookup["befindDeals"]);
            //Utility.Pause(8000);
            Utility.TakeScreenShot(context, "FoundBESearchResults");
            var getdealsHeader = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["dealsBelowHeader"]), 8000);
            string writeDealsHeader = getdealsHeader.Text;
            Console.WriteLine("Deals Found Header : " + writeDealsHeader);

            if (writeDealsHeader.Contains(BaseModule.AssertLookup["dealsBelowBE"]))
            {

                if (GetCountofDeals(context) > 0)
                {
                    Utility.TakeScreenShot(context, "DealsBelowBE");

                }
                Console.WriteLine("Deals Found");


            }
            else
            {
                Console.WriteLine("No deals found");
                Utility.TakeScreenShot(context, "NoDealsFound");

            }

        }



        public void GetReturnTime(Drivercontext context)
        {
            Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);

            SelectElement selectReturnTime = new SelectElement(Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["returnTime"]), 50));
            IList<IWebElement> getTimeOptions = selectReturnTime.Options;
            int countTimeOptions = getTimeOptions.Count;
            Console.WriteLine("Here is the count of Options :  " + countTimeOptions);
            if (countTimeOptions.Equals(4))
            {
                Console.WriteLine("All Time Options are present : ");
                Utility.TakeScreenShot(context, "TimeOptions");

            }
            else
            {
                Console.WriteLine("There are Options Missing within dropdown !!! ");


            }


        }



        public void DynamicSearch(Drivercontext context)
        {
            Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);

            var sourceUI = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["beSource"]), 50);
            sourceUI.Clear();
            sourceUI.SendKeys(BaseModule.DataLookup["fromSourceIATA"]);

            Utility.TakeScreenShot(context, "DynamicSearchSource");
            var destinationUI = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["beDestination"]), 50);
            destinationUI.Clear();
            destinationUI.SendKeys(BaseModule.DataLookup["toDestinationIATA"]);

            Utility.TakeScreenShot(context, "DynamicSearchDestination");

        }



        public void GetHeader(Drivercontext context)
        {
            Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["Searchbydate"]);

            var getHeader = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["beHeader"]), 50);
            string getheaderText = getHeader.Text;
            Console.WriteLine("Header Value is :  " + getheaderText);
            var getSubtitle = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["beSubtitle"]), 50);
            string getsubtitleText = getSubtitle.Text;
            Console.WriteLine("Header Value is :  " + getsubtitleText);

        }


        public void SelectOtherOptions(Drivercontext context)
        {
            var getRegionOption = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["tableRegionRadio"]), 50);
            getRegionOption.Click();
            var continueBtn = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["continueButton"]), 50);
            continueBtn.Click();
            Console.WriteLine("You are done here");
        }

    }
}
