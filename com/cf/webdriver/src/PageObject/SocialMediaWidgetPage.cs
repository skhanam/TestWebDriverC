using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestWebDriver.com.cf.webdriver.src.ModuleObject;
using TestWebDriver.com.cf.webdriver.src.Common;
using OpenQA.Selenium;

namespace TestWebDriver.com.cf.webdriver.src.PageObject
{
    public  class SocialMediaWidget : BaseModule
    {
            

                //Click on the facebook like widget

            public void FaceBookLike(Drivercontext context) 
                {

                    var travelTipsLink = Utility.FindElement(context,By.LinkText("Travel tips"),10);
                        travelTipsLink.Click();
                     
                    Utility.FindElement(context,By.XPath(".//*[@id='showcase-list']/li[1]"),10).Click();
                     
                    Utility.FindElement(context,By.XPath(".//*[@id='showcase']/div[2]/ul/li[2]/a"),10).Click();
                     
                    Utility.TakeScreenShot(context, "TravelTipsSMWidget");
                   // Utility.SwitchToFrame(".//f36aecbc7b0074e.fb_ltr");
                    Utility.FindElement(context,By.XPath(".//*[@id='connect_widget_4faba102d43131568309985']/table/tbody/tr/td[1]/div/div/a"),10).Click();
                   
                }
    
    
    }
}
