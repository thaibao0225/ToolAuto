using System;
using System.Collections.Generic;
using System.Text;
using ToolAuto.Model.Socical;
using ToolAuto.Function;

namespace ToolAuto.Management.Socical
{
    class GoogleManagement
    {
        UserGoogleModel UserGoogleModel;
        string type = "Google";
        Browser browser;

        public GoogleManagement(UserGoogleModel _UserGoogleModel)
        {
            UserGoogleModel = _UserGoogleModel;
        }

        public void StartProfile()
        {
            browser = new Browser();

            browser.SetNewProfile(type, UserGoogleModel.user, UserGoogleModel.UserName, "https://www.google.com");

        }

        public void CloseProfile()
        {
            browser.CloseDriver();
        }
    }
}
