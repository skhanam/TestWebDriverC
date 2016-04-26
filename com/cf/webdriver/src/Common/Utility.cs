using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using NUnit.Framework;
using System.IO;
using System.Globalization;
using System.Drawing;
using System.Configuration;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;

using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;

namespace TestWebDriver.com.cf.webdriver.src.Common
{
    public static class Utility
    {
        public static bool present;
        private static readonly string screenShotDirectory;
        public static int TIME_OUT = 60;

        static Utility()
        {
            string screenShotDirectoryConfigValue = ConfigurationManager.AppSettings["ScreenShotDirectory"];
            if (!string.IsNullOrWhiteSpace(screenShotDirectoryConfigValue))
            {
                if (!screenShotDirectoryConfigValue.EndsWith(@"\"))
                {
                    screenShotDirectoryConfigValue += @"\";
                }
                screenShotDirectory = screenShotDirectoryConfigValue;
            }
        }


        public static void WindowMaximize(Drivercontext context)
        {
            // ((IJavaScriptExecutor) context.GetDriver()).ExecuteScript("top.window.moveTo(0,0);if (document.all) {top.window.resizeTo(screen.availWidth,screen.availHeight);}");
            context.GetDriver().Manage().Window.Size = new Size(1324, 960);
            // context.GetDriver().Manage().Window.Size = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width + 10,Screen.PrimaryScreen.WorkingArea.Height + 10);


        }




        //Custom method using the WebDriverWait

        public static IWebElement FindElement(this Drivercontext context, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(context.GetDriver(), TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(by));
            }
            return context.GetDriver().FindElement(by);
        }

        public static ReadOnlyCollection<IWebElement> FindElements(this Drivercontext context, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(context.GetDriver(), TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => (drv.FindElements(by).Count > 0) ? drv.FindElements(by) : null);
            }
            return context.GetDriver().FindElements(by);
        }





        /*
         * This method is written wait on a page to load 
         * 
         */

        public static void WaitForCheapflightsPageToLoad(Drivercontext context, string oldUrl)
        {
            new WebDriverWait(context.GetDriver(), TimeSpan.FromSeconds(Utility.TIME_OUT)).Until((new PageLoadTester(oldUrl)).IsPageLoaded);
            //System.Console.WriteLine("Page loaded. New URL: " + context.GetDriver().Url);
        }

        public static void WaitForPageToLoad(Drivercontext context, string oldUrl)
        {
            new WebDriverWait(context.GetDriver(), TimeSpan.FromSeconds(Utility.TIME_OUT)).Until((new PageLoadTester(oldUrl, false)).IsPageLoaded);
            //System.Console.WriteLine("Page loaded. New URL: " + context.GetDriver().Url);
        }

        private class PageLoadTester
        {
            public PageLoadTester(string oldUrl)
            {
                this.OldUrl = oldUrl;
                this.IsCheapflightsPage = true;
            }

            public PageLoadTester(string oldUrl, bool waitForJQuery)
            {
                this.OldUrl = oldUrl;
                this.IsCheapflightsPage = waitForJQuery;
            }

            public string OldUrl { get; private set; }
            private bool IsCheapflightsPage { get; set; }

            public bool IsPageLoaded(IWebDriver driver)
            {
                try
                {
                    //First wait for the browser to register the new URL;
                    if (driver.Url.Equals(OldUrl, StringComparison.OrdinalIgnoreCase))
                    {
                        return false;
                    }
                    System.Console.WriteLine("Waiting for Page to load. Current URL: " + driver.Url);

                    //Second wait for JQuery to become available.
                    if (IsCheapflightsPage)
                    {
                        IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
                        return (bool)executor.ExecuteScript("return CF.isReady;");
                    }

                    return true;
                }
                catch (InvalidElementStateException)
                {
                    System.Console.WriteLine("Caught InvalidElementStateException. Assume page not yet loaded and continute waiting.");
                    return false;
                }

            }
        }

        /*
         * This method is verify if the element is present 
         * 
         * 
         */

        public static bool IsElementPresent(Drivercontext context, By by)
        {
            try
            {
                var objectFound = Utility.FindElement(context, by, 90);
                if (objectFound.Displayed && objectFound.Enabled)
                {
                    present = true;
                }
                //  IJavaScriptExecutor executor = (IJavaScriptExecutor)context.GetDriver();
                //return (bool)executor.ExecuteScript("return CF.isReady;");
            }
            catch (NoSuchElementException e)
            {
                System.Console.WriteLine(e.InnerException);
                present = false;
            }
            return present;
        }


        public static void AllTabs(Drivercontext context, By by)
        {
            bool onTabs = IsElementPresent(context, by);
            if (onTabs.Equals(true))
            {

                System.Console.WriteLine("On Page ");

            }

        }


         
      //Added this method for floating popup on heomepage

