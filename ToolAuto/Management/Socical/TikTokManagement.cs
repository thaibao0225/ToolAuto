using System;
using System.Collections.Generic;
using System.Text;
using ToolAuto.Model.Socical;
using ToolAuto.Function;

namespace ToolAuto.Management.Socical
{
    class TikTokManagement
    {
        UserTikTokModel UserTikTokModel;
        string type = "TikTok";
        Browser browser;

        public TikTokManagement(UserTikTokModel _UserTikTokModel)
        {
            UserTikTokModel = _UserTikTokModel;
        }

        public void StartProfile()
        {
            browser = new Browser();

            browser.SetNewProfile(type, UserTikTokModel.user, UserTikTokModel.UserName, "https://www.tiktok.com/vi-VN/");

        }

        public void CloseProfile()
        {
            browser.CloseDriver();
        }
    }
}
