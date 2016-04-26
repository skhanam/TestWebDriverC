using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestWebDriver.com.cf.webdriver.src.PageObject;

namespace TestWebDriver.com.cf.webdriver.src.ModuleObject
{
    public class HomeModule
    {
        public HomePage GetHomepage()
        {
            return new HomePage();
        }

        public DepartureSpiltPage GetDepartureSpiltPage() 
        {
            return new DepartureSpiltPage();
        }
    }
}