        public static void popUp(Drivercontext context,string signupbtn,string emailtxtui,string emailtxtboxdata,string postcodeui,string postcodedata,string submitsignupbtn) 
        {
            context.GetDriver().Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(15));
            var initialsignup = context.FindElement(By.XPath(signupbtn),20);
            initialsignup.Click();
            var popupemailid = context.FindElement(By.XPath(emailtxtui),20);
            popupemailid.SendKeys(emailtxtboxdata);
            var popuppostcode = context.FindElement(By.XPath(postcodeui),20);
            popuppostcode.SendKeys(postcodedata);
            var signup = context.FindElement(By.XPath(submitsignupbtn), 60);
            signup.Click();
        
        }


        /*
         * This method to wait until an element is showed up.
         * 
         */
        //public static void WaitForElementTobePresent(Drivercontext context,By by)
        //{
        //    System.DateTime start = System.DateTime.Now;
        //    Console.WriteLine("Milliseconds: {0:fff}", start);
        //    System.DateTime end = System.DateTime.Now.AddMilliseconds(120000);
        //    Console.WriteLine("Milliseconds: {0:fff}", end);
        //    while (start < end)
        //    {
        //        bool isPresent = IsElementPresent(context,by);
        //        if (isPresent)
        //        {
        //            break;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Waited for 2 mins!");
        //        }

        //    }
        //}



        /*
         * This method to wait until the text is present.
         * 
         */

        //public static void WaitForVisibleText(string text, Drivercontext context)
        //{
        //    System.DateTime start = System.DateTime.Now;
        //    Console.WriteLine("Milliseconds: {0:fff}", start);
        //    System.DateTime end = System.DateTime.Now.AddMilliseconds(6000);
        //    Console.WriteLine("Milliseconds: {0:fff}", end);
        //    //boolean isPresent = false;
        //    while (start < end)
        //    {
        //        if (context.GetDriver().PageSource.Contains(text))
        //        {
        //            break;
        //        }
        //    }

        //}



        /*
         * Below method will wait for an element to be displayed in the page, will time out after 5 mins
         */
        //public static void WaitForElementToBeDisplayed(Drivercontext context, string frameID, string objectID)
        //{
        //    System.DateTime start = System.DateTime.Now;
        //    Console.WriteLine("Milliseconds: {0:fff}", start);
        //    System.DateTime end = System.DateTime.Now.AddMilliseconds(30000);
        //    Console.WriteLine("Milliseconds: {0:fff}", end);
        //    SwitchToFrame(context, frameID);
        //    while (start < end)
        //    {
        //        if (Utility.FindElement(context, By.Id(objectID), 1000).Displayed)
        //        {
        //            break;
        //        }
        //    }
        //    Console.Error.WriteLine("Timed out after 5 mins !");
        //}





        /*
         * Verify if the text is present
         * 
         */
        public static bool IsTextPresent(string verifystring, Drivercontext context)
        {
            System.DateTime start = System.DateTime.Now;
            Console.WriteLine("Milliseconds: {0:fff}", start);
            System.DateTime end = System.DateTime.Now.AddMilliseconds(5000);
            Console.WriteLine("Milliseconds: {0:fff}", end);
            bool isPresent = false;
            while (start < end)
            {
                if (context.GetDriver().PageSource.Contains(verifystring))
                {
                    isPresent = true;
                    break;
                }
            }
            return isPresent;
        }





        /*
         * This method is written to handle frames
         * 
         */


        public static void SwitchToFrame(Drivercontext context, string frameID)
        {
            SwitchToParent(context);
            Console.WriteLine("Frame id ... now is :" + frameID);
            context.GetDriver().SwitchTo().Frame(frameID);
        }


        /*
         * This method is written to handle iframes
         * 
         */
        public static void SwitchToParent(Drivercontext context)
        {
            context.GetDriver().SwitchTo().DefaultContent();
        }


        /*
         *This is a US date format 
         * 
         */


        public static String GetDate(int numberofDays)
        {
            System.DateTime today = System.DateTime.Now;
            System.DateTime newDate = today.AddDays(numberofDays);
            //System.Console.WriteLine("{0:dd/MM/yyyy}", newDate);
            string getdate = newDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            // string datestring = DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            return getdate;
        }


        public static String GetDateUS(int numberOfDays)
        {
            System.DateTime today = System.DateTime.Now;
            System.DateTime newDate = today.AddDays(numberOfDays);
            //System.Console.WriteLine("{0:dd/MM/yyyy}", newDate);
            string getdate = newDate.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
            // string datestring = DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            return getdate;
        }


        public static double GetCurrentMilli()
        {
            DateTime Jan1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan javaSpan = DateTime.UtcNow - Jan1970;
            return javaSpan.TotalMilliseconds;
        }


        /*
         * 
         * 
         * ***/

        /* public static void SwitchTabs(Drivercontext context,string TabName)
         {
                 Utility.FindElement(context, By.PartialLinkText(TabName)).Click();
         } */



        public static void SwitchMainTabs(Drivercontext context, string tabName)
        {
            string oldUrl = context.GetDriver().Url;
            var getLink = FindElement(context, By.PartialLinkText(tabName), Utility.TIME_OUT);
            getLink.Click();
            WaitForCheapflightsPageToLoad(context, oldUrl);
        }


