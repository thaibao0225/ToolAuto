using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ToolAuto.Model;
using ToolAuto.Model.Shop;
using ToolAuto.Model.Socical;

namespace ToolAuto.Data.EF
{
    public class GomLuaDbContext : DbContext
    {
        public GomLuaDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<UserChoTotModel> UserChoTotModel { get; set; }
        public DbSet<UserLazadaModel> UserLazadaModel { get; set; }
        public DbSet<UserMarketingPlaceFbModel> UserMarketingPlaceFbModel { get; set; }

        public DbSet<UserSendoModel> UserSendoModel { get; set; }
        public DbSet<UserShopeeModel> UserShopeeModel { get; set; }
        public DbSet<UserFbModel> UserFbModel { get; set; }
        public DbSet<UserGoogleModel> UserGoogleModel { get; set; }
        public DbSet<UserInstagramModel> UserInstagramModel { get; set; }
        public DbSet<UserTikTokModel> UserTikTokModel { get; set; }
        public DbSet<UserYoutubeModel> UserYoutubeModel { get; set; }
        public DbSet<UserZaloModel> UserZaloModel { get; set; }
        public DbSet<UserOtherModel> UserOtherModel { get; set; }
       
    }
}
