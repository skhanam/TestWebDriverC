using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Configuration;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System.Collections;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using log4net;
using log4net.Config;
using TestWebDriver.com.cf.webdriver.src.Common;




namespace TestWebDriver.com.cf.webdriver.src.Common
{
    public class Drivercontext
    {
        private readonly Dictionary<string, string> lookup;
        private readonly IWebDriver driver;
        private readonly string testCaseName;
        private readonly string websiteurl;
       
        private static readonly ILog log = LogManager.GetLogger(typeof(Drivercontext));
        

        // TODO: Add another Create(String testCaseName, String excelFilename)
        // This will read in the lookup table from an excel spreadsheet
        //  public static Drivercontext create(string testCaseName, Hashtable lookup) 



        public static Drivercontext Create(string testCaseName, Dictionary<string, string> lookup,String websiteurl,IWebDriver driver)
        {
           
                log.Info("You are in the Drivercontext Class");
                driver.Manage().Cookies.DeleteAllCookies();
                driver.Navigate().GoToUrl(websiteurl);
                return new Drivercontext(testCaseName, driver, lookup, websiteurl);
            
            
        }

       

        
        private Drivercontext(String testCaseName, IWebDriver driver, Dictionary<string, string> lookup,String websiteurl)
        {
            this.driver = driver;
            this.lookup = lookup;
            this.testCaseName = testCaseName;
            this.websiteurl = websiteurl;
        }

        

       
        public Dictionary<string, string> GetLookup()
        {
            return lookup;
        }

        public string GetTestCaseName()
        {
            return testCaseName;
        }

     
        public IWebDriver GetDriver()
        {
            return driver;
        }

        public IJavaScriptExecutor GetExecutor()
        {
            return (IJavaScriptExecutor)driver;
        }

        public string GetWebsiteURL() 
        {
            return websiteurl;
        }

    }

}
