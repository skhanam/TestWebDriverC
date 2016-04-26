using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestWebDriver.com.cf.webdriver.src.PageObject;

namespace TestWebDriver.com.cf.webdriver.src.ModuleObject
{
    public class NewsLetterModule
    {
        public NewsLetterPage GetNewsLetterPage ()
        {
            return new NewsLetterPage();
        
        }
    }
}
