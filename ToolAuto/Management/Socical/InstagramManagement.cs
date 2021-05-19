using System;
using System.Collections.Generic;
using System.Text;
using ToolAuto.Model.Socical;
using ToolAuto.Function;

namespace ToolAuto.Management.Socical
{
    class InstagramManagement
    {
        UserInstagramModel UserInstagramModel;
        string type = "Instagram";
        Browser browser;

        public InstagramManagement(UserInstagramModel _UserInstagramModel)
        {
            UserInstagramModel = _UserInstagramModel;
        }

        public void StartProfile()
        {
            browser = new Browser();

            browser.SetNewProfile(type, UserInstagramModel.user, UserInstagramModel.UserName, "https://www.instagram.com");

        }

        public void CloseProfile()
        {
            browser.CloseDriver();
        }
    }
}
