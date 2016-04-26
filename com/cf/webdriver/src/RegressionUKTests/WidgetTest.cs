using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using TestWebDriver.com.cf.webdriver.src.Common;
using TestWebDriver.com.cf.webdriver.src.ModuleObject;
using System.Configuration;

namespace TestWebDriver.com.cf.webdriver.src.RegressionUKTests
{
    [TestFixture]
    [Category("Regression")]
    [Ignore]
    
    public class WidgetTest
    {
   /* public class WebDriverExceptionMonitor
    {
        string _reporterFunction;
        //IWebDriver _browser;

        public WebDriverExceptionMonitor StartMonitoring(Drivercontext context)
        {
                var reporterFunction = "reportWebDriverExceptionMonitor" + Guid.NewGuid().ToString().Replace("-", "");

                var monitorScript = @"(function() {

                var recordedErrors = [];

                var oldOnErrorHandler = window.onerror;

                function errorHandler(errorMessage, url, line) {
                    recordedErrors.push(errorMessage + ': ' + url + ' (' + line + ')');

                    if (oldOnErrorHandler != null) {
                        return oldOnErrorHandler.apply(this, arguments);
                    }
                }
                window.onerror = errorHandler;

                window." + reporterFunction + @" = function() {
                    return recordedErrors;
                }

                })();";

           ((IJavaScriptExecutor) context.GetDriver()).ExecuteScript(monitorScript);
            
            _reporterFunction = reporterFunction;
            //_browser = browser;

            return this;
        }

        public string[] GetJavascriptExceptions(Drivercontext context)
        {
            if (context.GetDriver() == null)
            {
                throw new InvalidOperationException("Attempted to call WebDriverExceptionMonitor.GetJavascriptExceptions before WebDriverExceptionMonitor.StartMonitoring.");
            }
            Console.WriteLine("Am here in");
            var result = ((IJavaScriptExecutor) context.GetDriver()).ExecuteScript("return window." + _reporterFunction + "()");

            return ((System.Collections.IEnumerable)result).Cast<string>().ToArray();
        }
         */

                [Test]
                public void facebookLikeTest() 
                {

                    Drivercontext context = null; string WebSiteUrlFromConfig = ConfigurationManager.AppSettings["Ukwebsiteurl"];
                        try
                        {
                            context = Drivercontext.Create("SocialWidgetTests", BaseModule.GetobjLookup(), WebSiteUrlFromConfig, Utility.GetFireFoxDriver());
                            SocialMediaModule socialMedia = new SocialMediaModule();
                            Utility.WindowMaximize(context);
                        //  Utility.SwitchMainTabs(context,BaseModule.ObjectLookup["Staff"]);
                        //     
                            socialMedia.GetSocialMediaWidget().FaceBookLike(context);
                    
                        }
                        finally
                        {
                           if (context != null){Utility.Cleanup(context);}
                    
                        }
        
                }

        }
}

      