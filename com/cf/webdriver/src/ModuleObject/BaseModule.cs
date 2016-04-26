using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestWebDriver.com.cf.webdriver.src.Common;

namespace TestWebDriver.com.cf.webdriver.src.ModuleObject
{
    public class BaseModule
    {

        public static Dictionary<string, string> DataLookup { get; private set; }

        public static Dictionary<string, string> ObjectLookup { get; private set; }

        public static Dictionary<string, string> AssertLookup { get; private set; }

        static BaseModule()
        {
                DataLookup = GetDataLookup();
                ObjectLookup = GetobjLookup();
                AssertLookup = GetassertObj();
        }



        /* This Collection will store values for data that flows in our website.
         * 
         * **/
        public static Dictionary<string, string> GetDataLookup()
        {
                    Dictionary<string, string> DataLookup = new Dictionary<string, string>();
                    DataLookup.Add("fromSource", "London, United Kingdom - Heathrow (LHR)");
                    DataLookup.Add("fromsourceAu", "Sydney");
                    DataLookup.Add("toDestination", "Boston, MA, USA");
                    DataLookup.Add("FuzzySource","loudon");
                    DataLookup.Add("FuzzyDestination", "Bosuton");
                    // DataLookup.Add("toDestination", "qwerty");
                    // Data for IATA to IATA search
                    DataLookup.Add("fromSourceIATA", "EDI");
                    DataLookup.Add("fromSourceUSIATA","BOS");
                    DataLookup.Add("fromSourceAuIATA","SYD");
                    DataLookup.Add("toDestinationIATA", "MAD");
                    // Data for IATA to Region
                    DataLookup.Add("toDestinationRegion", "Caribbean");
                    // Data for State
                    DataLookup.Add("toDestinationState", "Florida");
                    //Data for IATA to Country
                    DataLookup.Add("toDestinationCountry", "India");
                    DataLookup.Add("toSourceCountry", "GLA");
                    //Data for Continent
                    DataLookup.Add("toDestinationContinent", "Asia");
                    //Data for Catchment Airport
                    DataLookup.Add("fromSourceAirport", "Dublin");
                    //Data for Catchment Airport
                    DataLookup.Add("fromSourceAnywhere", "BKK");
                    DataLookup.Add("toDestinationAnywhere", "Sydney");
                    //Data for Alphanumeric source
                    DataLookup.Add("fromSourceAlpha", "10n");
                    DataLookup.Add("toDestinationAlpha", "£3n");
                    DataLookup.Add("fromDate", Utility.GetDate(10));
                    DataLookup.Add("toDate", Utility.GetDate(12));
                    DataLookup.Add("fromDateUS", Utility.GetDateUS(10));
                    DataLookup.Add("toDateUS", Utility.GetDateUS(12));
                    DataLookup.Add("adult", "4");
                    DataLookup.Add("children", "1");
                    DataLookup.Add("changeDestinationData", "Paris, France - all airports (PAR)");
                    DataLookup.Add("flightDealsSearch","LAX");
                    DataLookup.Add("email", "dummy@gmail.com");
                    DataLookup.Add("emailid","shabana.khanam@cheapflights.com");
                    DataLookup.Add("postcode","WC1E 7EB");
                    DataLookup.Add("empty", "");
                    DataLookup.Add("agentLink", "Airlines and agents A-Z");
                    DataLookup.Add("sourceAlternateDeals", "Wick, United Kingdom");
                    DataLookup.Add("AusourceAlternateDeals", "Hokitika, New Zealand");
                    DataLookup.Add("destinationAlternateDeals", "Xi An, China - Xian Xianyang (XIY)");
                    DataLookup.Add("fname","auto");
                    DataLookup.Add("lname","tester");
                    //Travel Know how        
                    DataLookup.Add("continentEurope","Europe");
                    DataLookup.Add("continentAfrica","Africa");
                    DataLookup.Add("countryIreland","Ireland");
                    DataLookup.Add("cityDublin","Dublin");
                    // holidays
                    DataLookup.Add("destinationholidays", "Tenerife, CANARY ISLANDS");
                    DataLookup.Add("FooterInvalid", "Popular citieddds");
                    DataLookup.Add("Footervalid", "Popular cities");
                    DataLookup.Add("Footervalidtwo", "Departure Gate");
                    
                    


                    
                    return DataLookup;
        }



        /*This Collection will store values for objects on the webpage 
         * Your working on
         * **/

