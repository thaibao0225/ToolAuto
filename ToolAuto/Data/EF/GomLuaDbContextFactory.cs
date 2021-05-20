using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ToolAuto.Data.EF
{
    public class GomLuaDbContextFactory : IDesignTimeDbContextFactory<GomLuaDbContext>
    {
        public GomLuaDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())//Download the library
                .AddJsonFile("appsettings.json")// Download the library
                .Build();

            var connectionString = configuration.GetConnectionString("AspSchlDB");//add name data in file appsetting.json

            var optionsBuilder = new DbContextOptionsBuilder<GomLuaDbContext>();
            optionsBuilder.UseSqlServer(connectionString);//truyen data 

            return new GomLuaDbContext(optionsBuilder.Options);
        }
    }
}
