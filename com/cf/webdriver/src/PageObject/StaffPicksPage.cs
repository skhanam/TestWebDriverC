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
    public class StaffPicksPage : BaseModule
    {


        public void Handpickdeals(Drivercontext context,string  tab) 
        {
                    Utility.SwitchMainTabs(context, tab);
                     
                    IList<IWebElement>  getWebsitebuttons =  Utility.FindElements(context,By.XPath(BaseModule.ObjectLookup["hpdDetails"]),10);
                    int countWebsitebuttons = getWebsitebuttons.Count;
                    Console.WriteLine(countWebsitebuttons);
            
                    if(countWebsitebuttons.Equals(0) )
                    {
                        Console.WriteLine("No Deals Found.. Check Admin Console !!!");
                        Utility.TakeScreenShot(context, "HPDealsNotFound");
                         
                    }
                    else {

               
                        Console.WriteLine("Deals Found !!!");
                        Utility.TakeScreenShot(context,"HPDealsFound");
                        Assert.Pass();
                    }
            
        }
        


        public void CheckDatePosted(Drivercontext context,string tab)
        {
                    Utility.SwitchMainTabs(context, tab);
                     
                    IList<IWebElement> getDatePostedlabels = Utility.FindElements(context,By.XPath(BaseModule.ObjectLookup["dateLabel"]),10);
                    int countDateLabels = getDatePostedlabels.Count;
                    Console.WriteLine(countDateLabels);
                    if (countDateLabels.Equals(0))
                    {

                        Console.WriteLine("No Date Labels Found !!!! ");
                        Utility.TakeScreenShot(context, "DateLabelsNotFound");
                         
                    }
                    else {
                                Console.WriteLine("Date Label Found");
                                Utility.TakeScreenShot(context,"DateLabelsFound");
                                Assert.Pass();
                    
                    
                    }
        }



        public void CheckHeader(Drivercontext context,string tab) 
        {
                Utility.SwitchMainTabs(context,tab);
                 
                var getHeader = Utility.FindElement(context,By.XPath(BaseModule.ObjectLookup["hpdHeader"]),10);
                string getHeaderText = getHeader.Text;
                Console.WriteLine("Header for HPD is : "+getHeaderText);
                    if (getHeaderText.Equals(BaseModule.AssertLookup["hpdText"]))
                    {
                                Console.WriteLine("HPD page contains header ");
                                Utility.TakeScreenShot(context, "hpdheaderFound");
                        }
                            else 
                        {
                             Console.WriteLine("No HPD header Found !!!");
                                 
                
                    }
         }




    }
}