        public static Dictionary<string, string> GetobjLookup()
        {
                    Dictionary<string, string> ObjLookup = new Dictionary<string, string>();
                    ObjLookup.Add("littlepopup", "html/body/div[2]/div[4]/img");
                    //Flight Deals and Home Page
                    ObjLookup.Add("fromSource", ".//*[@id='sb-from']/input");
                    ObjLookup.Add("toDestination", ".//*[@id='sb-to']/input");
                    ObjLookup.Add("fixedRate", ".//*[@id='sb-fixed']/span");
                    ObjLookup.Add("flexRate", ".//*[@id='sb-deals-search']/span[1]");
                    ObjLookup.Add("fromDate", ".//*[@id='sb-depart']/input[starts-with(@id,'dp1')]");
                    ObjLookup.Add("toDate", ".//*[@id='sb-return']/input[starts-with(@id,'dp1')]");
                    ObjLookup.Add("adult", ".//*[@id='sb-adults']/option[value='3']");
                    ObjLookup.Add("children", ".//*[@id='sb-children']/option[value='2']");
                    ObjLookup.Add("findFlexSearch", ".//*[@id='sb-deals-search']/span[1]");
                    ObjLookup.Add("findFixedSearch", ".//*[@id='sb-be-search']/span[1]");
                    ObjLookup.Add("changeSearchLink", ".//*[@id='contentContainer']/div[2]/div/span[1]/a");
                    ObjLookup.Add("changeDestination", ".//*[@id='ctl00_ctl00_body']/div[8]/div[2]/div/div[4]/input");
                    ObjLookup.Add("SearchButton", ".//*[@id='ctl00_ctl00_body']/div[8]/div[2]/div/a/span[1]");
                    ObjLookup.Add("nlcheckbox", ".//*[@id='sb-nlsignup']/span");
                    ObjLookup.Add("flightDealsHeader", ".//*[@id='contentContainer']/div[1]/h1");
                    ObjLookup.Add("changeSearch", ".//*[@id='contentContainer']/div[2]/div/span[1]/a");
                    // Main Tabs 
                    ObjLookup.Add("Home", "Home");
                    ObjLookup.Add("flightdeals", "Flight deals");
                    ObjLookup.Add("Searchbydate", "Search by date");
                    ObjLookup.Add("Staff", "Staff picks");
                    ObjLookup.Add("inspired", "Be inspired");
                    ObjLookup.Add("knowhow", "Travel know-how");
                    ObjLookup.Add("Newsletter", "Newsletter");
                    ObjLookup.Add("Holidays","Holidays");
                    
                    //Handpicked Deals 
                    ObjLookup.Add("hpdDetails", ".//*[@id='ctl00_cp1_handPickedDealList']/tbody/tr[1]/td/a");
                    ObjLookup.Add("dateLabel", ".//*[@id='ctl00_cp1_handPickedDealList']/tbody/tr/td[1]/div/dl/dt");
                    ObjLookup.Add("hpdHeader", ".//*[@id='ctl00_cp1_heading']");
                    //Australia
                    ObjLookup.Add("Hotdeals", "Hot deals");
                    ObjLookup.Add("travelguides", "Travel guides");
                    //United States
                    ObjLookup.Add("flightshotels","Flights & hotels");
                    ObjLookup.Add("travel101","Travel 101");
                    //Canada
                    ObjLookup.Add("flightsandhotels","Flights and hotels");
                    //Search by date Page
                    ObjLookup.Add("prdtTypeCount", ".//*[@id='be-searchType']/div/input");
                    ObjLookup.Add("goCount", ".//*[@id='results-list']/li");
                    ObjLookup.Add("returnTime", ".//*[@id='returnTimeType']/select");
                    //Booking Engine Page
                    ObjLookup.Add("Flights", ".//*[@id='be-searchType']/div[1]/label");
                    ObjLookup.Add("FlightsnHotels", ".//*[@id='be-searchType']/div[2]/label");
                    ObjLookup.Add("Hotels", ".//*[@id='be-searchType']/div[3]/label");
                    ObjLookup.Add("Car", ".//*[@id='be-searchType']/div[4]/label");
                    ObjLookup.Add("beSource", ".//*[@id='textBoxOrigin']");
                    ObjLookup.Add("beDestination", ".//*[@id='textBoxDestination']");
                    ObjLookup.Add("beFromDate", ".//*[@id='textBoxDepartureDate']");
                    ObjLookup.Add("beToDate", ".//*[@id='textBoxReturnDate']");
                    ObjLookup.Add("befindDeals", ".//*[@id='buttonSearch']");
                    ObjLookup.Add("beFlightsPrdtType", ".//*[@id='be-searchType']/div[1]/label");
                    ObjLookup.Add("beFlightsnHotelPrdtType", ".//*[@id='be-searchType']/div[2]/label");
                    ObjLookup.Add("beHotelPrdtType", ".//*[@id='be-searchType']/div[3]/label");
                    ObjLookup.Add("beCarPrdtType", ".//*[@id='be-searchType']/div[4]/label");
                    ObjLookup.Add("noresultsFound", ".//*[@id='results-view']/span");
                    ObjLookup.Add("ticketTypeOneway", ".//*[@id='sgl']/input[starts-with(@id,'radioTicketType')]");
                    ObjLookup.Add("ticketTypeReturn", ".//*[@id='ret']/input[starts-with(@id,'radioTicketType')]");
                    ObjLookup.Add("ticketType", ".//*[@id='sgl']/label");
                    ObjLookup.Add("newsletter", ".//*[@id='be-newsletter']/span[1]/label");
                    ObjLookup.Add("flightdealsnl", ".//*[@id='sb-nlsignup']/span[1]");
                    ObjLookup.Add("flightdealstxtemail", ".//*[@id='sb-email']/input");
                    ObjLookup.Add("txtEmail", ".//*[@id='textBoxNewsletter']");
                    ObjLookup.Add("dealsBelowHeader", ".//*[@id='flight-header']/h2");
                    ObjLookup.Add("dealsExist", ".//*[starts-with(@id,'deal-')]");
                    ObjLookup.Add("beLookUp", "//*[@id='bookingEngine']");
                    ObjLookup.Add("sisterMsgHeader", ".//*[@id='se-text']");
                    ObjLookup.Add("BEHeaderSearchResults", ".//*[@id='bouncing-signpost']/span/");
                    //HPD
                    ObjLookup.Add("handpickedlinks", ".//*[@id='HPDModule']/ul/li");
                    //Assert Header Validations
                    ObjLookup.Add("validResponseFlightdeals", ".//*[@id='contentContainer']/div[1]/h1");
                    //Alternate Deals Page
                    ObjLookup.Add("headerGuideModule", ".//*[@id='ctl00_cp1_flightGuide']/h2");
                    ObjLookup.Add("validateWarningAlternateDeals", ".//*[@id='contentContainer']/div[1]/div[1]/p");
                    //Change Route 
                    ObjLookup.Add("changeRoute", ".//*[@id='changeRouteButton']");
                    //Get Text for failed results
                    ObjLookup.Add("alphaFailSourceResult", ".//*[@id='ctl00_cp1_SearchSelection_selectDepartureLocation']/p");
                    ObjLookup.Add("alphaFailDestinationResult",".//*[@id='ctl00_cp1_SearchSelection_selectDestinationLocation']/p");
                    ObjLookup.Add("errorMsg",".//*[@id='ctl00_cp1_SearchSelection']/div[1]/h1/span"); 
                    //Get the table for selecting Region
                    ObjLookup.Add("tableRegionRadio", ".//*[@id='ctl00_cp1_SearchSelection_selectDestinationLocation_regionsRadioButtonList_0']");
                    ObjLookup.Add("continueButton",".//*[@id='ctl00_cp1_SearchSelection_continueButton']");
                    //Warning messages header 
                    ObjLookup.Add("warningMesg", ".//*[@id='ctl00_cp1_SearchSelection']/div[1]/h1/span");
                    ObjLookup.Add("warningSistersite", ".//*[@id='ctl00_cp1_SearchSelection_selectDepartureLocation']/p");
                    ObjLookup.Add("sisterSitelink", ".//*[@id='ctl00_cp1_SearchSelection_selectDepartureLocation_alternativeSitesButtonList']/li/a");
                    //Destination split page
                    ObjLookup.Add("containerParentDiv", ".//*[@id='ctl00_cp1_destinationList']/ol[1]/descendant::li");
                    ObjLookup.Add("mapContainer", ".//*[@id='page']/div[2]/div[1]/div[2]/div/ul[1]");
                    //Inspire Me page
                    ObjLookup.Add("departurePoint", ".//*[@id='departure']");
                    ObjLookup.Add("beaches", ".//*[@id='searchform']/div[3]/ul/li[1]/label/span[2]");
                    ObjLookup.Add("citybreak", ".//*[@id='searchform']/div[3]/ul/li[2]/label/span[2]");
                    ObjLookup.Add("family", ".//*[@id='searchform']/div[3]/ul/li[3]/label/span[2]");
                    ObjLookup.Add("adventure", ".//*[@id='searchform']/div[3]/ul/li[4]/label/span[2]");
                    ObjLookup.Add("skisnow", ".//*[@id='searchform']/div[3]/ul/li[5]/label/span[2]");
                    ObjLookup.Add("any", ".//*[@id='searchform']/div[3]/ul/li[6]/label/span[2]");
                    ObjLookup.Add("inspireMeButton", ".//*[@id='searchform']/a[@id='searchButton']");
                    ObjLookup.Add("warningDeparture", ".//*[@id='inspirationErrors']/div[2]/ul/li");
                    ObjLookup.Add("getHeaderIMe", ".//*[@id='inspiration-search']/div[1]/h1");
                    ObjLookup.Add("selectbeinspired", "//*[@id='searchform']/div[@class='when-select']/select[@id='when']");
                    ObjLookup.Add("getDepartingIMe", ".//*[@id='searchform']/div[2]/div/ul/li");
                    ObjLookup.Add("getOptionsIMe",".//*[@id='searchform']/div[3]/ul/li/input");
                    ObjLookup.Add("getSearchSourceIme", ".//*[@id='summary']/label[1]/span");
                    ObjLookup.Add("getSearchDurationIme", ".//*[@id='summary']/label[2]/span");
                    ObjLookup.Add("getSearchPreferenceIme", ".//*[@id='summary']/label[3]/span");
                    //Travel Knwo How
                    ObjLookup.Add("travelTitles", ".//*[@id='showcase-list']/li");
                    ObjLookup.Add("traveltipdivs",".//*[@id='showcase']/div");
                    ObjLookup.Add("travelTips", "Travel tips");
                    ObjLookup.Add("usefulHeader", ".//*[@id='ctl00_cp1_indexTitle']");
                    ObjLookup.Add("modules", ".//*[starts-with(@id,'ctl00_cp1_dest')]");
                    ObjLookup.Add("flightNews", ".//*[@id='ctl00_cp1_flightNews']/div/h3");
                    ObjLookup.Add("travelTipsheader", ".//*[@id='ctl00_cp1_travelTips']/h4");
                    ObjLookup.Add("travelarticle", ".//*[@id='showcase-list']/li[1]/span");
                    ObjLookup.Add("travelarticlesub",".//*[@id='showcase']/div[2]/ul/li");
                    //Social Media Follow us
                    //ObjLookup.Add("faceBookUI", ".//*[@id='facebook-follow']/span[1]");
                    ObjLookup.Add("faceBookUI", ".//*[@id='social-follow']/span[1]/a/img");
                    ObjLookup.Add("twitterUI", ".//*[@id='social-follow']/span[2]/a/img");
                    ObjLookup.Add("gplusUI", ".//*[@id='social-follow']/span[3]/a/img");
                    //ObjLookup.Add("twitterUI", ".//*[@id='twitter-follow']/span[1]");
                    //ObjLookup.Add("gplusUI", ".//*[@id='gplus-follow']/span[1]");
                    ObjLookup.Add("followusIframe", "social-follow");
                    //useful links
                    ObjLookup.Add("listCountries", ".//*[@id='ctl00_cp1_csm']/ol/li/ol/li");
                    ObjLookup.Add("listCities", ".//*[@id='ctl00_ctl00_cp1_MainContent_csm']/ol/li/ol/li/ol/li");
                    ObjLookup.Add("airportGuide", ".//*[@id='ctl00_cp1_airportGuide']/h4");
                    ObjLookup.Add("travelTipsModule", ".//*[@id='ctl00_cp1_travelTips3']/h4");
                    ObjLookup.Add("flightDealModule", ".//*[@id='flight_guide_deal']/h4");
                    ObjLookup.Add("topCheapFlights", ".//*[@id='rightnav']/div[1]/div/h4");
                    //ObjLookup.Add("miniFlightSearch", ".//*[@id='ctl00_cp1_miniDealsSearch']/div/h4/span");
                    ObjLookup.Add("miniFlightSearch", ".//*[@id='ctl00_ctl00_cp1_MainContent_miniDealsSearch']/div[@class='rightnav dealscontainer minideals clearfix']/h4");
                    ObjLookup.Add("beHeader", ".//*[@id='be-title']");
                    ObjLookup.Add("beSubtitle", ".//*[@id='be-subtitle']");
                    //GooglePPC 
                    ObjLookup.Add("getSearchHeader", ".//*[@id='search-header']");
                    ObjLookup.Add("gethpdHeader", ".//*[@id='rightDiv']/h2");
                    //Home Page
                    ObjLookup.Add("getFlagId",".//*[@id='country-selector']/a");
                    ObjLookup.Add("getFlagLink", ".//*[@id='country-selector']/ul/li");
                    ObjLookup.Add("getFlagLabel", ".//*[@id='country-selector']/label");
                    ObjLookup.Add("getMainLogo",".//*[@id='page-header']/a/img");
                    ObjLookup.Add("getStrap", ".//*[@id='page-header']/h1");
                    ObjLookup.Add("travelTipHome", ".//*[@id='page']/div/div[1]/div[3]/ul/li");
                    //ObjLookup.Add("departureSpiltPage", ".//*[@id='page']/div[2]/div[1]/div[1]/div/div");
                    //ObjLookup.Add("","");
                    ObjLookup.Add("departureCityHeader", ".//*[@id='contentContainer']/div[1]/h1");
                    //ObjLookup.Add("continentLinks", ".//*[@id='page']/div/div/div/div/ul[1]/li");
                    ObjLookup.Add("continentLinks", ".//*[@id='module-continentlinks']/ul/li");
                    ObjLookup.Add("continentcountry", ".//*[starts-with(@id,'xxx-')]/div[2]/ul/li");
                    ObjLookup.Add("editorLinks", ".//*[@id='page']/div/div/div/div/ul[2]/li");
                    //ObjLookup.Add("continentHeader", ".//*[@id='contentContainer']/div[@class='ab-column-content']/div[@class='dep-split']/h1");
                    ObjLookup.Add("continentHeader", ".//*[@id='contentContainer']/div[1]/h1");
                    ObjLookup.Add("newsletterHP", ".//*[@id='sb-nlsignup']/span");
                    //TravelGuide
                    ObjLookup.Add("TravelGuide","Travel guides");
                    //ObjLookup.Add("TravelGuideHeader", ".//*[@id='ctl00_cp1_h1']");
                    ObjLookup.Add("TravelGuideHeader", ".//*[@id='contenthead']/div/h1");
                    ObjLookup.Add("TGPoplarlinkHeader", ".//*[@id='contenthead']/div[@class='guideheader']/h1");
                    ObjLookup.Add("TravelGuideSearchBox", ".//*[@id='ctl00_ctl07_destination']");
                    ObjLookup.Add("TravelGuideSearchButton", ".//*[@id='ctl00_ctl07_searchButton']");
                    ObjLookup.Add("TGNAmerica", ".//*[@id='ctl00_cp1_dest_XXX-NAMR']");
                    ObjLookup.Add("TGSAmerica", ".//*[@id='ctl00_cp1_dest_XXX-SAMR']");
                    ObjLookup.Add("TGEurope", ".//*[@id='ctl00_cp1_dest_XXX-EURP']");
                    ObjLookup.Add("TGAfrica", ".//*[@id='ctl00_cp1_dest_XXX-AFRC']");
                    ObjLookup.Add("TGAsia", ".//*[@id='ctl00_cp1_dest_XXX-ASIA']");
                    ObjLookup.Add("TGOceania", ".//*[@id='ctl00_cp1_dest_XXX-OCEN']");
                    //ObjLookup.Add("travelTipModule", ".//*[@id='ctl00_cp1_travelTips']");
                    ObjLookup.Add("travelTipModule", ".//*[@id='ctl00_ctl00_cp1_MainContent_travelTips']");
                    ObjLookup.Add("TGusefulLinkTitle", ".//*[@id='ctl00_cp1_detailTitle']");
                    ObjLookup.Add("usefullinksLeft", ".//*[@id='contentContainer']/div[2]/div[6]/dl[1]/dt");
                    ObjLookup.Add("usefullinksRight", ".//*[@id='contentContainer']/div[2]/div[6]/dl[2]/dt");
                    ObjLookup.Add("poplarLinks", ".//*[@id='ctl00_cp1_destPopularCities']/ul/li");
                    //ObjLookup.Add("airportGuideTG", ".//*[@id='ctl00_cp1_airportGuides']");
                    ObjLookup.Add("airportGuideTG", ".//*[@id='ctl00_ctl00_cp1_MainContent_airportGuides']");
                    //ObjLookup.Add("flightNewsTG", ".//*[@id='ctl00_cp1_flightNews']");
                    ObjLookup.Add("flightNewsTG", ".//*[@id='ctl00_ctl00_cp1_MainContent_flightNews']");
                    //ObjLookup.Add("usefulLinksTG", ".//*[@id='ctl00_cp1_usefulLinks']");
                    ObjLookup.Add("usefulLinksTG", ".//*[@id='ctl00_ctl00_cp1_MainContent_usefulLinks']");
                    //ObjLookup.Add("flightTimes", ".//*[@id='ctl00_cp1_rightNavOtherContainer']/div/h4");
                    ObjLookup.Add("flightTimes", ".//*[@id='ctl00_ctl00_cp1_MainContent_rightNavOtherContainer']/div/h4");
                    //ObjLookup.Add("flightReading", ".//*[@id='ctl00_cp1_inFlightReading']/div/h4");
                    ObjLookup.Add("flightReading", ".//*[@class='rightnav reading']/div[@class='secondaryColour reading']/h4");
                    //ObjLookup.Add("subsribeNL", ".//*[@id='ctl00_cp1_emailSignUp']/a");
                    ObjLookup.Add("subsribeNL", ".//*[@id='ctl00_ctl00_cp1_MainContent_emailSignUp']/a");
                    ObjLookup.Add("spiltLink", ".//*[@id='ctl00_ctl00_cp1_MainContent_search4Flights']");
                    //ObjLookup.Add("TGdestination", ".//*[@id='ctl00_ctl07_DestinationRegion']");
                    ObjLookup.Add("TGdestination", ".//*[@id='ctl00_ctl00_ctl07_DepartureRegion']");
                    //ObjLookup.Add("TGdeparture", ".//*[@id='ctl00_ctl07_DepartureRegion']");
                    ObjLookup.Add("TGdeparture", ".//*[@id='ctl00_ctl00_ctl07_DepartureRegion']");
                    //ObjLookup.Add("TGfindDeals", ".//*[@id='ctl00_ctl07_SearchButton']");
                    ObjLookup.Add("TGfindDeals", ".//*[@id='ctl00_ctl00_ctl07_SearchButton']");
                    ObjLookup.Add("airLineAgent", "Airlines and agents A-Z");
                    ObjLookup.Add("airlineAgentHeader", ".//*[@id='ctl00_cp1_agentListPanel']/div[1]/h1");
                    ObjLookup.Add("agentWeb", ".//*[@id='ctl00_cp1_agentlist']/table/tbody/tr/td[3]/a");
                    ObjLookup.Add("agentPhone", ".//*[@id='ctl00_cp1_agentlist']/table/tbody/tr/td[4]/a");
                    ObjLookup.Add("tgcity",".//*[@id='ctl00_cp1_csm']/ol/li/ol/li/ol/li[1]/a");
                    // Flight Deals Page 
                    ObjLookup.Add("searchModule", ".//*[@id='search-box']/span");
                    ObjLookup.Add("topDestinations", ".//*[@id='dest_1']");
                    ObjLookup.Add("socialMedia", ".//*[@id='travel-tips']");
                    ObjLookup.Add("content", ".//*[@id='left_content']/div[3]");
                    ObjLookup.Add("hpd", ".//*[@id='contentContainer']/div[2]");
                    ObjLookup.Add("otherDestinations", ".//*[@id='dest_2']");
                    //ObjLookup.Add("topdestinationModuleLinks", ".//*[@id='dest_1']/div/div/p/a");
                    ObjLookup.Add("topdest", ".//*[@id='dest_1']/div/div");
                    ObjLookup.Add("otherdest", ".//*[@id='dest_2']/div/div");
                    ObjLookup.Add("otherdestlinks", ".//*[@id='dest_2']/div/div/p/a");
                    ObjLookup.Add("getheadercontent",".//*[@id='left_content']/div[3]/h2/strong");
                    //Staff Picks
                    ObjLookup.Add("departureRegion", ".//*[@id='ctl00_ctl07_DepartureRegion']");
                    //Travel Know how
                    ObjLookup.Add("departureGuides", ".//*[@id='content']/div[1]/div[1]/div[1]/div/h3/a");
                    //News letter 
                    ObjLookup.Add("nlemail", ".//*[@id='cfemail']");
                    ObjLookup.Add("nlpostcode", ".//*[@id='cfpostalcode']");
                    ObjLookup.Add("Imenlpersonalise", ".//*[@id='SignUpPersonaliseButton']/span[1]");
                    ObjLookup.Add("nloptions", ".//*[@id='newsletter-options-regions cleafix']/div[2]/div/span");
                    ObjLookup.Add("IMenldone", ".//*[@id='LifeStyleOptionsButtonDone']");
                    ObjLookup.Add("IMeconfirmHeader", ".//*[@id='newsletter-thank-main-top']/h3");
                    //Airport Guides
                    ObjLookup.Add("agfromsource", ".//*[@id='ctl00_ctl00_ctl08_DepartureRegion']");
                    ObjLookup.Add("agtodest", ".//*[@id='ctl00_ctl00_ctl08_DestinationRegion']");
                    ObjLookup.Add("agfinddeals", ".//*[@id='ctl00_ctl00_ctl08_SearchButton']");
                    ObjLookup.Add("AirportGuide","Airport guides");
                    ObjLookup.Add("poplarairports", ".//*[@id='ctl00_ctl00_cp1_MainContent_destPopularAirports']/ul/li");
                    ObjLookup.Add("traveltipmoduleAG", ".//*[@id='ctl00_ctl00_cp1_MainContent_travelTips']");
                    ObjLookup.Add("usefullinkleftmoduleAG",".//*[@id='ctl00_ctl00_cp1_MainContent_usefulLinkCategories']/dl[1]/dt");
                    ObjLookup.Add("usefullinkrightmoduleAG",".//*[@id='ctl00_ctl00_cp1_MainContent_usefulLinkCategories']/dl[2]/dt");
                    ObjLookup.Add("flightnewsAG", ".//*[@id='ctl00_ctl00_cp1_MainContent_flightNews']/div/div/ul/li");
                    ObjLookup.Add("poplarLink", ".//*[@class='popular']/div/ul/li[1]");
                    ObjLookup.Add("airportdetails", ".//*[@class='airportHead col1 threeCs']/h4");
                    ObjLookup.Add("airportiata", ".//*[@class='airportHead col1 threeCs']/h4");
                    ObjLookup.Add("airportheader", ".//*[@class='guideheader ']/h1");
                    ObjLookup.Add("flightguidecity", ".//*[@id='flight_guide_deal']/h4/a");
                    ObjLookup.Add("agcountry", ".//*[@id='ctl00_ctl00_cp1_MainContent_destNorthAmerica']/ul/li[1]");
                    ObjLookup.Add("agcity", ".//*[@id='ctl00_ctl00_cp1_MainContent_csm']/ol/li/ol/li/ol/li[1]");
                    ObjLookup.Add("agflightnews", ".//*[@id='ctl00_ctl00_cp1_MainContent_flightNews']/div/h3");
                    ObjLookup.Add("agusefullinks", ".//*[@id='ctl00_ctl00_cp1_MainContent_usefulLinks']/h3");
                    ObjLookup.Add("agtopflights", ".//*[@class='rightnav dealscontainer minideals clearfix']/h4");
                    ObjLookup.Add("agtraveltips", ".//*[@id='ctl00_ctl00_cp1_MainContent_travelTips']/h4");
                    ObjLookup.Add("agusefullink", ".//*[@id='ctl00_ctl00_cp1_MainContent_usefulLinkCategories']/h4");
                    ObjLookup.Add("agcontinent", ".//*[@id='ctl00_ctl00_cp1_MainContent_destNorthAmerica']/h4");
                    ObjLookup.Add("getallinks", ".//*[@id='ctl00_ctl00_cp1_MainContent_csm']/ol/li/ol/li");
                    ObjLookup.Add("getallcities", ".//*[@id='ctl00_ctl00_cp1_MainContent_csm']/ol/li/ol/li/ol/li");
                    //Departure Spilt page
                    ObjLookup.Add("nameofdeparture",".//*[@name='Alicante']");
                    ObjLookup.Add("linkondep", ".//*[@id='ctl00_ctl00_cp1_MainContent_simpleList']/ol/li");
                    //ObjLookup.Add("searchdeparture", ".//*[@id='ctl00_ctl00_ctl07']/h2");
                    ObjLookup.Add("searchdeparture", ".//*[@id='contentContainer']/div/h1");
                    ObjLookup.Add("depnewsletter", ".//*[@class='newsletter']/h3");
                    ObjLookup.Add("dsdepartureregion", ".//*[@id='ctl00_ctl00_ctl08_DepartureRegion']");
                    ObjLookup.Add("dsdestinationregion", ".//*[@id='ctl00_ctl00_ctl08_DestinationRegion']");
                    ObjLookup.Add("dsfinddeals", ".//*[@id='ctl00_ctl00_ctl08_SearchButton']");
                    ObjLookup.Add("dsnlsignup", ".//*[@id='signup']");
                    ObjLookup.Add("dsnlemail",".//*[@id='cfemail']");
                    ObjLookup.Add("dsnlfname", ".//*[@id='cffirstname']");
                    ObjLookup.Add("dsnllname", ".//*[@id='cflastname']");
                    ObjLookup.Add("dsnlpostcode", "//*[@id='cfpostalcode']");
                    ObjLookup.Add("nlsignupbutton", ".//*[@id='SignUpButton']");
                    ObjLookup.Add("nlpersonalise", ".//*[@id='SignUpPersonaliseButton']");
                    ObjLookup.Add("dsnlpreference", ".//*[@class='ui ui-check']");
                    ObjLookup.Add("dsnldone", ".//*[@id='LifeStyleOptionsButtonDone']");
                    // Holidays 
                    ObjLookup.Add("holidaysdestination","destination");
                    ObjLookup.Add("departdate", "departDate");
                    ObjLookup.Add("departend", "departDateEnd");
                    ObjLookup.Add("searchbutn","hs-search");
                    ObjLookup.Add("flexradio", ".//*[@class='ui ui-radio']");
                    //pop up nl sign up 
                    ObjLookup.Add("nlsignupbtn",".//*[@id='page']/div[5]/div[2]/a/span[1]");
                    ObjLookup.Add("nlsignupemailtxt",".//*[@id='page']/div[5]/div[3]/div[2]/input[1]");
                    ObjLookup.Add("nlsignuppostcodetxt",".//*[@id='page']/div[5]/div[3]/div[2]/input[3]");
                    ObjLookup.Add("nlsubmitsignup",".//*[@id='page']/div[5]/div[3]/div[2]/a/span[1]");
                    //Switch to Flex
                    ObjLookup.Add("switchflex", ".//*[@id='sb-footer']/div/span");
                    return ObjLookup;


        }


