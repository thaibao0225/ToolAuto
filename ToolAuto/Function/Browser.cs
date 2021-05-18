using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using System.IO;

namespace ToolAuto.Function
{
    class Browser
    {
        string ProfileFolderPath = "Profile";
        public ChromeDriver driver;
        public Browser()
        {
            
        }

        

        public void SetNewProfile(string _title,string _user,string _nameProfile,string _url)
        {
            try
            {
                //ChromeDriver chromeDriver = new ChromeDriver();

                ChromeOptions options = new ChromeOptions();

                if (!Directory.Exists(ProfileFolderPath))
                {
                    Directory.CreateDirectory(ProfileFolderPath);
                }

                string nameProfile = _title +"-"+ _user + "-" + _nameProfile;
                if (Directory.Exists(ProfileFolderPath))
                {
                    //int nameCount = 0;

                    options.AddArguments("user-data-dir=" + ProfileFolderPath + "\\" + nameProfile);
                }


                //driver = new ChromeDriver(options);

                //code hide cmd.exe
                ChromeDriverService service = ChromeDriverService.CreateDefaultService();
                service.HideCommandPromptWindow = true;

                driver = new ChromeDriver(service, options);

                //https://www.facebook.com
                driver.Url = _url;

                driver.Navigate();

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        public ChromeDriver GetBrowserDiver()
        {
            return driver;
        }

        public void CloseDriver()
        {
            try
            {
                driver.Close();
                driver.Quit();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
        }
    }
}
