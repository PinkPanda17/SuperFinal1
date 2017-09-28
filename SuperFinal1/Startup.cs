using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Microsoft.Owin;
using Owin;
using SuperFinal1.Context;

[assembly: OwinStartup(typeof(SuperFinal1.Startup))]

namespace SuperFinal1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            Database.SetInitializer(new UserDBContextSeeder());
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<UserContext>());
        }
    }
}
