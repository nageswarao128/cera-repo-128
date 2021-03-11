﻿using CERA.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CERA.DataOperation.Data
{
    public class CeraDbContext : DbContext
    {
        //IConfiguration _Config;
        //public CeraDbContext(IConfiguration Config)
        //{
        //    _Config = Config;
        //}
        public CeraDbContext(DbContextOptions<CeraDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(connectionString: "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_Cera; Integrated Security= true;");
            //optionsBuilder.UseSqlServer(_Config.GetConnectionString("")
                    //"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_Cera; Integrated Security= true;"
                    //);
        }
        public DbSet<CeraSubscription> Subscriptions { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientCloudPlugin> ClientCloudPlugins { get; set; }
        public DbSet<CloudPlugIn> CloudPlugIns { get; set; }
        public DbSet<CeraResources> Resources { get; set; }
        public DbSet<CeraVM> ceraVMs { get; set; }


    }
}