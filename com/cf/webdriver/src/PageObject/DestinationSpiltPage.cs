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
    public class DestinationSpiltPage : BaseModule
    {
        
    
                public void navigate(Drivercontext context,string destination) 
                {
                    var destinationCountry = Utility.FindElement(context,By.LinkText(destination), Utility.TIME_OUT);
                    destinationCountry.Click();
                    string getTitle = context.GetDriver().Title;
                    System.Console.WriteLine("Title of Destination Page is  : " + getTitle);
                    string geturl = context.GetDriver().Url;
                    System.Console.WriteLine("URL of Destination Page is  : "+geturl);
                    if (getTitle.Contains(destination))
                    {
                        System.Console.WriteLine("You are on Destination Page  : " + destination);
                    }
                    else { Assert.Fail(); }
                }



                public void searchmodule(Drivercontext context) 
                {
                    var checkforSearchmodule = Utility.FindElement(context, By.XPath(" "), Utility.TIME_OUT);
                
                }


       

        
    }
}
