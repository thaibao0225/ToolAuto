using System;
using System.Collections.Generic;
using System.Text;
using ToolAuto.Model.Socical;
using ToolAuto.Function;

namespace ToolAuto.Management.Socical
{
    class FacebookManagement
    {
        UserFbModel userFbModel;
        string type = "Facebook";
        Browser browser;

        public FacebookManagement(UserFbModel _userFbModel)
        {
            userFbModel = _userFbModel;
        }

        public void StartProfile()
        {
            browser = new Browser();

            browser.SetNewProfile(type, userFbModel.user, userFbModel.UserName, "https://www.facebook.com");
            
        }

        public void CloseProfile()
        {
            browser.CloseDriver();
        }
    }
}
