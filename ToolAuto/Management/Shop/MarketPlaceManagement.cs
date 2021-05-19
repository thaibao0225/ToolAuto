using System;
using System.Collections.Generic;
using System.Text;
using ToolAuto.Model.Shop;
using ToolAuto.Function;

namespace ToolAuto.Management.Shop
{
    class MarketPlaceManagement
    {
        UserMarketingPlaceFbModel UserMarketingPlaceFbModel;
        string type = "MarketPlace";
        Browser browser;

        public MarketPlaceManagement(UserMarketingPlaceFbModel _UserMarketingPlaceFbModel)
        {
            UserMarketingPlaceFbModel = _UserMarketingPlaceFbModel;
        }

        public void StartProfile()
        {
            browser = new Browser();

            browser.SetNewProfile(type, UserMarketingPlaceFbModel.user, UserMarketingPlaceFbModel.UserName, "https://www.facebook.com/marketplace/?ref=bookmark");

        }

        public void CloseProfile()
        {
            browser.CloseDriver();
        }
    }
}
