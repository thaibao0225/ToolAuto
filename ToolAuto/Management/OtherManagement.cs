using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ToolAuto.Function;

namespace ToolAuto.Management
{
    class OtherManagement
    {
        public OtherManagement()
        {

        }

        
        public void test()
        {

            Browser browser = new Browser();

            browser.SetNewProfile("Facebook","thaibao","test", "https://www.facebook.com");


        }
    }
}