        public static void 
            TakeScreenShot(Drivercontext context, string filename)
        {
            System.Console.WriteLine("Taking screenshot: " + filename);
            if (!string.IsNullOrWhiteSpace(screenShotDirectory))
            {
                if (!Directory.Exists(screenShotDirectory))
                {
                    Directory.CreateDirectory(screenShotDirectory);
                }

                Screenshot ss = ((ITakesScreenshot)context.GetDriver()).GetScreenshot();
                ss.SaveAsFile(screenShotDirectory + filename + Utility.GetCurrentMilli() + ".Png", System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        public static void ClearCookies(Drivercontext context)
        {
            ICookieJar cookies = context.GetDriver().Manage().Cookies;
            cookies.DeleteAllCookies();
        }


        public static void GoToURL(Drivercontext context, string url)
        {
            var getLink = FindElement(context, By.LinkText(url), Utility.TIME_OUT);
            ClickAndWaitForCheapflightsPageToLoad(context, getLink);
        }


        public static void GoToURLXpath(Drivercontext context, string xpath)
        {
            var geturlXpath = FindElement(context, By.XPath(xpath), Utility.TIME_OUT);
            string urlString = geturlXpath.Text;
            Console.WriteLine("Here is the URL string  : " + urlString);
            ClickAndWaitForCheapflightsPageToLoad(context, geturlXpath);
        }

        public static void ClickAndWaitForCheapflightsPageToLoad(Drivercontext context, IWebElement elementToClick)
        {
            string oldUrl = context.GetDriver().Url;
            elementToClick.Click();
            //WaitForCheapflightsPageToLoad(context, oldUrl);
        }

        public static void ClickAndWaitForPartnerPageToLoad(Drivercontext context, IWebElement elementToClick, Action partnerSiteTests)
        {
            string initialWindowHandle = context.GetDriver().CurrentWindowHandle;
            string newWindowHandle = null;
            try
            {
                ReadOnlyCollection<string> oldWindowHandles = context.GetDriver().WindowHandles;
                elementToClick.Click();
                ReadOnlyCollection<string> newWindowHandles = context.GetDriver().WindowHandles;
                newWindowHandle = newWindowHandles.Except(oldWindowHandles).FirstOrDefault();
                if (newWindowHandle == null)
                {
                    throw new OpenQA.Selenium.NoSuchWindowException("New window for partner site not found.");
                }
                context.GetDriver().SwitchTo().Window(newWindowHandle);
                WaitForPageToLoad(context, string.Empty);

                if (partnerSiteTests != null)
                {
                    partnerSiteTests();
                }
            }
            finally
            {
                //If a new window was opened, close it.
                if (newWindowHandle != null && context.GetDriver().CurrentWindowHandle == newWindowHandle)
                {
                    context.GetDriver().Close();
                }

                //Switch back to initial window.
                if (!string.IsNullOrEmpty(initialWindowHandle))
                {
                    context.GetDriver().SwitchTo().Window(initialWindowHandle);
                }
            }
        }

        private static void ClickAndWaitForPageToLoad(Drivercontext context, IWebElement elementToClick)
        {
            string oldUrl = context.GetDriver().Url;
            elementToClick.Click();
            WaitForPageToLoad(context, oldUrl);
        }

        //To highlight an object
        public static void HighlightElement(Drivercontext context,IWebElement element)
        {
            for (int i = 0; i < 2; i++)
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)context.GetDriver();
                js.ExecuteScript("arguments[0].setAttribute('style', arguments[1]);",
                        element, "color: yellow; border: 2px solid yellow;");
                js.ExecuteScript("arguments[0].setAttribute('style', arguments[1]);",
                        element, "");
            }
        }


        public static void Cleanup(Drivercontext context)
        {
            Console.WriteLine("CleanUp and quit Driver.....");
            if (context.GetDriver() != null)
            {
                context.GetDriver().Manage().Cookies.DeleteAllCookies();
                //driver.Close();
                context.GetDriver().Quit(); //stopping the driver


            }
        }

        public static  IWebDriver GetFireFoxDriver() 
        {
            IWebDriver driver = new FirefoxDriver();
            return driver;

            //System.setProperty("webdriver.firefox.profile", "MySeleniumProfile");

            //FirefoxProfile ffprofile = new FirefoxProfile();
            //ffprofile.AddExtension(@"C:\Selenium\JSErrorCollector.xpi");
            //IWebDriver driver = new FirefoxDriver(ffprofile);
        }


        public static IWebDriver GetInternetExplorer() 
        {
             var options = new InternetExplorerOptions();
            options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            IWebDriver driver = new InternetExplorerDriver(@"C:\Selenium\",options);
            return driver;
        }


        public static IWebDriver GetChromeDriver() 
        {

            IWebDriver driver = new ChromeDriver(@"C:\Selenium\");
            return driver;
        
        }




    }
}
