using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ToolAuto.Model.Socical
{
    public class UserGoogleModel
    {
        [Key]
        public string user { get; set; }

        public string password { get; set; }

        public string UserName { get; set; }

        public string phone { get; set; }
        public string email { get; set; }
    }
}
