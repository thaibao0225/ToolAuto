using System;
using System.Collections.Generic;
using System.Text;
using ToolAuto.Model.Socical;
using ToolAuto.Function;

namespace ToolAuto.Management.Socical
{
    class ZaloManagement
    {
        UserZaloModel UserZaloModel;
        string type = "Zalo";
        Browser browser;

        public ZaloManagement(UserZaloModel _UserZaloModel)
        {
            UserZaloModel = _UserZaloModel;
        }

        public void StartProfile()
        {
            browser = new Browser();

            browser.SetNewProfile(type, UserZaloModel.user, UserZaloModel.UserName, "https://id.zalo.me");

        }

        public void CloseProfile()
        {
            browser.CloseDriver();
        }
    }
}
