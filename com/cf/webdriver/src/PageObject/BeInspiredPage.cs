using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestWebDriver.com.cf.webdriver.src.ModuleObject;
using OpenQA.Selenium;
using TestWebDriver.com.cf.webdriver.src.Common;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using log4net;
using log4net.Config;

namespace TestWebDriver.com.cf.webdriver.src.PageObject
{
   public class BeInspiredPage : BaseModule
    {

       //private static readonly ILog log = LogManager.GetLogger(typeof(BeInspiredPage));
        
                public void BeInspiredSearch(Drivercontext context,string radioValue,string fromSource)
                {
                                   
                    var themeList = Utility.FindElement(context, By.XPath(radioValue),10);
                    themeList.Click();
                    Utility.TakeScreenShot(context, "SearchInspireMeCriteria");
                    
                    var departUI = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["departurePoint"]),10);
                    departUI.Clear();
                    departUI.SendKeys(fromSource);
                    var inspireMebutton = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["inspireMeButton"]),10);
                    inspireMebutton.Click();
                    Utility.TakeScreenShot(context,"FoundSearchInspireMeResults");
                    ChangeSearch(context);
                    CloseSearch(context);
                    CloseFilters(context);
                    ValidDealDisplayed(context);
                }


            

                public void ChangeSearch(Drivercontext context) 
                {
                    var changeSearchInspireMeUI = Utility.FindElement(context, By.PartialLinkText("Change search"), Utility.TIME_OUT);
                    //Utility.FindElement(context, By.XPath(".//*[@id='form-control-bar']/a/span[3]"));
                    changeSearchInspireMeUI.Click();
                    var themeListUI = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["adventure"]), Utility.TIME_OUT);
                    themeListUI.Click();
                    var inspireMebuttonUI = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["inspireMeButton"]), Utility.TIME_OUT);
                    inspireMebuttonUI.Click();
                    Utility.TakeScreenShot(context, "ChangedCriteriaInspireme");
                    
                }

                public void CloseSearch(Drivercontext context) 
                {
                    var closeSearchUI = Utility.FindElement(context, By.PartialLinkText("Close search"), Utility.TIME_OUT);
                    closeSearchUI.Click();
                     
                    Utility.TakeScreenShot(context, "ClosedSearch");
                }


                public void CloseFilters(Drivercontext context) 
                {
                    var closeFiltersUI = Utility.FindElement(context, By.PartialLinkText("Close filters"),Utility.TIME_OUT);
                    closeFiltersUI.Click();
                     
                    Utility.TakeScreenShot(context, "Closedfilters");
                    context.GetDriver().Manage().Cookies.DeleteAllCookies();
                }


                public void WithoutDeparture(Drivercontext context) 
                {
                    var inspireMebuttonUI = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["inspireMeButton"]), Utility.TIME_OUT);
                        inspireMebuttonUI.Click();
                        var departureWarning = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["warningDeparture"]), Utility.TIME_OUT);
                        string departureWarningText = departureWarning.Text;
                                if(departureWarningText.Equals(BaseModule.AssertLookup["destinationWarning"]))
                                {
                                       Assert.Pass();
                            
                                }
                  
                }



                public void GetAllWhenOptions(Drivercontext context) 
                {
                    var selectWhen = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["selectbeinspired"]), Utility.TIME_OUT);
                    IList<IWebElement> allOptions = selectWhen.FindElements(By.TagName("option"));
                    int CountOptions = allOptions.Count;
                    System.Console.WriteLine(CountOptions);
                    if (CountOptions.Equals(3))
                    {
                                foreach (var option in allOptions)
                                {
                                    System.Console.WriteLine("Value is: " + option.GetAttribute("value"));
                                   
                                }
                    }
                   
                }


                public void GetHeader(Drivercontext context) 
                {
                    var getHeader = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["getHeaderIMe"]), Utility.TIME_OUT);
                    string getString = getHeader.Text;
                    Console.WriteLine("Header is :" + getString);
                            if (getString.Equals(BaseModule.AssertLookup["bInspired"]))
                            {
                                Utility.TakeScreenShot(context, "YouRonInspireMe");
                                   
                            }
                }
                

                

                public void GetWhatOptions(Drivercontext context) 
                {
                    IList<IWebElement> getAllOptions = Utility.FindElements(context,By.XPath(BaseModule.ObjectLookup["getOptionsIMe"]),Utility.TIME_OUT);
                    int CountWhat = getAllOptions.Count;
                    Console.WriteLine("Count is :"+CountWhat);
                    if (CountWhat.Equals(6))
                    {
                                foreach (var option in getAllOptions)
                                {
                                    System.Console.WriteLine("Value is :" + option.GetAttribute("value"));
                                }

                    }
                       
                }



                public void ValidDealDisplayed(Drivercontext context) 
                {
                    var sourceIMe = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["getSearchSourceIme"]),Utility.TIME_OUT);
                    string sourceString = sourceIMe.Text;
                    Console.WriteLine("Value for :"+sourceString);
                    var getValue = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["getDepartingIMe"]), Utility.TIME_OUT);
                    Console.WriteLine("Value for getValue : "+getValue.Text);
                    var durationIMe = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["getSearchDurationIme"]), Utility.TIME_OUT);
                    string durationIMeString = durationIMe.Text;
                    Console.WriteLine("Value for :" + durationIMeString);
                    var preferenceTimeIMe = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["getSearchPreferenceIme"]), Utility.TIME_OUT);
                    string preferenceTimeIMeString = preferenceTimeIMe.Text;
                    Console.WriteLine("Value for :" + preferenceTimeIMeString);
                        if (durationIMe.Equals(BaseModule.ObjectLookup["getSearchDurationIme"]))
                            {
                                Console.WriteLine("You are here ");    
                            
                            }
                
                }



                public void DealspageCookie(Drivercontext context) 
                {
                    HomeModule homeModule = new HomeModule();
                    Utility.popUp(context, BaseModule.ObjectLookup["nlsignupbtn"], BaseModule.ObjectLookup["nlsignupemailtxt"], 
                        BaseModule.DataLookup["email"], BaseModule.ObjectLookup["nlsignuppostcodetxt"], BaseModule.DataLookup["postcode"], BaseModule.ObjectLookup["nlsubmitsignup"]);
                    homeModule.GetHomepage().SearchFlex(context, BaseModule.DataLookup["fromSource"], BaseModule.DataLookup["toDestination"], 
                        BaseModule.ObjectLookup["newsletterHP"]);
                    Utility.SwitchMainTabs(context, BaseModule.ObjectLookup["inspired"]);
                    
                    var departPointInsMe = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["departurePoint"]), Utility.TIME_OUT);
                    string getTextCookied = departPointInsMe.GetAttribute("value");
                    Console.WriteLine("Check for Cookie Cached : "+getTextCookied);
                            if ((BaseModule.DataLookup["fromSource"]).Equals(getTextCookied))
                            {
                                    Console.WriteLine("Data is cookied from Deals Page !!!!");
                                    Utility.TakeScreenShot(context, "dealsPageDataCookiedIMe");
                                    Assert.Pass();
                                }
                                else {
                                    Console.WriteLine("Data is not Cookied from Deal Page !!! ");
                                     
                            }
                    Utility.ClearCookies(context);
                }


        

    }
}
