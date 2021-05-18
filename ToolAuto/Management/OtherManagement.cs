using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ToolAuto.Management
{
    class OtherManagement
    {
        public OtherManagement()
        {

        }

        string ProfileFolderPath = "Profile";
        public ChromeDriver driver;
        public void test()
        {
            try
            {
                //ChromeDriver chromeDriver = new ChromeDriver();

                ChromeOptions options = new ChromeOptions();

                if (!Directory.Exists(ProfileFolderPath))
                {
                    Directory.CreateDirectory(ProfileFolderPath);
                }

                if (Directory.Exists(ProfileFolderPath))
                {
                    //int nameCount = 0;

                    options.AddArguments("user-data-dir=" + ProfileFolderPath + "\\" + "thanhcong1");
                }


                //driver = new ChromeDriver(options);

                //code hide cmd.exe
                ChromeDriverService service = ChromeDriverService.CreateDefaultService();
                service.HideCommandPromptWindow = true;

                driver = new ChromeDriver(service, options);

                driver.Url = "https://www.facebook.com";

                driver.Navigate();

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            


        }
    }
}
