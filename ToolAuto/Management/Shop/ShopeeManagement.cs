using System;
using System.Collections.Generic;
using System.Text;
using ToolAuto.Model.Shop;
using ToolAuto.Function;

namespace ToolAuto.Management.Shop
{
    class ShopeeManagement
    {
        UserShopeeModel UserShopeeModel;
        string type = "Shopee";
        Browser browser;

        public ShopeeManagement(UserShopeeModel _UserShopeeModel)
        {
            UserShopeeModel = _UserShopeeModel;
        }

        public void StartProfile()
        {
            browser = new Browser();

            browser.SetNewProfile(type, UserShopeeModel.user, UserShopeeModel.UserName, "https://shopee.vn");

        }

        public void CloseProfile()
        {
            browser.CloseDriver();
        }
    }
}
