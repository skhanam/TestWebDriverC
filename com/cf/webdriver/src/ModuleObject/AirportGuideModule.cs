﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestWebDriver.com.cf.webdriver.src.PageObject;

namespace TestWebDriver.com.cf.webdriver.src.ModuleObject
{
    public class AirportGuideModule
    {
        public AirportGuidePage GetAirportGuidePage() 
        {
            return new AirportGuidePage();
        }

    }
}
