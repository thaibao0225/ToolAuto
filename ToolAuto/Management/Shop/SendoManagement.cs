using System;
using System.Collections.Generic;
using System.Text;
using ToolAuto.Model.Shop;
using ToolAuto.Function;

namespace ToolAuto.Management.Shop
{
    class SendoManagement
    {
        UserSendoModel UserSendoModel;
        string type = "Sendo";
        Browser browser;

        public SendoManagement(UserSendoModel _UserSendoModel)
        {
            UserSendoModel = _UserSendoModel;
        }

        public void StartProfile()
        {
            browser = new Browser();

            browser.SetNewProfile(type, UserSendoModel.user, UserSendoModel.UserName, "https://www.sendo.vn");

        }

        public void CloseProfile()
        {
            browser.CloseDriver();
        }
    }
}
