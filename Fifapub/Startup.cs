using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fifapub
{
    public class Startup
    {
        public static string wwwRootFolder = string.Empty;

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            Startup.wwwRootFolder = env.WebRootPath;
            // ...
        }
    }
}