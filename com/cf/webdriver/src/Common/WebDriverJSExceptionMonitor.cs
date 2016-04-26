using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace TestWebDriver.com.cf.webdriver.src.Common
{
    public class WebDriverJSExceptionMonitor
    {
            string _reporterFunction;
                    public WebDriverJSExceptionMonitor StartMonitoring(Drivercontext context)
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
                
        }


}