        /* This Collection is  for  
         * Assertions
         * **/

        public static Dictionary<string, string> GetassertObj()
        {
                    Dictionary<string, string> AssertObj = new Dictionary<string, string>();
                    //Cheap flights from London to Berlin (Germany)
                    AssertObj.Add("expTitle", "Cheap flights from " + GetDataLookup()["fromSource"] + " to " + GetDataLookup()["toDestination"]);
                    AssertObj.Add("flightDeals", "Flights from " + GetDataLookup()["fromSource"] + " to " + GetDataLookup()["toDestination"]);
                    AssertObj.Add("TGflightDeals", "Flights from "+GetDataLookup()["fromSource"] + "to");
                    AssertObj.Add("searchHeader", "Search recommended websites");
                    AssertObj.Add("noresultsFound", "Sorry, we do not have any partners that match your search criteria.");
                    AssertObj.Add("flightDealsChanged", "Flights from " + GetDataLookup()["fromSource"] + " to " + GetDataLookup()["changeDestinationData"]);
                    AssertObj.Add("alphasearchSourceResult", "Unfortunately, we were unable to match your search criteria '"+GetDataLookup()["fromSourceAlpha"]+"'. Please modify your search and try again.");
                    AssertObj.Add("alphasearchDestinationResult", "Unfortunately, we were unable to match your search criteria '" + GetDataLookup()["toDestinationAlpha"]+"'. Please modify your search and try again.");
                    AssertObj.Add("warningMsg","Sorry but we require more information");
                    AssertObj.Add("dateWarningDeparture", "Please enter a valid departure date");
                    AssertObj.Add("dateWarningReturn", "Please enter a valid return date");
                    AssertObj.Add("destinationWarning", "Please Enter a Destination Point");
                    AssertObj.Add("sourceWarning", "Please Enter a Departure Point");
                    AssertObj.Add("departureWarning", "Please enter a valid departure");
                    AssertObj.Add("destinationWarningHome", "Please enter a valid destination");
                    AssertObj.Add("dealsPage", "Find Flights to " + GetDataLookup()["toDestinationContinent"]);
                    AssertObj.Add("continentLink", "Cheap flights to " + GetDataLookup()["toDestinationContinent"]);
                    AssertObj.Add("facebookTitle", "Cheapflights | Facebook");
                    AssertObj.Add("twitterTitle", "Cheapflights (@Cheapflights) on Twitter");
                    AssertObj.Add("gPlusTitle", "Cheapflights - Google+");
                    AssertObj.Add("nlTitle","Cheapflights Weekly Newsletter");
                    AssertObj.Add("bInspired", "Be inspired");
                    AssertObj.Add("hpdWarning", "Sorry, there are currently no handpicked deals available. Please check back later.");
                    AssertObj.Add("dealsBelowBE", "Flexible with your dates?");
                    AssertObj.Add("missingEmail","Please enter a valid email address");
                    AssertObj.Add("missingAirports","Please enter a valid departure and destination");
                    AssertObj.Add("missingDates","Please enter a valid departure and return date");
                    AssertObj.Add("warningAlternateDeals", "Sorry, we are unable to find any deals matching your search. Complete the form below to search our partners' websites.");
                    AssertObj.Add("metaValue", "CFUK Deal Pages;CFUK Alternate Deal Pages;CFUK Graphical Ads");
                    AssertObj.Add("alternateHeader", "flights and travel guide");
                    AssertObj.Add("validateUsefulLinks","Useful Links");
                    AssertObj.Add("flightnews","Flight news");
                    AssertObj.Add("travelTips","Travel Tips");
                    AssertObj.Add("continentAssert", "Tourist information for " + GetDataLookup()["continentEurope"]);
                    AssertObj.Add("minideals","Top flights deals");
                    AssertObj.Add("cheapflights", "Cheap flights to " + GetDataLookup()["continentEurope"]);
                    AssertObj.Add("airportGuide","Airport guide");
                    AssertObj.Add("flightGuide","Flight guide to "+ GetDataLookup()["continentEurope"]);
                    AssertObj.Add("countryAssert", "Tourist information for " + GetDataLookup()["continentEurope"]);
                    AssertObj.Add("cheapflightsCountry", "Cheap flights to " + GetDataLookup()["countryIreland"]);
                    AssertObj.Add("flightGuideCountry", "Flight guide to " + GetDataLookup()["countryIreland"]);
                    AssertObj.Add("cheapflightsCity", "Cheap flights to " + GetDataLookup()["cityDublin"]);
                    AssertObj.Add("flightGuideCity", "Flight guide to " + GetDataLookup()["cityDublin"]);
                    AssertObj.Add("sisterMessage", "The departure point you have entered");
                    AssertObj.Add("hpdText","Handpicked Travel Deals");
                    AssertObj.Add("BETextSpanish", "Reserva billetes de avión");
                    AssertObj.Add("assertheaderPPC", "Search By Date");
                    AssertObj.Add("strapUK", "The UK’s widest range of deals on cheap flights");
                    AssertObj.Add("strapUS", "The US’ widest range of deals on airline tickets");
                    AssertObj.Add("strapAus", "Australia’s widest range of deals on cheap flights");
                    AssertObj.Add("strapCanada", "Canada’s widest range of deals on cheap flights");
                    AssertObj.Add("travelGuide","Travel guides");
                    AssertObj.Add("BETitle","Book Cheap Flights - Search Flight Deals by Date");
                    AssertObj.Add("TrvlGuideTitle","flights and travel guide");
                    AssertObj.Add("BEheaderTitle", "Book Airline Tickets");
                    AssertObj.Add("contentmodule","Bag yourself a cheap flight");
                    AssertObj.Add("hpdpage","More hot travel deals");
                    AssertObj.Add("hpdtitle","Handpicked Travel Deals - Latest flights, holidays and hot travel deals");
                    AssertObj.Add("warning404", "Sorry, the page you are looking for does not exist.");
                    AssertObj.Add("partialUrl", "holidays.cheapflights.co.uk");
                    AssertObj.Add("footerText","");
                    AssertObj.Add("signupcreated", "Congratulations!");
                    //Warning messages
                    //.//*[@id='results-view']/span
                    return AssertObj;
        }

    }
}
