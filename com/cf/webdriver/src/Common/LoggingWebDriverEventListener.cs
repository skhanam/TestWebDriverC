using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium;
using log4net;
using NUnit.Framework;

/*
namespace TestWebDriver.com.cf.webdriver.src.Common
{
    public class LoggingWebDriverEventListener : EventFiringWebDriver
    {
                            private ILog log = LogManager.GetLoggers();
                                 //(this.getClass());
                            private By lastFindBy;
                            private String originalValue;
 
                    public void beforeNavigateTo(String url, IWebDriver selenium){
                        log.Info("WebDriver navigating to:'"+url+"'");
                    }
 
                    public void beforeChangeValueOf(IWebElement element, IWebDriver selenium){
                        originalValue = element.GetAttribute("value");
                    }
 
                    public void afterChangeValueOf(IWebElement element, IWebDriver selenium){
                        log.Debug("WebDriver changing value in element found "+lastFindBy+" from '"+originalValue+"' to '"+element.GetAttribute("value")+"'");
                    }
 
                    public void beforeFindBy(By by, IWebElement element, IWebDriver selenium){
                        lastFindBy = by;
                    }
 
                    public void onException(Throws error, IWebDriver selenium){
                        String filename = 
                        if (error.GetType().Namespace.Equals(NoSuchElementException))
                            //.getClass().equals(NoSuchElementException.dll)
                            {
                                    log.Error("WebDriver error: Element not found "+lastFindBy);
                        } else 
                        {
                            log.Error("IWebDriver error:"+ error);
                        }
                    }
 
                    public void beforeNavigateBack(IWebDriver selenium){}
                    public void beforeNavigateForward(IWebDriver selenium){}
                    public void beforeClickOn(IWebElement element, IWebDriver selenium){}
                    public void beforeScript(String script, IWebDriver selenium){}
                    public void afterClickOn(IWebElement element, IWebDriver selenium){}
                    public void afterFindBy(By by, IWebElement element, IWebDriver selenium){}
                    public void afterNavigateBack(IWebDriver selenium){}
                    public void afterNavigateForward(IWebDriver selenium){}
                    public void afterNavigateTo(String url, IWebDriver selenium){}
                    public void afterScript(String script, IWebDriver selenium){}
             
    
    
    } 
}
*/