using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ToolAuto.Model.Shop
{
    public class UserMarketingPlaceFbModel
    {
        [Key]
        public string user { get; set; }

        public string password { get; set; }

        public string UserName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
    }
}
