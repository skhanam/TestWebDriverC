using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace TestWebDriver.com.cf.webdriver.src.Common
{
    class Dateex
    {

            static void Main()
            {

                System.DateTime today = System.DateTime.Now;
                System.DateTime answer = today.AddDays(36);
               /* System.Console.WriteLine("{0:MM/dd/yyyy}", answer);
                System.DateTime today = System.DateTime.Now;
                System.DateTime newDate = today.AddDays(numberOfDays);
                //System.Console.WriteLine("{0:dd/MM/yyyy}", newDate);*/
                string getdate = answer.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine("You are here ");
                Console.WriteLine("{0:MM/dd/yyyy}",getdate);
            }

    }
}
