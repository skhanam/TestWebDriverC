using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestWebDriver.com.cf.webdriver.src.Common
{
    public class Environment
    {

    
        public static string FunctionalTest = "http://10.180.101.11:91/";
        public static string BlackProd = "http://10.180.101.11:91/";
        public static string RedProd = "http://10.180.101.11:91/";
        public static string Stress = "http://10.180.101.11:91/";

              
            public Environment(string url)
            {
                this.Url = url;
            }

            public string Url { get; private set; }
  
    }
}
