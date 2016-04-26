using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestWebDriver.com.cf.webdriver.src.Common;
using TestWebDriver.com.cf.webdriver.src.ModuleObject;
using OpenQA.Selenium;



namespace TestWebDriver.com.cf.webdriver.src.PageObject
{
    public class DepartureSpiltPage : BaseModule
    {
                public void Departurespilt(Drivercontext context,string departurename) 
                {
                    var getname = Utility.FindElement(context, By.LinkText(departurename), Utility.TIME_OUT);
                    getname.Click();
                    var getTitle = context.GetDriver().Title;
                    System.Console.WriteLine(" Title of the Page is  : "+getTitle);
                    if(getTitle.Contains(departurename))
                    {
                        Utility.TakeScreenShot(context, "departurespilt_");
                        System.Console.WriteLine("You are on a Departure Page !!! ");
                    
                    }
                }

                public void DepartureSpiltModules(Drivercontext context,string departurename) 
                {
                    var getname = Utility.FindElement(context, By.LinkText(departurename), Utility.TIME_OUT);
                    getname.Click();
                    IList<IWebElement> getalldeparturelinks = Utility.FindElements(context, By.XPath(BaseModule.ObjectLookup["linkondep"]), Utility.TIME_OUT);
                    int countdeplinks = getalldeparturelinks.Count;
                    System.Console.WriteLine("Count of  other departure links : "+countdeplinks);
                    if (!(countdeplinks.Equals(0))) 
                    {

                        System.Console.WriteLine("There are other CF departure spilt pages !! ");
                    }
                    var getsearchheader = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["searchdeparture"]), Utility.TIME_OUT);
                    string getSearchText = getsearchheader.Text;
                    System.Console.WriteLine("Get the Text of Search Header  : "+getSearchText);
                    var getnlmodule = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["depnewsletter"]), Utility.TIME_OUT);
                    string getnlheader = getnlmodule.Text;
                    var getusefulmodule = context.GetDriver().PageSource.Contains("Useful stuff");
                    if (getusefulmodule.Equals(true)) 
                    {
                        System.Console.WriteLine("Found the useful module");
                    }
                }



                public void DSSearchFlex(Drivercontext context) 
                {
                    var getDestinationValue = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["dsdestinationregion"]), Utility.TIME_OUT);
                    string DestinationValueText = getDestinationValue.GetAttribute("value");
                    Console.WriteLine("Value from  Destination : " + DestinationValueText);
                    var departureRegion = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["dsdepartureregion"]), Utility.TIME_OUT);
                    departureRegion.SendKeys(BaseModule.DataLookup["fromSource"]);
                    var dealsClick = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["dsfinddeals"]), Utility.TIME_OUT);
                    dealsClick.Click();
                    string getTitle = context.GetDriver().Title;
                    Console.WriteLine("Title of the Page is  : " + getTitle);

                    if (getTitle.Contains(BaseModule.DataLookup["fromSource"] + DestinationValueText))
                    {
                        Console.WriteLine("You are on a Flight Deals Page");
                    }
                
                }

               

                public void DSViewNewsLetter(Drivercontext context) 
                {
                    string getWinHandleOrig = context.GetDriver().CurrentWindowHandle;
                    System.Console.WriteLine("Current Window Handle Original is : " + getWinHandleOrig);
                    var getviewnllink = Utility.FindElement(context, By.LinkText("View our last newsletter"), Utility.TIME_OUT);
                    getviewnllink.Click();
                    foreach (string winHandle in context.GetDriver().WindowHandles)
                    {
                        context.GetDriver().SwitchTo().Window(winHandle);
                        Console.WriteLine(winHandle);
                        string getTitle = context.GetDriver().Title;
                        System.Console.WriteLine("Current Window Title is : " + getTitle);
                        if (getTitle.Contains("Newsletter"))
                        {
                            Utility.TakeScreenShot(context, "ViewNl");
                        }
                       
                    }
                    context.GetDriver().Close();
                    context.GetDriver().SwitchTo().Window(getWinHandleOrig);  
                }




                public void NewsletterSignup(Drivercontext context)
                {
                    var clickSignup = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["dsnlsignup"]), 10);
                    clickSignup.Click();
                    var useremail = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["dsnlemail"]), Utility.TIME_OUT);
                    String useremailcreate = "dumb" + Utility.GetCurrentMilli()+"@gmail.com";
                    //useremail.SendKeys(BaseModule.DataLookup["email"]);
                    useremail.SendKeys(useremailcreate);
                    var ufname = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["dsnlfname"]), Utility.TIME_OUT);
                    ufname.SendKeys(BaseModule.DataLookup["fname"]);
                    var ulname = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["dsnllname"]), Utility.TIME_OUT);
                    ulname.SendKeys(BaseModule.DataLookup["lname"]);
                    var unlpostcode = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["dsnlpostcode"]), Utility.TIME_OUT);
                    unlpostcode.SendKeys(BaseModule.DataLookup["postcode"]);
                    var unlpersonalise = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["nlpersonalise"]), Utility.TIME_OUT);
                    unlpersonalise.Click();
                    var checkprefernce = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["dsnlpreference"]), Utility.TIME_OUT);
                    checkprefernce.Click();
                    var lifestyleDone = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["dsnldone"]), Utility.TIME_OUT);
                    lifestyleDone.Click();
                    var registernl = Utility.FindElement(context, By.XPath(BaseModule.ObjectLookup["nlsignupbutton"]), Utility.TIME_OUT);
                    registernl.Click();
                    Utility.TakeScreenShot(context, "nlsignup");
                }


            
                
    }
}
