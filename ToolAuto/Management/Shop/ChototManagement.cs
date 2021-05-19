using System;
using System.Collections.Generic;
using System.Text;
using ToolAuto.Model.Shop;
using ToolAuto.Function;

namespace ToolAuto.Management.Shop
{
    class ChototManagement
    {
        UserChoTotModel UserChoTotModel; 
        string type = "ChoTot";
        Browser browser;

        public ChototManagement(UserChoTotModel _UserChoTotModel)
        {
            UserChoTotModel = _UserChoTotModel;
        }

        public void StartProfile()
        {
            browser = new Browser();

            browser.SetNewProfile(type, UserChoTotModel.user, UserChoTotModel.UserName, "https://www.chotot.com");

        }

        public void CloseProfile()
        {
            browser.CloseDriver();
        }
    }
}
