using System;
using System.Collections.Generic;
using System.Text;
using ToolAuto.Model.Socical;
using ToolAuto.Function;

namespace ToolAuto.Management.Socical
{
    class YoutubeManagement
    {
        UserYoutubeModel UserYoutubeModel;
        string type = "Youtube";
        Browser browser;

        public YoutubeManagement(UserYoutubeModel _UserYoutubeModel)
        {
            UserYoutubeModel = _UserYoutubeModel;
        }

        public void StartProfile()
        {
            browser = new Browser();

            browser.SetNewProfile(type, UserYoutubeModel.user, UserYoutubeModel.UserName, "https://www.youtube.com");

        }

        public void CloseProfile()
        {
            browser.CloseDriver();
        }
    }
}
