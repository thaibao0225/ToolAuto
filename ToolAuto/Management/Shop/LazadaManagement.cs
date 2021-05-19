using System;
using System.Collections.Generic;
using System.Text;
using ToolAuto.Model.Shop;
using ToolAuto.Function;

namespace ToolAuto.Management.Shop
{
    class LazadaManagement
    {
        UserLazadaModel UserLazadaModel;
        string type = "Lazada";
        Browser browser;

        public LazadaManagement(UserLazadaModel _UserLazadaModel)
        {
            UserLazadaModel = _UserLazadaModel;
        }

        public void StartProfile()
        {
            browser = new Browser();

            browser.SetNewProfile(type, UserLazadaModel.user, UserLazadaModel.UserName, "https://www.lazada.vn");

        }

        public void CloseProfile()
        {
            browser.CloseDriver();
        }
    }
}
